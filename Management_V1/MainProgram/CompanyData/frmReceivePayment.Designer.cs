namespace CompanyData
{
    partial class frmReceivePayment
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
            this.tbRecPay = new ToolsDocument.ucTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.mpRecPay1 = new ToolsDocument.ucMappingControls();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbRecPay
            // 
            this.tbRecPay._PasswordChar = '\0';
            this.tbRecPay._Value = "";
            this.tbRecPay._XPath = null;
            this.tbRecPay.BackColor = System.Drawing.Color.Transparent;
            this.tbRecPay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbRecPay.Location = new System.Drawing.Point(31, 42);
            this.tbRecPay.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbRecPay.Name = "tbRecPay";
            this.tbRecPay.Size = new System.Drawing.Size(237, 21);
            this.tbRecPay.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(23, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "USER : ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(99, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "DateTime";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(60, 83);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(171, 83);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // mpRecPay1
            // 
            this.mpRecPay1.Location = new System.Drawing.Point(12, 79);
            this.mpRecPay1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mpRecPay1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mpRecPay1.Name = "mpRecPay1";
            this.mpRecPay1.Size = new System.Drawing.Size(24, 27);
            this.mpRecPay1.TabIndex = 5;
            this.mpRecPay1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmReceivePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 127);
            this.Controls.Add(this.mpRecPay1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbRecPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReceivePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive & Payment List";
            this.Load += new System.EventHandler(this.frmReceivePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolsDocument.ucTextBox tbRecPay;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private ToolsDocument.ucMappingControls mpRecPay1;
        private System.Windows.Forms.Timer timer1;
    }
}