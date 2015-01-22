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
    public partial class frmCompanyData : Form
    {
        public frmCompanyData()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/CompanyData.xml");
            }
            else
            {
                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);
                string strDoc = cCon.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "CompanyData", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='CompanyData']";
            tbNameT._XPath = RootPath + "/Item[@Name='NAME_TH']";
            tbNameE._XPath = RootPath + "/Item[@Name='NAME_EN']";
            tbAddress._XPath = RootPath + "/Item[@Name='OFFICE_ADDRESS']";
            tbTel._XPath = RootPath + "/Item[@Name='OFFICE_TEL']";
            tbFax._XPath = RootPath + "/Item[@Name='OFFICE_FAX']";
            tbEmail._XPath = RootPath + "/Item[@Name='OFFICE_EMAIL']";
            tbLineID._XPath = RootPath + "/Item[@Name='OFFICE_LINEID']";
            tbWebsite._XPath = RootPath + "/Item[@Name='WEBSITE']";
            tbTaxID._XPath = RootPath + "/Item[@Name='TAXID']";
            tbRegis._XPath = RootPath + "/Item[@Name='BUSINESS_REGIS']";

            //คำสั่งในการ Map Control กับ Xml โดยใช้ Mapping control
            mpCompanyData1._XmlDocument = xDoc;
            mpCompanyData1.AddControl(tbNameT);
            mpCompanyData1.AddControl(tbNameE);
            mpCompanyData1.AddControl(tbAddress);
            mpCompanyData1.AddControl(tbTel);
            mpCompanyData1.AddControl(tbFax);
            mpCompanyData1.AddControl(tbEmail);
            mpCompanyData1.AddControl(tbLineID);
            mpCompanyData1.AddControl(tbWebsite);
            mpCompanyData1.AddControl(tbTaxID);
            mpCompanyData1.AddControl(tbRegis);
        }

        public void funSave()
        {
            if (mpCompanyData1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("NAME_TH", tbNameT._Value));
                NCS.Add(new NextwaverDB.NColumn("NAME_EN", tbNameE._Value));
                NCS.Add(new NextwaverDB.NColumn("OFFICE_ADDRESS", tbAddress._Value));
                NCS.Add(new NextwaverDB.NColumn("OFFICE_TEL", tbTel._Value));
                NCS.Add(new NextwaverDB.NColumn("OFFICE_FAX", tbFax._Value));
                NCS.Add(new NextwaverDB.NColumn("OFFICE_EMAIL", tbEmail._Value));
                NCS.Add(new NextwaverDB.NColumn("OFFICE_LINEID", tbLineID._Value));
                NCS.Add(new NextwaverDB.NColumn("WEBSITE", tbWebsite._Value));
                NCS.Add(new NextwaverDB.NColumn("TAXID", tbTaxID._Value));
                NCS.Add(new NextwaverDB.NColumn("BUSINESS_REGIS", tbRegis._Value));

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
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "CompanyData", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "CompanyData", NCS, NWS, strDoc))
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

        private void frmCompanyData_Load(object sender, EventArgs e)
        {
            lblUser.Text = "USER : " + cMain.user;
            lblDatetime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy" + " เวลา " + "hh:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblDatetime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy"+" เวลา "+"hh:mm:ss");
            timer1.Enabled = true;
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
