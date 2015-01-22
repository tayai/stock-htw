namespace CompanyData
{
    partial class frmPayerPayee
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
            this.tbPayerPayee = new ToolsDocument.ucTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.mpPayPay1 = new ToolsDocument.ucMappingControls();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbPayerPayee
            // 
            this.tbPayerPayee._PasswordChar = '\0';
            this.tbPayerPayee._Value = "";
            this.tbPayerPayee._XPath = null;
            this.tbPayerPayee.BackColor = System.Drawing.Color.Transparent;
            this.tbPayerPayee.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPayerPayee.Location = new System.Drawing.Point(39, 41);
            this.tbPayerPayee.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPayerPayee.Name = "tbPayerPayee";
            this.tbPayerPayee.Size = new System.Drawing.Size(237, 21);
            this.tbPayerPayee.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "USER : ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(119, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "DateTime";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(71, 80);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(175, 80);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // mpPayPay1
            // 
            this.mpPayPay1.Location = new System.Drawing.Point(12, 69);
            this.mpPayPay1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mpPayPay1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mpPayPay1.Name = "mpPayPay1";
            this.mpPayPay1.Size = new System.Drawing.Size(24, 27);
            this.mpPayPay1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPayerPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 125);
            this.Controls.Add(this.mpPayPay1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbPayerPayee);
            this.Name = "frmPayerPayee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payer & Payee (เฮงทวีค้าไม้)";
            this.Load += new System.EventHandler(this.frmPayerPayee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolsDocument.ucTextBox tbPayerPayee;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private ToolsDocument.ucMappingControls mpPayPay1;
        private System.Windows.Forms.Timer timer1;
    }
}