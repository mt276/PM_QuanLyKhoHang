namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucInput
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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.gcInput = new DevExpress.XtraEditors.GroupControl();
            this.spccInput = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnExits = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lbStartDate = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.dtpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtImportPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtCount = new DevExpress.XtraEditors.TextEdit();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.lbSalePrice = new DevExpress.XtraEditors.LabelControl();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            this.lbImportPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbCount = new DevExpress.XtraEditors.LabelControl();
            this.lbProductName = new DevExpress.XtraEditors.LabelControl();
            this.mmedNote = new DevExpress.XtraEditors.MemoEdit();
            this.dtgvInput = new DevExpress.XtraGrid.GridControl();
            this.gvInput = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffInput = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInput)).BeginInit();
            this.gcInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccInput.Panel1)).BeginInit();
            this.spccInput.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccInput.Panel2)).BeginInit();
            this.spccInput.Panel2.SuspendLayout();
            this.spccInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInput)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.pnlMain.Controls.Add(this.gcInput);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "panelControl1";
            this.pnlMain.Size = new System.Drawing.Size(1214, 580);
            this.pnlMain.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.gcInput.Controls.Add(this.spccInput);
            this.gcInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInput.Location = new System.Drawing.Point(2, 2);
            this.gcInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcInput.Name = "groupControl1";
            this.gcInput.Size = new System.Drawing.Size(1210, 576);
            this.gcInput.TabIndex = 0;
            this.gcInput.Text = "Nhập Kho";
            // 
            // splitContainerControl1
            // 
            this.spccInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spccInput.Horizontal = false;
            this.spccInput.Location = new System.Drawing.Point(2, 34);
            this.spccInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccInput.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.spccInput.Panel1.Controls.Add(this.btnExits);
            this.spccInput.Panel1.Controls.Add(this.btnShowAll);
            this.spccInput.Panel1.Controls.Add(this.btnUpdate);
            this.spccInput.Panel1.Controls.Add(this.lbStartDate);
            this.spccInput.Panel1.Controls.Add(this.btnDelete);
            this.spccInput.Panel1.Controls.Add(this.dtpkStartDate);
            this.spccInput.Panel1.Controls.Add(this.btnCancel);
            this.spccInput.Panel1.Controls.Add(this.txtSalePrice);
            this.spccInput.Panel1.Controls.Add(this.btnAdd);
            this.spccInput.Panel1.Controls.Add(this.txtImportPrice);
            this.spccInput.Panel1.Controls.Add(this.txtCount);
            this.spccInput.Panel1.Controls.Add(this.cbUnit);
            this.spccInput.Panel1.Controls.Add(this.cbProductName);
            this.spccInput.Panel1.Controls.Add(this.lbSalePrice);
            this.spccInput.Panel1.Controls.Add(this.lbNote);
            this.spccInput.Panel1.Controls.Add(this.lbImportPrice);
            this.spccInput.Panel1.Controls.Add(this.lbCount);
            this.spccInput.Panel1.Controls.Add(this.lbProductName);
            this.spccInput.Panel1.Controls.Add(this.mmedNote);
            this.spccInput.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.spccInput.Panel2.Controls.Add(this.dtgvInput);
            this.spccInput.Panel2.Text = "Panel2";
            this.spccInput.Size = new System.Drawing.Size(1206, 540);
            this.spccInput.SplitterPosition = 291;
            this.spccInput.TabIndex = 0;
            this.spccInput.Text = "splitContainerControl1";
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(1041, 250);
            this.btnExits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(112, 35);
            this.btnExits.TabIndex = 12;
            this.btnExits.Text = "Thoát";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(847, 250);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(176, 35);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "Danh sách nhập kho";
            this.btnShowAll.ToolTip = "Danh sách mà nhân viên này từng nhập vào kho";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(717, 250);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.toolTip1.SetToolTip(this.btnUpdate, "Cập nhật sản phẩm này");
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(5, 205);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(76, 19);
            this.lbStartDate.TabIndex = 5;
            this.lbStartDate.Text = "Ngày nhập";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(587, 250);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btnDelete, "Xóa sản phầm này");
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.Location = new System.Drawing.Point(130, 200);
            this.dtpkStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(295, 27);
            this.dtpkStartDate.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dtpkStartDate, "Ngày nhập sản phẩm này");
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 250);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy thao tác";
            this.toolTip1.SetToolTip(this.btnCancel, "Hủy thao tác này");
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Enabled = false;
            this.txtSalePrice.Location = new System.Drawing.Point(130, 155);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(295, 26);
            this.txtSalePrice.TabIndex = 4;
            this.txtSalePrice.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(327, 250);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Nhập vào kho";
            this.toolTip1.SetToolTip(this.btnAdd, "Nhập sản phẩm này vào kho");
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Location = new System.Drawing.Point(130, 110);
            this.txtImportPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(295, 26);
            this.txtImportPrice.TabIndex = 3;
            this.txtImportPrice.ToolTip = "Giá nhập";
            this.txtImportPrice.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(130, 65);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(174, 26);
            this.txtCount.TabIndex = 1;
            this.txtCount.ToolTip = "Số lượng sản phẩm";
            this.txtCount.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(313, 65);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(112, 27);
            this.cbUnit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbUnit, "đơn vị tính");
            // 
            // cbProductName
            // 
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(130, 20);
            this.cbProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(295, 27);
            this.cbProductName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbProductName, "Tên sản phẩm");
            // 
            // lbSalePrice
            // 
            this.lbSalePrice.Location = new System.Drawing.Point(5, 160);
            this.lbSalePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSalePrice.Name = "lbSalePrice";
            this.lbSalePrice.Size = new System.Drawing.Size(54, 19);
            this.lbSalePrice.TabIndex = 6;
            this.lbSalePrice.Text = "Giá bán";
            // 
            // lbNote
            // 
            this.lbNote.Location = new System.Drawing.Point(590, 25);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(57, 19);
            this.lbNote.TabIndex = 4;
            this.lbNote.Text = "Ghi Chú";
            // 
            // lbImportPrice
            // 
            this.lbImportPrice.Location = new System.Drawing.Point(5, 115);
            this.lbImportPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbImportPrice.Name = "lbImportPrice";
            this.lbImportPrice.Size = new System.Drawing.Size(63, 19);
            this.lbImportPrice.TabIndex = 6;
            this.lbImportPrice.Text = "Giá nhập";
            // 
            // lbCount
            // 
            this.lbCount.Location = new System.Drawing.Point(5, 70);
            this.lbCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(64, 19);
            this.lbCount.TabIndex = 8;
            this.lbCount.Text = "Số lượng";
            // 
            // lbProductName
            // 
            this.lbProductName.Location = new System.Drawing.Point(5, 25);
            this.lbProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(101, 19);
            this.lbProductName.TabIndex = 7;
            this.lbProductName.Text = "Tên sản phẩm";
            // 
            // mmedNote
            // 
            this.mmedNote.Location = new System.Drawing.Point(668, 25);
            this.mmedNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mmedNote.Name = "mmedNote";
            this.mmedNote.Size = new System.Drawing.Size(452, 135);
            this.mmedNote.TabIndex = 6;
            this.mmedNote.ToolTip = "Ghi chú cho sản phầm này";
            this.mmedNote.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // dtgvInput
            // 
            this.dtgvInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInput.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvInput.Location = new System.Drawing.Point(0, 0);
            this.dtgvInput.MainView = this.gvInput;
            this.dtgvInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvInput.Name = "dtgvInput";
            this.dtgvInput.Size = new System.Drawing.Size(1206, 234);
            this.dtgvInput.TabIndex = 0;
            this.dtgvInput.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInput});
            // 
            // gvInput
            // 
            this.gvInput.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colProductName,
            this.colProductID,
            this.colCount,
            this.colImportPrice,
            this.colSalePrice,
            this.colStartDate,
            this.colStaffInput,
            this.colStaffID,
            this.colDelete,
            this.colNote});
            this.gvInput.DetailHeight = 538;
            this.gvInput.GridControl = this.dtgvInput;
            this.gvInput.GroupPanelText = " ";
            this.gvInput.Name = "gvInput";
            this.gvInput.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvInput.RowHeight = 62;
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
            this.colProductName.MinWidth = 30;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 157;
            // 
            // colProductID
            // 
            this.colProductID.Caption = "SanPhamID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.MinWidth = 30;
            this.colProductID.Name = "colProductID";
            this.colProductID.Width = 112;
            // 
            // colCount
            // 
            this.colCount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colCount.AppearanceCell.Options.UseFont = true;
            this.colCount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCount.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colCount.AppearanceHeader.Options.UseFont = true;
            this.colCount.AppearanceHeader.Options.UseForeColor = true;
            this.colCount.Caption = "Số Lượng";
            this.colCount.FieldName = "Count";
            this.colCount.MinWidth = 30;
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 2;
            this.colCount.Width = 157;
            // 
            // colImportPrice
            // 
            this.colImportPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colImportPrice.AppearanceCell.Options.UseFont = true;
            this.colImportPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colImportPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImportPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colImportPrice.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colImportPrice.AppearanceHeader.Options.UseFont = true;
            this.colImportPrice.AppearanceHeader.Options.UseForeColor = true;
            this.colImportPrice.Caption = "Giá Nhập";
            this.colImportPrice.FieldName = "ImportPrice";
            this.colImportPrice.MinWidth = 30;
            this.colImportPrice.Name = "colImportPrice";
            this.colImportPrice.Visible = true;
            this.colImportPrice.VisibleIndex = 3;
            this.colImportPrice.Width = 157;
            // 
            // colSalePrice
            // 
            this.colSalePrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colSalePrice.AppearanceCell.Options.UseFont = true;
            this.colSalePrice.AppearanceCell.Options.UseTextOptions = true;
            this.colSalePrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSalePrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSalePrice.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSalePrice.AppearanceHeader.Options.UseFont = true;
            this.colSalePrice.AppearanceHeader.Options.UseForeColor = true;
            this.colSalePrice.Caption = "Giá Bán";
            this.colSalePrice.MinWidth = 30;
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.Visible = true;
            this.colSalePrice.VisibleIndex = 4;
            this.colSalePrice.Width = 157;
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
            this.colStartDate.Caption = "Ngày Nhập";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.MinWidth = 30;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 5;
            this.colStartDate.Width = 157;
            // 
            // colStaffInput
            // 
            this.colStaffInput.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colStaffInput.AppearanceCell.Options.UseFont = true;
            this.colStaffInput.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStaffInput.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStaffInput.AppearanceHeader.Options.UseFont = true;
            this.colStaffInput.AppearanceHeader.Options.UseForeColor = true;
            this.colStaffInput.Caption = "Nhân Viên Nhập";
            this.colStaffInput.MinWidth = 30;
            this.colStaffInput.Name = "colStaffInput";
            this.colStaffInput.Visible = true;
            this.colStaffInput.VisibleIndex = 6;
            this.colStaffInput.Width = 157;
            // 
            // colStaffID
            // 
            this.colStaffID.Caption = "NhanVienID";
            this.colStaffID.FieldName = "StaffID";
            this.colStaffID.MinWidth = 30;
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.Width = 112;
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
            this.colNote.FieldName = "GhiChu";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 177;
            // 
            // ucInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucInput";
            this.Size = new System.Drawing.Size(1214, 580);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInput)).EndInit();
            this.gcInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccInput.Panel1)).EndInit();
            this.spccInput.Panel1.ResumeLayout(false);
            this.spccInput.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccInput.Panel2)).EndInit();
            this.spccInput.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccInput)).EndInit();
            this.spccInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.GroupControl gcInput;
        private DevExpress.XtraEditors.SplitContainerControl spccInput;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl lbStartDate;
        private System.Windows.Forms.DateTimePicker dtpkStartDate;
        private DevExpress.XtraEditors.TextEdit txtImportPrice;
        private DevExpress.XtraEditors.TextEdit txtCount;
        private System.Windows.Forms.ComboBox cbProductName;
        private DevExpress.XtraEditors.LabelControl lbNote;
        private DevExpress.XtraEditors.LabelControl lbImportPrice;
        private DevExpress.XtraEditors.LabelControl lbCount;
        private DevExpress.XtraEditors.LabelControl lbProductName;
        private DevExpress.XtraEditors.MemoEdit mmedNote;
        private DevExpress.XtraGrid.GridControl dtgvInput;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colImportPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffInput;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffID;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.SimpleButton btnShowAll;
        private DevExpress.XtraEditors.TextEdit txtSalePrice;
        private DevExpress.XtraEditors.LabelControl lbSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSalePrice;
        private DevExpress.XtraEditors.SimpleButton btnExits;
    }
}
