namespace CompanyData
{
    partial class frmCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCustName = new ToolsDocument.ucTextBox();
            this.tbCustAddress = new ToolsDocument.ucRichTextBox();
            this.tbCustTel = new ToolsDocument.ucTextBox();
            this.tbCustFax = new ToolsDocument.ucTextBox();
            this.tbCustLine = new ToolsDocument.ucTextBox();
            this.tbCustTaxID = new ToolsDocument.ucTextBox();
            this.tbContact = new ToolsDocument.ucTextBox();
            this.tbDiscount = new ToolsDocument.ucTextBox();
            this.tbPayment = new ToolsDocument.ucTextBox();
            this.tbCredit = new ToolsDocument.ucTextBox();
            this.tbCustDetail = new ToolsDocument.ucRichTextBox();
            this.mpCust1 = new ToolsDocument.ucMappingControls();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อลูกค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ที่อยู่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "โทรศัพท์";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "แฟกซ์";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ไอดีไลน์";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 205);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "เลขผู้เสียภาษี";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ชื่อผู้ติดต่อ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ส่วนลด (%)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 286);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "การชำระเงิน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "เครดิต";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "รายละเอียด";
            // 
            // tbCustName
            // 
            this.tbCustName._PasswordChar = '\0';
            this.tbCustName._Value = "";
            this.tbCustName._XPath = null;
            this.tbCustName.BackColor = System.Drawing.Color.Transparent;
            this.tbCustName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbCustName.Location = new System.Drawing.Point(92, 33);
            this.tbCustName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(237, 21);
            this.tbCustName.TabIndex = 11;
            // 
            // tbCustAddress
            // 
            this.tbCustAddress._Value = "";
            this.tbCustAddress._XPath = null;
            this.tbCustAddress.Location = new System.Drawing.Point(92, 60);
            this.tbCustAddress.Name = "tbCustAddress";
            this.tbCustAddress.Size = new System.Drawing.Size(237, 54);
            this.tbCustAddress.TabIndex = 12;
            // 
            // tbCustTel
            // 
            this.tbCustTel._PasswordChar = '\0';
            this.tbCustTel._Value = "";
            this.tbCustTel._XPath = null;
            this.tbCustTel.BackColor = System.Drawing.Color.Transparent;
            this.tbCustTel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbCustTel.Location = new System.Drawing.Point(92, 120);
            this.tbCustTel.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbCustTel.Name = "tbCustTel";
            this.tbCustTel.Size = new System.Drawing.Size(237, 21);
            this.tbCustTel.TabIndex = 13;
            // 
            // tbCustFax
            // 
            this.tbCustFax._PasswordChar = '\0';
            this.tbCustFax._Value = "";
            this.tbCustFax._XPath = null;
            this.tbCustFax.BackColor = System.Drawing.Color.Transparent;
            this.tbCustFax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbCustFax.Location = new System.Drawing.Point(92, 147);
            this.tbCustFax.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbCustFax.Name = "tbCustFax";
            this.tbCustFax.Size = new System.Drawing.Size(237, 21);
            this.tbCustFax.TabIndex = 14;
            // 
            // tbCustLine
            // 
            this.tbCustLine._PasswordChar = '\0';
            this.tbCustLine._Value = "";
            this.tbCustLine._XPath = null;
            this.tbCustLine.BackColor = System.Drawing.Color.Transparent;
            this.tbCustLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbCustLine.Location = new System.Drawing.Point(92, 174);
            this.tbCustLine.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbCustLine.Name = "tbCustLine";
            this.tbCustLine.Size = new System.Drawing.Size(237, 21);
            this.tbCustLine.TabIndex = 15;
            // 
            // tbCustTaxID
            // 
            this.tbCustTaxID._PasswordChar = '\0';
            this.tbCustTaxID._Value = "";
            this.tbCustTaxID._XPath = null;
            this.tbCustTaxID.BackColor = System.Drawing.Color.Transparent;
            this.tbCustTaxID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbCustTaxID.Location = new System.Drawing.Point(92, 201);
            this.tbCustTaxID.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbCustTaxID.Name = "tbCustTaxID";
            this.tbCustTaxID.Size = new System.Drawing.Size(237, 21);
            this.tbCustTaxID.TabIndex = 16;
            // 
            // tbContact
            // 
            this.tbContact._PasswordChar = '\0';
            this.tbContact._Value = "";
            this.tbContact._XPath = null;
            this.tbContact.BackColor = System.Drawing.Color.Transparent;
            this.tbContact.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbContact.Location = new System.Drawing.Point(92, 228);
            this.tbContact.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(237, 21);
            this.tbContact.TabIndex = 17;
            // 
            // tbDiscount
            // 
            this.tbDiscount._PasswordChar = '\0';
            this.tbDiscount._Value = "";
            this.tbDiscount._XPath = null;
            this.tbDiscount.BackColor = System.Drawing.Color.Transparent;
            this.tbDiscount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbDiscount.Location = new System.Drawing.Point(92, 255);
            this.tbDiscount.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(42, 21);
            this.tbDiscount.TabIndex = 18;
            // 
            // tbPayment
            // 
            this.tbPayment._PasswordChar = '\0';
            this.tbPayment._Value = "";
            this.tbPayment._XPath = null;
            this.tbPayment.BackColor = System.Drawing.Color.Transparent;
            this.tbPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPayment.Location = new System.Drawing.Point(92, 282);
            this.tbPayment.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(237, 21);
            this.tbPayment.TabIndex = 19;
            // 
            // tbCredit
            // 
            this.tbCredit._PasswordChar = '\0';
            this.tbCredit._Value = "";
            this.tbCredit._XPath = null;
            this.tbCredit.BackColor = System.Drawing.Color.Transparent;
            this.tbCredit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbCredit.Location = new System.Drawing.Point(92, 309);
            this.tbCredit.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(237, 21);
            this.tbCredit.TabIndex = 20;
            // 
            // tbCustDetail
            // 
            this.tbCustDetail._Value = "";
            this.tbCustDetail._XPath = null;
            this.tbCustDetail.Location = new System.Drawing.Point(92, 336);
            this.tbCustDetail.Name = "tbCustDetail";
            this.tbCustDetail.Size = new System.Drawing.Size(237, 54);
            this.tbCustDetail.TabIndex = 21;
            // 
            // mpCust1
            // 
            this.mpCust1.Location = new System.Drawing.Point(17, 408);
            this.mpCust1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mpCust1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mpCust1.Name = "mpCust1";
            this.mpCust1.Size = new System.Drawing.Size(24, 27);
            this.mpCust1.TabIndex = 22;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(160, 412);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 23;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(254, 412);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 24;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(9, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "User";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(156, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 26;
            this.lblDateTime.Text = "DateTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 456);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.mpCust1);
            this.Controls.Add(this.tbCustDetail);
            this.Controls.Add(this.tbCredit);
            this.Controls.Add(this.tbPayment);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbCustTaxID);
            this.Controls.Add(this.tbCustLine);
            this.Controls.Add(this.tbCustFax);
            this.Controls.Add(this.tbCustTel);
            this.Controls.Add(this.tbCustAddress);
            this.Controls.Add(this.tbCustName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer (เฮงทวีค้าไม้)";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private ToolsDocument.ucTextBox tbCustName;
        private ToolsDocument.ucRichTextBox tbCustAddress;
        private ToolsDocument.ucTextBox tbCustTel;
        private ToolsDocument.ucTextBox tbCustFax;
        private ToolsDocument.ucTextBox tbCustLine;
        private ToolsDocument.ucTextBox tbCustTaxID;
        private ToolsDocument.ucTextBox tbContact;
        private ToolsDocument.ucTextBox tbDiscount;
        private ToolsDocument.ucTextBox tbPayment;
        private ToolsDocument.ucTextBox tbCredit;
        private ToolsDocument.ucRichTextBox tbCustDetail;
        private ToolsDocument.ucMappingControls mpCust1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}