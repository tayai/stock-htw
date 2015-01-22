namespace CompanyData
{
    partial class frmPartnerType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPName = new ToolsDocument.ucTextBox();
            this.tbPType = new ToolsDocument.ucTextBox();
            this.tbPDetail = new ToolsDocument.ucRichTextBox();
            this.btPTSave = new System.Windows.Forms.Button();
            this.btPTClose = new System.Windows.Forms.Button();
            this.ucMCPT1 = new ToolsDocument.ucMappingControls();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อคู่ค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ขนิดคู่ค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "รายละเอียด";
            // 
            // tbPName
            // 
            this.tbPName._PasswordChar = '\0';
            this.tbPName._Value = "";
            this.tbPName._XPath = null;
            this.tbPName.BackColor = System.Drawing.Color.Transparent;
            this.tbPName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPName.Location = new System.Drawing.Point(129, 18);
            this.tbPName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(237, 21);
            this.tbPName.TabIndex = 3;
            // 
            // tbPType
            // 
            this.tbPType._PasswordChar = '\0';
            this.tbPType._Value = "";
            this.tbPType._XPath = null;
            this.tbPType.BackColor = System.Drawing.Color.Transparent;
            this.tbPType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPType.Location = new System.Drawing.Point(129, 59);
            this.tbPType.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPType.Name = "tbPType";
            this.tbPType.Size = new System.Drawing.Size(237, 21);
            this.tbPType.TabIndex = 4;
            // 
            // tbPDetail
            // 
            this.tbPDetail._Value = "";
            this.tbPDetail._XPath = null;
            this.tbPDetail.Location = new System.Drawing.Point(129, 100);
            this.tbPDetail.Name = "tbPDetail";
            this.tbPDetail.Size = new System.Drawing.Size(237, 87);
            this.tbPDetail.TabIndex = 5;
            // 
            // btPTSave
            // 
            this.btPTSave.Location = new System.Drawing.Point(192, 216);
            this.btPTSave.Name = "btPTSave";
            this.btPTSave.Size = new System.Drawing.Size(75, 23);
            this.btPTSave.TabIndex = 6;
            this.btPTSave.Text = "Save";
            this.btPTSave.UseVisualStyleBackColor = true;
            this.btPTSave.Click += new System.EventHandler(this.btPTSave_Click);
            // 
            // btPTClose
            // 
            this.btPTClose.Location = new System.Drawing.Point(291, 216);
            this.btPTClose.Name = "btPTClose";
            this.btPTClose.Size = new System.Drawing.Size(75, 23);
            this.btPTClose.TabIndex = 7;
            this.btPTClose.Text = "Close";
            this.btPTClose.UseVisualStyleBackColor = true;
            this.btPTClose.Click += new System.EventHandler(this.btPTClose_Click);
            // 
            // ucMCPT1
            // 
            this.ucMCPT1.Location = new System.Drawing.Point(56, 160);
            this.ucMCPT1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMCPT1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMCPT1.Name = "ucMCPT1";
            this.ucMCPT1.Size = new System.Drawing.Size(24, 27);
            this.ucMCPT1.TabIndex = 8;
            this.ucMCPT1.Visible = false;
            // 
            // frmPartnerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 267);
            this.Controls.Add(this.ucMCPT1);
            this.Controls.Add(this.btPTClose);
            this.Controls.Add(this.btPTSave);
            this.Controls.Add(this.tbPDetail);
            this.Controls.Add(this.tbPType);
            this.Controls.Add(this.tbPName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPartnerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ชนิดคู่ค้า";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ToolsDocument.ucTextBox tbPName;
        private ToolsDocument.ucTextBox tbPType;
        private ToolsDocument.ucRichTextBox tbPDetail;
        private System.Windows.Forms.Button btPTSave;
        private System.Windows.Forms.Button btPTClose;
        private ToolsDocument.ucMappingControls ucMCPT1;
    }
}