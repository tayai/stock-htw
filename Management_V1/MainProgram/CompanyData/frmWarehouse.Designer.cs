namespace CompanyData
{
    partial class frmWarehouse
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbWareName = new ToolsDocument.ucTextBox();
            this.tbWareAddress = new ToolsDocument.ucTextBox();
            this.tbWareTel = new ToolsDocument.ucTextBox();
            this.tbWareFax = new ToolsDocument.ucTextBox();
            this.tbWareDetail = new ToolsDocument.ucRichTextBox();
            this.btWareClose = new System.Windows.Forms.Button();
            this.btWareSave = new System.Windows.Forms.Button();
            this.mpWarehouse1 = new ToolsDocument.ucMappingControls();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อคลังสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ที่อยู่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "เบอร์โทรศัพท์";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "เบอร์แฟกซ์";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "รายละเอียด";
            // 
            // tbWareName
            // 
            this.tbWareName._PasswordChar = '\0';
            this.tbWareName._Value = "";
            this.tbWareName._XPath = null;
            this.tbWareName.BackColor = System.Drawing.Color.Transparent;
            this.tbWareName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbWareName.Location = new System.Drawing.Point(114, 45);
            this.tbWareName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbWareName.Name = "tbWareName";
            this.tbWareName.Size = new System.Drawing.Size(237, 21);
            this.tbWareName.TabIndex = 5;
            // 
            // tbWareAddress
            // 
            this.tbWareAddress._PasswordChar = '\0';
            this.tbWareAddress._Value = "";
            this.tbWareAddress._XPath = null;
            this.tbWareAddress.BackColor = System.Drawing.Color.Transparent;
            this.tbWareAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbWareAddress.Location = new System.Drawing.Point(114, 82);
            this.tbWareAddress.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbWareAddress.Name = "tbWareAddress";
            this.tbWareAddress.Size = new System.Drawing.Size(237, 21);
            this.tbWareAddress.TabIndex = 6;
            // 
            // tbWareTel
            // 
            this.tbWareTel._PasswordChar = '\0';
            this.tbWareTel._Value = "";
            this.tbWareTel._XPath = null;
            this.tbWareTel.BackColor = System.Drawing.Color.Transparent;
            this.tbWareTel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbWareTel.Location = new System.Drawing.Point(114, 119);
            this.tbWareTel.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbWareTel.Name = "tbWareTel";
            this.tbWareTel.Size = new System.Drawing.Size(237, 21);
            this.tbWareTel.TabIndex = 7;
            // 
            // tbWareFax
            // 
            this.tbWareFax._PasswordChar = '\0';
            this.tbWareFax._Value = "";
            this.tbWareFax._XPath = null;
            this.tbWareFax.BackColor = System.Drawing.Color.Transparent;
            this.tbWareFax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbWareFax.Location = new System.Drawing.Point(114, 155);
            this.tbWareFax.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbWareFax.Name = "tbWareFax";
            this.tbWareFax.Size = new System.Drawing.Size(237, 21);
            this.tbWareFax.TabIndex = 8;
            // 
            // tbWareDetail
            // 
            this.tbWareDetail._Value = "";
            this.tbWareDetail._XPath = null;
            this.tbWareDetail.Location = new System.Drawing.Point(114, 192);
            this.tbWareDetail.Name = "tbWareDetail";
            this.tbWareDetail.Size = new System.Drawing.Size(237, 87);
            this.tbWareDetail.TabIndex = 9;
            // 
            // btWareClose
            // 
            this.btWareClose.Location = new System.Drawing.Point(276, 312);
            this.btWareClose.Name = "btWareClose";
            this.btWareClose.Size = new System.Drawing.Size(75, 23);
            this.btWareClose.TabIndex = 10;
            this.btWareClose.Text = "Close";
            this.btWareClose.UseVisualStyleBackColor = true;
            this.btWareClose.Click += new System.EventHandler(this.btWareClose_Click);
            // 
            // btWareSave
            // 
            this.btWareSave.Location = new System.Drawing.Point(182, 312);
            this.btWareSave.Name = "btWareSave";
            this.btWareSave.Size = new System.Drawing.Size(75, 23);
            this.btWareSave.TabIndex = 11;
            this.btWareSave.Text = "Save";
            this.btWareSave.UseVisualStyleBackColor = true;
            this.btWareSave.Click += new System.EventHandler(this.btWareSave_Click);
            // 
            // mpWarehouse1
            // 
            this.mpWarehouse1.Location = new System.Drawing.Point(27, 308);
            this.mpWarehouse1.MaximumSize = new System.Drawing.Size(24, 27);
            this.mpWarehouse1.MinimumSize = new System.Drawing.Size(24, 27);
            this.mpWarehouse1.Name = "mpWarehouse1";
            this.mpWarehouse1.Size = new System.Drawing.Size(24, 27);
            this.mpWarehouse1.TabIndex = 12;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "USER : ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(179, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.Text = "DateTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 362);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.mpWarehouse1);
            this.Controls.Add(this.btWareSave);
            this.Controls.Add(this.btWareClose);
            this.Controls.Add(this.tbWareDetail);
            this.Controls.Add(this.tbWareFax);
            this.Controls.Add(this.tbWareTel);
            this.Controls.Add(this.tbWareAddress);
            this.Controls.Add(this.tbWareName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "คลังสินค้า";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ToolsDocument.ucTextBox tbWareName;
        private ToolsDocument.ucTextBox tbWareAddress;
        private ToolsDocument.ucTextBox tbWareTel;
        private ToolsDocument.ucTextBox tbWareFax;
        private ToolsDocument.ucRichTextBox tbWareDetail;
        private System.Windows.Forms.Button btWareClose;
        private System.Windows.Forms.Button btWareSave;
        private ToolsDocument.ucMappingControls mpWarehouse1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}