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
    public partial class frmProductInfo : Form
    {
        public frmProductInfo()
        {
            InitializeComponent();
        }

        XmlDocument xDoc;
        public string Command;
        public string ID_TEMP;

        public void funLoad()

        {

            xDoc = new XmlDocument();
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/ProductInformation.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductInformation", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='ProductInformation']";
            tbProdCode._XPath = RootPath + "/Item[@Name='PRODUCT_CODE']";
            tbProdName._XPath = RootPath + "/Item[@Name='PRODUCT_NAME']";
            tbProdGroup._XPath = RootPath + "/Item[@Name='PRODUCT_GROUP']";
            tbProdCat._XPath = RootPath + "/Item[@Name='PRODUCT_CATEGORY']";
            tbUnitType._XPath = RootPath + "/Item[@Name='UNIT_TYPE']";
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
            tbDetail._XPath = RootPath + "/Item[@Name='DETAIL']";

            //คำสั่งในการ Map Control กับ Xml
            ucMCPI1._XmlDocument = xDoc;
            ucMCPI1.AddControl(tbProdCode);
            ucMCPI1.AddControl(tbProdName);
            ucMCPI1.AddControl(tbProdGroup);
            ucMCPI1.AddControl(tbProdCat);
            ucMCPI1.AddControl(tbUnitType);
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
            if (ucMCPI1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("PRODUCT_CODE", tbProdCode._Value));
                NCS.Add(new NextwaverDB.NColumn("PRODUCT_NAME", tbProdName._Value));
                NCS.Add(new NextwaverDB.NColumn("PRODUCT_GROUP", tbProdGroup._Value));
                NCS.Add(new NextwaverDB.NColumn("PRODUCT_CATEGORY", tbProdCat._Value));
                NCS.Add(new NextwaverDB.NColumn("UNIT_TYPE", tbUnitType._Value));
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
                NCS.Add(new NextwaverDB.NColumn("DETAIL", tbDetail._Value));
                if (Command == "New")
                {
                    NCS.Add(new NextwaverDB.NColumn("CREATE_BY", cMain.user));
                }
                else 
                {
                    NCS.Add(new NextwaverDB.NColumn("EDIT_BY", cMain.user));
                }
                NCS.Add(new NextwaverDB.NColumn("DATE_TIME", DateTime.Now.ToString()));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);

                if (Command == "New")
                {
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductInformation", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductInformation", NCS, NWS, strDoc))
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

        private void btPTClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPISave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btPIClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
