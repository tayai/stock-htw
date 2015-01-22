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
    public partial class frmWarehouse : Form
    {
        public frmWarehouse()
        {
            InitializeComponent();
        }

        XmlDocument xDoc = new XmlDocument();
        public string Command;
        public string ID_TEMP;
        public string WAREHOUSE_TEMP;

        public void funLoad()
        {
            //xDoc = new XmlDocument();
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/Warehouse.xml");
            }
            else
            {
                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);
                string strDoc = cCon.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Warehouse", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='Warehouse']";
            tbWareName._XPath = RootPath + "/Item[@Name='WAREHOUSE_NAME']";
            tbWareAddress._XPath = RootPath + "/Item[@Name='WAREHOUSE_ADDRESS']";
            tbWareTel._XPath = RootPath + "/Item[@Name='WAREHOUSE_TEL']";
            tbWareFax._XPath = RootPath + "/Item[@Name='WAREHOUSE_FAX']";
            tbWareDetail._XPath = RootPath + "/Item[@Name='WAREHOUSE_DETAIL']";

            //คำสั่งในการ Map Control กับ Xml โดยใช้ Mapping control
            mpWarehouse1._XmlDocument = xDoc;
            mpWarehouse1.AddControl(tbWareName);
            mpWarehouse1.AddControl(tbWareAddress);
            mpWarehouse1.AddControl(tbWareTel);
            mpWarehouse1.AddControl(tbWareFax);
            mpWarehouse1.AddControl(tbWareDetail);

        }

        public void funSave()
        {
            //WAREHOUSE_TEMP = tbWareName._Value;
            if (Validation())
            {
                if(mpWarehouse1.funSaveXml())
                {
                    string strDoc = xDoc.OuterXml;
                    NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                    NCS.Add(new NextwaverDB.NColumn("WAREHOUSE_NAME", tbWareName._Value));
                    NCS.Add(new NextwaverDB.NColumn("WAREHOUSE_ADDRESS", tbWareAddress._Value));
                    NCS.Add(new NextwaverDB.NColumn("WAREHOUSE_TEL", tbWareTel._Value));
                    NCS.Add(new NextwaverDB.NColumn("WAREHOUSE_FAX", tbWareFax._Value));
                    NCS.Add(new NextwaverDB.NColumn("WAREHOUSE_DETAIL", tbWareDetail._Value));

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
                        if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Warehouse", NCS, strDoc))
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

                        if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Warehouse", NCS, NWS, strDoc))
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
            if (tbWareName._Value == "")
            {
                MessageBox.Show("โปรดระบุคลังสินค้า", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
            NWS.whereType = true;
            NWS.Where = "[@WAREHOUSE_NAME@ = '" + tbWareName._Value + "']";
            if (Command != "New")
            {
                NWS.Where += "[@WAREHOUSE_NAME@ != '" + WAREHOUSE_TEMP + "']";
            }

            NextwaverDB.NColumns NCS_S = new NextwaverDB.NColumns();
            NCS_S.Add(new NextwaverDB.NColumn("WAREHOUSE_NAME"));

            DataTable dt = cConn.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Warehouse", NCS_S, NWS);
           
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("ชื่อคลังสินค้านี้มีอยู่แล้วในระบบโปรดระบุใหม่", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbWareName.Focus();
                return false;
            }
            return true;
        }

        private void btWareSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btWareClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
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
