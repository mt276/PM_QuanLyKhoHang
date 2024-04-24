namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucAddProducts
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
            this.gcAddProducts = new DevExpress.XtraEditors.GroupControl();
            this.spccAddProducts = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lklbAddUnit = new System.Windows.Forms.LinkLabel();
            this.dtpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.lbUnit = new DevExpress.XtraEditors.LabelControl();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            this.txtInputSource = new DevExpress.XtraEditors.TextEdit();
            this.lbInputSource = new DevExpress.XtraEditors.LabelControl();
            this.lbDimensions = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.lbStartDate = new DevExpress.XtraEditors.LabelControl();
            this.lbProductName = new DevExpress.XtraEditors.LabelControl();
            this.mmedDimensions = new DevExpress.XtraEditors.MemoEdit();
            this.mmedNote = new DevExpress.XtraEditors.MemoEdit();
            this.dtgvAddProducts = new DevExpress.XtraGrid.GridControl();
            this.gvAddProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimensions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInputSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAddProducts)).BeginInit();
            this.gcAddProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAddProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccAddProducts.Panel1)).BeginInit();
            this.spccAddProducts.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAddProducts.Panel2)).BeginInit();
            this.spccAddProducts.Panel2.SuspendLayout();
            this.spccAddProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedDimensions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAddProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gcAddProducts);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1304, 557);
            this.pnlMain.TabIndex = 0;
            // 
            // gcAddProducts
            // 
            this.gcAddProducts.Controls.Add(this.spccAddProducts);
            this.gcAddProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAddProducts.Location = new System.Drawing.Point(2, 2);
            this.gcAddProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcAddProducts.Name = "gcAddProducts";
            this.gcAddProducts.Size = new System.Drawing.Size(1300, 553);
            this.gcAddProducts.TabIndex = 0;
            this.gcAddProducts.Text = "Thêm Sản Phẩm Mới";
            // 
            // spccAddProducts
            // 
            this.spccAddProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spccAddProducts.Horizontal = false;
            this.spccAddProducts.Location = new System.Drawing.Point(2, 34);
            this.spccAddProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccAddProducts.Name = "spccAddProducts";
            // 
            // spccAddProducts.Panel1
            // 
            this.spccAddProducts.Panel1.Controls.Add(this.btnUpdate);
            this.spccAddProducts.Panel1.Controls.Add(this.btnDelete);
            this.spccAddProducts.Panel1.Controls.Add(this.btnCancel);
            this.spccAddProducts.Panel1.Controls.Add(this.btnAdd);
            this.spccAddProducts.Panel1.Controls.Add(this.lklbAddUnit);
            this.spccAddProducts.Panel1.Controls.Add(this.dtpkStartDate);
            this.spccAddProducts.Panel1.Controls.Add(this.cbUnit);
            this.spccAddProducts.Panel1.Controls.Add(this.lbUnit);
            this.spccAddProducts.Panel1.Controls.Add(this.lbNote);
            this.spccAddProducts.Panel1.Controls.Add(this.txtInputSource);
            this.spccAddProducts.Panel1.Controls.Add(this.lbInputSource);
            this.spccAddProducts.Panel1.Controls.Add(this.lbDimensions);
            this.spccAddProducts.Panel1.Controls.Add(this.txtProductName);
            this.spccAddProducts.Panel1.Controls.Add(this.lbStartDate);
            this.spccAddProducts.Panel1.Controls.Add(this.lbProductName);
            this.spccAddProducts.Panel1.Controls.Add(this.mmedDimensions);
            this.spccAddProducts.Panel1.Controls.Add(this.mmedNote);
            this.spccAddProducts.Panel1.Text = "Panel1";
            // 
            // spccAddProducts.Panel2
            // 
            this.spccAddProducts.Panel2.Controls.Add(this.dtgvAddProducts);
            this.spccAddProducts.Panel2.Text = "Panel2";
            this.spccAddProducts.Size = new System.Drawing.Size(1296, 517);
            this.spccAddProducts.SplitterPosition = 280;
            this.spccAddProducts.TabIndex = 0;
            this.spccAddProducts.Text = "splitContainerControl1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1100, 238);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(958, 238);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(816, 238);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy thao tác";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(675, 238);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            // 
            // lklbAddUnit
            // 
            this.lklbAddUnit.AutoSize = true;
            this.lklbAddUnit.Location = new System.Drawing.Point(374, 193);
            this.lklbAddUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklbAddUnit.Name = "lklbAddUnit";
            this.lklbAddUnit.Size = new System.Drawing.Size(131, 19);
            this.lklbAddUnit.TabIndex = 3;
            this.lklbAddUnit.TabStop = true;
            this.lklbAddUnit.Text = "Thêm đơn vị tính";
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.Location = new System.Drawing.Point(840, 20);
            this.dtpkStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(295, 27);
            this.dtpkStartDate.TabIndex = 4;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(170, 190);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(177, 27);
            this.cbUnit.TabIndex = 2;
            // 
            // lbUnit
            // 
            this.lbUnit.Location = new System.Drawing.Point(5, 195);
            this.lbUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(78, 19);
            this.lbUnit.TabIndex = 0;
            this.lbUnit.Text = "Đơn vị tính";
            // 
            // lbNote
            // 
            this.lbNote.Location = new System.Drawing.Point(710, 125);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(54, 19);
            this.lbNote.TabIndex = 0;
            this.lbNote.Text = "Ghi chú";
            // 
            // txtInputSource
            // 
            this.txtInputSource.Location = new System.Drawing.Point(840, 72);
            this.txtInputSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputSource.Name = "txtInputSource";
            this.txtInputSource.Size = new System.Drawing.Size(295, 26);
            this.txtInputSource.TabIndex = 5;
            // 
            // lbInputSource
            // 
            this.lbInputSource.Location = new System.Drawing.Point(710, 75);
            this.lbInputSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbInputSource.Name = "lbInputSource";
            this.lbInputSource.Size = new System.Drawing.Size(87, 19);
            this.lbInputSource.TabIndex = 0;
            this.lbInputSource.Text = "Nguồn nhập";
            // 
            // lbDimensions
            // 
            this.lbDimensions.Location = new System.Drawing.Point(5, 75);
            this.lbDimensions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbDimensions.Name = "lbDimensions";
            this.lbDimensions.Size = new System.Drawing.Size(65, 19);
            this.lbDimensions.TabIndex = 0;
            this.lbDimensions.Text = "Quy cách";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(170, 20);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(380, 26);
            this.txtProductName.TabIndex = 0;
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(710, 25);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(63, 19);
            this.lbStartDate.TabIndex = 0;
            this.lbStartDate.Text = "Ngày tạo";
            // 
            // lbProductName
            // 
            this.lbProductName.Location = new System.Drawing.Point(5, 25);
            this.lbProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(101, 19);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Tên sản phẩm";
            // 
            // mmedDimensions
            // 
            this.mmedDimensions.Location = new System.Drawing.Point(170, 70);
            this.mmedDimensions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mmedDimensions.Name = "mmedDimensions";
            this.mmedDimensions.Size = new System.Drawing.Size(380, 95);
            this.mmedDimensions.TabIndex = 1;
            // 
            // mmedNote
            // 
            this.mmedNote.Location = new System.Drawing.Point(840, 125);
            this.mmedNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mmedNote.Name = "mmedNote";
            this.mmedNote.Size = new System.Drawing.Size(400, 91);
            this.mmedNote.TabIndex = 6;
            // 
            // dtgvAddProducts
            // 
            this.dtgvAddProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAddProducts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvAddProducts.Location = new System.Drawing.Point(0, 0);
            this.dtgvAddProducts.MainView = this.gvAddProducts;
            this.dtgvAddProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvAddProducts.Name = "dtgvAddProducts";
            this.dtgvAddProducts.Size = new System.Drawing.Size(1296, 222);
            this.dtgvAddProducts.TabIndex = 0;
            this.dtgvAddProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAddProducts});
            // 
            // gvAddProducts
            // 
            this.gvAddProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colProductName,
            this.colDimensions,
            this.colUnit,
            this.colStock,
            this.colStartDate,
            this.colInputSource,
            this.colDelete,
            this.colNote,
            this.colUnitID});
            this.gvAddProducts.DetailHeight = 538;
            this.gvAddProducts.FixedLineWidth = 1;
            this.gvAddProducts.GridControl = this.dtgvAddProducts;
            this.gvAddProducts.GroupPanelText = " ";
            this.gvAddProducts.Name = "gvAddProducts";
            this.gvAddProducts.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvAddProducts.RowHeight = 46;
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
            this.colSTT.Width = 73;
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
            this.colProductName.Width = 259;
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
            this.colDimensions.Width = 190;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colUnit.AppearanceCell.Options.UseFont = true;
            this.colUnit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colUnit.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colUnit.AppearanceHeader.Options.UseFont = true;
            this.colUnit.AppearanceHeader.Options.UseForeColor = true;
            this.colUnit.Caption = "Đơn vị tính";
            this.colUnit.MinWidth = 30;
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 3;
            this.colUnit.Width = 184;
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
            this.colStock.Width = 214;
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
            this.colStartDate.Width = 220;
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
            this.colInputSource.Width = 244;
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
            this.colNote.Width = 180;
            // 
            // colUnitID
            // 
            this.colUnitID.Caption = "Đơn vị tính ID";
            this.colUnitID.FieldName = "UnitID";
            this.colUnitID.MinWidth = 30;
            this.colUnitID.Name = "colUnitID";
            this.colUnitID.Width = 112;
            // 
            // ucAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucAddProducts";
            this.Size = new System.Drawing.Size(1304, 557);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAddProducts)).EndInit();
            this.gcAddProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccAddProducts.Panel1)).EndInit();
            this.spccAddProducts.Panel1.ResumeLayout(false);
            this.spccAddProducts.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccAddProducts.Panel2)).EndInit();
            this.spccAddProducts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccAddProducts)).EndInit();
            this.spccAddProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInputSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedDimensions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAddProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.GroupControl gcAddProducts;
        private DevExpress.XtraEditors.SplitContainerControl spccAddProducts;
        private System.Windows.Forms.LinkLabel lklbAddUnit;
        private System.Windows.Forms.DateTimePicker dtpkStartDate;
        private System.Windows.Forms.ComboBox cbUnit;
        private DevExpress.XtraEditors.LabelControl lbUnit;
        private DevExpress.XtraEditors.LabelControl lbNote;
        private DevExpress.XtraEditors.TextEdit txtInputSource;
        private DevExpress.XtraEditors.LabelControl lbInputSource;
        private DevExpress.XtraEditors.LabelControl lbDimensions;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.LabelControl lbStartDate;
        private DevExpress.XtraEditors.LabelControl lbProductName;
        private DevExpress.XtraEditors.MemoEdit mmedDimensions;
        private DevExpress.XtraGrid.GridControl dtgvAddProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAddProducts;
        private DevExpress.XtraEditors.MemoEdit mmedNote;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colDimensions;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInputSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitID;
    }
}
