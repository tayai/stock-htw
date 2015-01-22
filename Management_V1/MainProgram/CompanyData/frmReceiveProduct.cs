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
    public partial class frmReceiveProduct : Form
    {
        public frmReceiveProduct()
        {
            InitializeComponent();
        }
        XmlDocument xDoc = new XmlDocument();
        //XmlDocument xDoc1;
        public string Command;
        public string ID_TEMP;
        public string SUPP_TEMP;
        public string DISCOUNT_TEMP;
        //public string P_CODE_TEMP;

        public void funLoad()
        {
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/ReceiveProduct.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ReceiveProduct", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            // กำหนด path ของ xml และ map ข้อมูลใน xml มาใส่ control
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='ReceiveProduct']";
            dtpRecProd._XPath = RootPath + "/Item[@Name='DATE_RECEIVE']";
            tbInVat._XPath = RootPath + "/Item[@Name='INCLUDE_VAT']";
            tbExVat._XPath = RootPath + "/Item[@Name='EXCLUDE_VAT']";
            tbDocNo._XPath = RootPath + "/Item[@Name='DOCUMENT_NO']";
            cbSuppName._XPath = RootPath + "/Item[@Name='SUPPLIER_NAME']";
            tbPrivDiscount._XPath = RootPath + "/Item[@Name='PRIVILEGE_DISCOUNT']";
            tbSaleDiscount._XPath = RootPath + "/Item[@Name='SALE_DISCOUNT']";
            tbTotalAmount._XPath = RootPath + "/Item[@Name='TOTAL_AMOUNT']";
            tbDiscount._XPath = RootPath + "/Item[@Name='DISCOUNT']";
            tbAmount._XPath = RootPath + "/Item[@Name='AMOUNT']";
            tbVat._XPath = RootPath + "/Item[@Name='VAT']";
            tbTotal._XPath = RootPath + "/Item[@Name='TOTAL']";
            tbGrandTotal._XPath = RootPath + "/Item[@Name='GRAND_TOTAL']";
            tbDetail._XPath = RootPath + "/Item[@Name='RECEIVE_DETAIL']";

            dgRecProdItem._XPath = RootPath + "//Document/Data/Section[@ID='2']/Items[@Name='ReceiveItems']";


            //คำสั่งในการ Map Control กับ Xml

            // Map กับคอนโทรล combobox Supplier
            ConnectServer.cConection cConn2 = new ConnectServer.cConection(cMain.user);
            NextwaverDB.NColumns NCS_S_SUPP = new NextwaverDB.NColumns();
            NCS_S_SUPP.Add(new NextwaverDB.NColumn("ID"));
            NCS_S_SUPP.Add(new NextwaverDB.NColumn("SUPPLIER_NAME"));
            NCS_S_SUPP.Add(new NextwaverDB.NColumn("DISCOUNT_RATE"));
            DataTable dt2 = cConn2.Retreive(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Supplier", NCS_S_SUPP);
            cbSuppName._DisplayMember = "SUPPLIER_NAME";
            cbSuppName._ValueMember = "SUPPLIER_NAME";
            cbSuppName._DataSource = dt2;
            

            // Map กับคอนโทรล combobox

            mcRecProd1._XmlDocument = xDoc;
            mcRecProd1.AddControl(dtpRecProd);
            mcRecProd1.AddControl(tbInVat);
            mcRecProd1.AddControl(tbExVat);
            mcRecProd1.AddControl(tbDocNo);
            mcRecProd1.AddControl(cbSuppName);
            mcRecProd1.AddControl(tbPrivDiscount);
            mcRecProd1.AddControl(tbSaleDiscount);
            mcRecProd1.AddControl(tbTotalAmount);
            mcRecProd1.AddControl(tbDiscount);
            mcRecProd1.AddControl(tbAmount);
            mcRecProd1.AddControl(tbVat);
            mcRecProd1.AddControl(tbTotal);
            mcRecProd1.AddControl(tbGrandTotal);
            mcRecProd1.AddControl(tbDetail);

            mcRecProd1.AddControl(dgRecProdItem);

            if (Command == "New")
            {
                SUPP_TEMP = "";
            }
            else if (Command == "Edit")
            {
                SUPP_TEMP = cbSuppName._SelectedValue;
                DISCOUNT_TEMP = tbPrivDiscount._Value;
                tbDocNo.Enabled = false;
            }
        }

        public void funSave()
        {
            if (mcRecProd1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("DATE_RECEIVE", dtpRecProd._Day.ToString()));
                NCS.Add(new NextwaverDB.NColumn("INCLUDE_VAT", tbInVat._Value));
                NCS.Add(new NextwaverDB.NColumn("EXCLUDE_VAT", tbExVat._Value));
                NCS.Add(new NextwaverDB.NColumn("DOCUMENT_NO", tbDocNo._Value));
                NCS.Add(new NextwaverDB.NColumn("SUPPLIER_NAME", cbSuppName._SelectedValue));
                NCS.Add(new NextwaverDB.NColumn("PRIVILEGE_DISCOUNT", tbPrivDiscount._Value));
                NCS.Add(new NextwaverDB.NColumn("SALE_DISCOUNT", tbSaleDiscount._Value));
                NCS.Add(new NextwaverDB.NColumn("TOTAL_AMOUNT", tbTotalAmount._Value));
                NCS.Add(new NextwaverDB.NColumn("DISCOUNT", tbDiscount._Value));
                NCS.Add(new NextwaverDB.NColumn("AMOUNT", tbAmount._Value));
                NCS.Add(new NextwaverDB.NColumn("VAT", tbVat._Value));
                NCS.Add(new NextwaverDB.NColumn("TOTAL", tbTotal._Value));
                NCS.Add(new NextwaverDB.NColumn("GRAND_TOTAL", tbGrandTotal._Value));
                NCS.Add(new NextwaverDB.NColumn("RECEIVE_DETAIL", tbDetail._Value));

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

                NCS.Add(new NextwaverDB.NColumn("RECEIVE_DETAIL", tbDetail._Value));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);

                if (Command == "New")
                {
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ReceiveProduct", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "ReceiveProduct", NCS, NWS, strDoc))
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

        private void frmReceiveProduct_Load(object sender, EventArgs e)
        {
            lblUser.Text = "USER : " + cMain.user;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
            tbInVat._Value = "0";
            tbExVat._Value = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblDateTime.Text = "วันที่ " + DateTime.Now.ToString("d MMMM yyyy") + " เวลา " + DateTime.Now.ToString("hh:mm:ss");
            timer1.Enabled = true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void cbSuppName_Select_Index_Change(object sender, EventArgs e)
        {
            if (cbSuppName._SelectedValue == "System.Data.DataRowView" || cbSuppName._SelectedValue == "")
            {
                tbPrivDiscount._Value = "";
            }
            else
            {
                if (Command == "New")
                {
                    tbPrivDiscount._Value = cbSuppName._DataSource.Rows[cbSuppName._SelectedIndex].ItemArray[2].ToString();
                }
                else if (Command == "Edit" && cbSuppName._SelectedValue != SUPP_TEMP)
                {
                    tbPrivDiscount._Value = cbSuppName._DataSource.Rows[cbSuppName._SelectedIndex].ItemArray[2].ToString();
                }
                else if (Command == "Edit" && cbSuppName._SelectedValue == SUPP_TEMP)
                {
                    tbPrivDiscount._Value = DISCOUNT_TEMP;
                }
            }
        }
    }
}
