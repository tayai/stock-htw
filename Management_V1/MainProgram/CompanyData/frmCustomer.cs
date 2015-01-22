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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/Customer.xml");
            }
            else
            {
                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);
                string strDoc = cCon.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Customer", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='Customer']";
            tbCustName._XPath = RootPath + "/Item[@Name='CUSTOMER_NAME']";
            tbCustAddress._XPath = RootPath + "/Item[@Name='CUSTOMER_ADDRESS']";
            tbCustTel._XPath = RootPath + "/Item[@Name='CUSTOMER_TEL']";
            tbCustFax._XPath = RootPath + "/Item[@Name='CUSTOMER_FAX']";
            tbCustLine._XPath = RootPath + "/Item[@Name='CUSTOMER_LINEID']";
            tbCustTaxID._XPath = RootPath + "/Item[@Name='CUSTOMER_TAXID']";
            tbContact._XPath = RootPath + "/Item[@Name='CONTACT']";
            tbDiscount._XPath = RootPath + "/Item[@Name='DISCOUNT_RATE']";
            tbPayment._XPath = RootPath + "/Item[@Name='PAYMENT']";
            tbCredit._XPath = RootPath + "/Item[@Name='CREDIT']";
            tbCustDetail._XPath = RootPath + "/Item[@Name='CUSTOMER_DETAIL']";

            //คำสั่งในการ Map Control กับ Xml โดยใช้ Mapping control
            mpCust1._XmlDocument = xDoc;
            mpCust1.AddControl(tbCustName);
            mpCust1.AddControl(tbCustAddress);
            mpCust1.AddControl(tbCustTel);
            mpCust1.AddControl(tbCustFax);
            mpCust1.AddControl(tbCustLine);
            mpCust1.AddControl(tbCustTaxID);
            mpCust1.AddControl(tbContact);
            mpCust1.AddControl(tbDiscount);
            mpCust1.AddControl(tbPayment);
            mpCust1.AddControl(tbCredit);
            mpCust1.AddControl(tbCustDetail);
        }

        public void funSave()
        {
            if (mpCust1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("CUSTOMER_NAME", tbCustName._Value));
                NCS.Add(new NextwaverDB.NColumn("CUSTOMER_ADDRESS", tbCustAddress._Value));
                NCS.Add(new NextwaverDB.NColumn("CUSTOMER_TEL", tbCustTel._Value));
                NCS.Add(new NextwaverDB.NColumn("CUSTOMER_FAX", tbCustFax._Value));
                NCS.Add(new NextwaverDB.NColumn("CUSTOMER_LINEID", tbCustLine._Value));
                NCS.Add(new NextwaverDB.NColumn("CUSTOMER_TAXID", tbCustTaxID._Value));
                NCS.Add(new NextwaverDB.NColumn("CONTACT", tbContact._Value));
                NCS.Add(new NextwaverDB.NColumn("DISCOUNT_RATE", tbDiscount._Value));
                NCS.Add(new NextwaverDB.NColumn("PAYMENT", tbPayment._Value));
                NCS.Add(new NextwaverDB.NColumn("CREDIT", tbCredit._Value));
                NCS.Add(new NextwaverDB.NColumn("CUSTOMER_DETAIL", tbCustDetail._Value));

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
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Customer", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Customer", NCS, NWS, strDoc))
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

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            lblUser.Text = "USER : " + cMain.user;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy" + " เวลา " + "hh:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy" + " เวลา " + "hh:mm:ss");
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
