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
    public partial class frmProductRecord : Form
    {
        public frmProductRecord()
        {
            InitializeComponent();
        }

        XmlDocument xDoc = new XmlDocument();
        //XmlDocument xDoc1;
        public string Command;
        public string ID_TEMP;
        public string P_CODE_TEMP;

        public void funLoad()

        {

            //xDoc = new XmlDocument();
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/ProductRecord.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductRecord", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            // กำหนด path ของ xml และ map ข้อมูลใน xml มาใส่ control
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='ProductRecord']";
            tbProdCode._XPath = RootPath + "/Item[@Name='PRODUCT_CODE']";
            tbProdName._XPath = RootPath + "/Item[@Name='PRODUCT_NAME']";
            cbProdGroup._XPath = RootPath + "/Item[@Name='GROUP_NAME']";
            cbProdCat._XPath = RootPath + "/Item[@Name='CATEGORY_NAME']";
            cbProdUnit._XPath = RootPath + "/Item[@Name='UNIT_NAME']";
            cbWarehouse._XPath = RootPath + "/Item[@Name='WAREHOUSE_NAME']";
            tbPOV._XPath = RootPath + "/Item[@Name='POINT_OF_ORDER']";
            tbPrice1._XPath = RootPath + "/Item[@Name='PRICE1']";
            tbPrice2._XPath = RootPath + "/Item[@Name='PRICE2']";
            tbPrice3._XPath = RootPath + "/Item[@Name='PRICE3']";
            tbPrice4._XPath = RootPath + "/Item[@Name='PRICE4']";
            tbPrice5._XPath = RootPath + "/Item[@Name='PRICE5']";
            tbPrice6._XPath = RootPath + "/Item[@Name='PRICE6']";
            tbPrice7._XPath = RootPath + "/Item[@Name='PRICE7']";
            tbPrice8._XPath = RootPath + "/Item[@Name='PRICE8']";
            tbPrice9._XPath = RootPath + "/Item[@Name='PRICE9']";
            tbPrice10._XPath = RootPath + "/Item[@Name='PRICE10']";
            tbDetail._XPath = RootPath + "/Item[@Name='PRODUCT_DETAIL']";
            
            //คำสั่งในการ Map Control กับ Xml

            // Map กับคอนโทรล combobox กลุ่มสินค้า
            ConnectServer.cConection cConn2 = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NColumns NCS_S_GRP = new NextwaverDB.NColumns();
            NCS_S_GRP.Add(new NextwaverDB.NColumn("ID"));
            NCS_S_GRP.Add(new NextwaverDB.NColumn("GROUP_NAME"));
            DataTable dt2 = cConn2.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductGroup", NCS_S_GRP);
            cbProdGroup._DisplayMember = "GROUP_NAME";
            cbProdGroup._ValueMember = "GROUP_NAME";
            cbProdGroup._DataSource = dt2;

            // Map กับคอนโทรล combobox หมวดหมู่สินค้า
            ConnectServer.cConection cConn3 = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NColumns NCS_S_CAT = new NextwaverDB.NColumns();
            NCS_S_CAT.Add(new NextwaverDB.NColumn("ID"));
            NCS_S_CAT.Add(new NextwaverDB.NColumn("CATEGORY_NAME"));
            DataTable dt3 = cConn3.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductCategory", NCS_S_CAT);
            cbProdCat._DisplayMember = "CATEGORY_NAME";
            cbProdCat._ValueMember = "CATEGORY_NAME";
            cbProdCat._DataSource = dt3;

            // Map กับคอนโทรล combobox หน่วยนับสินค้า
            ConnectServer.cConection cConn4 = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NColumns NCS_S_UNIT = new NextwaverDB.NColumns();
            NCS_S_UNIT.Add(new NextwaverDB.NColumn("ID"));
            NCS_S_UNIT.Add(new NextwaverDB.NColumn("UNIT_NAME"));
            DataTable dt4 = cConn4.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductUnit", NCS_S_UNIT);
            cbProdUnit._DisplayMember = "UNIT_NAME";
            cbProdUnit._ValueMember = "UNIT_NAME";
            cbProdUnit._DataSource = dt4;

            // Map กับคอนโทรล combobox คลังสินค้า
            ConnectServer.cConection cConn5 = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NColumns NCS_S_WARE = new NextwaverDB.NColumns();
            NCS_S_WARE.Add(new NextwaverDB.NColumn("ID"));
            NCS_S_WARE.Add(new NextwaverDB.NColumn("WAREHOUSE_NAME"));
            DataTable dt5 = cConn5.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Warehouse", NCS_S_WARE);
            cbWarehouse._DisplayMember = "WAREHOUSE_NAME";
            cbWarehouse._ValueMember = "WAREHOUSE_NAME";
            cbWarehouse._DataSource = dt5;

            // Map กับคอนโทรล combobox

            ucMCPI1._XmlDocument = xDoc;
            ucMCPI1.AddControl(tbProdCode);
            ucMCPI1.AddControl(tbProdName);
            ucMCPI1.AddControl(cbProdGroup);
            ucMCPI1.AddControl(cbProdCat);
            ucMCPI1.AddControl(cbProdUnit);
            ucMCPI1.AddControl(cbWarehouse);
            ucMCPI1.AddControl(tbPOV);
            ucMCPI1.AddControl(tbPrice1);
            ucMCPI1.AddControl(tbPrice2);
            ucMCPI1.AddControl(tbPrice3);
            ucMCPI1.AddControl(tbPrice4);
            ucMCPI1.AddControl(tbPrice5);
            ucMCPI1.AddControl(tbPrice6);
            ucMCPI1.AddControl(tbPrice7);
            ucMCPI1.AddControl(tbPrice8);
            ucMCPI1.AddControl(tbPrice9);
            ucMCPI1.AddControl(tbPrice10);
            ucMCPI1.AddControl(tbDetail);
            
 //           ucMCPI1.AddControl(tbUser);
 //           ucMCPI1.AddControl(tbTime);
            
        }

        private void btPTSave_Click(object sender, EventArgs e)
        {
            funSave();
            
        }

        public void funSave()
        {
            //PROD_TEMP = tbProdCode._Value;
            if (Validation())
            {
                if (ucMCPI1.funSaveXml())
                {
                    string strDoc = xDoc.OuterXml;
                    NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                    NCS.Add(new NextwaverDB.NColumn("PRODUCT_CODE", tbProdCode._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRODUCT_NAME", tbProdName._Value));
                    NCS.Add(new NextwaverDB.NColumn("GROUP_NAME", cbProdGroup._SelectedValue));
                    NCS.Add(new NextwaverDB.NColumn("CATEGORY_NAME", cbProdCat._SelectedValue));
                    NCS.Add(new NextwaverDB.NColumn("UNIT_NAME", cbProdUnit._SelectedValue));
                    NCS.Add(new NextwaverDB.NColumn("WAREHOUSE_NAME", cbWarehouse._SelectedValue));
                    NCS.Add(new NextwaverDB.NColumn("POINT_OF_ORDER", tbPOV._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE1", tbPrice1._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE2", tbPrice2._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE3", tbPrice3._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE4", tbPrice4._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE5", tbPrice5._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE6", tbPrice6._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE7", tbPrice7._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE8", tbPrice8._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE9", tbPrice9._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRICE10", tbPrice10._Value));
                    NCS.Add(new NextwaverDB.NColumn("PRODUCT_DETAIL", tbDetail._Value));
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
                        if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductRecord", NCS, strDoc))
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

                        if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductRecord", NCS, NWS, strDoc))
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
            if (tbProdCode._Value == "")
            {
                MessageBox.Show("โปรดระบุรหัสสินค้า", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tbProdName._Value == "")
            {
                MessageBox.Show("โปรดระบุชื่อสินค้า", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbProdName.Focus();
                return false;
            }

            ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
            NWS.whereType = true;
            NWS.Where = "[@PRODUCT_CODE@ = '" + tbProdCode._Value + "']";
            if (Command != "New")
            {
                NWS.Where += "[@PRODUCT_CODE@ != '" + P_CODE_TEMP + "']";
            }

            NextwaverDB.NColumns NCS_S = new NextwaverDB.NColumns();
            NCS_S.Add(new NextwaverDB.NColumn("PRODUCT_CODE"));

            DataTable dt = cConn.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductRecord", NCS_S, NWS);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("รหัสสินค้านี้มีอยู่แล้วในระบบโปรดระบุใหม่", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbProdCode.Focus();
                return false;
            }
            return true;
        }

        private void btPISave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btPIClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");

            timer1.Enabled = true;
        }

        private void frmProductRecord_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
            lblUser.Text = "USER : " + cMain.user;
        }

    }
}
