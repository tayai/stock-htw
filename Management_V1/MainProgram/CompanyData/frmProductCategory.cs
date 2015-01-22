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
    public partial class frmProductCategory : Form
    {
        public frmProductCategory()
        {
            InitializeComponent();
        }

        public string Command;
        public string ID_TEMP;
        public string CAT_TEMP;
        XmlDocument xDoc;

        public void funLoad()
        {
            xDoc = new XmlDocument();
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/ProductCategory.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductCategory", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='ProductCategory']";
            tbPCName._XPath = RootPath + "/Item[@Name='CATEGORY_NAME']";
            tbPCDetail._XPath = RootPath + "/Item[@Name='CATEGORY_DETAIL']";


            //คำสั่งในการ Map Control กับ Xml
            ucMCPC1._XmlDocument = xDoc;
            ucMCPC1.AddControl(tbPCName);
            ucMCPC1.AddControl(tbPCDetail);
        }

        public void funSave()
        {
            if (Validation())
            {
                //CAT_TEMP = tbPCName._Value;
                if (ucMCPC1.funSaveXml())
                {
                    string strDoc = xDoc.OuterXml;
                    NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                    NCS.Add(new NextwaverDB.NColumn("CATEGORY_NAME", tbPCName._Value));
                    NCS.Add(new NextwaverDB.NColumn("CATEGORY_DETAIL", tbPCDetail._Value));
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
                        if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductCategory", NCS, strDoc))
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

                        if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductCategory", NCS, NWS, strDoc))
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
            if (tbPCName._Value == "")
            {
                MessageBox.Show("โปรดระบุหมวดหมู่สินค้า", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
            NWS.whereType = true;
            NWS.Where = "[@CATEGORY_NAME@ = '" + tbPCName._Value + "']";
            if (Command != "New")
            {
                NWS.Where += "[@CATEGORY_NAME@ != '" + CAT_TEMP + "']";
            }

            NextwaverDB.NColumns NCS_S = new NextwaverDB.NColumns();
            NCS_S.Add(new NextwaverDB.NColumn("CATEGORY_NAME"));

            DataTable dt = cConn.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductCategory", NCS_S, NWS);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("หมวดหมู่นี้มีอยู่แล้วในระบบโปรดระบุใหม่", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPCName.Focus();
                return false;
            }
            return true;
        }

        private void btPCSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btPCClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductCategory_Load(object sender, EventArgs e)
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
