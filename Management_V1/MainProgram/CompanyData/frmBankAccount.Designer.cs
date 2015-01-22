namespace CompanyData
{
    partial class frmBankAccount
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tbBankName = new ToolsDocument.ucTextBox();
            this.tbBankDetail = new ToolsDocument.ucRichTextBox();
            this.mpBank1 = new ToolsDocument.ucMappingControls();
            this.btBankSave = new System.Windows.Forms.Button();
            this.btBankClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อธนาคาร";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "รายละเอียด";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User : ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(127, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "DateTime";
            // 
            // tbBankName
            // 
            this.tbBankName._PasswordChar = '\0';
            this.tbBankName._Value = "";
            this.tbBankName._XPath = null;
            this.tbBankName.BackColor = System.Drawing.Color.Transparent;
            this.tbBankName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbBankName.Location = new System.Drawing.Point(98, 55);
            this.tbBankName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbBankName.Name = "tbBankName";
            this.tbBankName.Size = new System.Drawing.Size(237, 21);
            this.tbBankName.TabIndex = 4;
            // 
            // tbBankDetail
            // 
            this.tbBankDetail._Value = "";
            this.tbBankDetail._XPath = null;
            this.tbBankDetail.Location = new System.Drawing.Point(98, 98);
            this.tbBankDetail.Name = "tbBankDetail";
            this.tbBankDetail.Size = new System.Drawing.Size(237, 63);
            this.tbBankDetail.TabIndex = 5;
            // 
            // mpBank1
            // 
            this.mpBank1.Location = new System.Drawing.Point(15, 194);
            this.mpBank1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mpBank1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mpBank1.Name = "mpBank1";
            this.mpBank1.Size = new System.Drawing.Size(24, 27);
            this.mpBank1.TabIndex = 6;
            // 
            // btBankSave
            // 
            this.btBankSave.Location = new System.Drawing.Point(146, 182);
            this.btBankSave.Name = "btBankSave";
            this.btBankSave.Size = new System.Drawing.Size(75, 23);
            this.btBankSave.TabIndex = 7;
            this.btBankSave.Text = "Save";
            this.btBankSave.UseVisualStyleBackColor = true;
            this.btBankSave.Click += new System.EventHandler(this.btBankSave_Click);
            // 
            // btBankClose
            // 
            this.btBankClose.Location = new System.Drawing.Point(246, 182);
            this.btBankClose.Name = "btBankClose";
            this.btBankClose.Size = new System.Drawing.Size(75, 23);
            this.btBankClose.TabIndex = 8;
            this.btBankClose.Text = "Close";
            this.btBankClose.UseVisualStyleBackColor = true;
            this.btBankClose.Click += new System.EventHandler(this.btBankClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            // 
            // frmBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 233);
            this.Controls.Add(this.btBankClose);
            this.Controls.Add(this.btBankSave);
            this.Controls.Add(this.mpBank1);
            this.Controls.Add(this.tbBankDetail);
            this.Controls.Add(this.tbBankName);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBankAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account (เฮงทวีค้าไม้)";
            this.Load += new System.EventHandler(this.frmBankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private ToolsDocument.ucTextBox tbBankName;
        private ToolsDocument.ucRichTextBox tbBankDetail;
        private ToolsDocument.ucMappingControls mpBank1;
        private System.Windows.Forms.Button btBankSave;
        private System.Windows.Forms.Button btBankClose;
        private System.Windows.Forms.Timer timer1;
    }
}