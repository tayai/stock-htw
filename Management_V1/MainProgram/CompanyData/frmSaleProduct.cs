using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ToolsDocument;

namespace CompanyData
{
    public partial class frmSaleProduct : Form
    {
        public frmSaleProduct()
        {
            InitializeComponent();
        }

        XmlDocument xDoc = new XmlDocument();
        //XmlDocument xDoc1;
        public string Command;
        public string ID_TEMP;
        private bool FirstTime = true;
        public void funLoad()
        {
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/SaleProduct.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "SaleProduct", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            // กำหนด path ของ xml และ map ข้อมูลใน xml มาใส่ control
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='SaleProduct']";

            tbDocName._XPath = RootPath + "/Item[@Name='DOCUMENT_NAME']";
            dtpBillDate._XPath = RootPath + "/Item[@Name='BILL_DATE']";
            cbCustName._XPath = RootPath + "/Item[@Name = 'CUSTOMER_NAME']";
            tbBillNo._XPath = RootPath + "/Item[@Name = 'BILL_NO']";
            tbTaxInvNo._XPath = RootPath + "/Item[@Name = 'TAXINVOICE_NO']";
            if (RootPath + "Item[@Name = 'CREDIT']" == "t")
            {
                cbCredit._Checked = true;
            }
            else
            {
                cbCredit._Checked = false;
            }
            dtpDueDate._XPath = RootPath + "/Item[@Name = 'DUE_DATE']";
            lblSeller.Text = cMain.user;
            tbDiscountPercent._XPath = RootPath + "/Item[@Name='DISCOUNT_PERCENT']";
            tbInVat._XPath = RootPath + "/Item[@Name='INCLUDE_VAT']";
            tbExVat._XPath = RootPath + "/Item[@Name='EXCLUDE_VAT']";
            tbTotalAmount._XPath = RootPath + "/Item[@Name='TOTAL_AMOUNT']";
            tbDiscountAmount._XPath = RootPath + "/Item[@Name='DISCOUNT_AMOUNT']";
            tbVat._XPath = RootPath + "/Item[@Name='VAT']";
            tbNetAmount._XPath = RootPath + "/Item[@Name='NET_AMOUNT']";
            tbSaleDetail._XPath = RootPath + "/Item[@Name='SALE_DETAIL']";

            dgSaleItems._XPath = "//Document/Data/Section[@ID='2']/Items[@Name='SaleItems']";
            
            // Map กับคอนโทรล combobox Customer
            ConnectServer.cConection cConn1 = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NColumns NCS_S_CUST = new NextwaverDB.NColumns();
            NCS_S_CUST.Add(new NextwaverDB.NColumn("ID"));
            NCS_S_CUST.Add(new NextwaverDB.NColumn("CUSTOMER_NAME"));
            NCS_S_CUST.Add(new NextwaverDB.NColumn("CUSTOMER_ADDRESS"));
            DataTable dt1 = cConn1.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Customer", NCS_S_CUST);
            cbCustName._DisplayMember = "CUSTOMER_NAME";
            cbCustName._ValueMember = "CUSTOMER_NAME";
            cbCustName._DataSource = dt1;
            

            //นำข้อมูลในคอลัมน์ Address มาใส่ใน lblAddress.Text


            //คำสั่งในการ Map Control กับ Xml
            mcSP1._XmlDocument = xDoc;
            mcSP1.AddControl(tbDocName);
            mcSP1.AddControl(cbCustName);
            mcSP1.AddControl(tbBillNo);
            mcSP1.AddControl(dtpBillDate);
            mcSP1.AddControl(tbTaxInvNo);
            //mcSP1.AddControl(cbCredit);
            mcSP1.AddControl(dtpDueDate);
            mcSP1.AddControl(tbDiscountPercent);
            mcSP1.AddControl(tbInVat);
            mcSP1.AddControl(tbExVat);
            mcSP1.AddControl(tbTotalAmount);
            mcSP1.AddControl(tbDiscountAmount);
            mcSP1.AddControl(tbVat);
            mcSP1.AddControl(tbNetAmount);
            mcSP1.AddControl(tbSaleDetail);

            mcSP1.AddControl(dgSaleItems);
        }

        public void funSave()
        {
            if (mcSP1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("DOCUMENT_NAME", tbDocName._Value));
                NCS.Add(new NextwaverDB.NColumn("CUSTOMER_NAME", cbCustName._SelectedValue));
                NCS.Add(new NextwaverDB.NColumn("BILL_NO", tbBillNo._Value));
                NCS.Add(new NextwaverDB.NColumn("BILL_DATE", dtpBillDate._Day.ToString("dd/mm/yy")));
                NCS.Add(new NextwaverDB.NColumn("TAXINVOICE_NO", tbTaxInvNo._Value));
                if (cbCredit._Checked)
                {
                    NCS.Add(new NextwaverDB.NColumn("CREDIT", "t"));
                }
                else
                {
                    NCS.Add(new NextwaverDB.NColumn("CREDIT", "f"));
                }
                NCS.Add(new NextwaverDB.NColumn("DUE_DATE", dtpDueDate._Day.ToString("dd/mm/yy")));
                NCS.Add(new NextwaverDB.NColumn("SALLER", cMain.user));
                NCS.Add(new NextwaverDB.NColumn("DISCOUNT_PERCENT", tbDiscountPercent._Value));
                NCS.Add(new NextwaverDB.NColumn("INCLUDE_VAT", tbInVat._Value));
                NCS.Add(new NextwaverDB.NColumn("EXCLUDE_VAT", tbExVat._Value));
                NCS.Add(new NextwaverDB.NColumn("TOTAL_AMOUNT", tbTotalAmount._Value));
                NCS.Add(new NextwaverDB.NColumn("DISCOUNT_AMOUNT", tbDiscountAmount._Value));
                NCS.Add(new NextwaverDB.NColumn("VAT", tbVat._Value));
                NCS.Add(new NextwaverDB.NColumn("NET_AMOUNT", tbNetAmount._Value));
                NCS.Add(new NextwaverDB.NColumn("SALE_DETAIL", tbSaleDetail._Value));

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

                //NCS.Add(new NextwaverDB.NColumn("RECEIVE_DETAIL", tbDetail._Value));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);

                if (Command == "New")
                {
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "SaleProduct", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "SaleProduct", NCS, NWS, strDoc))
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

        private void frmSaleProduct_Load(object sender, EventArgs e)
        {
            lblUser.Text = "USER : " + cMain.user;
            lblSeller.Text = cMain.user;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
            //ucGridView gv = new ucGridView();
            //gv.MdiParent = this;
            //gv.Show();
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

        private void cbCustName_SelectChange(object sender, EventArgs e)
        {

            if (cbCustName._SelectedValue == "System.Data.DataRowView" || cbCustName._SelectedValue == "")
            {
                 lblAddress.Text = "";
            }
            else
            {

                lblAddress.Text = cbCustName._DataSource.Rows[cbCustName._SelectedIndex].ItemArray[2].ToString();
            }
        }

    }
}
