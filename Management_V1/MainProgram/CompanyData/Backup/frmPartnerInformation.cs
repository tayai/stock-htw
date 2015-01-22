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
    public partial class frmPartnerInformation : Form
    {
        public frmPartnerInformation()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/PartnerInformation.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "PartnerInformation", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='PartnerInformation']";
            tbPartnerType._XPath = RootPath + "/Item[@Name='PARTNERTYPE']";
            tbPartnerCode._XPath = RootPath + "/Item[@Name='PARTNERCODE']";
            tbPartnerName._XPath = RootPath + "/Item[@Name='PARTNERNAME']";
            tbContactPerson._XPath = RootPath + "/Item[@Name='CONTACTPERSON']";
            tbAddress._XPath = RootPath + "/Item[@Name='ADDRESS']";
            tbTel._XPath = RootPath + "/Item[@Name='TEL']";
            tbFax._XPath = RootPath + "/Item[@Name='FAX']";
            tbEmail._XPath = RootPath + "/Item[@Name='EMAIL']";
            tbWebsite._XPath = RootPath + "/Item[@Name='WEBSITE']";
            tbExceptTax._XPath = RootPath + "/Item[@Name='EXCEPTTAX']";
            tbActive._XPath = RootPath + "/Item[@Name='ACTIVE']";
            tbStatus._XPath = RootPath + "/Item[@Name='P_STATUS']";
            tbPayment._XPath = RootPath + "/Item[@Name='PAYMENTTYPE']";
            tbDetail._XPath = RootPath + "/Item[@Name='DETAIL']";
            tbRemark._XPath = RootPath + "/Item[@Name='REMARK']";


            //คำสั่งในการ Map Control กับ Xml
            ucMCPartI1._XmlDocument = xDoc;
            ucMCPartI1.AddControl(tbPartnerType);
            ucMCPartI1.AddControl(tbPartnerCode);
            ucMCPartI1.AddControl(tbPartnerName);
            ucMCPartI1.AddControl(tbContactPerson);
            ucMCPartI1.AddControl(tbAddress);
            ucMCPartI1.AddControl(tbTel);
            ucMCPartI1.AddControl(tbFax);
            ucMCPartI1.AddControl(tbEmail);
            ucMCPartI1.AddControl(tbWebsite);
            ucMCPartI1.AddControl(tbExceptTax);
            ucMCPartI1.AddControl(tbActive);
            ucMCPartI1.AddControl(tbStatus);
            ucMCPartI1.AddControl(tbPayment);
            ucMCPartI1.AddControl(tbDetail);
            ucMCPartI1.AddControl(tbRemark);

        }

        public void funSave()
        {
            if (ucMCPartI1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("PARTNERTYPE", tbPartnerType._Value));
                NCS.Add(new NextwaverDB.NColumn("PARTNERCODE", tbPartnerCode._Value));
                NCS.Add(new NextwaverDB.NColumn("PARTNERNAME", tbPartnerName._Value));
                NCS.Add(new NextwaverDB.NColumn("CONTACTPERSON", tbContactPerson._Value));
                NCS.Add(new NextwaverDB.NColumn("ADDRESS", tbAddress._Value));
                NCS.Add(new NextwaverDB.NColumn("TEL", tbTel._Value));
                NCS.Add(new NextwaverDB.NColumn("FAX", tbFax._Value));
                NCS.Add(new NextwaverDB.NColumn("EMAIL", tbEmail._Value));
                NCS.Add(new NextwaverDB.NColumn("WEBSITE", tbWebsite._Value));
                NCS.Add(new NextwaverDB.NColumn("EXCEPTTAX", tbExceptTax._Value));
                NCS.Add(new NextwaverDB.NColumn("ACTIVE", tbActive._Value));
                NCS.Add(new NextwaverDB.NColumn("P_STATUS", tbStatus._Value));
                NCS.Add(new NextwaverDB.NColumn("PAYMENTTYPE", tbPayment._Value));
                NCS.Add(new NextwaverDB.NColumn("DETAIL", tbDetail._Value));
                NCS.Add(new NextwaverDB.NColumn("REMARK", tbRemark._Value));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);

                if (Command == "New")
                {
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "PartnerInformation", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "PartnerInformation", NCS, NWS, strDoc))
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
