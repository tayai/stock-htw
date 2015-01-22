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
    public partial class frmProductUnit : Form
    {
        public frmProductUnit()
        {
            InitializeComponent();
        }

        public string Command;
        public string ID_TEMP;
        public string UNIT_TEMP;
        XmlDocument xDoc;

        public void funLoad()
        {
            xDoc = new XmlDocument();
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/ProductUnit.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductUnit", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='ProductUnit']";
            tbAcronym._XPath = RootPath + "/Item[@Name='ACRONYM']";
            tbUnitName._XPath = RootPath + "/Item[@Name='UNIT_NAME']";
            tbSymbol._XPath = RootPath + "/Item[@Name='SYMBOL']";
            tbUnitDetail._XPath = RootPath + "/Item[@Name='UNIT_DETAIL']";

            //คำสั่งในการ Map Control กับ Xml
            ucMCPU1._XmlDocument = xDoc;
            ucMCPU1.AddControl(tbAcronym);
            ucMCPU1.AddControl(tbUnitName);
            ucMCPU1.AddControl(tbSymbol);
            ucMCPU1.AddControl(tbUnitDetail);
        }

        public void funSave()
        {
            //UNIT_TEMP = tbUnitName._Value;
            if (Validation())
            {
                if (ucMCPU1.funSaveXml())
                {
                    string strDoc = xDoc.OuterXml;
                    NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                    NCS.Add(new NextwaverDB.NColumn("ACRONYM", tbAcronym._Value));
                    NCS.Add(new NextwaverDB.NColumn("UNIT_NAME", tbUnitName._Value));
                    NCS.Add(new NextwaverDB.NColumn("SYMBOL", tbSymbol._Value));
                    NCS.Add(new NextwaverDB.NColumn("UNIT_DETAIL", tbUnitDetail._Value));
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
                        if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductUnit", NCS, strDoc))
                        {
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว", "สร้างใหม่");
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

                        if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductUnit", NCS, NWS, strDoc))
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
            if (tbUnitName._Value == "")
            {
                MessageBox.Show("โปรดระบุหน่วยนับสินค้า", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
            NWS.whereType = true;
            NWS.Where = "[@UNIT_NAME@ = '" + tbUnitName._Value + "']";
            if (Command != "New")
            {
                NWS.Where += "[@UNIT_NAME@ != '" + UNIT_TEMP + "']";
            }

            NextwaverDB.NColumns NCS_S = new NextwaverDB.NColumns();
            NCS_S.Add(new NextwaverDB.NColumn("UNIT_NAME"));

            DataTable dt = cConn.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductUnit", NCS_S, NWS);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("หน่วยนับนี้มีอยู่แล้วในระบบโปรดระบุใหม่", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUnitName.Focus();
                return false;
            }
            return true;
        }


        private void btPUSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btPUClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductUnit_Load(object sender, EventArgs e)
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


    }
}
