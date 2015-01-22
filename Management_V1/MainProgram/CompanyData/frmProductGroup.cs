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
    public partial class frmProductGroup : Form
    {
        public frmProductGroup()
        {
            InitializeComponent();
        }

        public string Command;
        public string ID_TEMP;
        public string GROUP_TEMP;
        
        XmlDocument xDoc;

        public void funLoad()
        {
            xDoc = new XmlDocument();
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/ProductGroup.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductGroup", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='ProductGroup']";
            tbPGName._XPath = RootPath + "/Item[@Name='GROUP_NAME']";
            tbPGDetail._XPath = RootPath + "/Item[@Name='GROUP_DETAIL']";


            //คำสั่งในการ Map Control กับ Xml
            ucMPCPG1._XmlDocument = xDoc;
            ucMPCPG1.AddControl(tbPGName);
            ucMPCPG1.AddControl(tbPGDetail);
        }

        public void funSave()
        {
            // ผิดครับ GROUP_TEMP = tbPGName._Value;
            if (Validation())
            {
                if (ucMPCPG1.funSaveXml())
                {
                    string strDoc = xDoc.OuterXml;
                    NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                    NCS.Add(new NextwaverDB.NColumn("GROUP_NAME", tbPGName._Value));
                    NCS.Add(new NextwaverDB.NColumn("GROUP_DETAIL", tbPGDetail._Value));
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
                        if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductGroup", NCS, strDoc))
                        {
                            MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว", "สร้างใหม่");
                            this.DialogResult = DialogResult.OK;
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก", cCon.ErrorMsg());
                        }

                    }
                    else
                    {
                        NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
                        NWS.Add(new NextwaverDB.NWhere("ID", ID_TEMP));

                        if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductGroup", NCS, NWS, strDoc))
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
            if (tbPGName._Value == "")
            {
                MessageBox.Show("โปรดระบุกลุ่มสินค้า", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
            NWS.whereType = true;
            NWS.Where = "[@GROUP_NAME@ = '" + tbPGName._Value + "']";
            if (Command != "New")
            {
                NWS.Where += "[@GROUP_NAME@ != '" + GROUP_TEMP + "']";
            }

            NextwaverDB.NColumns NCS_S = new NextwaverDB.NColumns();
            NCS_S.Add(new NextwaverDB.NColumn("GROUP_NAME"));

            DataTable dt = cConn.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop" , "ProductGroup", NCS_S, NWS);
            
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("ชื่อกลุ่มสินค้านี้มีอยู่แล้วในระบบโปรดระบุใหม่", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPGName.Focus();
                return false;
            }
            return true;
        }
 

        private void btPGSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btPGClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductGroup_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
            lblUser.Text = "USER : " + cMain.user;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
            timer1.Enabled = true;
        }
    }
}
