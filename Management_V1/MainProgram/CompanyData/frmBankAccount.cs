using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CompanyData
{
    public partial class frmBankAccount : Form
    {
        public frmBankAccount()
        {
            InitializeComponent();
        }

        XmlDocument xDoc;
        public string Command;
        public string ID_TEMP;
        public string BANK_TEMP;

        public void funLoad()
        {
            xDoc = new XmlDocument();
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/BankAccount.xml");
            }
            else 
            {
                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);
                string strDoc = cCon.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "BankAccount", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }

            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='BankAccount']";
            tbBankName._XPath = RootPath + "/Item[@Name='BANK_NAME']";
            tbBankDetail._XPath = RootPath + "/Item[@Name='BANK_DETAIL']";

            //คำสั่งในการ Map Control กับ Xml โดยใช้ Mapping control
            mpBank1._XmlDocument = xDoc;
            mpBank1.AddControl(tbBankName);
            mpBank1.AddControl(tbBankDetail);
        }

        public void funSave() 
        {
            //BANK_TEMP = tbBankName._Value;
            if (Validation())
            {
                if (mpBank1.funSaveXml())
                {
                    string strDoc = xDoc.OuterXml;
                    NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                    NCS.Add(new NextwaverDB.NColumn("BANK_NAME", tbBankName._Value));
                    NCS.Add(new NextwaverDB.NColumn("BANK_DETAIL", tbBankDetail._Value));
                    if (Command == "New")
                    {
                        NCS.Add(new NextwaverDB.NColumn("CREATE_BY", cMain.user));
                        NCS.Add(new NextwaverDB.NColumn("CREATE_TIME", DateTime.Now.ToString("dd/mm/yy hh:mm:ss")));
                    }
                    else
                    {
                        NCS.Add(new NextwaverDB.NColumn("EDIT_BY", cMain.user));
                        NCS.Add(new NextwaverDB.NColumn("EDIT_TIME", DateTime.Now.ToString("dd/mm/yy hh:mm:ss")));
                    }

                    ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);

                    if (Command == "New")
                    {
                        if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "BankAccount", NCS, strDoc))
                        {
                            MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว", "สร้างใหม่");
                            this.DialogResult = DialogResult.OK;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก" + cCon.ErrorMsg(), "สร้างใหม่");
                        }
                    }
                    else
                    {
                        NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
                        NWS.Add(new NextwaverDB.NWhere("ID", ID_TEMP));

                        if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "BankAccount", NCS, NWS, strDoc))
                        {
                            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "แก้ไขข้อมูล");
                            this.DialogResult = DialogResult.OK;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก : " + cCon.ErrorMsg(), "แก้ไขข้อมูล");
                        }
                    }
                }
            }
        }
        

        private bool Validation()
        {
            if (tbBankName._Value == "")
            {
                MessageBox.Show("โปรดระบุบัญชีธนาคาร", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
            NWS.whereType = true;
            NWS.Where = "[@BANK_NAME@ = '" + tbBankName._Value + "']";
            if (Command != "New")
            {
                NWS.Where += "[@BANK_NAME@ != '" + BANK_TEMP + "']";
            }

            NextwaverDB.NColumns NCS_S = new NextwaverDB.NColumns();
            NCS_S.Add(new NextwaverDB.NColumn("BANK_NAME"));

            DataTable dt = cConn.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop" , "BankAccount", NCS_S, NWS);
           
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("ชื่อธนาคารนี้มีอยู่แล้วในระบบโปรดระบุใหม่", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBankName.Focus();
                return false;
            }
            return true;
        }

        private void frmBankAccount_Load(object sender, EventArgs e)
        {
            lblUser.Text = "USER : " + cMain.user;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
            timer1.Enabled = true;
        }

        private void btBankSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btBankClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
