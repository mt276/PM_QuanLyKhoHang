namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucProductInfo
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
            this.gcProductInfo = new DevExpress.XtraEditors.GroupControl();
            this.pnlAct = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnExits = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lbSearchResults = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dtgvProductInfo = new DevExpress.XtraGrid.GridControl();
            this.gvProductInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimensions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInputSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductInfo)).BeginInit();
            this.gcProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAct)).BeginInit();
            this.pnlAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gcProductInfo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(819, 458);
            this.pnlMain.TabIndex = 0;
            // 
            // gcProductInfo
            // 
            this.gcProductInfo.Controls.Add(this.pnlAct);
            this.gcProductInfo.Controls.Add(this.pnlSearch);
            this.gcProductInfo.Controls.Add(this.panelControl1);
            this.gcProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductInfo.Location = new System.Drawing.Point(2, 2);
            this.gcProductInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcProductInfo.Name = "gcProductInfo";
            this.gcProductInfo.Size = new System.Drawing.Size(815, 454);
            this.gcProductInfo.TabIndex = 0;
            this.gcProductInfo.Text = "Danh sách các sản phẩm hiện có trong công ty";
            // 
            // pnlAct
            // 
            this.pnlAct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAct.Controls.Add(this.btnCancel);
            this.pnlAct.Controls.Add(this.btnExits);
            this.pnlAct.Controls.Add(this.btnDelete);
            this.pnlAct.Location = new System.Drawing.Point(-3, 382);
            this.pnlAct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAct.Name = "pnlAct";
            this.pnlAct.Size = new System.Drawing.Size(816, 69);
            this.pnlAct.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(562, 20);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(687, 20);
            this.btnExits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(112, 35);
            this.btnExits.TabIndex = 3;
            this.btnExits.Text = "Thoát";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(436, 20);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lbSearchResults);
            this.pnlSearch.Location = new System.Drawing.Point(0, 34);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(814, 57);
            this.pnlSearch.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(380, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(400, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.Location = new System.Drawing.Point(540, 20);
            this.lbSearchResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(126, 19);
            this.lbSearchResults.TabIndex = 3;
            this.lbSearchResults.Text = "Kết quả tìm kiếm:";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.dtgvProductInfo);
            this.panelControl1.Location = new System.Drawing.Point(-3, 86);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(816, 300);
            this.panelControl1.TabIndex = 4;
            // 
            // dtgvProductInfo
            // 
            this.dtgvProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProductInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvProductInfo.Location = new System.Drawing.Point(2, 2);
            this.dtgvProductInfo.MainView = this.gvProductInfo;
            this.dtgvProductInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvProductInfo.Name = "dtgvProductInfo";
            this.dtgvProductInfo.Size = new System.Drawing.Size(812, 296);
            this.dtgvProductInfo.TabIndex = 0;
            this.dtgvProductInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductInfo});
            // 
            // gvProductInfo
            // 
            this.gvProductInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colProductName,
            this.colDimensions,
            this.colUnitID,
            this.colUnit,
            this.colStock,
            this.colStartDate,
            this.colInputSource,
            this.colNote,
            this.colDelete});
            this.gvProductInfo.DetailHeight = 538;
            this.gvProductInfo.FixedLineWidth = 1;
            this.gvProductInfo.GridControl = this.dtgvProductInfo;
            this.gvProductInfo.GroupPanelText = " ";
            this.gvProductInfo.Name = "gvProductInfo";
            this.gvProductInfo.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvProductInfo.RowHeight = 46;
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
            this.colSTT.Width = 94;
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
            this.colProductName.Caption = "Tên Sản Phẩm";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 30;
            this.colProductName.Name = "colProductName";
            this.colProductName.ToolTip = "Tên sản phẩm";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 241;
            // 
            // colDimensions
            // 
            this.colDimensions.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colDimensions.AppearanceCell.Options.UseFont = true;
            this.colDimensions.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDimensions.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDimensions.AppearanceHeader.Options.UseFont = true;
            this.colDimensions.AppearanceHeader.Options.UseForeColor = true;
            this.colDimensions.Caption = "Quy Cách";
            this.colDimensions.FieldName = "Dimensions";
            this.colDimensions.MinWidth = 30;
            this.colDimensions.Name = "colDimensions";
            this.colDimensions.ToolTip = "Quy cách của sản phẩm";
            this.colDimensions.Visible = true;
            this.colDimensions.VisibleIndex = 2;
            this.colDimensions.Width = 180;
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
            this.colUnit.Caption = "Đơn Vị Tính";
            this.colUnit.FieldName = "Unit";
            this.colUnit.MinWidth = 30;
            this.colUnit.Name = "colUnit";
            this.colUnit.ToolTip = "Tên đơn vị tính";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 3;
            this.colUnit.Width = 196;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colStock.AppearanceCell.Options.UseFont = true;
            this.colStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStock.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStock.AppearanceHeader.Options.UseFont = true;
            this.colStock.AppearanceHeader.Options.UseForeColor = true;
            this.colStock.Caption = "Số Lượng Tồn";
            this.colStock.FieldName = "Stock";
            this.colStock.MinWidth = 30;
            this.colStock.Name = "colStock";
            this.colStock.ToolTip = "Số lượng tồn trong kho";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 4;
            this.colStock.Width = 190;
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
            this.colStartDate.Caption = "Ngày Tạo";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.MinWidth = 30;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 5;
            this.colStartDate.Width = 196;
            // 
            // colInputSource
            // 
            this.colInputSource.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colInputSource.AppearanceCell.Options.UseFont = true;
            this.colInputSource.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colInputSource.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colInputSource.AppearanceHeader.Options.UseFont = true;
            this.colInputSource.AppearanceHeader.Options.UseForeColor = true;
            this.colInputSource.Caption = "Nguồn Nhập";
            this.colInputSource.FieldName = "InputSource";
            this.colInputSource.MinWidth = 30;
            this.colInputSource.Name = "colInputSource";
            this.colInputSource.ToolTip = "Nguồn nhập sản phẩm";
            this.colInputSource.Visible = true;
            this.colInputSource.VisibleIndex = 6;
            this.colInputSource.Width = 196;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colNote.AppearanceCell.Options.UseFont = true;
            this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNote.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colNote.AppearanceHeader.Options.UseFont = true;
            this.colNote.AppearanceHeader.Options.UseForeColor = true;
            this.colNote.Caption = "Ghi Chú";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.ToolTip = "Ghi chú thông tin thêm cho sản phẩm";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 189;
            // 
            // colDelete
            // 
            this.colDelete.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colDelete.AppearanceCell.Options.UseFont = true;
            this.colDelete.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDelete.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colDelete.AppearanceHeader.Options.UseFont = true;
            this.colDelete.AppearanceHeader.Options.UseForeColor = true;
            this.colDelete.Caption = "Xóa";
            this.colDelete.FieldName = "Delete";
            this.colDelete.MinWidth = 30;
            this.colDelete.Name = "colDelete";
            this.colDelete.ToolTip = "Đánh dấu sản phẩm cần xóa";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 8;
            this.colDelete.Width = 82;
            // 
            // ucProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucProductInfo";
            this.Size = new System.Drawing.Size(819, 458);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProductInfo)).EndInit();
            this.gcProductInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAct)).EndInit();
            this.pnlAct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.GroupControl gcProductInfo;
        private DevExpress.XtraGrid.GridControl dtgvProductInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductInfo;
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
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl lbSearchResults;
        private DevExpress.XtraEditors.PanelControl pnlAct;
        private DevExpress.XtraEditors.PanelControl pnlSearch;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExits;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;

    }
}

