namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucInventoryManagement
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
            this.gcInventoryManagement = new DevExpress.XtraEditors.GroupControl();
            this.spccInventoryManagement = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dtgvInventoryManagement = new DevExpress.XtraGrid.GridControl();
            this.gvInventoryManagement = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimensions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInputSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.lbQuatityProducts = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lbSearchResults = new DevExpress.XtraEditors.LabelControl();
            this.gcAddProduct = new DevExpress.XtraEditors.GroupControl();
            this.lbStartDate = new DevExpress.XtraEditors.LabelControl();
            this.dtpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.lklbAddUnit = new System.Windows.Forms.LinkLabel();
            this.lklbAddProduct = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtImportPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtCount = new DevExpress.XtraEditors.TextEdit();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            this.lbImportPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbCount = new DevExpress.XtraEditors.LabelControl();
            this.lbProductName = new DevExpress.XtraEditors.LabelControl();
            this.mmedNote = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInventoryManagement)).BeginInit();
            this.gcInventoryManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccInventoryManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccInventoryManagement.Panel1)).BeginInit();
            this.spccInventoryManagement.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccInventoryManagement.Panel2)).BeginInit();
            this.spccInventoryManagement.Panel2.SuspendLayout();
            this.spccInventoryManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventoryManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventoryManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAddProduct)).BeginInit();
            this.gcAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gcInventoryManagement);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1344, 635);
            this.pnlMain.TabIndex = 0;
            // 
            // gcInventoryManagement
            // 
            this.gcInventoryManagement.Controls.Add(this.spccInventoryManagement);
            this.gcInventoryManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInventoryManagement.Location = new System.Drawing.Point(2, 2);
            this.gcInventoryManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcInventoryManagement.Name = "gcInventoryManagement";
            this.gcInventoryManagement.Size = new System.Drawing.Size(1340, 631);
            this.gcInventoryManagement.TabIndex = 0;
            this.gcInventoryManagement.Text = "Quản Lý Kho Hàng & Thông báo sản phẩm sắp hết hàng";
            // 
            // spccInventoryManagement
            // 
            this.spccInventoryManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spccInventoryManagement.Horizontal = false;
            this.spccInventoryManagement.Location = new System.Drawing.Point(2, 34);
            this.spccInventoryManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccInventoryManagement.Name = "spccInventoryManagement";
            // 
            // spccInventoryManagement.Panel1
            // 
            this.spccInventoryManagement.Panel1.Controls.Add(this.panelControl3);
            this.spccInventoryManagement.Panel1.Controls.Add(this.pnlSearch);
            this.spccInventoryManagement.Panel1.Text = "Panel1";
            // 
            // spccInventoryManagement.Panel2
            // 
            this.spccInventoryManagement.Panel2.Controls.Add(this.gcAddProduct);
            this.spccInventoryManagement.Panel2.Text = "Panel2";
            this.spccInventoryManagement.Size = new System.Drawing.Size(1336, 595);
            this.spccInventoryManagement.SplitterPosition = 294;
            this.spccInventoryManagement.TabIndex = 4;
            this.spccInventoryManagement.Text = "splitContainerControl1";
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.dtgvInventoryManagement);
            this.panelControl3.Location = new System.Drawing.Point(4, 55);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1332, 238);
            this.panelControl3.TabIndex = 2;
            // 
            // dtgvInventoryManagement
            // 
            this.dtgvInventoryManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInventoryManagement.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvInventoryManagement.Location = new System.Drawing.Point(2, 2);
            this.dtgvInventoryManagement.MainView = this.gvInventoryManagement;
            this.dtgvInventoryManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvInventoryManagement.Name = "dtgvInventoryManagement";
            this.dtgvInventoryManagement.Size = new System.Drawing.Size(1328, 234);
            this.dtgvInventoryManagement.TabIndex = 0;
            this.dtgvInventoryManagement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInventoryManagement});
            // 
            // gvInventoryManagement
            // 
            this.gvInventoryManagement.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colProductName,
            this.colDimensions,
            this.colUnitID,
            this.colUnit,
            this.colStock,
            this.colStartDate,
            this.colInputSource,
            this.colDelete,
            this.colNote});
            this.gvInventoryManagement.DetailHeight = 538;
            this.gvInventoryManagement.GridControl = this.dtgvInventoryManagement;
            this.gvInventoryManagement.GroupPanelText = " ";
            this.gvInventoryManagement.Name = "gvInventoryManagement";
            this.gvInventoryManagement.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvInventoryManagement.RowHeight = 46;
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
            // colProductName
            // 
            this.colProductName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colProductName.AppearanceCell.Options.UseFont = true;
            this.colProductName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colProductName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colProductName.AppearanceHeader.Options.UseFont = true;
            this.colProductName.AppearanceHeader.Options.UseForeColor = true;
            this.colProductName.Caption = "Tên Sản Phẩm";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 30;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 123;
            // 
            // colDimensions
            // 
            this.colDimensions.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colDimensions.AppearanceCell.Options.UseFont = true;
            this.colDimensions.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDimensions.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDimensions.AppearanceHeader.Options.UseFont = true;
            this.colDimensions.AppearanceHeader.Options.UseForeColor = true;
            this.colDimensions.Caption = "Kích Thước";
            this.colDimensions.FieldName = "Dimensions";
            this.colDimensions.MinWidth = 30;
            this.colDimensions.Name = "colDimensions";
            this.colDimensions.Visible = true;
            this.colDimensions.VisibleIndex = 2;
            this.colDimensions.Width = 123;
            // 
            // colUnitID
            // 
            this.colUnitID.Caption = "DonViID";
            this.colUnitID.FieldName = "UnitID";
            this.colUnitID.MinWidth = 30;
            this.colUnitID.Name = "colUnitID";
            this.colUnitID.Width = 112;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colUnit.AppearanceCell.Options.UseFont = true;
            this.colUnit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colUnit.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colUnit.AppearanceHeader.Options.UseFont = true;
            this.colUnit.AppearanceHeader.Options.UseForeColor = true;
            this.colUnit.Caption = "Đơn Vị Tính";
            this.colUnit.MinWidth = 30;
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 3;
            this.colUnit.Width = 123;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colStock.AppearanceCell.Options.UseFont = true;
            this.colStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStock.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStock.AppearanceHeader.Options.UseFont = true;
            this.colStock.AppearanceHeader.Options.UseForeColor = true;
            this.colStock.Caption = "Số Lượng Tồn";
            this.colStock.FieldName = "Stock";
            this.colStock.MinWidth = 30;
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 4;
            this.colStock.Width = 123;
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
            this.colStartDate.Caption = "Ngày Tạo";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.MinWidth = 30;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 5;
            this.colStartDate.Width = 123;
            // 
            // colInputSource
            // 
            this.colInputSource.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colInputSource.AppearanceCell.Options.UseFont = true;
            this.colInputSource.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colInputSource.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colInputSource.AppearanceHeader.Options.UseFont = true;
            this.colInputSource.AppearanceHeader.Options.UseForeColor = true;
            this.colInputSource.Caption = "Nguồn Nhập";
            this.colInputSource.FieldName = "InputSource";
            this.colInputSource.MinWidth = 30;
            this.colInputSource.Name = "colInputSource";
            this.colInputSource.Visible = true;
            this.colInputSource.VisibleIndex = 6;
            this.colInputSource.Width = 123;
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
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 136;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.Controls.Add(this.lbQuatityProducts);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lbSearchResults);
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1336, 54);
            this.pnlSearch.TabIndex = 1;
            // 
            // lbQuatityProducts
            // 
            this.lbQuatityProducts.Location = new System.Drawing.Point(976, 17);
            this.lbQuatityProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbQuatityProducts.Name = "lbQuatityProducts";
            this.lbQuatityProducts.Size = new System.Drawing.Size(167, 19);
            this.lbQuatityProducts.TabIndex = 4;
            this.lbQuatityProducts.Text = "Số sản phẩm cần nhập:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(40, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(342, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.ToolTip = "Tìm kiếm một sản phẩm theo tiêu chí bất kỳ";
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.Location = new System.Drawing.Point(496, 12);
            this.lbSearchResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(126, 19);
            this.lbSearchResults.TabIndex = 3;
            this.lbSearchResults.Text = "Kết quả tìm kiếm:";
            // 
            // gcAddProduct
            // 
            this.gcAddProduct.Controls.Add(this.lbStartDate);
            this.gcAddProduct.Controls.Add(this.dtpkStartDate);
            this.gcAddProduct.Controls.Add(this.lklbAddUnit);
            this.gcAddProduct.Controls.Add(this.lklbAddProduct);
            this.gcAddProduct.Controls.Add(this.btnCancel);
            this.gcAddProduct.Controls.Add(this.btnAdd);
            this.gcAddProduct.Controls.Add(this.txtImportPrice);
            this.gcAddProduct.Controls.Add(this.txtCount);
            this.gcAddProduct.Controls.Add(this.cbUnit);
            this.gcAddProduct.Controls.Add(this.cbProductName);
            this.gcAddProduct.Controls.Add(this.lbNote);
            this.gcAddProduct.Controls.Add(this.lbImportPrice);
            this.gcAddProduct.Controls.Add(this.lbCount);
            this.gcAddProduct.Controls.Add(this.lbProductName);
            this.gcAddProduct.Controls.Add(this.mmedNote);
            this.gcAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAddProduct.Location = new System.Drawing.Point(0, 0);
            this.gcAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcAddProduct.Name = "gcAddProduct";
            this.gcAddProduct.Size = new System.Drawing.Size(1336, 286);
            this.gcAddProduct.TabIndex = 1;
            this.gcAddProduct.Text = "Nhập thêm các mặt hàng đã có trong kho";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(100, 210);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(76, 19);
            this.lbStartDate.TabIndex = 41;
            this.lbStartDate.Text = "Ngày nhập";
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.Location = new System.Drawing.Point(230, 205);
            this.dtpkStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(295, 27);
            this.dtpkStartDate.TabIndex = 40;
            // 
            // lklbAddUnit
            // 
            this.lklbAddUnit.AutoSize = true;
            this.lklbAddUnit.Location = new System.Drawing.Point(545, 125);
            this.lklbAddUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklbAddUnit.Name = "lklbAddUnit";
            this.lklbAddUnit.Size = new System.Drawing.Size(103, 19);
            this.lklbAddUnit.TabIndex = 35;
            this.lklbAddUnit.TabStop = true;
            this.lklbAddUnit.Text = "Thêm Đơn Vị";
            // 
            // lklbAddProduct
            // 
            this.lklbAddProduct.AutoSize = true;
            this.lklbAddProduct.Location = new System.Drawing.Point(545, 72);
            this.lklbAddProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklbAddProduct.Name = "lklbAddProduct";
            this.lklbAddProduct.Size = new System.Drawing.Size(86, 38);
            this.lklbAddProduct.TabIndex = 34;
            this.lklbAddProduct.TabStop = true;
            this.lklbAddProduct.Text = "Thêm Sản \r\nPhẩm Mới";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1061, 238);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Hủy thao tác";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(893, 238);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Nhập vào kho";
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Location = new System.Drawing.Point(230, 160);
            this.txtImportPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(295, 26);
            this.txtImportPrice.TabIndex = 30;
            this.txtImportPrice.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(230, 115);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(218, 26);
            this.txtCount.TabIndex = 28;
            this.txtCount.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(457, 115);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(68, 27);
            this.cbUnit.TabIndex = 29;
            // 
            // cbProductName
            // 
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(230, 70);
            this.cbProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(295, 27);
            this.cbProductName.TabIndex = 27;
            // 
            // lbNote
            // 
            this.lbNote.Location = new System.Drawing.Point(710, 75);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(57, 19);
            this.lbNote.TabIndex = 36;
            this.lbNote.Text = "Ghi Chú";
            // 
            // lbImportPrice
            // 
            this.lbImportPrice.Location = new System.Drawing.Point(100, 165);
            this.lbImportPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbImportPrice.Name = "lbImportPrice";
            this.lbImportPrice.Size = new System.Drawing.Size(63, 19);
            this.lbImportPrice.TabIndex = 37;
            this.lbImportPrice.Text = "Giá nhập";
            // 
            // lbCount
            // 
            this.lbCount.Location = new System.Drawing.Point(100, 120);
            this.lbCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(64, 19);
            this.lbCount.TabIndex = 39;
            this.lbCount.Text = "Số lượng";
            // 
            // lbProductName
            // 
            this.lbProductName.Location = new System.Drawing.Point(100, 75);
            this.lbProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(101, 19);
            this.lbProductName.TabIndex = 38;
            this.lbProductName.Text = "Tên sản phẩm";
            // 
            // mmedNote
            // 
            this.mmedNote.Location = new System.Drawing.Point(800, 75);
            this.mmedNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mmedNote.Name = "mmedNote";
            this.mmedNote.Size = new System.Drawing.Size(452, 135);
            this.mmedNote.TabIndex = 31;
            this.mmedNote.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // ucInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucInventoryManagement";
            this.Size = new System.Drawing.Size(1344, 635);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInventoryManagement)).EndInit();
            this.gcInventoryManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccInventoryManagement.Panel1)).EndInit();
            this.spccInventoryManagement.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccInventoryManagement.Panel2)).EndInit();
            this.spccInventoryManagement.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccInventoryManagement)).EndInit();
            this.spccInventoryManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventoryManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventoryManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAddProduct)).EndInit();
            this.gcAddProduct.ResumeLayout(false);
            this.gcAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.GroupControl gcInventoryManagement;
        private DevExpress.XtraGrid.GridControl dtgvInventoryManagement;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInventoryManagement;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colDimensions;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInputSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.LabelControl lbSearchResults;
        private DevExpress.XtraEditors.SplitContainerControl spccInventoryManagement;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl pnlSearch;
        private DevExpress.XtraEditors.LabelControl lbQuatityProducts;
        private DevExpress.XtraEditors.GroupControl gcAddProduct;
        private System.Windows.Forms.LinkLabel lklbAddUnit;
        private System.Windows.Forms.LinkLabel lklbAddProduct;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtImportPrice;
        private DevExpress.XtraEditors.TextEdit txtCount;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox cbProductName;
        private DevExpress.XtraEditors.LabelControl lbNote;
        private DevExpress.XtraEditors.LabelControl lbImportPrice;
        private DevExpress.XtraEditors.LabelControl lbCount;
        private DevExpress.XtraEditors.LabelControl lbProductName;
        private DevExpress.XtraEditors.MemoEdit mmedNote;
        private DevExpress.XtraEditors.LabelControl lbStartDate;
        private System.Windows.Forms.DateTimePicker dtpkStartDate;
    }
}
