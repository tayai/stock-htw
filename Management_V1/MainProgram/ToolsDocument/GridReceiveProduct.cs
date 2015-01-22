using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ToolsDocument
{
    public partial class GridReceiveProduct : Form
    {
        public GridReceiveProduct()
        {
            InitializeComponent();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "การบันทึกข้อมูล");
            this.Close();
            this.Dispose();
        }
    }
}
