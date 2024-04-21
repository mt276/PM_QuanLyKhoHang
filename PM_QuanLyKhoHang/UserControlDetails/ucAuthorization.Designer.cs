namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucAuthorization
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
            this.pnMain = new DevExpress.XtraEditors.PanelControl();
            this.spccAuthorization = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ddbtnStaffTypeID = new DevExpress.XtraEditors.DropDownButton();
            this.lbStaffTypeID = new DevExpress.XtraEditors.LabelControl();
            this.lbPassword = new DevExpress.XtraEditors.LabelControl();
            this.lbUserName = new DevExpress.XtraEditors.LabelControl();
            this.lbStaffName = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtStaffName = new DevExpress.XtraEditors.TextEdit();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            this.lbAddress = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.mmedAddress = new DevExpress.XtraEditors.MemoEdit();
            this.mmedNote = new DevExpress.XtraEditors.MemoEdit();
            this.dtgvAuthorization = new DevExpress.XtraGrid.GridControl();
            this.gvAuthorization = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAuthorization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccAuthorization.Panel1)).BeginInit();
            this.spccAuthorization.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAuthorization.Panel2)).BeginInit();
            this.spccAuthorization.Panel2.SuspendLayout();
            this.spccAuthorization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthorization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuthorization)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.spccAuthorization);
            this.pnMain.Controls.Add(this.dtgvAuthorization);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1232, 595);
            this.pnMain.TabIndex = 0;
            // 
            // spccAuthorization
            // 
            this.spccAuthorization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spccAuthorization.Location = new System.Drawing.Point(8, 8);
            this.spccAuthorization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccAuthorization.Name = "spccAuthorization";
            // 
            // spccAuthorization.Panel1
            // 
            this.spccAuthorization.Panel1.Controls.Add(this.btnCancel);
            this.spccAuthorization.Panel1.Controls.Add(this.ddbtnStaffTypeID);
            this.spccAuthorization.Panel1.Controls.Add(this.lbStaffTypeID);
            this.spccAuthorization.Panel1.Controls.Add(this.lbPassword);
            this.spccAuthorization.Panel1.Controls.Add(this.lbUserName);
            this.spccAuthorization.Panel1.Controls.Add(this.lbStaffName);
            this.spccAuthorization.Panel1.Controls.Add(this.txtPassword);
            this.spccAuthorization.Panel1.Controls.Add(this.txtUserName);
            this.spccAuthorization.Panel1.Controls.Add(this.txtStaffName);
            this.spccAuthorization.Panel1.Text = "Panel1";
            // 
            // spccAuthorization.Panel2
            // 
            this.spccAuthorization.Panel2.Controls.Add(this.lbNote);
            this.spccAuthorization.Panel2.Controls.Add(this.lbAddress);
            this.spccAuthorization.Panel2.Controls.Add(this.btnUpdate);
            this.spccAuthorization.Panel2.Controls.Add(this.btnDelete);
            this.spccAuthorization.Panel2.Controls.Add(this.btnAdd);
            this.spccAuthorization.Panel2.Controls.Add(this.mmedAddress);
            this.spccAuthorization.Panel2.Controls.Add(this.mmedNote);
            this.spccAuthorization.Panel2.Text = "Panel2";
            this.spccAuthorization.Size = new System.Drawing.Size(1216, 285);
            this.spccAuthorization.SplitterPosition = 601;
            this.spccAuthorization.TabIndex = 1;
            this.spccAuthorization.Text = "splitContainerControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(5, 245);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy Thao Tác";
            this.btnCancel.ToolTip = "Xóa dữ liệu trên các control";
            // 
            // ddbtnStaffTypeID
            // 
            this.ddbtnStaffTypeID.Location = new System.Drawing.Point(142, 170);
            this.ddbtnStaffTypeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddbtnStaffTypeID.Name = "ddbtnStaffTypeID";
            this.ddbtnStaffTypeID.Size = new System.Drawing.Size(365, 35);
            this.ddbtnStaffTypeID.TabIndex = 4;
            this.ddbtnStaffTypeID.Text = "(Chọn)";
            this.ddbtnStaffTypeID.ToolTip = "Chọn loại nhân viên";
            // 
            // lbStaffTypeID
            // 
            this.lbStaffTypeID.Location = new System.Drawing.Point(5, 175);
            this.lbStaffTypeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStaffTypeID.Name = "lbStaffTypeID";
            this.lbStaffTypeID.Size = new System.Drawing.Size(103, 19);
            this.lbStaffTypeID.TabIndex = 2;
            this.lbStaffTypeID.Text = "Loại nhân viên";
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(5, 125);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(64, 19);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // lbUserName
            // 
            this.lbUserName.Location = new System.Drawing.Point(5, 75);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(107, 19);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Tên đăng nhập";
            // 
            // lbStaffName
            // 
            this.lbStaffName.Location = new System.Drawing.Point(5, 25);
            this.lbStaffName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(105, 19);
            this.lbStaffName.TabIndex = 2;
            this.lbStaffName.Text = "Tên Nhân Viên";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 120);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(365, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.ToolTip = "Mật khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(140, 70);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(365, 26);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.ToolTip = "Tên đăng nhập";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(140, 20);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(365, 26);
            this.txtStaffName.TabIndex = 1;
            this.txtStaffName.ToolTip = "Tên nhân viên";
            // 
            // lbNote
            // 
            this.lbNote.Location = new System.Drawing.Point(15, 135);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(57, 19);
            this.lbNote.TabIndex = 2;
            this.lbNote.Text = "Ghi Chú";
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(15, 25);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(48, 19);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(366, 245);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.ToolTip = "Cập nhật thông tin của nhân viên";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 245);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.ToolTip = "Xoá một nhân viên đang chọn";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 245);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.ToolTip = "Thêm một nhân viên mới";
            // 
            // mmedAddress
            // 
            this.mmedAddress.Location = new System.Drawing.Point(100, 25);
            this.mmedAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mmedAddress.Name = "mmedAddress";
            this.mmedAddress.Size = new System.Drawing.Size(501, 88);
            this.mmedAddress.TabIndex = 5;
            this.mmedAddress.ToolTip = "Đia chỉ của nhân viên";
            // 
            // mmedNote
            // 
            this.mmedNote.Location = new System.Drawing.Point(100, 135);
            this.mmedNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mmedNote.Name = "mmedNote";
            this.mmedNote.Size = new System.Drawing.Size(501, 80);
            this.mmedNote.TabIndex = 6;
            this.mmedNote.ToolTip = "Ghi chú thêm về nhân viên này";
            // 
            // dtgvAuthorization
            // 
            this.dtgvAuthorization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAuthorization.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvAuthorization.Location = new System.Drawing.Point(3, 302);
            this.dtgvAuthorization.MainView = this.gvAuthorization;
            this.dtgvAuthorization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvAuthorization.Name = "dtgvAuthorization";
            this.dtgvAuthorization.Size = new System.Drawing.Size(1226, 291);
            this.dtgvAuthorization.TabIndex = 0;
            this.dtgvAuthorization.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAuthorization});
            // 
            // gvAuthorization
            // 
            this.gvAuthorization.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colUserName,
            this.colPassword,
            this.colFullName,
            this.colAddress,
            this.colStaffTypeName,
            this.colStaffTypeID,
            this.colStartDate,
            this.colDelete,
            this.colNote});
            this.gvAuthorization.DetailHeight = 538;
            this.gvAuthorization.GridControl = this.dtgvAuthorization;
            this.gvAuthorization.GroupPanelText = " ";
            this.gvAuthorization.Name = "gvAuthorization";
            this.gvAuthorization.OptionsEditForm.PopupEditFormWidth = 1200;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 112;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 30;
            this.colID.Name = "colID";
            this.colID.Width = 112;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Tên đăng nhập";
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 30;
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            this.colUserName.Width = 112;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Mật Khẩu";
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 30;
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            this.colPassword.Width = 112;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Tên đầy đủ";
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 30;
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 3;
            this.colFullName.Width = 112;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Địa chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 30;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 112;
            // 
            // colStaffTypeName
            // 
            this.colStaffTypeName.Caption = "Loại Nhân Viên";
            this.colStaffTypeName.MinWidth = 30;
            this.colStaffTypeName.Name = "colStaffTypeName";
            this.colStaffTypeName.Visible = true;
            this.colStaffTypeName.VisibleIndex = 5;
            this.colStaffTypeName.Width = 112;
            // 
            // colStaffTypeID
            // 
            this.colStaffTypeID.Caption = "Loại Nhân Viên";
            this.colStaffTypeID.FieldName = "StaffTypeID";
            this.colStaffTypeID.MinWidth = 30;
            this.colStaffTypeID.Name = "colStaffTypeID";
            this.colStaffTypeID.Width = 112;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày tạo";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.MinWidth = 30;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 6;
            this.colStartDate.Width = 112;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Xoá";
            this.colDelete.FieldName = "Delete";
            this.colDelete.MinWidth = 30;
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 112;
            // 
            // colNote
            // 
            this.colNote.Caption = "Ghi chú";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 112;
            // 
            // ucAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucAuthorization";
            this.Size = new System.Drawing.Size(1232, 595);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccAuthorization.Panel1)).EndInit();
            this.spccAuthorization.Panel1.ResumeLayout(false);
            this.spccAuthorization.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAuthorization.Panel2)).EndInit();
            this.spccAuthorization.Panel2.ResumeLayout(false);
            this.spccAuthorization.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAuthorization)).EndInit();
            this.spccAuthorization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthorization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuthorization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnMain;
        private DevExpress.XtraEditors.SplitContainerControl spccAuthorization;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtStaffName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl dtgvAuthorization;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAuthorization;
        private DevExpress.XtraEditors.LabelControl lbStaffTypeID;
        private DevExpress.XtraEditors.LabelControl lbPassword;
        private DevExpress.XtraEditors.LabelControl lbUserName;
        private DevExpress.XtraEditors.LabelControl lbStaffName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lbNote;
        private DevExpress.XtraEditors.LabelControl lbAddress;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.MemoEdit mmedAddress;
        private DevExpress.XtraEditors.MemoEdit mmedNote;
        private DevExpress.XtraEditors.DropDownButton ddbtnStaffTypeID;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffTypeName;
    }
}
