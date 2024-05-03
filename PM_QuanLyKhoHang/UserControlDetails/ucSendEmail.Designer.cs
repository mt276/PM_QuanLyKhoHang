namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucSendEmail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.gcSendEmail = new DevExpress.XtraEditors.GroupControl();
            this.lbCharacter = new DevExpress.XtraEditors.LabelControl();
            this.cbEmail = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbIsContent = new DevExpress.XtraEditors.LabelControl();
            this.lbIsTitle = new DevExpress.XtraEditors.LabelControl();
            this.lbIsRecipient = new DevExpress.XtraEditors.LabelControl();
            this.lbIsPassword = new DevExpress.XtraEditors.LabelControl();
            this.lbIsSendEmail = new DevExpress.XtraEditors.LabelControl();
            this.btnExits = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lbContent = new DevExpress.XtraEditors.LabelControl();
            this.lbTitle = new DevExpress.XtraEditors.LabelControl();
            this.lbRecipient = new DevExpress.XtraEditors.LabelControl();
            this.lbPassword = new DevExpress.XtraEditors.LabelControl();
            this.lbSendEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtSupportEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtSendEmail = new DevExpress.XtraEditors.TextEdit();
            this.mmedContent = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSendEmail)).BeginInit();
            this.gcSendEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupportEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedContent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gcSendEmail);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1194, 508);
            this.pnlMain.TabIndex = 0;
            // 
            // gcSendEmail
            // 
            this.gcSendEmail.Controls.Add(this.lbCharacter);
            this.gcSendEmail.Controls.Add(this.cbEmail);
            this.gcSendEmail.Controls.Add(this.lbIsContent);
            this.gcSendEmail.Controls.Add(this.lbIsTitle);
            this.gcSendEmail.Controls.Add(this.lbIsRecipient);
            this.gcSendEmail.Controls.Add(this.lbIsPassword);
            this.gcSendEmail.Controls.Add(this.lbIsSendEmail);
            this.gcSendEmail.Controls.Add(this.btnExits);
            this.gcSendEmail.Controls.Add(this.btnOK);
            this.gcSendEmail.Controls.Add(this.lbContent);
            this.gcSendEmail.Controls.Add(this.lbTitle);
            this.gcSendEmail.Controls.Add(this.lbRecipient);
            this.gcSendEmail.Controls.Add(this.lbPassword);
            this.gcSendEmail.Controls.Add(this.lbSendEmail);
            this.gcSendEmail.Controls.Add(this.txtTitle);
            this.gcSendEmail.Controls.Add(this.txtSupportEmail);
            this.gcSendEmail.Controls.Add(this.txtPassword);
            this.gcSendEmail.Controls.Add(this.txtSendEmail);
            this.gcSendEmail.Controls.Add(this.mmedContent);
            this.gcSendEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSendEmail.Location = new System.Drawing.Point(2, 2);
            this.gcSendEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcSendEmail.Name = "gcSendEmail";
            this.gcSendEmail.Size = new System.Drawing.Size(1190, 504);
            this.gcSendEmail.TabIndex = 0;
            this.gcSendEmail.Text = "Gửi Email Admin";
            // 
            // lbCharacter
            // 
            this.lbCharacter.Location = new System.Drawing.Point(567, 85);
            this.lbCharacter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCharacter.Name = "lbCharacter";
            this.lbCharacter.Size = new System.Drawing.Size(15, 19);
            this.lbCharacter.TabIndex = 36;
            this.lbCharacter.Text = "@";
            // 
            // cbEmail
            // 
            this.cbEmail.EditValue = "gmail.com";
            this.cbEmail.Location = new System.Drawing.Point(588, 80);
            this.cbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEmail.Properties.Items.AddRange(new object[] {
            "yahoo.com",
            "gmail.com"});
            this.cbEmail.Size = new System.Drawing.Size(120, 26);
            this.cbEmail.TabIndex = 1;
            // 
            // lbIsContent
            // 
            this.lbIsContent.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbIsContent.Appearance.Options.UseForeColor = true;
            this.lbIsContent.Location = new System.Drawing.Point(912, 322);
            this.lbIsContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbIsContent.Name = "lbIsContent";
            this.lbIsContent.Size = new System.Drawing.Size(9, 19);
            this.lbIsContent.TabIndex = 34;
            this.lbIsContent.Text = "*";
            this.lbIsContent.Visible = false;
            // 
            // lbIsTitle
            // 
            this.lbIsTitle.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbIsTitle.Appearance.Options.UseForeColor = true;
            this.lbIsTitle.Location = new System.Drawing.Point(912, 205);
            this.lbIsTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbIsTitle.Name = "lbIsTitle";
            this.lbIsTitle.Size = new System.Drawing.Size(9, 19);
            this.lbIsTitle.TabIndex = 33;
            this.lbIsTitle.Text = "*";
            this.lbIsTitle.Visible = false;
            // 
            // lbIsRecipient
            // 
            this.lbIsRecipient.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbIsRecipient.Appearance.Options.UseForeColor = true;
            this.lbIsRecipient.Location = new System.Drawing.Point(717, 165);
            this.lbIsRecipient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbIsRecipient.Name = "lbIsRecipient";
            this.lbIsRecipient.Size = new System.Drawing.Size(9, 19);
            this.lbIsRecipient.TabIndex = 31;
            this.lbIsRecipient.Text = "*";
            this.lbIsRecipient.Visible = false;
            // 
            // lbIsPassword
            // 
            this.lbIsPassword.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbIsPassword.Appearance.Options.UseForeColor = true;
            this.lbIsPassword.Location = new System.Drawing.Point(717, 125);
            this.lbIsPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbIsPassword.Name = "lbIsPassword";
            this.lbIsPassword.Size = new System.Drawing.Size(9, 19);
            this.lbIsPassword.TabIndex = 30;
            this.lbIsPassword.Text = "*";
            this.lbIsPassword.Visible = false;
            // 
            // lbIsSendEmail
            // 
            this.lbIsSendEmail.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbIsSendEmail.Appearance.Options.UseForeColor = true;
            this.lbIsSendEmail.Location = new System.Drawing.Point(717, 85);
            this.lbIsSendEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbIsSendEmail.Name = "lbIsSendEmail";
            this.lbIsSendEmail.Size = new System.Drawing.Size(9, 19);
            this.lbIsSendEmail.TabIndex = 29;
            this.lbIsSendEmail.Text = "*";
            this.lbIsSendEmail.Visible = false;
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(790, 422);
            this.btnExits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(112, 35);
            this.btnExits.TabIndex = 7;
            this.btnExits.Text = "&Thoát";
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(614, 422);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Gửi Email";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbContent
            // 
            this.lbContent.Location = new System.Drawing.Point(218, 245);
            this.lbContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(73, 19);
            this.lbContent.TabIndex = 17;
            this.lbContent.Text = "Nội Dung:";
            // 
            // lbTitle
            // 
            this.lbTitle.Location = new System.Drawing.Point(218, 205);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(130, 19);
            this.lbTitle.TabIndex = 16;
            this.lbTitle.Text = "Tiêu Đề (Subject:)";
            // 
            // lbRecipient
            // 
            this.lbRecipient.Location = new System.Drawing.Point(218, 165);
            this.lbRecipient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbRecipient.Name = "lbRecipient";
            this.lbRecipient.Size = new System.Drawing.Size(131, 19);
            this.lbRecipient.TabIndex = 15;
            this.lbRecipient.Text = "Email người nhận:";
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(218, 125);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(71, 19);
            this.lbPassword.TabIndex = 20;
            this.lbPassword.Text = "Mật Khẩu:";
            // 
            // lbSendEmail
            // 
            this.lbSendEmail.Location = new System.Drawing.Point(218, 85);
            this.lbSendEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSendEmail.Name = "lbSendEmail";
            this.lbSendEmail.Size = new System.Drawing.Size(73, 19);
            this.lbSendEmail.TabIndex = 18;
            this.lbSendEmail.Text = "Email gửi:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(380, 200);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(524, 26);
            this.txtTitle.TabIndex = 4;
            // 
            // txtSupportEmail
            // 
            this.txtSupportEmail.EditValue = "minhtrieu02101@gmail.com";
            this.txtSupportEmail.Enabled = false;
            this.txtSupportEmail.Location = new System.Drawing.Point(380, 160);
            this.txtSupportEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupportEmail.Name = "txtSupportEmail";
            this.txtSupportEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSupportEmail.Properties.Appearance.Options.UseFont = true;
            this.txtSupportEmail.Size = new System.Drawing.Size(328, 28);
            this.txtSupportEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(380, 120);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(328, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // txtSendEmail
            // 
            this.txtSendEmail.Location = new System.Drawing.Point(380, 80);
            this.txtSendEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSendEmail.Name = "txtSendEmail";
            this.txtSendEmail.Size = new System.Drawing.Size(178, 26);
            toolTipTitleItem1.Text = "Email người gởi";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Nhập email người gởi\r\n";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.txtSendEmail.SuperTip = superToolTip1;
            this.txtSendEmail.TabIndex = 0;
            // 
            // mmedContent
            // 
            this.mmedContent.Location = new System.Drawing.Point(380, 240);
            this.mmedContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mmedContent.Name = "mmedContent";
            this.mmedContent.Size = new System.Drawing.Size(524, 172);
            this.mmedContent.TabIndex = 5;
            // 
            // ucSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucSendEmail";
            this.Size = new System.Drawing.Size(1194, 508);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSendEmail)).EndInit();
            this.gcSendEmail.ResumeLayout(false);
            this.gcSendEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupportEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedContent.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.GroupControl gcSendEmail;
        private DevExpress.XtraEditors.LabelControl lbCharacter;
        private DevExpress.XtraEditors.ComboBoxEdit cbEmail;
        private DevExpress.XtraEditors.LabelControl lbIsContent;
        private DevExpress.XtraEditors.LabelControl lbIsTitle;
        private DevExpress.XtraEditors.LabelControl lbIsRecipient;
        private DevExpress.XtraEditors.LabelControl lbIsPassword;
        private DevExpress.XtraEditors.LabelControl lbIsSendEmail;
        private DevExpress.XtraEditors.SimpleButton btnExits;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl lbContent;
        private DevExpress.XtraEditors.LabelControl lbTitle;
        private DevExpress.XtraEditors.LabelControl lbRecipient;
        private DevExpress.XtraEditors.LabelControl lbPassword;
        private DevExpress.XtraEditors.LabelControl lbSendEmail;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.TextEdit txtSupportEmail;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtSendEmail;
        private DevExpress.XtraEditors.MemoEdit mmedContent;
    }
}
