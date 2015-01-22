using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Data;
using System.Windows.Forms;
using Message;
using System.Text.RegularExpressions;
using CompanyData;

namespace ToolCommand
{
    public class csCommand
    {
        public string DatabaseTemp;
        public Xceed.Grid.GridControl _gridTemp;
        public string OfficeSpaceId;
        public string Command;
       
        Panel panelView;
        public Panel _PanelView
        {
            set { panelView = value; }
            get { return panelView; }
        }
        string ProjectID;
        public string _ProjectID
        {
            set { ProjectID = value; }
        }

        public csCommand(string iOfficeSpaceId)
        {
            OfficeSpaceId = iOfficeSpaceId;
        }

        public void RowClick(string ToolID, DataTable dt, int currentIndex, string strConnect, string user, string Position)
        {
            switch (ToolID)
            {
                default: Default(); break;
            }
        }

        public bool RowDoubleClick(string ToolID, DataTable dt, int currentIndex, string strConnect, string user, string Position)
        {
            switch (ToolID)
            {
                default: return Default();
            }
        }

        public bool funCommand(string ToolID, string command, DataTable dt, int[] listSelectIndex, int currentIndex, string strConnect, string user, string Position, string strParameter)
        {
            switch (ToolID)
            {
                case "Tools1": return Users(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools2": return Users(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools4": return CompanyData(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools5": return Warehouse(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools6": return Customer(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools7": return Supplier(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools8": return Employee(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools9": return Bank(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools10": return ReceivePayment(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools11": return PayerPayee(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools12": return TermOfPayment(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools13": return ProdUnit(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools14": return ProdCat(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools15": return ProdGroup(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools16": return ProdRec(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools17": return ReceiveProduct(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                case "Tools18": return SaleProduct(command, dt, listSelectIndex, currentIndex, user, Position, strConnect);
                default: return Default();
            }
        }

        private bool SaleProduct(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain SalPro12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return SalPro12.NewSalProd(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return SalPro12.EditSalProd(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;
            }
        }

        private bool ReceiveProduct(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain RecPro12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return RecPro12.NewReceiveProduct(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return RecPro12.EditReceiveProduct(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                case "Search":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return RecPro12.SearchReceiveProduct(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
            //return false;

        }

        private bool ProdRec(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain ProRec12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return ProRec12.NewProRec(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return ProRec12.EditProRec(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
            //return false;

        }

        private bool ProdGroup(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain ProGroup12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return ProGroup12.NewProGroup(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return ProGroup12.EditProGroup(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
            //return false;

        }

        private bool ProdCat(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain ProCat12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return ProCat12.NewProCat(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return ProCat12.EditProCat(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
            //return false;

        }

        private bool ProdUnit(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain ProUnit12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return ProUnit12.NewProUnit(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return ProUnit12.EditProUnit(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
            //return false;

        }

        private bool TermOfPayment(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain TermPay12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return TermPay12.NewTermOfPayment(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return TermPay12.EditTermOfPayment(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
        }

        private bool PayerPayee(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain PayPay12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return PayPay12.NewPayerPayee(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return PayPay12.EditPayerPayee(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
        }

        private bool ReceivePayment(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain RecPay12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return RecPay12.NewReceivePayment(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return RecPay12.EditReceivePayment(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
        }

        private bool Bank(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain Bank12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return Bank12.NewBank(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return Bank12.EditBank(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
        }

        private bool Employee(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain Employ12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return Employ12.NewEmployee(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return Employ12.EditEmployee(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
        }

        private bool Supplier(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain Supp12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return Supp12.NewSupplier(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return Supp12.EditSupplier(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
        }

        private bool Customer(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain Cust12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return Cust12.NewCustomer(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return Cust12.EditCustomer(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                case "Report":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return Cust12.ReportCustomer(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
        }

        private bool Warehouse(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain Warh12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return Warh12.NewWarehouse(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return Warh12.EditWarehouse(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                case "Report":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return Warh12.ReportWarehouse(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
        }

        private bool CompanyData(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            CompanyData.cMain ComDat12 = new CompanyData.cMain();

            switch (command)
            {
                case "New": return ComDat12.NewCompanyData(strConnect, user, OfficeSpaceId);
                case "Edit":
                    {
                        if (dt.Rows.Count <= 0) return false;
                        return ComDat12.EditCompanyData(strConnect, user, OfficeSpaceId, dt, currentIndex);
                    }
                default: return false;

            }
        }

        private bool Users(string command, DataTable dt, int[] listSelectIndex, int currentIndex, string user, string Position, string strConnect)
        {
            Users.cMain US = new Users.cMain();
            
           
            switch (command)
            {
                default: return false;
                case "NewPosition": return US.newPosition(strConnect, user, OfficeSpaceId,DatabaseTemp);
                case "EditPosition": return US.editPosition(strConnect, user, OfficeSpaceId, dt, currentIndex, DatabaseTemp);
                case "AddUser": return US.newUser(strConnect, user, OfficeSpaceId, DatabaseTemp);
                case "EditUser": return US.editUser(strConnect, user, OfficeSpaceId, dt, currentIndex, DatabaseTemp);
                 
            }

        }

        private bool Default()
        {

            //MSG.Error("No Function Tool", "Error");
            return false;
        }
    }
}