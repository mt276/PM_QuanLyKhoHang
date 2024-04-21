namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucAddCustomers
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
            this.gcAddCustomers = new DevExpress.XtraEditors.GroupControl();
            this.spccAddCustomers = new DevExpress.XtraEditors.SplitContainerControl();
            this.dtpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnShowAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtPhoneDelegate = new DevExpress.XtraEditors.TextEdit();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            this.lbStartDate = new DevExpress.XtraEditors.LabelControl();
            this.lbFax = new DevExpress.XtraEditors.LabelControl();
            this.txtDelegate = new DevExpress.XtraEditors.TextEdit();
            this.lbPhoneDelegate = new DevExpress.XtraEditors.LabelControl();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.lbDelegate = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.lbPhone = new DevExpress.XtraEditors.LabelControl();
            this.lbAddress = new DevExpress.XtraEditors.LabelControl();
            this.lbCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.dtgvAddCustomers = new DevExpress.XtraGrid.GridControl();
            this.gvAddCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAddCustomers)).BeginInit();
            this.gcAddCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAddCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccAddCustomers.Panel1)).BeginInit();
            this.spccAddCustomers.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAddCustomers.Panel2)).BeginInit();
            this.spccAddCustomers.Panel2.SuspendLayout();
            this.spccAddCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneDelegate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelegate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAddCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gcAddCustomers);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1461, 591);
            this.pnlMain.TabIndex = 0;
            // 
            // gcAddCustomers
            // 
            this.gcAddCustomers.Controls.Add(this.spccAddCustomers);
            this.gcAddCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAddCustomers.Location = new System.Drawing.Point(2, 2);
            this.gcAddCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcAddCustomers.Name = "gcAddCustomers";
            this.gcAddCustomers.Size = new System.Drawing.Size(1457, 587);
            this.gcAddCustomers.TabIndex = 0;
            this.gcAddCustomers.Text = "Thêm khách hàng mới (Thêm công ty mới)";
            // 
            // spccAddCustomers
            // 
            this.spccAddCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spccAddCustomers.Horizontal = false;
            this.spccAddCustomers.Location = new System.Drawing.Point(2, 34);
            this.spccAddCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccAddCustomers.Name = "spccAddCustomers";
            // 
            // spccAddCustomers.Panel1
            // 
            this.spccAddCustomers.Panel1.Controls.Add(this.dtpkStartDate);
            this.spccAddCustomers.Panel1.Controls.Add(this.btnShowAll);
            this.spccAddCustomers.Panel1.Controls.Add(this.btnUpdate);
            this.spccAddCustomers.Panel1.Controls.Add(this.btnDelete);
            this.spccAddCustomers.Panel1.Controls.Add(this.btnCancel);
            this.spccAddCustomers.Panel1.Controls.Add(this.btnAdd);
            this.spccAddCustomers.Panel1.Controls.Add(this.txtPhoneDelegate);
            this.spccAddCustomers.Panel1.Controls.Add(this.lbNote);
            this.spccAddCustomers.Panel1.Controls.Add(this.lbStartDate);
            this.spccAddCustomers.Panel1.Controls.Add(this.lbFax);
            this.spccAddCustomers.Panel1.Controls.Add(this.txtDelegate);
            this.spccAddCustomers.Panel1.Controls.Add(this.lbPhoneDelegate);
            this.spccAddCustomers.Panel1.Controls.Add(this.txtFax);
            this.spccAddCustomers.Panel1.Controls.Add(this.lbDelegate);
            this.spccAddCustomers.Panel1.Controls.Add(this.txtPhone);
            this.spccAddCustomers.Panel1.Controls.Add(this.lbPhone);
            this.spccAddCustomers.Panel1.Controls.Add(this.lbAddress);
            this.spccAddCustomers.Panel1.Controls.Add(this.lbCompanyName);
            this.spccAddCustomers.Panel1.Controls.Add(this.txtCompanyName);
            this.spccAddCustomers.Panel1.Controls.Add(this.txtAddress);
            this.spccAddCustomers.Panel1.Controls.Add(this.txtNote);
            this.spccAddCustomers.Panel1.Text = "Panel1";
            // 
            // spccAddCustomers.Panel2
            // 
            this.spccAddCustomers.Panel2.Controls.Add(this.dtgvAddCustomers);
            this.spccAddCustomers.Panel2.Text = "Panel2";
            this.spccAddCustomers.Size = new System.Drawing.Size(1453, 551);
            this.spccAddCustomers.SplitterPosition = 292;
            this.spccAddCustomers.TabIndex = 0;
            this.spccAddCustomers.Text = "splitContainerControl1";
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.Location = new System.Drawing.Point(770, 170);
            this.dtpkStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(295, 27);
            this.dtpkStartDate.TabIndex = 7;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(1178, 255);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(180, 35);
            this.btnShowAll.TabIndex = 13;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.ToolTip = "Cập nhật khách hàng mới";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1042, 255);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.ToolTip = "Cập nhật khách hàng mới";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(905, 255);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.ToolTip = "Xóa khách hàng đang được chọn";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(761, 255);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy Thao Tác";
            this.btnCancel.ToolTip = "Hủy thao tác thêm mới khách hàng này";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(625, 255);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.ToolTip = "Thêm mới một khách hàng";
            // 
            // txtPhoneDelegate
            // 
            this.txtPhoneDelegate.Location = new System.Drawing.Point(770, 120);
            this.txtPhoneDelegate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneDelegate.Name = "txtPhoneDelegate";
            this.txtPhoneDelegate.Size = new System.Drawing.Size(295, 26);
            this.txtPhoneDelegate.TabIndex = 6;
            this.txtPhoneDelegate.ToolTip = "Số điện thoại người đại diện";
            this.txtPhoneDelegate.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbNote
            // 
            this.lbNote.Location = new System.Drawing.Point(1105, 25);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(57, 19);
            this.lbNote.TabIndex = 1;
            this.lbNote.Text = "Ghi Chú";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(689, 175);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(68, 19);
            this.lbStartDate.TabIndex = 1;
            this.lbStartDate.Text = "Ngày Tạo";
            // 
            // lbFax
            // 
            this.lbFax.Location = new System.Drawing.Point(733, 25);
            this.lbFax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbFax.Name = "lbFax";
            this.lbFax.Size = new System.Drawing.Size(24, 19);
            this.lbFax.TabIndex = 1;
            this.lbFax.Text = "Fax";
            // 
            // txtDelegate
            // 
            this.txtDelegate.Location = new System.Drawing.Point(770, 70);
            this.txtDelegate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelegate.Name = "txtDelegate";
            this.txtDelegate.Size = new System.Drawing.Size(295, 26);
            this.txtDelegate.TabIndex = 5;
            this.txtDelegate.ToolTip = "Tên người đại diện";
            this.txtDelegate.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbPhoneDelegate
            // 
            this.lbPhoneDelegate.Location = new System.Drawing.Point(544, 125);
            this.lbPhoneDelegate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbPhoneDelegate.Name = "lbPhoneDelegate";
            this.lbPhoneDelegate.Size = new System.Drawing.Size(213, 19);
            this.lbPhoneDelegate.TabIndex = 1;
            this.lbPhoneDelegate.Text = "Số Điện Thoại Người Đại Diện";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(770, 20);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(295, 26);
            this.txtFax.TabIndex = 4;
            this.txtFax.ToolTip = "Fax";
            this.txtFax.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbDelegate
            // 
            this.lbDelegate.Location = new System.Drawing.Point(617, 75);
            this.lbDelegate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbDelegate.Name = "lbDelegate";
            this.lbDelegate.Size = new System.Drawing.Size(140, 19);
            this.lbDelegate.TabIndex = 1;
            this.lbDelegate.Text = "Tên Người Đại Diện";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(114, 206);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(420, 26);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.ToolTip = "Số Điện thoại liên lạc";
            this.txtPhone.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbPhone
            // 
            this.lbPhone.Location = new System.Drawing.Point(5, 209);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(100, 19);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Số Điện Thoại";
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(5, 80);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(51, 19);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "Địa Chỉ";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Location = new System.Drawing.Point(5, 25);
            this.lbCompanyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(92, 19);
            this.lbCompanyName.TabIndex = 1;
            this.lbCompanyName.Text = "Tên Công Ty";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(114, 20);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(420, 26);
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.ToolTip = "Tên công ty cần thêm mới";
            this.txtCompanyName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(114, 80);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(420, 94);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.ToolTip = "Địa chỉ công ty";
            this.txtAddress.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(1105, 50);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(338, 174);
            this.txtNote.TabIndex = 8;
            this.txtNote.ToolTip = "Ghi Chú thêm về công ty này";
            this.txtNote.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // dtgvAddCustomers
            // 
            this.dtgvAddCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAddCustomers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvAddCustomers.Location = new System.Drawing.Point(0, 0);
            this.dtgvAddCustomers.MainView = this.gvAddCustomers;
            this.dtgvAddCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvAddCustomers.Name = "dtgvAddCustomers";
            this.dtgvAddCustomers.Size = new System.Drawing.Size(1453, 244);
            this.dtgvAddCustomers.TabIndex = 0;
            this.dtgvAddCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAddCustomers});
            // 
            // gvAddCustomers
            // 
            this.gvAddCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colCompanyName,
            this.colAddress,
            this.colPhone,
            this.colFax,
            this.colStartDate,
            this.colDelete,
            this.colNote});
            this.gvAddCustomers.DetailHeight = 538;
            this.gvAddCustomers.GridControl = this.dtgvAddCustomers;
            this.gvAddCustomers.GroupPanelText = " ";
            this.gvAddCustomers.Name = "gvAddCustomers";
            this.gvAddCustomers.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvAddCustomers.RowHeight = 46;
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colSTT.AppearanceCell.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseForeColor = true;
            this.colSTT.Caption = "STT";
            this.colSTT.MinWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 52;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 30;
            this.colID.Name = "colID";
            this.colID.Width = 112;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCompanyName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Options.UseForeColor = true;
            this.colCompanyName.Caption = "Tên Công Ty";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.MinWidth = 30;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 1;
            this.colCompanyName.Width = 225;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colAddress.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Options.UseForeColor = true;
            this.colAddress.Caption = "Địa Chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 30;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 225;
            // 
            // colPhone
            // 
            this.colPhone.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colPhone.AppearanceCell.Options.UseFont = true;
            this.colPhone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPhone.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colPhone.AppearanceHeader.Options.UseFont = true;
            this.colPhone.AppearanceHeader.Options.UseForeColor = true;
            this.colPhone.Caption = "Số Điện Thoại";
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 30;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 225;
            // 
            // colFax
            // 
            this.colFax.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colFax.AppearanceCell.Options.UseFont = true;
            this.colFax.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colFax.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colFax.AppearanceHeader.Options.UseFont = true;
            this.colFax.AppearanceHeader.Options.UseForeColor = true;
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.MinWidth = 30;
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 4;
            this.colFax.Width = 225;
            // 
            // colStartDate
            // 
            this.colStartDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colStartDate.AppearanceCell.Options.UseFont = true;
            this.colStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStartDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStartDate.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStartDate.AppearanceHeader.Options.UseFont = true;
            this.colStartDate.AppearanceHeader.Options.UseForeColor = true;
            this.colStartDate.Caption = "Ngày tạo";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.MinWidth = 30;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 5;
            this.colStartDate.Width = 225;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Xóa";
            this.colDelete.FieldName = "Delete";
            this.colDelete.MinWidth = 30;
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 112;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colNote.AppearanceCell.Options.UseFont = true;
            this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNote.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colNote.AppearanceHeader.Options.UseFont = true;
            this.colNote.AppearanceHeader.Options.UseForeColor = true;
            this.colNote.Caption = "Ghi Chú";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 6;
            this.colNote.Width = 244;
            // 
            // ucAddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucAddCustomers";
            this.Size = new System.Drawing.Size(1461, 591);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAddCustomers)).EndInit();
            this.gcAddCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccAddCustomers.Panel1)).EndInit();
            this.spccAddCustomers.Panel1.ResumeLayout(false);
            this.spccAddCustomers.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAddCustomers.Panel2)).EndInit();
            this.spccAddCustomers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccAddCustomers)).EndInit();
            this.spccAddCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneDelegate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelegate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAddCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.GroupControl gcAddCustomers;
        private DevExpress.XtraEditors.SplitContainerControl spccAddCustomers;
        private DevExpress.XtraEditors.LabelControl lbCompanyName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl dtgvAddCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAddCustomers;
        private DevExpress.XtraEditors.TextEdit txtPhoneDelegate;
        private DevExpress.XtraEditors.LabelControl lbNote;
        private DevExpress.XtraEditors.LabelControl lbStartDate;
        private DevExpress.XtraEditors.LabelControl lbFax;
        private DevExpress.XtraEditors.TextEdit txtDelegate;
        private DevExpress.XtraEditors.LabelControl lbPhoneDelegate;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.LabelControl lbDelegate;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl lbPhone;
        private DevExpress.XtraEditors.LabelControl lbAddress;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.MemoEdit txtNote;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.DateTimePicker dtpkStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.SimpleButton btnShowAll;
    }
}
