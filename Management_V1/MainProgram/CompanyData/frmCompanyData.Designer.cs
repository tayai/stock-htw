namespace CompanyData
{
    partial class frmCompanyData
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
            this.tbNameT = new ToolsDocument.ucTextBox();
            this.tbNameE = new ToolsDocument.ucTextBox();
            this.tbAddress = new ToolsDocument.ucRichTextBox();
            this.tbTel = new ToolsDocument.ucTextBox();
            this.tbFax = new ToolsDocument.ucTextBox();
            this.tbEmail = new ToolsDocument.ucTextBox();
            this.tbLineID = new ToolsDocument.ucTextBox();
            this.tbWebsite = new ToolsDocument.ucTextBox();
            this.tbTaxID = new ToolsDocument.ucTextBox();
            this.tbRegis = new ToolsDocument.ucTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.mpCompanyData1 = new ToolsDocument.ucMappingControls();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อภาษาไทย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อภาษาอังกฤษ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ที่อยู่";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "โทรศัพท์";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "แฟกซ์";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ฮีเมลล์";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ไอดีไลน์";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "เว็บไซต์";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(34, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 36);
            this.label9.TabIndex = 8;
            this.label9.Text = "หมาเลขประจำตัวผู้เสียภาษี";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "ทะเบียนการค้า";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNameT
            // 
            this.tbNameT._PasswordChar = '\0';
            this.tbNameT._Value = "";
            this.tbNameT._XPath = null;
            this.tbNameT.BackColor = System.Drawing.Color.Transparent;
            this.tbNameT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbNameT.Location = new System.Drawing.Point(126, 39);
            this.tbNameT.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbNameT.Name = "tbNameT";
            this.tbNameT.Size = new System.Drawing.Size(237, 21);
            this.tbNameT.TabIndex = 10;
            // 
            // tbNameE
            // 
            this.tbNameE._PasswordChar = '\0';
            this.tbNameE._Value = "";
            this.tbNameE._XPath = null;
            this.tbNameE.BackColor = System.Drawing.Color.Transparent;
            this.tbNameE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbNameE.Location = new System.Drawing.Point(126, 76);
            this.tbNameE.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbNameE.Name = "tbNameE";
            this.tbNameE.Size = new System.Drawing.Size(237, 21);
            this.tbNameE.TabIndex = 11;
            // 
            // tbAddress
            // 
            this.tbAddress._Value = "";
            this.tbAddress._XPath = null;
            this.tbAddress.BackColor = System.Drawing.Color.Transparent;
            this.tbAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbAddress.Location = new System.Drawing.Point(126, 113);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(237, 67);
            this.tbAddress.TabIndex = 12;
            // 
            // tbTel
            // 
            this.tbTel._PasswordChar = '\0';
            this.tbTel._Value = "";
            this.tbTel._XPath = null;
            this.tbTel.BackColor = System.Drawing.Color.Transparent;
            this.tbTel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTel.Location = new System.Drawing.Point(126, 196);
            this.tbTel.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(237, 21);
            this.tbTel.TabIndex = 13;
            // 
            // tbFax
            // 
            this.tbFax._PasswordChar = '\0';
            this.tbFax._Value = "";
            this.tbFax._XPath = null;
            this.tbFax.BackColor = System.Drawing.Color.Transparent;
            this.tbFax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbFax.Location = new System.Drawing.Point(126, 233);
            this.tbFax.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(237, 21);
            this.tbFax.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail._PasswordChar = '\0';
            this.tbEmail._Value = "";
            this.tbEmail._XPath = null;
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbEmail.Location = new System.Drawing.Point(126, 270);
            this.tbEmail.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(237, 21);
            this.tbEmail.TabIndex = 15;
            // 
            // tbLineID
            // 
            this.tbLineID._PasswordChar = '\0';
            this.tbLineID._Value = "";
            this.tbLineID._XPath = null;
            this.tbLineID.BackColor = System.Drawing.Color.Transparent;
            this.tbLineID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbLineID.Location = new System.Drawing.Point(126, 307);
            this.tbLineID.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbLineID.Name = "tbLineID";
            this.tbLineID.Size = new System.Drawing.Size(237, 21);
            this.tbLineID.TabIndex = 16;
            // 
            // tbWebsite
            // 
            this.tbWebsite._PasswordChar = '\0';
            this.tbWebsite._Value = "";
            this.tbWebsite._XPath = null;
            this.tbWebsite.BackColor = System.Drawing.Color.Transparent;
            this.tbWebsite.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbWebsite.Location = new System.Drawing.Point(126, 344);
            this.tbWebsite.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(237, 21);
            this.tbWebsite.TabIndex = 17;
            // 
            // tbTaxID
            // 
            this.tbTaxID._PasswordChar = '\0';
            this.tbTaxID._Value = "";
            this.tbTaxID._XPath = null;
            this.tbTaxID.BackColor = System.Drawing.Color.Transparent;
            this.tbTaxID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTaxID.Location = new System.Drawing.Point(126, 381);
            this.tbTaxID.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbTaxID.Name = "tbTaxID";
            this.tbTaxID.Size = new System.Drawing.Size(237, 21);
            this.tbTaxID.TabIndex = 18;
            // 
            // tbRegis
            // 
            this.tbRegis._PasswordChar = '\0';
            this.tbRegis._Value = "";
            this.tbRegis._XPath = null;
            this.tbRegis.BackColor = System.Drawing.Color.Transparent;
            this.tbRegis.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbRegis.Location = new System.Drawing.Point(126, 418);
            this.tbRegis.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbRegis.Name = "tbRegis";
            this.tbRegis.Size = new System.Drawing.Size(237, 21);
            this.tbRegis.TabIndex = 19;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(154, 460);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 20;
            this.btSave.Text = "บันทึก";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(265, 460);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 21;
            this.btClose.Text = "ปิด";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 22;
            this.lblUser.Text = "USER : ";
            // 
            // mpCompanyData1
            // 
            this.mpCompanyData1.Location = new System.Drawing.Point(38, 449);
            this.mpCompanyData1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mpCompanyData1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mpCompanyData1.Name = "mpCompanyData1";
            this.mpCompanyData1.Size = new System.Drawing.Size(24, 27);
            this.mpCompanyData1.TabIndex = 23;
            this.mpCompanyData1.Visible = false;
            // 
            // lblDatetime
            // 
            this.lblDatetime.AutoSize = true;
            this.lblDatetime.Location = new System.Drawing.Point(126, 9);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDatetime.Size = new System.Drawing.Size(53, 13);
            this.lblDatetime.TabIndex = 24;
            this.lblDatetime.Text = "DateTime";
            this.lblDatetime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCompanyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 503);
            this.Controls.Add(this.lblDatetime);
            this.Controls.Add(this.mpCompanyData1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbRegis);
            this.Controls.Add(this.tbTaxID);
            this.Controls.Add(this.tbWebsite);
            this.Controls.Add(this.tbLineID);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbFax);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbNameE);
            this.Controls.Add(this.tbNameT);
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
            this.Name = "frmCompanyData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลบริษัท (เฮงทวีค้าไม้)";
            this.Load += new System.EventHandler(this.frmCompanyData_Load);
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
        private ToolsDocument.ucTextBox tbNameT;
        private ToolsDocument.ucTextBox tbNameE;
        private ToolsDocument.ucRichTextBox tbAddress;
        private ToolsDocument.ucTextBox tbTel;
        private ToolsDocument.ucTextBox tbFax;
        private ToolsDocument.ucTextBox tbEmail;
        private ToolsDocument.ucTextBox tbLineID;
        private ToolsDocument.ucTextBox tbWebsite;
        private ToolsDocument.ucTextBox tbTaxID;
        private ToolsDocument.ucTextBox tbRegis;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lblUser;
        private ToolsDocument.ucMappingControls mpCompanyData1;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.Timer timer1;
    }
}