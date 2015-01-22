namespace CompanyData
{
    partial class frm_rp_Warehouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_Warehouse = new CompanyData.DataSet_Warehouse();
            this.WarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WarehouseTableAdapter = new CompanyData.DataSet_WarehouseTableAdapters.WarehouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.WarehouseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CompanyData.Warehouse.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(956, 514);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_Warehouse
            // 
            this.DataSet_Warehouse.DataSetName = "DataSet_Warehouse";
            this.DataSet_Warehouse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WarehouseBindingSource
            // 
            this.WarehouseBindingSource.DataMember = "Warehouse";
            this.WarehouseBindingSource.DataSource = this.DataSet_Warehouse;
            // 
            // WarehouseTableAdapter
            // 
            this.WarehouseTableAdapter.ClearBeforeFill = true;
            // 
            // frm_rp_Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 514);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rp_Warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_rp_Warehouse";
            this.Load += new System.EventHandler(this.frm_rp_Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WarehouseBindingSource;
        private DataSet_Warehouse DataSet_Warehouse;
        private DataSet_WarehouseTableAdapters.WarehouseTableAdapter WarehouseTableAdapter;
    }
}