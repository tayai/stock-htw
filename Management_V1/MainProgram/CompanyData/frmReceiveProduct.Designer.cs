namespace CompanyData
{
    partial class frmReceiveProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiveProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.tbGrandTotal = new ToolsDocument.ucDoubleTextBox();
            this.tbTotal = new ToolsDocument.ucDoubleTextBox();
            this.tbVat = new ToolsDocument.ucDoubleTextBox();
            this.tbAmount = new ToolsDocument.ucDoubleTextBox();
            this.tbDiscount = new ToolsDocument.ucDoubleTextBox();
            this.tbTotalAmount = new ToolsDocument.ucDoubleTextBox();
            this.tbSaleDiscount = new ToolsDocument.ucDoubleTextBox();
            this.tbPrivDiscount = new ToolsDocument.ucDoubleTextBox();
            this.tbExVat = new ToolsDocument.ucDoubleTextBox();
            this.tbInVat = new ToolsDocument.ucDoubleTextBox();
            this.tbDetail = new ToolsDocument.ucRichTextBox();
            this.mcRecProd1 = new ToolsDocument.ucMappingControls();
            this.dtpRecProd = new ToolsDocument.ucDateTimePicker();
            this.cbSuppName = new ToolsDocument.ucComboBox();
            this.tbDocNo = new ToolsDocument.ucTextBox();
            this.dgRecProdItem = new ToolsDocument.ucDataGridView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่ / Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(439, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ภาษีมูลค่าเพิ่มชนิดในตัว / INCLUDE VAT                    %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(427, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ภาษีมูลค่าเพิ่มชนิดต่างหาก / EXCLUDE VAT                    %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "เลขที่เอกสารรับเข้า / Document No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ชื่อร้านค้าผู้จำหน่าย / Supplier Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "สิทธิส่วนลด / Privilaege Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "อัตราส่วนลดครั้งนี้ / Sale Discount";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "USER : ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(117, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "DateTime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(390, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "จำนวนเงินรวม / Total Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(403, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "จำนวนเงินส่วนลด/Discount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(389, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "จำนวนเงินหักส่วนลด / Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(437, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "ภาษีมูลค่าเพิ่ม / VAT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(429, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "จำนวนเงินรวม / Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(397, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "จำนวนเงินสุทธิ / Grand Total";
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSave.Location = new System.Drawing.Point(232, 504);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(101, 32);
            this.btSave.TabIndex = 16;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btClose.Location = new System.Drawing.Point(381, 504);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(101, 32);
            this.btClose.TabIndex = 17;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(153, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "รายละเอียด";
            // 
            // tbGrandTotal
            // 
            this.tbGrandTotal._Value = "0";
            this.tbGrandTotal._XPath = null;
            this.tbGrandTotal.Location = new System.Drawing.Point(545, 469);
            this.tbGrandTotal.Name = "tbGrandTotal";
            this.tbGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbGrandTotal.Size = new System.Drawing.Size(165, 21);
            this.tbGrandTotal.TabIndex = 29;
            // 
            // tbTotal
            // 
            this.tbTotal._Value = "0";
            this.tbTotal._XPath = null;
            this.tbTotal.Location = new System.Drawing.Point(545, 442);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTotal.Size = new System.Drawing.Size(165, 21);
            this.tbTotal.TabIndex = 28;
            // 
            // tbVat
            // 
            this.tbVat._Value = "0";
            this.tbVat._XPath = null;
            this.tbVat.Location = new System.Drawing.Point(545, 415);
            this.tbVat.Name = "tbVat";
            this.tbVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbVat.Size = new System.Drawing.Size(165, 21);
            this.tbVat.TabIndex = 27;
            // 
            // tbAmount
            // 
            this.tbAmount._Value = "0";
            this.tbAmount._XPath = null;
            this.tbAmount.Location = new System.Drawing.Point(545, 388);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAmount.Size = new System.Drawing.Size(165, 21);
            this.tbAmount.TabIndex = 26;
            // 
            // tbDiscount
            // 
            this.tbDiscount._Value = "0";
            this.tbDiscount._XPath = null;
            this.tbDiscount.Location = new System.Drawing.Point(545, 361);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDiscount.Size = new System.Drawing.Size(165, 21);
            this.tbDiscount.TabIndex = 25;
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount._Value = "0";
            this.tbTotalAmount._XPath = null;
            this.tbTotalAmount.Location = new System.Drawing.Point(545, 334);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTotalAmount.Size = new System.Drawing.Size(165, 21);
            this.tbTotalAmount.TabIndex = 24;
            // 
            // tbSaleDiscount
            // 
            this.tbSaleDiscount._Value = "0";
            this.tbSaleDiscount._XPath = null;
            this.tbSaleDiscount.Location = new System.Drawing.Point(547, 94);
            this.tbSaleDiscount.Name = "tbSaleDiscount";
            this.tbSaleDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSaleDiscount.Size = new System.Drawing.Size(162, 21);
            this.tbSaleDiscount.TabIndex = 23;
            // 
            // tbPrivDiscount
            // 
            this.tbPrivDiscount._Value = "0";
            this.tbPrivDiscount._XPath = null;
            this.tbPrivDiscount.Location = new System.Drawing.Point(382, 94);
            this.tbPrivDiscount.Name = "tbPrivDiscount";
            this.tbPrivDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPrivDiscount.Size = new System.Drawing.Size(158, 21);
            this.tbPrivDiscount.TabIndex = 22;
            // 
            // tbExVat
            // 
            this.tbExVat._Value = "0";
            this.tbExVat._XPath = null;
            this.tbExVat.Location = new System.Drawing.Point(649, 48);
            this.tbExVat.Name = "tbExVat";
            this.tbExVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbExVat.Size = new System.Drawing.Size(41, 21);
            this.tbExVat.TabIndex = 21;
            // 
            // tbInVat
            // 
            this.tbInVat._Value = "0";
            this.tbInVat._XPath = null;
            this.tbInVat.Location = new System.Drawing.Point(649, 22);
            this.tbInVat.Name = "tbInVat";
            this.tbInVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbInVat.Size = new System.Drawing.Size(41, 21);
            this.tbInVat.TabIndex = 20;
            // 
            // tbDetail
            // 
            this.tbDetail._Value = "";
            this.tbDetail._XPath = null;
            this.tbDetail.Location = new System.Drawing.Point(18, 359);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(333, 129);
            this.tbDetail.TabIndex = 9;
            // 
            // mcRecProd1
            // 
            this.mcRecProd1.Location = new System.Drawing.Point(18, 504);
            this.mcRecProd1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mcRecProd1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mcRecProd1.Name = "mcRecProd1";
            this.mcRecProd1.Size = new System.Drawing.Size(24, 27);
            this.mcRecProd1.TabIndex = 18;
            this.mcRecProd1.Visible = false;
            // 
            // dtpRecProd
            // 
            this.dtpRecProd._XPath = null;
            this.dtpRecProd.Location = new System.Drawing.Point(88, 32);
            this.dtpRecProd.Name = "dtpRecProd";
            this.dtpRecProd.Size = new System.Drawing.Size(151, 20);
            this.dtpRecProd.TabIndex = 1;
            // 
            // cbSuppName
            // 
            this.cbSuppName._DataSourceID = null;
            this.cbSuppName._DisplayMember = null;
            this.cbSuppName._SelectedIndex = -1;
            this.cbSuppName._SelectedText = "";
            this.cbSuppName._SelectedValue = "";
            this.cbSuppName._ValueMember = null;
            this.cbSuppName._XPath = null;
            this.cbSuppName.Location = new System.Drawing.Point(199, 94);
            this.cbSuppName.Name = "cbSuppName";
            this.cbSuppName.Size = new System.Drawing.Size(173, 21);
            this.cbSuppName.TabIndex = 5;
            this.cbSuppName.Select_Index_Change += new System.EventHandler(this.cbSuppName_Select_Index_Change);
            // 
            // tbDocNo
            // 
            this.tbDocNo._PasswordChar = '\0';
            this.tbDocNo._Value = "";
            this.tbDocNo._XPath = null;
            this.tbDocNo.AccessibleDescription = "";
            this.tbDocNo.BackColor = System.Drawing.Color.Transparent;
            this.tbDocNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbDocNo.Location = new System.Drawing.Point(18, 94);
            this.tbDocNo.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbDocNo.Name = "tbDocNo";
            this.tbDocNo.Size = new System.Drawing.Size(164, 21);
            this.tbDocNo.TabIndex = 4;
            // 
            // dgRecProdItem
            // 
            this.dgRecProdItem._DataText = null;
            this.dgRecProdItem._XPath = null;
            this.dgRecProdItem.Location = new System.Drawing.Point(12, 121);
            this.dgRecProdItem.Name = "dgRecProdItem";
            this.dgRecProdItem.Size = new System.Drawing.Size(700, 207);
            this.dgRecProdItem.TabIndex = 30;
            // 
            // frmReceiveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 550);
            this.Controls.Add(this.dgRecProdItem);
            this.Controls.Add(this.tbGrandTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbVat);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.tbTotalAmount);
            this.Controls.Add(this.tbSaleDiscount);
            this.Controls.Add(this.tbPrivDiscount);
            this.Controls.Add(this.tbExVat);
            this.Controls.Add(this.tbInVat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbDetail);
            this.Controls.Add(this.mcRecProd1);
            this.Controls.Add(this.dtpRecProd);
            this.Controls.Add(this.cbSuppName);
            this.Controls.Add(this.tbDocNo);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReceiveProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive Product (หน้าจอรับสินค้า เฮงทวีค้าไม้)";
            this.Load += new System.EventHandler(this.frmReceiveProduct_Load);
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
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Timer timer1;
        private ToolsDocument.ucComboBox cbSuppName;
        private ToolsDocument.ucDateTimePicker dtpRecProd;
        private ToolsDocument.ucTextBox tbDocNo;
        private ToolsDocument.ucMappingControls mcRecProd1;
        private ToolsDocument.ucRichTextBox tbDetail;
        private System.Windows.Forms.Label label14;
        private ToolsDocument.ucDoubleTextBox tbInVat;
        private ToolsDocument.ucDoubleTextBox tbExVat;
        private ToolsDocument.ucDoubleTextBox tbPrivDiscount;
        private ToolsDocument.ucDoubleTextBox tbSaleDiscount;
        private ToolsDocument.ucDoubleTextBox tbTotalAmount;
        private ToolsDocument.ucDoubleTextBox tbDiscount;
        private ToolsDocument.ucDoubleTextBox tbAmount;
        private ToolsDocument.ucDoubleTextBox tbVat;
        private ToolsDocument.ucDoubleTextBox tbTotal;
        private ToolsDocument.ucDoubleTextBox tbGrandTotal;
        private ToolsDocument.ucDataGridView dgRecProdItem;
    }
}