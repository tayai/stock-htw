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
    public partial class frmPartnerType : Form
    {
        public frmPartnerType()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/PartnerType.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "PartnerType", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='PartnerType']";
            tbPName._XPath = RootPath + "/Item[@Name='PARTNERNAME']";
            tbPType._XPath = RootPath + "/Item[@Name='PARTNERTYPE']";
            tbPDetail._XPath = RootPath + "/Item[@Name='DETAIL']";

            //คำสั่งในการ Map Control กับ Xml
            ucMCPT1._XmlDocument = xDoc;
            ucMCPT1.AddControl(tbPName);
            ucMCPT1.AddControl(tbPType);
            ucMCPT1.AddControl(tbPDetail);

        }

        public void funSave()
        {
            if (ucMCPT1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("PARTNERNAME", tbPName._Value));
                NCS.Add(new NextwaverDB.NColumn("PARTNERTYPE", tbPType._Value));
                NCS.Add(new NextwaverDB.NColumn("DETAIL", tbPDetail._Value));


                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);

                if (Command == "New")
                {
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "PartnerType", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "PartnerType", NCS, NWS, strDoc))
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

        private void btPTSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btPTClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
