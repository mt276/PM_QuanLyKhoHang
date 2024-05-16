namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucInputReport
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
            this.tcInputReport = new DevExpress.XtraTab.XtraTabControl();
            this.tpInputList = new DevExpress.XtraTab.XtraTabPage();
            this.gcInputList = new DevExpress.XtraEditors.GroupControl();
            this.lbSearchResults = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dtpkEnd = new System.Windows.Forms.DateTimePicker();
            this.lbEnd = new DevExpress.XtraEditors.LabelControl();
            this.dtpkStart = new System.Windows.Forms.DateTimePicker();
            this.lbStart = new DevExpress.XtraEditors.LabelControl();
            this.lbSearch = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.dtgvListInput = new DevExpress.XtraGrid.GridControl();
            this.gvListInput = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLImportPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLImportDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpInputDetails = new DevExpress.XtraTab.XtraTabPage();
            this.spccInputDetails = new DevExpress.XtraEditors.SplitContainerControl();
            this.dtgvListProducts = new DevExpress.XtraGrid.GridControl();
            this.gvListProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPInputSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtgvInputDetails = new DevExpress.XtraGrid.GridControl();
            this.gvInputDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDImportPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDImportDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcInputReport)).BeginInit();
            this.tcInputReport.SuspendLayout();
            this.tpInputList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInputList)).BeginInit();
            this.gcInputList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListInput)).BeginInit();
            this.tpInputDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccInputDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccInputDetails.Panel1)).BeginInit();
            this.spccInputDetails.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccInputDetails.Panel2)).BeginInit();
            this.spccInputDetails.Panel2.SuspendLayout();
            this.spccInputDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInputDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInputDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tcInputReport);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1617, 548);
            this.pnlMain.TabIndex = 0;
            // 
            // tcInputReport
            // 
            this.tcInputReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInputReport.Location = new System.Drawing.Point(2, 2);
            this.tcInputReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcInputReport.Name = "tcInputReport";
            this.tcInputReport.SelectedTabPage = this.tpInputList;
            this.tcInputReport.Size = new System.Drawing.Size(1613, 544);
            this.tcInputReport.TabIndex = 1;
            this.tcInputReport.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpInputList,
            this.tpInputDetails});
            // 
            // tpInputList
            // 
            this.tpInputList.Controls.Add(this.gcInputList);
            this.tpInputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpInputList.Name = "tpInputList";
            this.tpInputList.Size = new System.Drawing.Size(1611, 509);
            this.tpInputList.Text = "Danh sách nhập kho";
            // 
            // gcInputList
            // 
            this.gcInputList.Controls.Add(this.lbSearchResults);
            this.gcInputList.Controls.Add(this.btnCancel);
            this.gcInputList.Controls.Add(this.btnSearch);
            this.gcInputList.Controls.Add(this.dtpkEnd);
            this.gcInputList.Controls.Add(this.lbEnd);
            this.gcInputList.Controls.Add(this.dtpkStart);
            this.gcInputList.Controls.Add(this.lbStart);
            this.gcInputList.Controls.Add(this.lbSearch);
            this.gcInputList.Controls.Add(this.txtSearch);
            this.gcInputList.Controls.Add(this.dtgvListInput);
            this.gcInputList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInputList.Location = new System.Drawing.Point(0, 0);
            this.gcInputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcInputList.Name = "gcInputList";
            this.gcInputList.Size = new System.Drawing.Size(1611, 509);
            this.gcInputList.TabIndex = 0;
            this.gcInputList.Text = "Báo cáo nhập kho";
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.Location = new System.Drawing.Point(1453, 48);
            this.lbSearchResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(120, 19);
            this.lbSearchResults.TabIndex = 8;
            this.lbSearchResults.Text = "Kết quả tìm kiếm";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1328, 39);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1256, 39);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpkEnd
            // 
            this.dtpkEnd.Location = new System.Drawing.Point(950, 44);
            this.dtpkEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkEnd.Name = "dtpkEnd";
            this.dtpkEnd.Size = new System.Drawing.Size(290, 27);
            this.dtpkEnd.TabIndex = 2;
            // 
            // lbEnd
            // 
            this.lbEnd.Location = new System.Drawing.Point(831, 47);
            this.lbEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(107, 19);
            this.lbEnd.TabIndex = 2;
            this.lbEnd.Text = "Ngày nhập đến";
            // 
            // dtpkStart
            // 
            this.dtpkStart.Location = new System.Drawing.Point(527, 44);
            this.dtpkStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkStart.Name = "dtpkStart";
            this.dtpkStart.Size = new System.Drawing.Size(290, 27);
            this.dtpkStart.TabIndex = 1;
            // 
            // lbStart
            // 
            this.lbStart.Location = new System.Drawing.Point(419, 47);
            this.lbStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(96, 19);
            this.lbStart.TabIndex = 2;
            this.lbStart.Text = "Ngày nhập từ";
            // 
            // lbSearch
            // 
            this.lbSearch.Location = new System.Drawing.Point(10, 47);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(59, 19);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Từ khóa";
            this.lbSearch.ToolTip = "Tìm gần đúng tên sản phẩm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(94, 44);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(313, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // dtgvListInput
            // 
            this.dtgvListInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvListInput.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvListInput.Location = new System.Drawing.Point(2, 34);
            this.dtgvListInput.MainView = this.gvListInput;
            this.dtgvListInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvListInput.Name = "dtgvListInput";
            this.dtgvListInput.Size = new System.Drawing.Size(1607, 473);
            this.dtgvListInput.TabIndex = 0;
            this.dtgvListInput.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListInput});
            // 
            // gvListInput
            // 
            this.gvListInput.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLSTT,
            this.colID,
            this.colProductID,
            this.colLProductName,
            this.colLCount,
            this.colLImportPrice,
            this.colLImportDate,
            this.colAccountID,
            this.colLAccountName,
            this.colDelete,
            this.colLNote});
            this.gvListInput.DetailHeight = 538;
            this.gvListInput.GridControl = this.dtgvListInput;
            this.gvListInput.GroupPanelText = " ";
            this.gvListInput.Name = "gvListInput";
            this.gvListInput.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvListInput.RowHeight = 46;
            this.gvListInput.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvInputList_CustomDrawCell);
            // 
            // colLSTT
            // 
            this.colLSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colLSTT.AppearanceCell.Options.UseFont = true;
            this.colLSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colLSTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colLSTT.AppearanceHeader.Options.UseFont = true;
            this.colLSTT.AppearanceHeader.Options.UseForeColor = true;
            this.colLSTT.Caption = "STT";
            this.colLSTT.MinWidth = 30;
            this.colLSTT.Name = "colLSTT";
            this.colLSTT.Visible = true;
            this.colLSTT.VisibleIndex = 0;
            this.colLSTT.Width = 34;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 30;
            this.colID.Name = "colID";
            this.colID.Width = 112;
            // 
            // colProductID
            // 
            this.colProductID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 20F);
            this.colProductID.AppearanceCell.Options.UseFont = true;
            this.colProductID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colProductID.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colProductID.AppearanceHeader.Options.UseFont = true;
            this.colProductID.AppearanceHeader.Options.UseForeColor = true;
            this.colProductID.Caption = "Mã sản phẩm";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.MinWidth = 30;
            this.colProductID.Name = "colProductID";
            this.colProductID.Width = 112;
            // 
            // colLProductName
            // 
            this.colLProductName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colLProductName.AppearanceCell.Options.UseFont = true;
            this.colLProductName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colLProductName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colLProductName.AppearanceHeader.Options.UseFont = true;
            this.colLProductName.AppearanceHeader.Options.UseForeColor = true;
            this.colLProductName.Caption = "Tên sản phẩm";
            this.colLProductName.MinWidth = 30;
            this.colLProductName.Name = "colLProductName";
            this.colLProductName.Visible = true;
            this.colLProductName.VisibleIndex = 1;
            this.colLProductName.Width = 165;
            // 
            // colLCount
            // 
            this.colLCount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colLCount.AppearanceCell.Options.UseFont = true;
            this.colLCount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colLCount.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colLCount.AppearanceHeader.Options.UseFont = true;
            this.colLCount.AppearanceHeader.Options.UseForeColor = true;
            this.colLCount.Caption = "Số lượng nhập";
            this.colLCount.FieldName = "Count";
            this.colLCount.MinWidth = 30;
            this.colLCount.Name = "colLCount";
            this.colLCount.Visible = true;
            this.colLCount.VisibleIndex = 2;
            this.colLCount.Width = 165;
            // 
            // colLImportPrice
            // 
            this.colLImportPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colLImportPrice.AppearanceCell.Options.UseFont = true;
            this.colLImportPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colLImportPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colLImportPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colLImportPrice.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colLImportPrice.AppearanceHeader.Options.UseFont = true;
            this.colLImportPrice.AppearanceHeader.Options.UseForeColor = true;
            this.colLImportPrice.Caption = "Giá nhập";
            this.colLImportPrice.FieldName = "ImportPrice";
            this.colLImportPrice.MinWidth = 30;
            this.colLImportPrice.Name = "colLImportPrice";
            this.colLImportPrice.Visible = true;
            this.colLImportPrice.VisibleIndex = 3;
            this.colLImportPrice.Width = 165;
            // 
            // colLImportDate
            // 
            this.colLImportDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colLImportDate.AppearanceCell.Options.UseFont = true;
            this.colLImportDate.AppearanceCell.Options.UseTextOptions = true;
            this.colLImportDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLImportDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colLImportDate.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colLImportDate.AppearanceHeader.Options.UseFont = true;
            this.colLImportDate.AppearanceHeader.Options.UseForeColor = true;
            this.colLImportDate.Caption = "Ngày nhập";
            this.colLImportDate.FieldName = "StartDate";
            this.colLImportDate.MinWidth = 30;
            this.colLImportDate.Name = "colLImportDate";
            this.colLImportDate.Visible = true;
            this.colLImportDate.VisibleIndex = 4;
            this.colLImportDate.Width = 165;
            // 
            // colAccountID
            // 
            this.colAccountID.Caption = "nhanvienID";
            this.colAccountID.FieldName = "AccountID";
            this.colAccountID.MinWidth = 30;
            this.colAccountID.Name = "colAccountID";
            this.colAccountID.Width = 112;
            // 
            // colLAccountName
            // 
            this.colLAccountName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colLAccountName.AppearanceCell.Options.UseFont = true;
            this.colLAccountName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colLAccountName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colLAccountName.AppearanceHeader.Options.UseFont = true;
            this.colLAccountName.AppearanceHeader.Options.UseForeColor = true;
            this.colLAccountName.Caption = "Tên Nhân Viên Nhập";
            this.colLAccountName.MinWidth = 30;
            this.colLAccountName.Name = "colLAccountName";
            this.colLAccountName.Visible = true;
            this.colLAccountName.VisibleIndex = 5;
            this.colLAccountName.Width = 171;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Xóa";
            this.colDelete.FieldName = "Xoa";
            this.colDelete.MinWidth = 30;
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 112;
            // 
            // colLNote
            // 
            this.colLNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colLNote.AppearanceCell.Options.UseFont = true;
            this.colLNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colLNote.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colLNote.AppearanceHeader.Options.UseFont = true;
            this.colLNote.AppearanceHeader.Options.UseForeColor = true;
            this.colLNote.Caption = "Ghi Chú";
            this.colLNote.FieldName = "Note";
            this.colLNote.MinWidth = 30;
            this.colLNote.Name = "colLNote";
            this.colLNote.Visible = true;
            this.colLNote.VisibleIndex = 6;
            this.colLNote.Width = 180;
            // 
            // tpInputDetails
            // 
            this.tpInputDetails.Controls.Add(this.spccInputDetails);
            this.tpInputDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpInputDetails.Name = "tpInputDetails";
            this.tpInputDetails.Size = new System.Drawing.Size(1611, 509);
            this.tpInputDetails.Text = "Chi tiết nhập kho";
            // 
            // spccInputDetails
            // 
            this.spccInputDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spccInputDetails.Location = new System.Drawing.Point(0, 0);
            this.spccInputDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccInputDetails.Name = "spccInputDetails";
            // 
            // spccInputDetails.Panel1
            // 
            this.spccInputDetails.Panel1.Controls.Add(this.dtgvListProducts);
            this.spccInputDetails.Panel1.Text = "Panel1";
            // 
            // spccInputDetails.Panel2
            // 
            this.spccInputDetails.Panel2.Controls.Add(this.dtgvInputDetails);
            this.spccInputDetails.Panel2.Text = "Panel2";
            this.spccInputDetails.Size = new System.Drawing.Size(1611, 509);
            this.spccInputDetails.SplitterPosition = 455;
            this.spccInputDetails.TabIndex = 0;
            this.spccInputDetails.Text = "splitContainerControl1";
            // 
            // dtgvListProducts
            // 
            this.dtgvListProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvListProducts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvListProducts.Location = new System.Drawing.Point(0, 0);
            this.dtgvListProducts.MainView = this.gvListProducts;
            this.dtgvListProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvListProducts.Name = "dtgvListProducts";
            this.dtgvListProducts.Size = new System.Drawing.Size(455, 509);
            this.dtgvListProducts.TabIndex = 0;
            this.dtgvListProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListProducts});
            // 
            // gvListProducts
            // 
            this.gvListProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPSTT,
            this.colPProductName,
            this.colPInputSource});
            this.gvListProducts.DetailHeight = 538;
            this.gvListProducts.GridControl = this.dtgvListProducts;
            this.gvListProducts.GroupPanelText = "Danh sách các sản phẩm";
            this.gvListProducts.Name = "gvListProducts";
            this.gvListProducts.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvListProducts.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvListProducts_RowClick);
            this.gvListProducts.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvListProducts_CustomDrawCell);
            // 
            // colPSTT
            // 
            this.colPSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colPSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPSTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colPSTT.AppearanceHeader.Options.UseFont = true;
            this.colPSTT.AppearanceHeader.Options.UseForeColor = true;
            this.colPSTT.Caption = "STT";
            this.colPSTT.MinWidth = 30;
            this.colPSTT.Name = "colPSTT";
            this.colPSTT.Visible = true;
            this.colPSTT.VisibleIndex = 0;
            this.colPSTT.Width = 37;
            // 
            // colPProductName
            // 
            this.colPProductName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPProductName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colPProductName.AppearanceHeader.Options.UseFont = true;
            this.colPProductName.AppearanceHeader.Options.UseForeColor = true;
            this.colPProductName.Caption = "Tên Sản Phẩm";
            this.colPProductName.FieldName = "Name";
            this.colPProductName.MinWidth = 30;
            this.colPProductName.Name = "colPProductName";
            this.colPProductName.Visible = true;
            this.colPProductName.VisibleIndex = 1;
            this.colPProductName.Width = 127;
            // 
            // colPInputSource
            // 
            this.colPInputSource.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPInputSource.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colPInputSource.AppearanceHeader.Options.UseFont = true;
            this.colPInputSource.AppearanceHeader.Options.UseForeColor = true;
            this.colPInputSource.Caption = "Nguồn Nhập";
            this.colPInputSource.FieldName = "InputSource";
            this.colPInputSource.MinWidth = 30;
            this.colPInputSource.Name = "colPInputSource";
            this.colPInputSource.Visible = true;
            this.colPInputSource.VisibleIndex = 2;
            this.colPInputSource.Width = 133;
            // 
            // dtgvInputDetails
            // 
            this.dtgvInputDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInputDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvInputDetails.Location = new System.Drawing.Point(0, 0);
            this.dtgvInputDetails.MainView = this.gvInputDetails;
            this.dtgvInputDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvInputDetails.Name = "dtgvInputDetails";
            this.dtgvInputDetails.Size = new System.Drawing.Size(1141, 509);
            this.dtgvInputDetails.TabIndex = 0;
            this.dtgvInputDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInputDetails});
            // 
            // gvInputDetails
            // 
            this.gvInputDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDSTT,
            this.colDProductName,
            this.colDCount,
            this.colDImportPrice,
            this.colDImportDate,
            this.colDAccountName,
            this.colDNote});
            this.gvInputDetails.DetailHeight = 538;
            this.gvInputDetails.GridControl = this.dtgvInputDetails;
            this.gvInputDetails.GroupPanelText = "Chi Tiết Nhập Kho";
            this.gvInputDetails.Name = "gvInputDetails";
            this.gvInputDetails.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvInputDetails.RowHeight = 46;
            this.gvInputDetails.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvInputDetails_CustomDrawCell);
            // 
            // colDSTT
            // 
            this.colDSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDSTT.AppearanceCell.Options.UseFont = true;
            this.colDSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colDSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDSTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDSTT.AppearanceHeader.Options.UseFont = true;
            this.colDSTT.AppearanceHeader.Options.UseForeColor = true;
            this.colDSTT.Caption = "STT";
            this.colDSTT.MinWidth = 30;
            this.colDSTT.Name = "colDSTT";
            this.colDSTT.Visible = true;
            this.colDSTT.VisibleIndex = 0;
            this.colDSTT.Width = 67;
            // 
            // colDProductName
            // 
            this.colDProductName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDProductName.AppearanceCell.Options.UseFont = true;
            this.colDProductName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDProductName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDProductName.AppearanceHeader.Options.UseFont = true;
            this.colDProductName.AppearanceHeader.Options.UseForeColor = true;
            this.colDProductName.Caption = "Tên Sản Phẩm";
            this.colDProductName.FieldName = "Name";
            this.colDProductName.MinWidth = 30;
            this.colDProductName.Name = "colDProductName";
            this.colDProductName.Visible = true;
            this.colDProductName.VisibleIndex = 1;
            this.colDProductName.Width = 168;
            // 
            // colDCount
            // 
            this.colDCount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDCount.AppearanceCell.Options.UseFont = true;
            this.colDCount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDCount.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDCount.AppearanceHeader.Options.UseFont = true;
            this.colDCount.AppearanceHeader.Options.UseForeColor = true;
            this.colDCount.Caption = "Số Lượng";
            this.colDCount.FieldName = "Count";
            this.colDCount.MinWidth = 30;
            this.colDCount.Name = "colDCount";
            this.colDCount.Visible = true;
            this.colDCount.VisibleIndex = 2;
            this.colDCount.Width = 161;
            // 
            // colDImportPrice
            // 
            this.colDImportPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDImportPrice.AppearanceCell.Options.UseFont = true;
            this.colDImportPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colDImportPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDImportPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDImportPrice.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDImportPrice.AppearanceHeader.Options.UseFont = true;
            this.colDImportPrice.AppearanceHeader.Options.UseForeColor = true;
            this.colDImportPrice.Caption = "Giá Nhập";
            this.colDImportPrice.FieldName = "ImportPrice";
            this.colDImportPrice.MinWidth = 30;
            this.colDImportPrice.Name = "colDImportPrice";
            this.colDImportPrice.Visible = true;
            this.colDImportPrice.VisibleIndex = 3;
            this.colDImportPrice.Width = 176;
            // 
            // colDImportDate
            // 
            this.colDImportDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDImportDate.AppearanceCell.Options.UseFont = true;
            this.colDImportDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDImportDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDImportDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDImportDate.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDImportDate.AppearanceHeader.Options.UseFont = true;
            this.colDImportDate.AppearanceHeader.Options.UseForeColor = true;
            this.colDImportDate.Caption = "Ngày Nhập";
            this.colDImportDate.FieldName = "StartDate";
            this.colDImportDate.MinWidth = 30;
            this.colDImportDate.Name = "colDImportDate";
            this.colDImportDate.Visible = true;
            this.colDImportDate.VisibleIndex = 4;
            this.colDImportDate.Width = 161;
            // 
            // colDAccountName
            // 
            this.colDAccountName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDAccountName.AppearanceCell.Options.UseFont = true;
            this.colDAccountName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDAccountName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDAccountName.AppearanceHeader.Options.UseFont = true;
            this.colDAccountName.AppearanceHeader.Options.UseForeColor = true;
            this.colDAccountName.Caption = "Nhân Viên Nhập";
            this.colDAccountName.MinWidth = 30;
            this.colDAccountName.Name = "colDAccountName";
            this.colDAccountName.Visible = true;
            this.colDAccountName.VisibleIndex = 5;
            this.colDAccountName.Width = 171;
            // 
            // colDNote
            // 
            this.colDNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDNote.AppearanceCell.Options.UseFont = true;
            this.colDNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDNote.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDNote.AppearanceHeader.Options.UseFont = true;
            this.colDNote.AppearanceHeader.Options.UseForeColor = true;
            this.colDNote.Caption = "Ghi Chú";
            this.colDNote.FieldName = "Note";
            this.colDNote.MinWidth = 30;
            this.colDNote.Name = "colDNote";
            this.colDNote.Visible = true;
            this.colDNote.VisibleIndex = 6;
            this.colDNote.Width = 141;
            // 
            // ucInputReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucInputReport";
            this.Size = new System.Drawing.Size(1617, 548);
            this.Load += new System.EventHandler(this.ucInputReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcInputReport)).EndInit();
            this.tcInputReport.ResumeLayout(false);
            this.tpInputList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInputList)).EndInit();
            this.gcInputList.ResumeLayout(false);
            this.gcInputList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListInput)).EndInit();
            this.tpInputDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccInputDetails.Panel1)).EndInit();
            this.spccInputDetails.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccInputDetails.Panel2)).EndInit();
            this.spccInputDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccInputDetails)).EndInit();
            this.spccInputDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInputDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInputDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.GroupControl gcInputList;
        private DevExpress.XtraGrid.GridControl dtgvListInput;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListInput;
        private DevExpress.XtraGrid.Columns.GridColumn colLSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colLProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colLCount;
        private DevExpress.XtraGrid.Columns.GridColumn colLImportPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colLImportDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn colLAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colLNote;
        private System.Windows.Forms.DateTimePicker dtpkEnd;
        private DevExpress.XtraEditors.LabelControl lbEnd;
        private System.Windows.Forms.DateTimePicker dtpkStart;
        private DevExpress.XtraEditors.LabelControl lbStart;
        private DevExpress.XtraEditors.LabelControl lbSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lbSearchResults;
        private DevExpress.XtraTab.XtraTabControl tcInputReport;
        private DevExpress.XtraTab.XtraTabPage tpInputList;
        private DevExpress.XtraTab.XtraTabPage tpInputDetails;
        private DevExpress.XtraEditors.SplitContainerControl spccInputDetails;
        private DevExpress.XtraGrid.GridControl dtgvListProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colPSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colPProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colPInputSource;
        private DevExpress.XtraGrid.GridControl dtgvInputDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInputDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colDSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colDProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colDCount;
        private DevExpress.XtraGrid.Columns.GridColumn colDImportPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDImportDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colDNote;
        //private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
    }
}
