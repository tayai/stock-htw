namespace CompanyData
{
    partial class frmSaleProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSeller = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cbCredit = new ToolsDocument.ucCheckBox();
            this.tbSaleDetail = new ToolsDocument.ucRichTextBox();
            this.tbNetAmount = new ToolsDocument.ucTextBox();
            this.tbVat = new ToolsDocument.ucTextBox();
            this.tbDiscountAmount = new ToolsDocument.ucTextBox();
            this.tbTotalAmount = new ToolsDocument.ucTextBox();
            this.dgSaleItems = new ToolsDocument.ucDataGridView();
            this.tbExVat = new ToolsDocument.ucTextBox();
            this.tbInVat = new ToolsDocument.ucTextBox();
            this.tbDiscountPercent = new ToolsDocument.ucTextBox();
            this.dtpDueDate = new ToolsDocument.ucDateTimePicker();
            this.tbTaxInvNo = new ToolsDocument.ucTextBox();
            this.dtpBillDate = new ToolsDocument.ucDateTimePicker();
            this.tbBillNo = new ToolsDocument.ucTextBox();
            this.cbCustName = new ToolsDocument.ucComboBox();
            this.tbDocName = new ToolsDocument.ucTextBox();
            this.mcSP1 = new ToolsDocument.ucMappingControls();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อเอกสาร / Document Name";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "USER : ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(12, 28);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "DateTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "ชื่อลูกค้า\r\nCustomer Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "ที่อยู่\r\nAddress";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(404, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "เลขที่การขาย\r\nBill No.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "วันที่ / Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(500, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ใบกำกับภาษีเลขที่ / Tax Invoice No.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "ครบกำหนดชำระเงิน\r\nDue Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "พนักงานขาย\r\nSeller";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "ส่วนลด\r\nSale Discount";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 26);
            this.label11.TabIndex = 22;
            this.label11.Text = "ภาษีชนิดในตัว(%)\r\nInclude Vat";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(572, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 26);
            this.label12.TabIndex = 24;
            this.label12.Text = "ภาษีชนิดต่างหาก(%)\r\nExclude Vat";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "รวมเงิน / Total Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(427, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "ส่วนลด / Discount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(401, 455);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "ภาษีมูลค่าเพิ่ม / Vat 7 %";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(390, 482);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "รวมเงินสุทธิ / Net Amount";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 437);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "รายละเอียด";
            // 
            // btSave
            // 
            this.btSave.AutoSize = true;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSave.Location = new System.Drawing.Point(223, 515);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 27);
            this.btSave.TabIndex = 37;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btClose.Location = new System.Drawing.Point(391, 515);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 27);
            this.btClose.TabIndex = 38;
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
            // lblSeller
            // 
            this.lblSeller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeller.Location = new System.Drawing.Point(183, 202);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(171, 20);
            this.lblSeller.TabIndex = 40;
            this.lblSeller.Text = "USER";
            this.lblSeller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress.Location = new System.Drawing.Point(185, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(197, 72);
            this.lblAddress.TabIndex = 41;
            // 
            // cbCredit
            // 
            this.cbCredit._Checked = false;
            this.cbCredit._Text = "เครดิต / Credit";
            this.cbCredit._XPath = null;
            this.cbCredit.Location = new System.Drawing.Point(38, 125);
            this.cbCredit.Name = "cbCredit";
            this.cbCredit.Size = new System.Drawing.Size(101, 25);
            this.cbCredit.TabIndex = 42;
            // 
            // tbSaleDetail
            // 
            this.tbSaleDetail._Value = "";
            this.tbSaleDetail._XPath = null;
            this.tbSaleDetail.Location = new System.Drawing.Point(79, 393);
            this.tbSaleDetail.Name = "tbSaleDetail";
            this.tbSaleDetail.Size = new System.Drawing.Size(291, 102);
            this.tbSaleDetail.TabIndex = 36;
            // 
            // tbNetAmount
            // 
            this.tbNetAmount._PasswordChar = '\0';
            this.tbNetAmount._Value = "";
            this.tbNetAmount._XPath = null;
            this.tbNetAmount.BackColor = System.Drawing.Color.Transparent;
            this.tbNetAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbNetAmount.Location = new System.Drawing.Point(526, 474);
            this.tbNetAmount.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbNetAmount.Name = "tbNetAmount";
            this.tbNetAmount.Size = new System.Drawing.Size(148, 21);
            this.tbNetAmount.TabIndex = 34;
            // 
            // tbVat
            // 
            this.tbVat._PasswordChar = '\0';
            this.tbVat._Value = "";
            this.tbVat._XPath = null;
            this.tbVat.BackColor = System.Drawing.Color.Transparent;
            this.tbVat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbVat.Location = new System.Drawing.Point(526, 447);
            this.tbVat.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbVat.Name = "tbVat";
            this.tbVat.Size = new System.Drawing.Size(148, 21);
            this.tbVat.TabIndex = 33;
            // 
            // tbDiscountAmount
            // 
            this.tbDiscountAmount._PasswordChar = '\0';
            this.tbDiscountAmount._Value = "";
            this.tbDiscountAmount._XPath = null;
            this.tbDiscountAmount.BackColor = System.Drawing.Color.Transparent;
            this.tbDiscountAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbDiscountAmount.Location = new System.Drawing.Point(526, 420);
            this.tbDiscountAmount.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbDiscountAmount.Name = "tbDiscountAmount";
            this.tbDiscountAmount.Size = new System.Drawing.Size(148, 21);
            this.tbDiscountAmount.TabIndex = 32;
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount._PasswordChar = '\0';
            this.tbTotalAmount._Value = "";
            this.tbTotalAmount._XPath = null;
            this.tbTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.tbTotalAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTotalAmount.Location = new System.Drawing.Point(526, 393);
            this.tbTotalAmount.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.Size = new System.Drawing.Size(148, 21);
            this.tbTotalAmount.TabIndex = 31;
            // 
            // dgSaleItems
            // 
            this.dgSaleItems._DataText = null;
            this.dgSaleItems._XPath = null;
            this.dgSaleItems.Location = new System.Drawing.Point(12, 229);
            this.dgSaleItems.Name = "dgSaleItems";
            this.dgSaleItems.Size = new System.Drawing.Size(662, 158);
            this.dgSaleItems.TabIndex = 26;
            // 
            // tbExVat
            // 
            this.tbExVat._PasswordChar = '\0';
            this.tbExVat._Value = "";
            this.tbExVat._XPath = null;
            this.tbExVat.BackColor = System.Drawing.Color.Transparent;
            this.tbExVat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbExVat.Location = new System.Drawing.Point(570, 202);
            this.tbExVat.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbExVat.Name = "tbExVat";
            this.tbExVat.Size = new System.Drawing.Size(102, 21);
            this.tbExVat.TabIndex = 25;
            // 
            // tbInVat
            // 
            this.tbInVat._PasswordChar = '\0';
            this.tbInVat._Value = "";
            this.tbInVat._XPath = null;
            this.tbInVat.BackColor = System.Drawing.Color.Transparent;
            this.tbInVat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbInVat.Location = new System.Drawing.Point(469, 202);
            this.tbInVat.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbInVat.Name = "tbInVat";
            this.tbInVat.Size = new System.Drawing.Size(87, 21);
            this.tbInVat.TabIndex = 23;
            // 
            // tbDiscountPercent
            // 
            this.tbDiscountPercent._PasswordChar = '\0';
            this.tbDiscountPercent._Value = "";
            this.tbDiscountPercent._XPath = null;
            this.tbDiscountPercent.BackColor = System.Drawing.Color.Transparent;
            this.tbDiscountPercent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbDiscountPercent.Location = new System.Drawing.Point(368, 202);
            this.tbDiscountPercent.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbDiscountPercent.Name = "tbDiscountPercent";
            this.tbDiscountPercent.Size = new System.Drawing.Size(87, 21);
            this.tbDiscountPercent.TabIndex = 21;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate._XPath = null;
            this.dtpDueDate.Location = new System.Drawing.Point(13, 202);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(151, 20);
            this.dtpDueDate.TabIndex = 17;
            // 
            // tbTaxInvNo
            // 
            this.tbTaxInvNo._PasswordChar = '\0';
            this.tbTaxInvNo._Value = "";
            this.tbTaxInvNo._XPath = null;
            this.tbTaxInvNo.BackColor = System.Drawing.Color.Transparent;
            this.tbTaxInvNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTaxInvNo.Location = new System.Drawing.Point(501, 88);
            this.tbTaxInvNo.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbTaxInvNo.Name = "tbTaxInvNo";
            this.tbTaxInvNo.Size = new System.Drawing.Size(174, 21);
            this.tbTaxInvNo.TabIndex = 15;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate._XPath = null;
            this.dtpBillDate.Location = new System.Drawing.Point(523, 26);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(151, 20);
            this.dtpBillDate.TabIndex = 13;
            // 
            // tbBillNo
            // 
            this.tbBillNo._PasswordChar = '\0';
            this.tbBillNo._Value = "";
            this.tbBillNo._XPath = null;
            this.tbBillNo.BackColor = System.Drawing.Color.Transparent;
            this.tbBillNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbBillNo.Location = new System.Drawing.Point(405, 88);
            this.tbBillNo.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbBillNo.Name = "tbBillNo";
            this.tbBillNo.Size = new System.Drawing.Size(64, 21);
            this.tbBillNo.TabIndex = 11;
            // 
            // cbCustName
            // 
            this.cbCustName._DataSourceID = null;
            this.cbCustName._DisplayMember = null;
            this.cbCustName._SelectedIndex = -1;
            this.cbCustName._SelectedText = "";
            this.cbCustName._SelectedValue = "";
            this.cbCustName._ValueMember = null;
            this.cbCustName._XPath = null;
            this.cbCustName.Location = new System.Drawing.Point(15, 88);
            this.cbCustName.Name = "cbCustName";
            this.cbCustName.Size = new System.Drawing.Size(145, 21);
            this.cbCustName.TabIndex = 6;
            this.cbCustName.Select_Index_Change += new System.EventHandler(this.cbCustName_SelectChange);
            // 
            // tbDocName
            // 
            this.tbDocName._PasswordChar = '\0';
            this.tbDocName._Value = "";
            this.tbDocName._XPath = null;
            this.tbDocName.BackColor = System.Drawing.Color.Transparent;
            this.tbDocName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbDocName.Location = new System.Drawing.Point(273, 25);
            this.tbDocName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbDocName.Name = "tbDocName";
            this.tbDocName.Size = new System.Drawing.Size(143, 21);
            this.tbDocName.TabIndex = 1;
            // 
            // mcSP1
            // 
            this.mcSP1.Location = new System.Drawing.Point(25, 515);
            this.mcSP1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mcSP1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mcSP1.Name = "mcSP1";
            this.mcSP1.Size = new System.Drawing.Size(24, 27);
            this.mcSP1.TabIndex = 43;
            // 
            // frmSaleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 554);
            this.Controls.Add(this.mcSP1);
            this.Controls.Add(this.cbCredit);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbSaleDetail);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbNetAmount);
            this.Controls.Add(this.tbVat);
            this.Controls.Add(this.tbDiscountAmount);
            this.Controls.Add(this.tbTotalAmount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgSaleItems);
            this.Controls.Add(this.tbExVat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbInVat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDiscountPercent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTaxInvNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpBillDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBillNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCustName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbDocName);
            this.Controls.Add(this.label1);
            this.Name = "frmSaleProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอขายสินค้า (เฮงทวีค้าไม้)";
            this.Load += new System.EventHandler(this.frmSaleProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ToolsDocument.ucTextBox tbDocName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ToolsDocument.ucComboBox cbCustName;
        private System.Windows.Forms.Label label5;
        private ToolsDocument.ucTextBox tbBillNo;
        private System.Windows.Forms.Label label6;
        private ToolsDocument.ucDateTimePicker dtpBillDate;
        private System.Windows.Forms.Label label7;
        private ToolsDocument.ucTextBox tbTaxInvNo;
        private System.Windows.Forms.Label label8;
        private ToolsDocument.ucDateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ToolsDocument.ucTextBox tbDiscountPercent;
        private System.Windows.Forms.Label label11;
        private ToolsDocument.ucTextBox tbInVat;
        private System.Windows.Forms.Label label12;
        private ToolsDocument.ucTextBox tbExVat;
        private ToolsDocument.ucDataGridView dgSaleItems;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private ToolsDocument.ucTextBox tbTotalAmount;
        private ToolsDocument.ucTextBox tbDiscountAmount;
        private ToolsDocument.ucTextBox tbVat;
        private ToolsDocument.ucTextBox tbNetAmount;
        private System.Windows.Forms.Label label17;
        private ToolsDocument.ucRichTextBox tbSaleDetail;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label lblAddress;
        private ToolsDocument.ucCheckBox cbCredit;
        private ToolsDocument.ucMappingControls mcSP1;
    }
}