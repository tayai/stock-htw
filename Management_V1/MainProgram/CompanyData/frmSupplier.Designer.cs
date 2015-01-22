namespace CompanyData
{
    partial class frmSupplier
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
            this.tbSuppName = new ToolsDocument.ucTextBox();
            this.tbSuppAddress = new ToolsDocument.ucRichTextBox();
            this.tbSuppTel = new ToolsDocument.ucTextBox();
            this.tbSuppFax = new ToolsDocument.ucTextBox();
            this.tbSuppLine = new ToolsDocument.ucTextBox();
            this.tbDiscount = new ToolsDocument.ucTextBox();
            this.tbPayment = new ToolsDocument.ucTextBox();
            this.tbContact = new ToolsDocument.ucTextBox();
            this.tbCredit = new ToolsDocument.ucTextBox();
            this.tbSuppDetail = new ToolsDocument.ucRichTextBox();
            this.mpSupp1 = new ToolsDocument.ucMappingControls();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อผู้ขาย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ที่อยู่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "โทรศัพท์";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "แฟกซ์";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ไอดีไลน์";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ส่วนลด(%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 246);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "การชำระเงิน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ชื่อผู้ติดต่อ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "เครดิต";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "รายละเอียด";
            // 
            // tbSuppName
            // 
            this.tbSuppName._PasswordChar = '\0';
            this.tbSuppName._Value = "";
            this.tbSuppName._XPath = null;
            this.tbSuppName.BackColor = System.Drawing.Color.Transparent;
            this.tbSuppName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSuppName.Location = new System.Drawing.Point(84, 40);
            this.tbSuppName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbSuppName.Name = "tbSuppName";
            this.tbSuppName.Size = new System.Drawing.Size(237, 21);
            this.tbSuppName.TabIndex = 10;
            // 
            // tbSuppAddress
            // 
            this.tbSuppAddress._Value = "";
            this.tbSuppAddress._XPath = null;
            this.tbSuppAddress.Location = new System.Drawing.Point(84, 67);
            this.tbSuppAddress.Name = "tbSuppAddress";
            this.tbSuppAddress.Size = new System.Drawing.Size(237, 57);
            this.tbSuppAddress.TabIndex = 11;
            // 
            // tbSuppTel
            // 
            this.tbSuppTel._PasswordChar = '\0';
            this.tbSuppTel._Value = "";
            this.tbSuppTel._XPath = null;
            this.tbSuppTel.BackColor = System.Drawing.Color.Transparent;
            this.tbSuppTel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSuppTel.Location = new System.Drawing.Point(84, 130);
            this.tbSuppTel.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbSuppTel.Name = "tbSuppTel";
            this.tbSuppTel.Size = new System.Drawing.Size(237, 21);
            this.tbSuppTel.TabIndex = 12;
            // 
            // tbSuppFax
            // 
            this.tbSuppFax._PasswordChar = '\0';
            this.tbSuppFax._Value = "";
            this.tbSuppFax._XPath = null;
            this.tbSuppFax.BackColor = System.Drawing.Color.Transparent;
            this.tbSuppFax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSuppFax.Location = new System.Drawing.Point(84, 157);
            this.tbSuppFax.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbSuppFax.Name = "tbSuppFax";
            this.tbSuppFax.Size = new System.Drawing.Size(237, 21);
            this.tbSuppFax.TabIndex = 13;
            // 
            // tbSuppLine
            // 
            this.tbSuppLine._PasswordChar = '\0';
            this.tbSuppLine._Value = "";
            this.tbSuppLine._XPath = null;
            this.tbSuppLine.BackColor = System.Drawing.Color.Transparent;
            this.tbSuppLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSuppLine.Location = new System.Drawing.Point(84, 184);
            this.tbSuppLine.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbSuppLine.Name = "tbSuppLine";
            this.tbSuppLine.Size = new System.Drawing.Size(237, 21);
            this.tbSuppLine.TabIndex = 14;
            // 
            // tbDiscount
            // 
            this.tbDiscount._PasswordChar = '\0';
            this.tbDiscount._Value = "";
            this.tbDiscount._XPath = null;
            this.tbDiscount.BackColor = System.Drawing.Color.Transparent;
            this.tbDiscount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbDiscount.Location = new System.Drawing.Point(84, 211);
            this.tbDiscount.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(237, 21);
            this.tbDiscount.TabIndex = 15;
            // 
            // tbPayment
            // 
            this.tbPayment._PasswordChar = '\0';
            this.tbPayment._Value = "";
            this.tbPayment._XPath = null;
            this.tbPayment.BackColor = System.Drawing.Color.Transparent;
            this.tbPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPayment.Location = new System.Drawing.Point(84, 238);
            this.tbPayment.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(237, 21);
            this.tbPayment.TabIndex = 16;
            // 
            // tbContact
            // 
            this.tbContact._PasswordChar = '\0';
            this.tbContact._Value = "";
            this.tbContact._XPath = null;
            this.tbContact.BackColor = System.Drawing.Color.Transparent;
            this.tbContact.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbContact.Location = new System.Drawing.Point(84, 265);
            this.tbContact.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(237, 21);
            this.tbContact.TabIndex = 17;
            // 
            // tbCredit
            // 
            this.tbCredit._PasswordChar = '\0';
            this.tbCredit._Value = "";
            this.tbCredit._XPath = null;
            this.tbCredit.BackColor = System.Drawing.Color.Transparent;
            this.tbCredit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbCredit.Location = new System.Drawing.Point(84, 292);
            this.tbCredit.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(237, 21);
            this.tbCredit.TabIndex = 18;
            // 
            // tbSuppDetail
            // 
            this.tbSuppDetail._Value = "";
            this.tbSuppDetail._XPath = null;
            this.tbSuppDetail.Location = new System.Drawing.Point(84, 319);
            this.tbSuppDetail.Name = "tbSuppDetail";
            this.tbSuppDetail.Size = new System.Drawing.Size(237, 57);
            this.tbSuppDetail.TabIndex = 19;
            // 
            // mpSupp1
            // 
            this.mpSupp1.Location = new System.Drawing.Point(21, 382);
            this.mpSupp1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mpSupp1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mpSupp1.Name = "mpSupp1";
            this.mpSupp1.Size = new System.Drawing.Size(24, 27);
            this.mpSupp1.TabIndex = 20;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(9, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "User";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(135, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 22;
            this.lblDateTime.Text = "DateTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(138, 395);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 23;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(246, 395);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 24;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 433);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.mpSupp1);
            this.Controls.Add(this.tbSuppDetail);
            this.Controls.Add(this.tbCredit);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbPayment);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.tbSuppLine);
            this.Controls.Add(this.tbSuppFax);
            this.Controls.Add(this.tbSuppTel);
            this.Controls.Add(this.tbSuppAddress);
            this.Controls.Add(this.tbSuppName);
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
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier (เฮงทวีค้าไม้)";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
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
        private ToolsDocument.ucTextBox tbSuppName;
        private ToolsDocument.ucRichTextBox tbSuppAddress;
        private ToolsDocument.ucTextBox tbSuppTel;
        private ToolsDocument.ucTextBox tbSuppFax;
        private ToolsDocument.ucTextBox tbSuppLine;
        private ToolsDocument.ucTextBox tbDiscount;
        private ToolsDocument.ucTextBox tbPayment;
        private ToolsDocument.ucTextBox tbContact;
        private ToolsDocument.ucTextBox tbCredit;
        private ToolsDocument.ucRichTextBox tbSuppDetail;
        private ToolsDocument.ucMappingControls mpSupp1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
    }
}