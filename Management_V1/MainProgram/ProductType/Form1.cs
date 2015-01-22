using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ProductType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Command;
        public string ID_TEMP;
        
        XmlDocument xDoc;

        public void funLoad()
        {
            xDoc = new XmlDocument();
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/ProductType.xml");
            }
/*            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "CompanyData", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }*/
 
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='ProductType']";
            tbPTName._XPath = RootPath + "/Item[@Name='PRODUCTTYPENAME']";
            tbPTDetail._XPath = RootPath + "/Item[@Name='DETAIL']";


            //คำสั่งในการ Map Control กับ Xml
            ucMappingControls1._XmlDocument = xDoc;
            ucMappingControls1.AddControl(tbPTName);
            ucMappingControls1.AddControl(tbPTDetail);

        }


        public void funSave()
        {
            if (ucMappingControls1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;

                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();

                NCS.Add(new NextwaverDB.NColumn("PRODUCTTYPENAME", tbPTName._Value));
                NCS.Add(new NextwaverDB.NColumn("DETAIL", tbPTDetail._Value));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);

                if (Command == "New")
                {
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductType", NCS, strDoc))
                    {
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ProductType", NCS, NWS, strDoc))
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

        private void btSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
