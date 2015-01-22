namespace CompanyData
{
    partial class frmTermOfPayment
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTermOFPayment = new ToolsDocument.ucTextBox();
            this.tbNumberOfDays = new ToolsDocument.ucTextBox();
            this.tbPaymentDetail = new ToolsDocument.ucRichTextBox();
            this.mpTOP1 = new ToolsDocument.ucMappingControls();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "USER : ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(170, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "DateTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "กำหนดการชำระเงิน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "จำนวนวันที่ครบกำหนด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "รายละเอียด";
            // 
            // tbTermOFPayment
            // 
            this.tbTermOFPayment._PasswordChar = '\0';
            this.tbTermOFPayment._Value = "";
            this.tbTermOFPayment._XPath = null;
            this.tbTermOFPayment.BackColor = System.Drawing.Color.Transparent;
            this.tbTermOFPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTermOFPayment.Location = new System.Drawing.Point(135, 41);
            this.tbTermOFPayment.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbTermOFPayment.Name = "tbTermOFPayment";
            this.tbTermOFPayment.Size = new System.Drawing.Size(237, 21);
            this.tbTermOFPayment.TabIndex = 5;
            // 
            // tbNumberOfDays
            // 
            this.tbNumberOfDays._PasswordChar = '\0';
            this.tbNumberOfDays._Value = "";
            this.tbNumberOfDays._XPath = null;
            this.tbNumberOfDays.BackColor = System.Drawing.Color.Transparent;
            this.tbNumberOfDays.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbNumberOfDays.Location = new System.Drawing.Point(135, 77);
            this.tbNumberOfDays.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbNumberOfDays.Name = "tbNumberOfDays";
            this.tbNumberOfDays.Size = new System.Drawing.Size(237, 21);
            this.tbNumberOfDays.TabIndex = 6;
            // 
            // tbPaymentDetail
            // 
            this.tbPaymentDetail._Value = "";
            this.tbPaymentDetail._XPath = null;
            this.tbPaymentDetail.Location = new System.Drawing.Point(135, 119);
            this.tbPaymentDetail.Name = "tbPaymentDetail";
            this.tbPaymentDetail.Size = new System.Drawing.Size(237, 61);
            this.tbPaymentDetail.TabIndex = 7;
            // 
            // mpTOP1
            // 
            this.mpTOP1.Location = new System.Drawing.Point(12, 129);
            this.mpTOP1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mpTOP1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mpTOP1.Name = "mpTOP1";
            this.mpTOP1.Size = new System.Drawing.Size(24, 27);
            this.mpTOP1.TabIndex = 8;
            this.mpTOP1.Visible = false;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(173, 200);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(276, 200);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 10;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTermOfPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 241);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.mpTOP1);
            this.Controls.Add(this.tbPaymentDetail);
            this.Controls.Add(this.tbNumberOfDays);
            this.Controls.Add(this.tbTermOFPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTermOfPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Term Of Payment";
            this.Load += new System.EventHandler(this.frmTermOfPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ToolsDocument.ucTextBox tbTermOFPayment;
        private ToolsDocument.ucTextBox tbNumberOfDays;
        private ToolsDocument.ucRichTextBox tbPaymentDetail;
        private ToolsDocument.ucMappingControls mpTOP1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Timer timer1;
    }
}