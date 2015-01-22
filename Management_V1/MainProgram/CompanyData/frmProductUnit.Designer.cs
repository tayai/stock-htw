namespace CompanyData
{
    partial class frmProductUnit
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
            this.tbAcronym = new ToolsDocument.ucTextBox();
            this.tbUnitName = new ToolsDocument.ucTextBox();
            this.tbSymbol = new ToolsDocument.ucTextBox();
            this.tbUnitDetail = new ToolsDocument.ucRichTextBox();
            this.btPUSave = new System.Windows.Forms.Button();
            this.btPUClose = new System.Windows.Forms.Button();
            this.ucMCPU1 = new ToolsDocument.ucMappingControls();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "อักษรย่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อหน่วยนับ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "สัญลักษณ์";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "รายละเอียด";
            // 
            // tbAcronym
            // 
            this.tbAcronym._PasswordChar = '\0';
            this.tbAcronym._Value = "";
            this.tbAcronym._XPath = null;
            this.tbAcronym.BackColor = System.Drawing.Color.Transparent;
            this.tbAcronym.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbAcronym.Location = new System.Drawing.Point(101, 51);
            this.tbAcronym.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbAcronym.Name = "tbAcronym";
            this.tbAcronym.Size = new System.Drawing.Size(237, 21);
            this.tbAcronym.TabIndex = 4;
            // 
            // tbUnitName
            // 
            this.tbUnitName._PasswordChar = '\0';
            this.tbUnitName._Value = "";
            this.tbUnitName._XPath = null;
            this.tbUnitName.BackColor = System.Drawing.Color.Transparent;
            this.tbUnitName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUnitName.Location = new System.Drawing.Point(101, 78);
            this.tbUnitName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbUnitName.Name = "tbUnitName";
            this.tbUnitName.Size = new System.Drawing.Size(237, 21);
            this.tbUnitName.TabIndex = 5;
            // 
            // tbSymbol
            // 
            this.tbSymbol._PasswordChar = '\0';
            this.tbSymbol._Value = "";
            this.tbSymbol._XPath = null;
            this.tbSymbol.BackColor = System.Drawing.Color.Transparent;
            this.tbSymbol.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSymbol.Location = new System.Drawing.Point(101, 105);
            this.tbSymbol.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbSymbol.Name = "tbSymbol";
            this.tbSymbol.Size = new System.Drawing.Size(237, 21);
            this.tbSymbol.TabIndex = 6;
            // 
            // tbUnitDetail
            // 
            this.tbUnitDetail._Value = "";
            this.tbUnitDetail._XPath = null;
            this.tbUnitDetail.Location = new System.Drawing.Point(101, 132);
            this.tbUnitDetail.Name = "tbUnitDetail";
            this.tbUnitDetail.Size = new System.Drawing.Size(237, 87);
            this.tbUnitDetail.TabIndex = 7;
            // 
            // btPUSave
            // 
            this.btPUSave.Location = new System.Drawing.Point(166, 241);
            this.btPUSave.Name = "btPUSave";
            this.btPUSave.Size = new System.Drawing.Size(75, 23);
            this.btPUSave.TabIndex = 8;
            this.btPUSave.Text = "Save";
            this.btPUSave.UseVisualStyleBackColor = true;
            this.btPUSave.Click += new System.EventHandler(this.btPUSave_Click);
            // 
            // btPUClose
            // 
            this.btPUClose.Location = new System.Drawing.Point(263, 241);
            this.btPUClose.Name = "btPUClose";
            this.btPUClose.Size = new System.Drawing.Size(75, 23);
            this.btPUClose.TabIndex = 9;
            this.btPUClose.Text = "Close";
            this.btPUClose.UseVisualStyleBackColor = true;
            this.btPUClose.Click += new System.EventHandler(this.btPUClose_Click);
            // 
            // ucMCPU1
            // 
            this.ucMCPU1.Location = new System.Drawing.Point(30, 241);
            this.ucMCPU1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMCPU1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMCPU1.Name = "ucMCPU1";
            this.ucMCPU1.Size = new System.Drawing.Size(24, 27);
            this.ucMCPU1.TabIndex = 10;
            this.ucMCPU1.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "USER : ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(151, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 12;
            this.lblDateTime.Text = "DateTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmProductUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 285);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.ucMCPU1);
            this.Controls.Add(this.btPUClose);
            this.Controls.Add(this.btPUSave);
            this.Controls.Add(this.tbUnitDetail);
            this.Controls.Add(this.tbSymbol);
            this.Controls.Add(this.tbUnitName);
            this.Controls.Add(this.tbAcronym);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProductUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "หน่วยนับ (เฮงทวีค้าไม้)";
            this.Load += new System.EventHandler(this.frmProductUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ToolsDocument.ucTextBox tbAcronym;
        private ToolsDocument.ucTextBox tbUnitName;
        private ToolsDocument.ucTextBox tbSymbol;
        private ToolsDocument.ucRichTextBox tbUnitDetail;
        private System.Windows.Forms.Button btPUSave;
        private System.Windows.Forms.Button btPUClose;
        private ToolsDocument.ucMappingControls ucMCPU1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}