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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/Employee.xml");
            }
            else
            {
                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);
                string strDoc = cCon.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Employee", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }
            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='Employee']";
            tbEmpName._XPath = RootPath + "/Item[@Name='EMPLOYEE_NAME']";
            tbEmpAddress._XPath = RootPath + "/Item[@Name='EMPLOYEE_ADDRESS']";
            tbEmpWorkDay._XPath = RootPath + "/Item[@Name='WORK_DAY']";
            tbEmpWorkTime._XPath = RootPath + "/Item[@Name='WORK_TIME']";
            tbResponsibility._XPath = RootPath + "/Item[@Name='RESPONSIBILITY']";
            tbEmpTel._XPath = RootPath + "/Item[@Name='EMPLOYEE_TEL']";
            tbEmpLine._XPath = RootPath + "/Item[@Name='EMPLOYEE_LINEID']";
            tbIDCard._XPath = RootPath + "/Item[@Name='ID_CARD']";
            tbIssue._XPath = RootPath + "/Item[@Name='ISSUE']";
            tbExpire._XPath = RootPath + "/Item[@Name='EXPIRE_DATE']";
            tbEmpDetail._XPath = RootPath + "/Item[@Name='EMPLOYEE_DETAIL']";

            //คำสั่งในการ Map Control กับ Xml โดยใช้ Mapping control
            mpEmp1._XmlDocument = xDoc;
            mpEmp1.AddControl(tbEmpName);
            mpEmp1.AddControl(tbEmpAddress);
            mpEmp1.AddControl(tbEmpWorkDay);
            mpEmp1.AddControl(tbEmpWorkTime);
            mpEmp1.AddControl(tbResponsibility);
            mpEmp1.AddControl(tbEmpTel);
            mpEmp1.AddControl(tbEmpLine);
            mpEmp1.AddControl(tbIDCard);
            mpEmp1.AddControl(tbIssue);
            mpEmp1.AddControl(tbExpire);
            mpEmp1.AddControl(tbEmpDetail);
        }

        public void funSave()
        {
            if (mpEmp1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("EMPLOYEE_NAME", tbEmpName._Value));
                NCS.Add(new NextwaverDB.NColumn("EMPLOYEE_ADDRESS", tbEmpAddress._Value));
                NCS.Add(new NextwaverDB.NColumn("WORK_DAY", tbEmpWorkDay._Value));
                NCS.Add(new NextwaverDB.NColumn("WORK_TIME", tbEmpWorkTime._Value));
                NCS.Add(new NextwaverDB.NColumn("RESPONSIBILITY", tbResponsibility._Value));
                NCS.Add(new NextwaverDB.NColumn("EMPLOYEE_TEL", tbEmpTel._Value));
                NCS.Add(new NextwaverDB.NColumn("EMPLOYEE_LINEID", tbEmpLine._Value));
                NCS.Add(new NextwaverDB.NColumn("ID_CARD", tbIDCard._Value));
                NCS.Add(new NextwaverDB.NColumn("ISSUE", tbIssue._Value));
                NCS.Add(new NextwaverDB.NColumn("EXPIRE_DATE", tbExpire._Value));
                NCS.Add(new NextwaverDB.NColumn("EMPLOYEE_DETAIL", tbEmpDetail._Value));

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
                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Employee", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "htw_shop", "Employee", NCS, NWS, strDoc))
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

        private void frmEmployee_Load(object sender, EventArgs e)
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
