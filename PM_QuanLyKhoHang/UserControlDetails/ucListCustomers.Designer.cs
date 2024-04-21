namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucListCustomers
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
            this.gcListCustomers = new DevExpress.XtraEditors.GroupControl();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cbCompany = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtgvListCustomers = new DevExpress.XtraGrid.GridControl();
            this.gvListCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlCancel = new DevExpress.XtraEditors.PanelControl();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListCustomers)).BeginInit();
            this.gcListCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCancel)).BeginInit();
            this.pnlCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gcListCustomers);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1149, 508);
            this.pnlMain.TabIndex = 0;
            // 
            // gcListCustomers
            // 
            this.gcListCustomers.Controls.Add(this.pnlSearch);
            this.gcListCustomers.Controls.Add(this.dtgvListCustomers);
            this.gcListCustomers.Controls.Add(this.pnlCancel);
            this.gcListCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListCustomers.Location = new System.Drawing.Point(2, 2);
            this.gcListCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcListCustomers.Name = "gcListCustomers";
            this.gcListCustomers.Size = new System.Drawing.Size(1145, 504);
            this.gcListCustomers.TabIndex = 0;
            this.gcListCustomers.Text = "Danh Sách Các Khách Hàng";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.cbCompany);
            this.pnlSearch.Location = new System.Drawing.Point(3, 34);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1138, 49);
            this.pnlSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(452, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            // 
            // cbCompany
            // 
            this.cbCompany.Location = new System.Drawing.Point(88, 9);
            this.cbCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCompany.Size = new System.Drawing.Size(345, 26);
            this.cbCompany.TabIndex = 1;
            // 
            // dtgvListCustomers
            // 
            this.dtgvListCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvListCustomers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvListCustomers.Location = new System.Drawing.Point(2, 34);
            this.dtgvListCustomers.MainView = this.gvListCustomers;
            this.dtgvListCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvListCustomers.Name = "dtgvListCustomers";
            this.dtgvListCustomers.Size = new System.Drawing.Size(1141, 419);
            this.dtgvListCustomers.TabIndex = 1;
            this.dtgvListCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListCustomers});
            // 
            // gvListCustomers
            // 
            this.gvListCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colCompanyName,
            this.colAddress,
            this.colPhone,
            this.colFax,
            this.colStartDate,
            this.colNote,
            this.colDelete});
            this.gvListCustomers.DetailHeight = 538;
            this.gvListCustomers.GridControl = this.dtgvListCustomers;
            this.gvListCustomers.GroupPanelText = " ";
            this.gvListCustomers.Name = "gvListCustomers";
            this.gvListCustomers.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvListCustomers.RowHeight = 46;
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
            this.colSTT.Width = 46;
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
            this.colCompanyName.Caption = "Tên công ty";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.MinWidth = 30;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 1;
            this.colCompanyName.Width = 157;
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
            this.colAddress.Width = 157;
            // 
            // 
            // 
            // colPhone
            // 
            this.colPhone.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colPhone.AppearanceCell.Options.UseFont = true;
            this.colPhone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPhone.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colPhone.AppearanceHeader.Options.UseFont = true;
            this.colPhone.AppearanceHeader.Options.UseForeColor = true;
            this.colPhone.Caption = "Số điện thoại";
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 30;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 157;
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
            this.colFax.Width = 157;
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
            this.colStartDate.Width = 157;
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
            this.colNote.FieldName = "GhiChu";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 6;
            this.colNote.Width = 172;
            // 
            // 
            // 
            // colDelete
            // 
            this.colDelete.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colDelete.AppearanceCell.Options.UseFont = true;
            this.colDelete.AppearanceCell.Options.UseTextOptions = true;
            this.colDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDelete.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDelete.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDelete.AppearanceHeader.Options.UseFont = true;
            this.colDelete.AppearanceHeader.Options.UseForeColor = true;
            this.colDelete.Caption = "Xóa";
            this.colDelete.FieldName = "Delete";
            this.colDelete.MinWidth = 30;
            this.colDelete.Name = "colDelete";
            this.colDelete.ToolTip = "Xóa khách hàng này";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 7;
            this.colDelete.Width = 30;
            // 
            // pnlCancel
            // 
            this.pnlCancel.Controls.Add(this.btnNext);
            this.pnlCancel.Controls.Add(this.btnPrev);
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.Controls.Add(this.btnDelete);
            this.pnlCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCancel.Location = new System.Drawing.Point(2, 453);
            this.pnlCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(1141, 49);
            this.pnlCancel.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(656, 9);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">>";
            this.btnNext.Visible = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(534, 9);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(112, 35);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<<";
            this.btnPrev.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Hủy Xóa";
            this.btnCancel.ToolTip = "Hủy thao tác xóa trước đó";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa khách hàng này";
            // 
            // 
            // ucListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucListCustomers";
            this.Size = new System.Drawing.Size(1149, 508);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListCustomers)).EndInit();
            this.gcListCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCancel)).EndInit();
            this.pnlCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.GroupControl gcListCustomers;
        private DevExpress.XtraGrid.GridControl dtgvListCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.PanelControl pnlCancel;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.ComboBoxEdit cbCompany;
        private DevExpress.XtraEditors.PanelControl pnlSearch;

    }
}
