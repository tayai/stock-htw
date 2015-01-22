namespace ProductType
{
    partial class Form1
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
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.ucMappingControls1 = new ToolsDocument.ucMappingControls();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อชนิดสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
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
            this.tbPTName.Location = new System.Drawing.Point(115, 22);
            this.tbPTName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPTName.Name = "tbPTName";
            this.tbPTName.Size = new System.Drawing.Size(237, 21);
            this.tbPTName.TabIndex = 2;
            // 
            // tbPTDetail
            // 
            this.tbPTDetail._Value = "";
            this.tbPTDetail._XPath = null;
            this.tbPTDetail.Location = new System.Drawing.Point(115, 49);
            this.tbPTDetail.Name = "tbPTDetail";
            this.tbPTDetail.Size = new System.Drawing.Size(237, 59);
            this.tbPTDetail.TabIndex = 3;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(115, 141);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(277, 141);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ucMappingControls1
            // 
            this.ucMappingControls1.Location = new System.Drawing.Point(35, 100);
            this.ucMappingControls1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.Name = "ucMappingControls1";
            this.ucMappingControls1.Size = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.TabIndex = 6;
            this.ucMappingControls1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 178);
            this.Controls.Add(this.ucMappingControls1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbPTDetail);
            this.Controls.Add(this.tbPTName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ชนิดสินค้า";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ToolsDocument.ucTextBox tbPTName;
        private ToolsDocument.ucRichTextBox tbPTDetail;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private ToolsDocument.ucMappingControls ucMappingControls1;
    }
}

