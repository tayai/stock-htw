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
    public partial class frmTermOfPayment : Form
    {
        public frmTermOfPayment()
        {
            InitializeComponent();
        }

        XmlDocument xDoc;
        public string Command;
        public string ID_TEMP;
        public string PAYMENT_TEMP;

        public void funLoad()
        {
            xDoc = new XmlDocument();
            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/TermOfPayment.xml");
            }
            else
            {
                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);
                string strDoc = cCon.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "TermOfPayment", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }

            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='TermOfPayment']";
            tbTermOFPayment._XPath = RootPath + "/Item[@Name='TERM_OF_PAYMENT']";
            tbNumberOfDays._XPath = RootPath + "/Item[@Name='NUMBER_OF_DAYS']";
            tbPaymentDetail._XPath = RootPath + "/Item[@Name='PAYMENT_DETAIL']";


            //คำสั่งในการ Map Control กับ Xml โดยใช้ Mapping control
            mpTOP1._XmlDocument = xDoc;
            mpTOP1.AddControl(tbTermOFPayment);
            mpTOP1.AddControl(tbNumberOfDays);
            mpTOP1.AddControl(tbPaymentDetail);

        }

        public void funSave()
        {
            if (mpTOP1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("TERM_OF_PAYMENT", tbTermOFPayment._Value));
                NCS.Add(new NextwaverDB.NColumn("NUMBER_OF_DAYS", tbNumberOfDays._Value));
                NCS.Add(new NextwaverDB.NColumn("PAYMENT_DETAIL", tbPaymentDetail._Value));

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

                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "TermOfPayment", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "TermOfPayment", NCS, NWS, strDoc))
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

        private void frmTermOfPayment_Load(object sender, EventArgs e)
        {
            lblUser.Text = "USER : " + cMain.user;
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
