namespace CompanyData
{
    partial class frmProductType
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
            this.tbPTName = new ToolsDocument.ucTextBox();
            this.tbPTDetail = new ToolsDocument.ucRichTextBox();
            this.ucMPPT1 = new ToolsDocument.ucMappingControls();
            this.btPTSave = new System.Windows.Forms.Button();
            this.btPTClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อชนิดสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "รายละเอียด";
            // 
            // tbPTName
            // 
            this.tbPTName._PasswordChar = '\0';
            this.tbPTName._Value = "";
            this.tbPTName._XPath = null;
            this.tbPTName.BackColor = System.Drawing.Color.Transparent;
            this.tbPTName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPTName.Location = new System.Drawing.Point(121, 21);
            this.tbPTName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPTName.Name = "tbPTName";
            this.tbPTName.Size = new System.Drawing.Size(237, 21);
            this.tbPTName.TabIndex = 2;
            // 
            // tbPTDetail
            // 
            this.tbPTDetail._Value = "";
            this.tbPTDetail._XPath = null;
            this.tbPTDetail.Location = new System.Drawing.Point(121, 63);
            this.tbPTDetail.Name = "tbPTDetail";
            this.tbPTDetail.Size = new System.Drawing.Size(237, 87);
            this.tbPTDetail.TabIndex = 3;
            // 
            // ucMPPT1
            // 
            this.ucMPPT1.Location = new System.Drawing.Point(29, 123);
            this.ucMPPT1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMPPT1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMPPT1.Name = "ucMPPT1";
            this.ucMPPT1.Size = new System.Drawing.Size(24, 27);
            this.ucMPPT1.TabIndex = 4;
            this.ucMPPT1.Visible = false;
            // 
            // btPTSave
            // 
            this.btPTSave.Location = new System.Drawing.Point(178, 181);
            this.btPTSave.Name = "btPTSave";
            this.btPTSave.Size = new System.Drawing.Size(75, 23);
            this.btPTSave.TabIndex = 5;
            this.btPTSave.Text = "Save";
            this.btPTSave.UseVisualStyleBackColor = true;
            this.btPTSave.Click += new System.EventHandler(this.btPTSave_Click);
            // 
            // btPTClose
            // 
            this.btPTClose.Location = new System.Drawing.Point(283, 181);
            this.btPTClose.Name = "btPTClose";
            this.btPTClose.Size = new System.Drawing.Size(75, 23);
            this.btPTClose.TabIndex = 6;
            this.btPTClose.Text = "Close";
            this.btPTClose.UseVisualStyleBackColor = true;
            this.btPTClose.Click += new System.EventHandler(this.btPTClose_Click);
            // 
            // frmProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 230);
            this.Controls.Add(this.btPTClose);
            this.Controls.Add(this.btPTSave);
            this.Controls.Add(this.ucMPPT1);
            this.Controls.Add(this.tbPTDetail);
            this.Controls.Add(this.tbPTName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProductType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ชนิดสินค้า";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ToolsDocument.ucTextBox tbPTName;
        private ToolsDocument.ucRichTextBox tbPTDetail;
        private ToolsDocument.ucMappingControls ucMPPT1;
        private System.Windows.Forms.Button btPTSave;
        private System.Windows.Forms.Button btPTClose;
    }
}