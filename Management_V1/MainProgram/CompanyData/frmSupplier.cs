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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/Supplier.xml");
            }
            else
            {
                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);
                string strDoc = cCon.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Supplier", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='Supplier']";
            tbSuppName._XPath = RootPath + "/Item[@Name='SUPPLIER_NAME']";
            tbSuppAddress._XPath = RootPath + "/Item[@Name='SUPPLIER_ADDRESS']";
            tbSuppTel._XPath = RootPath + "/Item[@Name='SUPPLIER_TEL']";
            tbSuppFax._XPath = RootPath + "/Item[@Name='SUPPLIER_FAX']";
            tbSuppLine._XPath = RootPath + "/Item[@Name='SUPPLIER_LINEID']";
            tbDiscount._XPath = RootPath + "/Item[@Name='DISCOUNT_RATE']";
            tbPayment._XPath = RootPath + "/Item[@Name='PAYMENT']";
            tbContact._XPath = RootPath + "/Item[@Name='CONTACT']";
            tbCredit._XPath = RootPath + "/Item[@Name='CREDIT']";
            tbSuppDetail._XPath = RootPath + "/Item[@Name='SUPPLIER_DETAIL']";

            //คำสั่งในการ Map Control กับ Xml โดยใช้ Mapping control
            mpSupp1._XmlDocument = xDoc;
            mpSupp1.AddControl(tbSuppName);
            mpSupp1.AddControl(tbSuppAddress);
            mpSupp1.AddControl(tbSuppTel);
            mpSupp1.AddControl(tbSuppFax);
            mpSupp1.AddControl(tbSuppLine);
            mpSupp1.AddControl(tbDiscount);
            mpSupp1.AddControl(tbDiscount);
            mpSupp1.AddControl(tbPayment);
            mpSupp1.AddControl(tbContact);
            mpSupp1.AddControl(tbCredit);
            mpSupp1.AddControl(tbSuppDetail);
        }

        public void funSave()
        {
            if (mpSupp1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("SUPPLIER_NAME", tbSuppName._Value));
                NCS.Add(new NextwaverDB.NColumn("SUPPLIER_ADDRESS", tbSuppAddress._Value));
                NCS.Add(new NextwaverDB.NColumn("SUPPLIER_TEL", tbSuppTel._Value));
                NCS.Add(new NextwaverDB.NColumn("SUPPLIER_FAX", tbSuppFax._Value));
                NCS.Add(new NextwaverDB.NColumn("SUPPLIER_LINEID", tbSuppLine._Value));
                NCS.Add(new NextwaverDB.NColumn("DISCOUNT_RATE", tbDiscount._Value));
                NCS.Add(new NextwaverDB.NColumn("PAYMENT", tbPayment._Value));
                NCS.Add(new NextwaverDB.NColumn("CONTACT", tbContact._Value));
                NCS.Add(new NextwaverDB.NColumn("CREDIT", tbCredit._Value));
                NCS.Add(new NextwaverDB.NColumn("SUPPLIER_DETAIL", tbSuppDetail._Value));

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
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Supplier", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Supplier", NCS, NWS, strDoc))
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

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            lblUser.Text = "User : " + cMain.user;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
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
