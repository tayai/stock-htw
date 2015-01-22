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
    public partial class frmTermPayment : Form
    {
        public frmTermPayment()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/TermPayment.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "TermPayment", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='TermPayment']";
            tbPayType._XPath = RootPath + "/Item[@Name='PAYMENTTYPE']";
            tbDueDate._XPath = RootPath + "/Item[@Name='DUEDATE']";
            tbDetail._XPath = RootPath + "/Item[@Name='DETAIL']";
            tbRemark._XPath = RootPath + "/Item[@Name='REMARK']";

            //คำสั่งในการ Map Control กับ Xml
            ucMCTP1._XmlDocument = xDoc;
            ucMCTP1.AddControl(tbPayType);
            ucMCTP1.AddControl(tbDueDate);
            ucMCTP1.AddControl(tbDetail);
            ucMCTP1.AddControl(tbRemark);

        }

        public void funSave()
        {
            if (ucMCTP1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("PAYMENTTYPE", tbPayType._Value));
                NCS.Add(new NextwaverDB.NColumn("DUEDATE", tbDueDate._Value));
                NCS.Add(new NextwaverDB.NColumn("DETAIL", tbDetail._Value));
                NCS.Add(new NextwaverDB.NColumn("REMARK", tbRemark._Value));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);

                if (Command == "New")
                {
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "TermPayment", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "TermPayment", NCS, NWS, strDoc))
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

        private void btTPSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btTPClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
