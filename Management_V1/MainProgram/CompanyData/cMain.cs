using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using NextProcess;
using System.Xml;


namespace CompanyData
{
    public class cMain
    {
        public static string strConnect;
        public static string user;
        public static string OfficeSpaceId;

        public bool NewSalProd(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmSaleProduct form = new frmSaleProduct();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditSalProd(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            if (dt.Rows.Count <= 0) return false;

            frmSaleProduct form = new frmSaleProduct();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewReceiveProduct(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmReceiveProduct form = new frmReceiveProduct();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditReceiveProduct(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            if (dt.Rows.Count <= 0) return false;

            frmReceiveProduct form = new frmReceiveProduct();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            //form.P_CODE_TEMP = dt.Rows[currentIndex]["PRODUCT_CODE"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool SearchReceiveProduct(string istrConnect, string iuser, string iOfficeSpaceId,DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            if (dt.Rows.Count <= 0) return false;

            frmReceiveProduct form = new frmReceiveProduct();
            form.Command = "Search";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            //form.P_CODE_TEMP = dt.Rows[currentIndex]["PRODUCT_CODE"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }


        public bool NewProRec(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmProductRecord form = new frmProductRecord();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditProRec(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            if (dt.Rows.Count <= 0) return false;

            frmProductRecord form = new frmProductRecord();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            form.P_CODE_TEMP = dt.Rows[currentIndex]["PRODUCT_CODE"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewProGroup(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmProductGroup form = new frmProductGroup();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditProGroup(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmProductGroup form = new frmProductGroup();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            //ส่งแบบนี้ครับ
            form.GROUP_TEMP = dt.Rows[currentIndex]["GROUP_NAME"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewProCat(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmProductCategory form = new frmProductCategory();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditProCat(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmProductCategory form = new frmProductCategory();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            form.CAT_TEMP = dt.Rows[currentIndex]["CATEGORY_NAME"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewProUnit(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmProductUnit form = new frmProductUnit();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditProUnit(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmProductUnit form = new frmProductUnit();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            form.UNIT_TEMP = dt.Rows[currentIndex]["UNIT_NAME"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewTermOfPayment(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmTermOfPayment form = new frmTermOfPayment();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditTermOfPayment(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmTermOfPayment form = new frmTermOfPayment();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewPayerPayee(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmPayerPayee form = new frmPayerPayee();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditPayerPayee(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmPayerPayee form = new frmPayerPayee();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            form.PAY_TEMP = dt.Rows[currentIndex]["PAYER_PAYEE"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewReceivePayment(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmReceivePayment form = new frmReceivePayment();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditReceivePayment(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmReceivePayment form = new frmReceivePayment();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            form.REC_PAY_TEMP = dt.Rows[currentIndex]["RECEIVE_PAYMENT"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewBank(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmBankAccount form = new frmBankAccount();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditBank(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmBankAccount form = new frmBankAccount();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            form.BANK_TEMP = dt.Rows[currentIndex]["BANK_NAME"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewEmployee(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmEmployee form = new frmEmployee();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditEmployee(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmEmployee form = new frmEmployee();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewSupplier(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmSupplier form = new frmSupplier();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditSupplier(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmSupplier form = new frmSupplier();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool NewCustomer(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmCustomer form = new frmCustomer();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditCustomer(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmCustomer form = new frmCustomer();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool ReportCustomer(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            XmlDocument xConfig = new XmlDocument();

            xConfig.Load(Application.StartupPath + "/Config_Process.xml");

            string ID = "Customer";
            if (XmlProcess.Transform(xConfig,ID))
            {
                frm_rp_Customer frCus = new frm_rp_Customer();
                frCus.Show();
            }
            else 
            { 
                MessageBox.Show(XmlProcess.ErrMsg); 
            }

            return false;
        }

        public bool NewWarehouse(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmWarehouse form = new frmWarehouse();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditWarehouse(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmWarehouse form = new frmWarehouse();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            form.WAREHOUSE_TEMP = dt.Rows[currentIndex]["WAREHOUSE_NAME"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool ReportWarehouse(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            XmlDocument xConfig = new XmlDocument();

            xConfig.Load(Application.StartupPath + "/Config_Process.xml");

            string ID = "Warehouse";
            if (XmlProcess.Transform(xConfig, ID))
            {
                frm_rp_Warehouse frWh = new frm_rp_Warehouse();
                frWh.Show();
            }
            else
            {
                MessageBox.Show(XmlProcess.ErrMsg);
            }

            return false;
        }

        public bool NewCompanyData(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmCompanyData form = new frmCompanyData();
            form.Command = "New";
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK) 
            {
                if (!form.IsDisposed)
                { 
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed) 
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }

        public bool EditCompanyData(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            frmCompanyData form = new frmCompanyData();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            return false;
        }
    }
}
