namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucMyAccount
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
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.btnExits = new DevExpress.XtraEditors.SimpleButton();
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.txtRePass = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.lbRePass = new DevExpress.XtraEditors.LabelControl();
            this.lbNewPass = new DevExpress.XtraEditors.LabelControl();
            this.lblsRePass = new DevExpress.XtraEditors.LabelControl();
            this.lblsNewPass = new DevExpress.XtraEditors.LabelControl();
            this.lblsOldPass = new DevExpress.XtraEditors.LabelControl();
            this.lbOldPass = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lbUserName = new DevExpress.XtraEditors.LabelControl();
            this.lbTypeID = new DevExpress.XtraEditors.LabelControl();
            this.lbAddress = new DevExpress.XtraEditors.LabelControl();
            this.lbFullName = new DevExpress.XtraEditors.LabelControl();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtLocation = new DevExpress.XtraEditors.TextEdit();
            this.ptbMyAccount = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.gbChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMyAccount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnExits);
            this.pnlMain.Controls.Add(this.gbChangePassword);
            this.pnlMain.Controls.Add(this.lbUserName);
            this.pnlMain.Controls.Add(this.lbTypeID);
            this.pnlMain.Controls.Add(this.lbAddress);
            this.pnlMain.Controls.Add(this.lbFullName);
            this.pnlMain.Controls.Add(this.btnBrowse);
            this.pnlMain.Controls.Add(this.txtLocation);
            this.pnlMain.Controls.Add(this.ptbMyAccount);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1023, 555);
            this.pnlMain.TabIndex = 0;
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(900, 490);
            this.btnExits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(112, 35);
            this.btnExits.TabIndex = 5;
            this.btnExits.Text = "Thoát";
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Controls.Add(this.txtRePass);
            this.gbChangePassword.Controls.Add(this.txtNewPass);
            this.gbChangePassword.Controls.Add(this.lbRePass);
            this.gbChangePassword.Controls.Add(this.lbNewPass);
            this.gbChangePassword.Controls.Add(this.lblsRePass);
            this.gbChangePassword.Controls.Add(this.lblsNewPass);
            this.gbChangePassword.Controls.Add(this.lblsOldPass);
            this.gbChangePassword.Controls.Add(this.lbOldPass);
            this.gbChangePassword.Controls.Add(this.txtOldPass);
            this.gbChangePassword.Controls.Add(this.btnCancel);
            this.gbChangePassword.Controls.Add(this.btnUpdate);
            this.gbChangePassword.Location = new System.Drawing.Point(400, 250);
            this.gbChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChangePassword.Size = new System.Drawing.Size(620, 209);
            this.gbChangePassword.TabIndex = 4;
            this.gbChangePassword.TabStop = false;
            this.gbChangePassword.Text = "Thay đổi mật khẩu";
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(260, 110);
            this.txtRePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Properties.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(325, 26);
            this.txtRePass.TabIndex = 2;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(260, 70);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(325, 26);
            this.txtNewPass.TabIndex = 1;
            // 
            // lbRePass
            // 
            this.lbRePass.Location = new System.Drawing.Point(10, 115);
            this.lbRePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbRePass.Name = "lbRePass";
            this.lbRePass.Size = new System.Drawing.Size(164, 19);
            this.lbRePass.TabIndex = 3;
            this.lbRePass.Text = "Nhập lại Mật Khẩu Mới:";
            // 
            // lbNewPass
            // 
            this.lbNewPass.Location = new System.Drawing.Point(10, 75);
            this.lbNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(101, 19);
            this.lbNewPass.TabIndex = 3;
            this.lbNewPass.Text = "Mật Khẩu Mới:";
            // 
            // lblsRePass
            // 
            this.lblsRePass.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblsRePass.Appearance.Options.UseForeColor = true;
            this.lblsRePass.Location = new System.Drawing.Point(594, 114);
            this.lblsRePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblsRePass.Name = "lblsRePass";
            this.lblsRePass.Size = new System.Drawing.Size(9, 19);
            this.lblsRePass.TabIndex = 3;
            this.lblsRePass.Text = "*";
            this.lblsRePass.Visible = false;
            // 
            // lblsNewPass
            // 
            this.lblsNewPass.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblsNewPass.Appearance.Options.UseForeColor = true;
            this.lblsNewPass.Location = new System.Drawing.Point(594, 74);
            this.lblsNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblsNewPass.Name = "lblsNewPass";
            this.lblsNewPass.Size = new System.Drawing.Size(9, 19);
            this.lblsNewPass.TabIndex = 3;
            this.lblsNewPass.Text = "*";
            this.lblsNewPass.Visible = false;
            // 
            // lblsOldPass
            // 
            this.lblsOldPass.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblsOldPass.Appearance.Options.UseForeColor = true;
            this.lblsOldPass.Location = new System.Drawing.Point(594, 34);
            this.lblsOldPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblsOldPass.Name = "lblsOldPass";
            this.lblsOldPass.Size = new System.Drawing.Size(9, 19);
            this.lblsOldPass.TabIndex = 3;
            this.lblsOldPass.Text = "*";
            this.lblsOldPass.Visible = false;
            // 
            // lbOldPass
            // 
            this.lbOldPass.Location = new System.Drawing.Point(10, 35);
            this.lbOldPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbOldPass.Name = "lbOldPass";
            this.lbOldPass.Size = new System.Drawing.Size(95, 19);
            this.lbOldPass.TabIndex = 3;
            this.lbOldPass.Text = "Mật Khẩu Cũ:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(260, 30);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Properties.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(325, 26);
            this.txtOldPass.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 165);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(360, 165);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Thay Đổi";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.Location = new System.Drawing.Point(400, 200);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(117, 19);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "Tên Đăng Nhập:";
            // 
            // lbTypeID
            // 
            this.lbTypeID.Location = new System.Drawing.Point(400, 150);
            this.lbTypeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbTypeID.Name = "lbTypeID";
            this.lbTypeID.Size = new System.Drawing.Size(113, 19);
            this.lbTypeID.TabIndex = 3;
            this.lbTypeID.Text = "Loại Nhân Viên:";
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(400, 100);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(57, 19);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Địa Chỉ:";
            // 
            // lbFullName
            // 
            this.lbFullName.Location = new System.Drawing.Point(400, 50);
            this.lbFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(111, 19);
            this.lbFullName.TabIndex = 3;
            this.lbFullName.Text = "Tên Nhân Viên:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(267, 406);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(99, 35);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(9, 411);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(250, 26);
            this.txtLocation.TabIndex = 6;
            this.txtLocation.DoubleClick += new System.EventHandler(this.txtLocation_DoubleClick);
            // 
            // ptbMyAccount
            // 
            this.ptbMyAccount.Location = new System.Drawing.Point(8, 23);
            this.ptbMyAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbMyAccount.Name = "ptbMyAccount";
            this.ptbMyAccount.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ptbMyAccount.Size = new System.Drawing.Size(358, 368);
            this.ptbMyAccount.TabIndex = 0;
            // 
            // ucMyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMyAccount";
            this.Size = new System.Drawing.Size(1023, 555);
            this.Load += new System.EventHandler(this.ucMyAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbChangePassword.ResumeLayout(false);
            this.gbChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMyAccount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.PictureEdit ptbMyAccount;
        private System.Windows.Forms.GroupBox gbChangePassword;
        private DevExpress.XtraEditors.TextEdit txtRePass;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.LabelControl lbRePass;
        private DevExpress.XtraEditors.LabelControl lbNewPass;
        private DevExpress.XtraEditors.LabelControl lbOldPass;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.LabelControl lbUserName;
        private DevExpress.XtraEditors.LabelControl lbTypeID;
        private DevExpress.XtraEditors.LabelControl lbAddress;
        private DevExpress.XtraEditors.LabelControl lbFullName;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private DevExpress.XtraEditors.LabelControl lblsRePass;
        private DevExpress.XtraEditors.LabelControl lblsNewPass;
        private DevExpress.XtraEditors.LabelControl lblsOldPass;
        private DevExpress.XtraEditors.SimpleButton btnExits;
    }
}
