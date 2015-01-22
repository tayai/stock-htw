namespace CompanyData
{
    partial class frmTermPayment
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbPayType = new ToolsDocument.ucTextBox();
            this.tbDueDate = new ToolsDocument.ucTextBox();
            this.tbDetail = new ToolsDocument.ucRichTextBox();
            this.tbRemark = new ToolsDocument.ucRichTextBox();
            this.btTPSave = new System.Windows.Forms.Button();
            this.btTPClose = new System.Windows.Forms.Button();
            this.ucMCTP1 = new ToolsDocument.ucMappingControls();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ประเภทการชำระเงิน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "จำนวนวันที่ครบกำหนด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "รายละเอียด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "หมายเหตุ";
            // 
            // tbPayType
            // 
            this.tbPayType._PasswordChar = '\0';
            this.tbPayType._Value = "";
            this.tbPayType._XPath = null;
            this.tbPayType.BackColor = System.Drawing.Color.Transparent;
            this.tbPayType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPayType.Location = new System.Drawing.Point(164, 28);
            this.tbPayType.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPayType.Name = "tbPayType";
            this.tbPayType.Size = new System.Drawing.Size(237, 21);
            this.tbPayType.TabIndex = 4;
            // 
            // tbDueDate
            // 
            this.tbDueDate._PasswordChar = '\0';
            this.tbDueDate._Value = "";
            this.tbDueDate._XPath = null;
            this.tbDueDate.BackColor = System.Drawing.Color.Transparent;
            this.tbDueDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbDueDate.Location = new System.Drawing.Point(164, 55);
            this.tbDueDate.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbDueDate.Name = "tbDueDate";
            this.tbDueDate.Size = new System.Drawing.Size(237, 21);
            this.tbDueDate.TabIndex = 5;
            // 
            // tbDetail
            // 
            this.tbDetail._Value = "";
            this.tbDetail._XPath = null;
            this.tbDetail.Location = new System.Drawing.Point(164, 82);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(237, 55);
            this.tbDetail.TabIndex = 6;
            // 
            // tbRemark
            // 
            this.tbRemark._Value = "";
            this.tbRemark._XPath = null;
            this.tbRemark.Location = new System.Drawing.Point(164, 143);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(237, 59);
            this.tbRemark.TabIndex = 7;
            // 
            // btTPSave
            // 
            this.btTPSave.Location = new System.Drawing.Point(216, 232);
            this.btTPSave.Name = "btTPSave";
            this.btTPSave.Size = new System.Drawing.Size(75, 23);
            this.btTPSave.TabIndex = 8;
            this.btTPSave.Text = "Save";
            this.btTPSave.UseVisualStyleBackColor = true;
            this.btTPSave.Click += new System.EventHandler(this.btTPSave_Click);
            // 
            // btTPClose
            // 
            this.btTPClose.Location = new System.Drawing.Point(326, 232);
            this.btTPClose.Name = "btTPClose";
            this.btTPClose.Size = new System.Drawing.Size(75, 23);
            this.btTPClose.TabIndex = 9;
            this.btTPClose.Text = "Close";
            this.btTPClose.UseVisualStyleBackColor = true;
            this.btTPClose.Click += new System.EventHandler(this.btTPClose_Click);
            // 
            // ucMCTP1
            // 
            this.ucMCTP1.Location = new System.Drawing.Point(12, 6);
            this.ucMCTP1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMCTP1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMCTP1.Name = "ucMCTP1";
            this.ucMCTP1.Size = new System.Drawing.Size(24, 27);
            this.ucMCTP1.TabIndex = 10;
            this.ucMCTP1.Visible = false;
            // 
            // frmTermPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 285);
            this.Controls.Add(this.ucMCTP1);
            this.Controls.Add(this.btTPClose);
            this.Controls.Add(this.btTPSave);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.tbDetail);
            this.Controls.Add(this.tbDueDate);
            this.Controls.Add(this.tbPayType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTermPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เงื่อนไขการชำระเงิน";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ToolsDocument.ucTextBox tbPayType;
        private ToolsDocument.ucTextBox tbDueDate;
        private ToolsDocument.ucRichTextBox tbDetail;
        private ToolsDocument.ucRichTextBox tbRemark;
        private System.Windows.Forms.Button btTPSave;
        private System.Windows.Forms.Button btTPClose;
        private ToolsDocument.ucMappingControls ucMCTP1;
    }
}