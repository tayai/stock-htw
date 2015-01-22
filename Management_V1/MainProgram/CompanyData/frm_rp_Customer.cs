using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompanyData
{
    public partial class frm_rp_Customer : Form
    {
        public frm_rp_Customer()
        {
            InitializeComponent();
        }

        private void frm_rp_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Customer.Customer' table. You can move, or remove it, as needed.
            this.CustomerTableAdapter.Fill(this.DataSet_Customer.Customer);

            this.reportViewer1.RefreshReport();
        }

        private void btSerch_Click(object sender, EventArgs e)
        {
            if (NameSearch.Text == "")
            {
                this.CustomerTableAdapter.Fill(this.DataSet_Customer.Customer);
            }
            else
            {
                this.CustomerTableAdapter.FillBy(this.DataSet_Customer.Customer, NameSearch.Text);

            }
            if (CustomerBindingSource.Count == 0)
            {
                MessageBox.Show("No Data", "Resault");
            }
            else
            { 
                this.reportViewer1.RefreshReport();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (NameSearch.Text == "")
            {
                this.CustomerTableAdapter.Fill(this.DataSet_Customer.Customer);
            }
            else
            {
                this.CustomerTableAdapter.FillBy(this.DataSet_Customer.Customer, NameSearch.Text);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
