using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompanyData
{
    public partial class frm_rp_Warehouse : Form
    {
        public frm_rp_Warehouse()
        {
            InitializeComponent();
        }

        private void frm_rp_Warehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Warehouse.Warehouse' table. You can move, or remove it, as needed.
            this.WarehouseTableAdapter.Fill(this.DataSet_Warehouse.Warehouse);

            this.reportViewer1.RefreshReport();
        }
    }
}
