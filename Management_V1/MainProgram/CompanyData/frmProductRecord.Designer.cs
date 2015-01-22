namespace CompanyData
{
    partial class frmProductRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductRecord));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btPISave = new System.Windows.Forms.Button();
            this.btPIClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ucDataGridView1 = new ToolsDocument.ucDataGridView();
            this.cbWarehouse = new ToolsDocument.ucComboBox();
            this.cbProdUnit = new ToolsDocument.ucComboBox();
            this.cbProdCat = new ToolsDocument.ucComboBox();
            this.cbProdGroup = new ToolsDocument.ucComboBox();
            this.tbPrice10 = new ToolsDocument.ucTextBox();
            this.tbPrice9 = new ToolsDocument.ucTextBox();
            this.tbPrice8 = new ToolsDocument.ucTextBox();
            this.tbPrice7 = new ToolsDocument.ucTextBox();
            this.tbPrice6 = new ToolsDocument.ucTextBox();
            this.tbPrice5 = new ToolsDocument.ucTextBox();
            this.tbPrice4 = new ToolsDocument.ucTextBox();
            this.tbPrice3 = new ToolsDocument.ucTextBox();
            this.tbPrice2 = new ToolsDocument.ucTextBox();
            this.tbPrice1 = new ToolsDocument.ucTextBox();
            this.tbDetail = new ToolsDocument.ucRichTextBox();
            this.tbPOV = new ToolsDocument.ucTextBox();
            this.tbProdName = new ToolsDocument.ucTextBox();
            this.ucMCPI1 = new ToolsDocument.ucMappingControls();
            this.tbProdCode = new ToolsDocument.ucTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ชื่อสินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "กลุ่มสินค้า";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "หมวดหมู่สินค้า";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "หน่วยนับ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "กำหนดจุดสั่งซื้อ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 307);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "รายละเอียด";
            // 
            // btPISave
            // 
            this.btPISave.Location = new System.Drawing.Point(440, 327);
            this.btPISave.Name = "btPISave";
            this.btPISave.Size = new System.Drawing.Size(75, 23);
            this.btPISave.TabIndex = 40;
            this.btPISave.Text = "Save";
            this.btPISave.UseVisualStyleBackColor = true;
            this.btPISave.Click += new System.EventHandler(this.btPISave_Click);
            // 
            // btPIClose
            // 
            this.btPIClose.Location = new System.Drawing.Point(561, 327);
            this.btPIClose.Name = "btPIClose";
            this.btPIClose.Size = new System.Drawing.Size(75, 23);
            this.btPIClose.TabIndex = 41;
            this.btPIClose.Text = "Close";
            this.btPIClose.UseVisualStyleBackColor = true;
            this.btPIClose.Click += new System.EventHandler(this.btPIClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "ราคาขาย1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "ราคาขาย2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "ราคาขาย3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "ราคาขาย5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "ราคาขาย7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "ราคาขาย9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "ราคาขาย4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "ราคาขาย6";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "ราคาขาย8";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(353, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "ราคาขาย10";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 63;
            this.lblUser.Text = "USER :";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(416, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 65;
            this.lblDateTime.Text = "DateTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(362, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 66;
            this.label18.Text = "คลังสินค้า";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(359, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 13);
            this.label19.TabIndex = 67;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(7, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 13);
            this.label20.TabIndex = 68;
            this.label20.Text = "*";
            // 
            // ucDataGridView1
            // 
            this.ucDataGridView1._DataText = null;
            this.ucDataGridView1._XPath = null;
            this.ucDataGridView1.Location = new System.Drawing.Point(21, 376);
            this.ucDataGridView1.Name = "ucDataGridView1";
            this.ucDataGridView1.Size = new System.Drawing.Size(635, 130);
            this.ucDataGridView1.TabIndex = 69;
            // 
            // cbWarehouse
            // 
            this.cbWarehouse._DataSourceID = null;
            this.cbWarehouse._DisplayMember = null;
            this.cbWarehouse._SelectedIndex = -1;
            this.cbWarehouse._SelectedText = "";
            this.cbWarehouse._SelectedValue = "";
            this.cbWarehouse._ValueMember = null;
            this.cbWarehouse._XPath = null;
            this.cbWarehouse.Location = new System.Drawing.Point(419, 114);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(237, 21);
            this.cbWarehouse.TabIndex = 6;
            // 
            // cbProdUnit
            // 
            this.cbProdUnit._DataSourceID = null;
            this.cbProdUnit._DisplayMember = null;
            this.cbProdUnit._SelectedIndex = -1;
            this.cbProdUnit._SelectedText = "";
            this.cbProdUnit._SelectedValue = "";
            this.cbProdUnit._ValueMember = null;
            this.cbProdUnit._XPath = null;
            this.cbProdUnit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbProdUnit.Location = new System.Drawing.Point(74, 114);
            this.cbProdUnit.Name = "cbProdUnit";
            this.cbProdUnit.Size = new System.Drawing.Size(237, 21);
            this.cbProdUnit.TabIndex = 5;
            // 
            // cbProdCat
            // 
            this.cbProdCat._DataSourceID = null;
            this.cbProdCat._DisplayMember = null;
            this.cbProdCat._SelectedIndex = -1;
            this.cbProdCat._SelectedText = "";
            this.cbProdCat._SelectedValue = "";
            this.cbProdCat._ValueMember = null;
            this.cbProdCat._XPath = null;
            this.cbProdCat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbProdCat.Location = new System.Drawing.Point(419, 75);
            this.cbProdCat.Name = "cbProdCat";
            this.cbProdCat.Size = new System.Drawing.Size(237, 21);
            this.cbProdCat.TabIndex = 4;
            // 
            // cbProdGroup
            // 
            this.cbProdGroup._DataSourceID = null;
            this.cbProdGroup._DisplayMember = null;
            this.cbProdGroup._SelectedIndex = -1;
            this.cbProdGroup._SelectedText = "";
            this.cbProdGroup._SelectedValue = "";
            this.cbProdGroup._ValueMember = null;
            this.cbProdGroup._XPath = null;
            this.cbProdGroup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbProdGroup.Location = new System.Drawing.Point(74, 75);
            this.cbProdGroup.Name = "cbProdGroup";
            this.cbProdGroup.Size = new System.Drawing.Size(237, 21);
            this.cbProdGroup.TabIndex = 3;
            // 
            // tbPrice10
            // 
            this.tbPrice10._PasswordChar = '\0';
            this.tbPrice10._Value = "";
            this.tbPrice10._XPath = null;
            this.tbPrice10.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice10.Location = new System.Drawing.Point(419, 261);
            this.tbPrice10.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice10.Name = "tbPrice10";
            this.tbPrice10.Size = new System.Drawing.Size(237, 21);
            this.tbPrice10.TabIndex = 16;
            // 
            // tbPrice9
            // 
            this.tbPrice9._PasswordChar = '\0';
            this.tbPrice9._Value = "";
            this.tbPrice9._XPath = null;
            this.tbPrice9.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice9.Location = new System.Drawing.Point(74, 261);
            this.tbPrice9.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice9.Name = "tbPrice9";
            this.tbPrice9.Size = new System.Drawing.Size(237, 21);
            this.tbPrice9.TabIndex = 15;
            // 
            // tbPrice8
            // 
            this.tbPrice8._PasswordChar = '\0';
            this.tbPrice8._Value = "";
            this.tbPrice8._XPath = null;
            this.tbPrice8.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice8.Location = new System.Drawing.Point(419, 234);
            this.tbPrice8.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice8.Name = "tbPrice8";
            this.tbPrice8.Size = new System.Drawing.Size(237, 21);
            this.tbPrice8.TabIndex = 14;
            // 
            // tbPrice7
            // 
            this.tbPrice7._PasswordChar = '\0';
            this.tbPrice7._Value = "";
            this.tbPrice7._XPath = null;
            this.tbPrice7.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice7.Location = new System.Drawing.Point(74, 234);
            this.tbPrice7.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice7.Name = "tbPrice7";
            this.tbPrice7.Size = new System.Drawing.Size(237, 21);
            this.tbPrice7.TabIndex = 13;
            // 
            // tbPrice6
            // 
            this.tbPrice6._PasswordChar = '\0';
            this.tbPrice6._Value = "";
            this.tbPrice6._XPath = null;
            this.tbPrice6.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice6.Location = new System.Drawing.Point(419, 207);
            this.tbPrice6.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice6.Name = "tbPrice6";
            this.tbPrice6.Size = new System.Drawing.Size(237, 21);
            this.tbPrice6.TabIndex = 12;
            // 
            // tbPrice5
            // 
            this.tbPrice5._PasswordChar = '\0';
            this.tbPrice5._Value = "";
            this.tbPrice5._XPath = null;
            this.tbPrice5.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice5.Location = new System.Drawing.Point(74, 207);
            this.tbPrice5.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice5.Name = "tbPrice5";
            this.tbPrice5.Size = new System.Drawing.Size(237, 21);
            this.tbPrice5.TabIndex = 11;
            // 
            // tbPrice4
            // 
            this.tbPrice4._PasswordChar = '\0';
            this.tbPrice4._Value = "";
            this.tbPrice4._XPath = null;
            this.tbPrice4.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice4.Location = new System.Drawing.Point(419, 180);
            this.tbPrice4.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice4.Name = "tbPrice4";
            this.tbPrice4.Size = new System.Drawing.Size(237, 21);
            this.tbPrice4.TabIndex = 10;
            // 
            // tbPrice3
            // 
            this.tbPrice3._PasswordChar = '\0';
            this.tbPrice3._Value = "";
            this.tbPrice3._XPath = null;
            this.tbPrice3.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice3.Location = new System.Drawing.Point(74, 180);
            this.tbPrice3.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice3.Name = "tbPrice3";
            this.tbPrice3.Size = new System.Drawing.Size(237, 21);
            this.tbPrice3.TabIndex = 9;
            // 
            // tbPrice2
            // 
            this.tbPrice2._PasswordChar = '\0';
            this.tbPrice2._Value = "";
            this.tbPrice2._XPath = null;
            this.tbPrice2.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice2.Location = new System.Drawing.Point(419, 153);
            this.tbPrice2.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice2.Name = "tbPrice2";
            this.tbPrice2.Size = new System.Drawing.Size(237, 21);
            this.tbPrice2.TabIndex = 8;
            // 
            // tbPrice1
            // 
            this.tbPrice1._PasswordChar = '\0';
            this.tbPrice1._Value = "";
            this.tbPrice1._XPath = null;
            this.tbPrice1.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPrice1.Location = new System.Drawing.Point(74, 153);
            this.tbPrice1.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPrice1.Name = "tbPrice1";
            this.tbPrice1.Size = new System.Drawing.Size(237, 21);
            this.tbPrice1.TabIndex = 7;
            // 
            // tbDetail
            // 
            this.tbDetail._Value = "";
            this.tbDetail._XPath = null;
            this.tbDetail.Location = new System.Drawing.Point(74, 288);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(237, 62);
            this.tbDetail.TabIndex = 17;
            // 
            // tbPOV
            // 
            this.tbPOV._PasswordChar = '\0';
            this.tbPOV._Value = "";
            this.tbPOV._XPath = null;
            this.tbPOV.BackColor = System.Drawing.Color.Transparent;
            this.tbPOV.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPOV.Location = new System.Drawing.Point(419, 288);
            this.tbPOV.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPOV.Name = "tbPOV";
            this.tbPOV.Size = new System.Drawing.Size(237, 21);
            this.tbPOV.TabIndex = 18;
            // 
            // tbProdName
            // 
            this.tbProdName._PasswordChar = '\0';
            this.tbProdName._Value = "";
            this.tbProdName._XPath = null;
            this.tbProdName.BackColor = System.Drawing.Color.Transparent;
            this.tbProdName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbProdName.Location = new System.Drawing.Point(419, 41);
            this.tbProdName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(237, 21);
            this.tbProdName.TabIndex = 2;
            // 
            // ucMCPI1
            // 
            this.ucMCPI1.Location = new System.Drawing.Point(370, 323);
            this.ucMCPI1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMCPI1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMCPI1.Name = "ucMCPI1";
            this.ucMCPI1.Size = new System.Drawing.Size(24, 27);
            this.ucMCPI1.TabIndex = 42;
            this.ucMCPI1.Visible = false;
            // 
            // tbProdCode
            // 
            this.tbProdCode._PasswordChar = '\0';
            this.tbProdCode._Value = "";
            this.tbProdCode._XPath = null;
            this.tbProdCode.BackColor = System.Drawing.Color.Transparent;
            this.tbProdCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbProdCode.Location = new System.Drawing.Point(74, 41);
            this.tbProdCode.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbProdCode.Name = "tbProdCode";
            this.tbProdCode.Size = new System.Drawing.Size(237, 21);
            this.tbProdCode.TabIndex = 1;
            // 
            // frmProductRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 518);
            this.Controls.Add(this.ucDataGridView1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbWarehouse);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbProdUnit);
            this.Controls.Add(this.cbProdCat);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.cbProdGroup);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrice10);
            this.Controls.Add(this.tbPrice9);
            this.Controls.Add(this.tbPrice8);
            this.Controls.Add(this.tbPrice7);
            this.Controls.Add(this.tbPrice6);
            this.Controls.Add(this.tbPrice5);
            this.Controls.Add(this.tbPrice4);
            this.Controls.Add(this.tbPrice3);
            this.Controls.Add(this.tbPrice2);
            this.Controls.Add(this.tbPrice1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDetail);
            this.Controls.Add(this.tbPOV);
            this.Controls.Add(this.tbProdName);
            this.Controls.Add(this.ucMCPI1);
            this.Controls.Add(this.btPIClose);
            this.Controls.Add(this.btPISave);
            this.Controls.Add(this.tbProdCode);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProductRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ข้อมูลสินค้า (เฮงทวีค้าไม้)";
            this.Load += new System.EventHandler(this.frmProductRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private ToolsDocument.ucTextBox tbProdCode;
        private System.Windows.Forms.Button btPISave;
        private System.Windows.Forms.Button btPIClose;
        private ToolsDocument.ucMappingControls ucMCPI1;
        private ToolsDocument.ucTextBox tbProdName;
        private ToolsDocument.ucTextBox tbPOV;
        private ToolsDocument.ucRichTextBox tbDetail;
        private System.Windows.Forms.Label label2;
        private ToolsDocument.ucTextBox tbPrice1;
        private ToolsDocument.ucTextBox tbPrice2;
        private ToolsDocument.ucTextBox tbPrice3;
        private ToolsDocument.ucTextBox tbPrice4;
        private ToolsDocument.ucTextBox tbPrice5;
        private ToolsDocument.ucTextBox tbPrice6;
        private ToolsDocument.ucTextBox tbPrice7;
        private ToolsDocument.ucTextBox tbPrice8;
        private ToolsDocument.ucTextBox tbPrice9;
        private ToolsDocument.ucTextBox tbPrice10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblUser;
        private ToolsDocument.ucComboBox cbProdGroup;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private ToolsDocument.ucComboBox cbProdCat;
        private ToolsDocument.ucComboBox cbProdUnit;
        private System.Windows.Forms.Label label18;
        private ToolsDocument.ucComboBox cbWarehouse;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private ToolsDocument.ucDataGridView ucDataGridView1;

    }
}