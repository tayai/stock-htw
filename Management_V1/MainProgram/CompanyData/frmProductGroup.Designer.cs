namespace CompanyData
{
    partial class frmProductGroup
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
            this.tbPGName = new ToolsDocument.ucTextBox();
            this.tbPGDetail = new ToolsDocument.ucRichTextBox();
            this.btPGSave = new System.Windows.Forms.Button();
            this.btPGClose = new System.Windows.Forms.Button();
            this.ucMPCPG1 = new ToolsDocument.ucMappingControls();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อกลุ่มสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "รายละเอียด";
            // 
            // tbPGName
            // 
            this.tbPGName._PasswordChar = '\0';
            this.tbPGName._Value = "";
            this.tbPGName._XPath = null;
            this.tbPGName.BackColor = System.Drawing.Color.Transparent;
            this.tbPGName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPGName.Location = new System.Drawing.Point(104, 50);
            this.tbPGName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPGName.Name = "tbPGName";
            this.tbPGName.Size = new System.Drawing.Size(237, 21);
            this.tbPGName.TabIndex = 2;
            // 
            // tbPGDetail
            // 
            this.tbPGDetail._Value = "";
            this.tbPGDetail._XPath = null;
            this.tbPGDetail.Location = new System.Drawing.Point(104, 93);
            this.tbPGDetail.Name = "tbPGDetail";
            this.tbPGDetail.Size = new System.Drawing.Size(237, 87);
            this.tbPGDetail.TabIndex = 3;
            // 
            // btPGSave
            // 
            this.btPGSave.Location = new System.Drawing.Point(155, 203);
            this.btPGSave.Name = "btPGSave";
            this.btPGSave.Size = new System.Drawing.Size(75, 23);
            this.btPGSave.TabIndex = 4;
            this.btPGSave.Text = "Save";
            this.btPGSave.UseVisualStyleBackColor = true;
            this.btPGSave.Click += new System.EventHandler(this.btPGSave_Click);
            // 
            // btPGClose
            // 
            this.btPGClose.Location = new System.Drawing.Point(266, 203);
            this.btPGClose.Name = "btPGClose";
            this.btPGClose.Size = new System.Drawing.Size(75, 23);
            this.btPGClose.TabIndex = 5;
            this.btPGClose.Text = "Close";
            this.btPGClose.UseVisualStyleBackColor = true;
            this.btPGClose.Click += new System.EventHandler(this.btPGClose_Click);
            // 
            // ucMPCPG1
            // 
            this.ucMPCPG1.Location = new System.Drawing.Point(21, 179);
            this.ucMPCPG1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMPCPG1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMPCPG1.Name = "ucMPCPG1";
            this.ucMPCPG1.Size = new System.Drawing.Size(24, 27);
            this.ucMPCPG1.TabIndex = 6;
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
            this.lblDateTime.Location = new System.Drawing.Point(152, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "DateTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmProductGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 248);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.ucMPCPG1);
            this.Controls.Add(this.btPGClose);
            this.Controls.Add(this.btPGSave);
            this.Controls.Add(this.tbPGDetail);
            this.Controls.Add(this.tbPGName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProductGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "กลุ่มสินค้า";
            this.Load += new System.EventHandler(this.frmProductGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ToolsDocument.ucTextBox tbPGName;
        private ToolsDocument.ucRichTextBox tbPGDetail;
        private System.Windows.Forms.Button btPGSave;
        private System.Windows.Forms.Button btPGClose;
        private ToolsDocument.ucMappingControls ucMPCPG1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}