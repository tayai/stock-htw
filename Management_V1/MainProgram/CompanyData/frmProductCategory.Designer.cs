namespace CompanyData
{
    partial class frmProductCategory
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
            this.tbPCName = new ToolsDocument.ucTextBox();
            this.tbPCDetail = new ToolsDocument.ucRichTextBox();
            this.btPCSave = new System.Windows.Forms.Button();
            this.btPCClose = new System.Windows.Forms.Button();
            this.ucMCPC1 = new ToolsDocument.ucMappingControls();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อหมวดหมู่สินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "รายละเอียด";
            // 
            // tbPCName
            // 
            this.tbPCName._PasswordChar = '\0';
            this.tbPCName._Value = "";
            this.tbPCName._XPath = null;
            this.tbPCName.BackColor = System.Drawing.Color.Transparent;
            this.tbPCName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPCName.Location = new System.Drawing.Point(105, 39);
            this.tbPCName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPCName.Name = "tbPCName";
            this.tbPCName.Size = new System.Drawing.Size(237, 21);
            this.tbPCName.TabIndex = 2;
            // 
            // tbPCDetail
            // 
            this.tbPCDetail._Value = "";
            this.tbPCDetail._XPath = null;
            this.tbPCDetail.Location = new System.Drawing.Point(105, 84);
            this.tbPCDetail.Name = "tbPCDetail";
            this.tbPCDetail.Size = new System.Drawing.Size(237, 98);
            this.tbPCDetail.TabIndex = 3;
            // 
            // btPCSave
            // 
            this.btPCSave.Location = new System.Drawing.Point(159, 202);
            this.btPCSave.Name = "btPCSave";
            this.btPCSave.Size = new System.Drawing.Size(75, 23);
            this.btPCSave.TabIndex = 4;
            this.btPCSave.Text = "Save";
            this.btPCSave.UseVisualStyleBackColor = true;
            this.btPCSave.Click += new System.EventHandler(this.btPCSave_Click);
            // 
            // btPCClose
            // 
            this.btPCClose.Location = new System.Drawing.Point(267, 202);
            this.btPCClose.Name = "btPCClose";
            this.btPCClose.Size = new System.Drawing.Size(75, 23);
            this.btPCClose.TabIndex = 5;
            this.btPCClose.Text = "Close";
            this.btPCClose.UseVisualStyleBackColor = true;
            this.btPCClose.Click += new System.EventHandler(this.btPCClose_Click);
            // 
            // ucMCPC1
            // 
            this.ucMCPC1.Location = new System.Drawing.Point(29, 150);
            this.ucMCPC1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMCPC1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMCPC1.Name = "ucMCPC1";
            this.ucMCPC1.Size = new System.Drawing.Size(24, 27);
            this.ucMCPC1.TabIndex = 6;
            this.ucMCPC1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.lblDateTime.Location = new System.Drawing.Point(146, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "DateTime";
            // 
            // frmProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 245);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.ucMCPC1);
            this.Controls.Add(this.btPCClose);
            this.Controls.Add(this.btPCSave);
            this.Controls.Add(this.tbPCDetail);
            this.Controls.Add(this.tbPCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "หมวดหมู่สินค้า";
            this.Load += new System.EventHandler(this.frmProductCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ToolsDocument.ucTextBox tbPCName;
        private ToolsDocument.ucRichTextBox tbPCDetail;
        private System.Windows.Forms.Button btPCSave;
        private System.Windows.Forms.Button btPCClose;
        private ToolsDocument.ucMappingControls ucMCPC1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
    }
}