namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucProfit
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
            this.gcProfit = new DevExpress.XtraEditors.GroupControl();
            this.tcProfit = new DevExpress.XtraTab.XtraTabControl();
            this.tpProfit = new DevExpress.XtraTab.XtraTabPage();
            this.spccW64Profit = new DevExpress.XtraCharts.Wizard.SplitContainerControlWin64();
            this.dtgvProfitDetails = new DevExpress.XtraGrid.GridControl();
            this.gvProfitDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevenue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommissions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShippingCosts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.lbTotalBill = new DevExpress.XtraEditors.LabelControl();
            this.lbCommissions = new DevExpress.XtraEditors.LabelControl();
            this.lbNetProfit = new DevExpress.XtraEditors.LabelControl();
            this.lbShippingCosts = new DevExpress.XtraEditors.LabelControl();
            this.lbGrossProfit = new DevExpress.XtraEditors.LabelControl();
            this.lbTotalProfit = new DevExpress.XtraEditors.LabelControl();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.rdThisYear = new System.Windows.Forms.RadioButton();
            this.rdThisDay = new System.Windows.Forms.RadioButton();
            this.rdToday = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcProfit)).BeginInit();
            this.gcProfit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcProfit)).BeginInit();
            this.tcProfit.SuspendLayout();
            this.tpProfit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccW64Profit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccW64Profit.Panel1)).BeginInit();
            this.spccW64Profit.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccW64Profit.Panel2)).BeginInit();
            this.spccW64Profit.Panel2.SuspendLayout();
            this.spccW64Profit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProfitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcProfit
            // 
            this.gcProfit.Controls.Add(this.tcProfit);
            this.gcProfit.Controls.Add(this.pnlSearch);
            this.gcProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProfit.Location = new System.Drawing.Point(0, 0);
            this.gcProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcProfit.Name = "gcProfit";
            this.gcProfit.Size = new System.Drawing.Size(838, 449);
            this.gcProfit.TabIndex = 0;
            this.gcProfit.Text = "Báo Cáo Lợi Nhuận";
            // 
            // tcProfit
            // 
            this.tcProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProfit.Location = new System.Drawing.Point(2, 106);
            this.tcProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcProfit.Name = "tcProfit";
            this.tcProfit.SelectedTabPage = this.tpProfit;
            this.tcProfit.Size = new System.Drawing.Size(834, 341);
            this.tcProfit.TabIndex = 0;
            this.tcProfit.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpProfit});
            // 
            // tpProfit
            // 
            this.tpProfit.Controls.Add(this.spccW64Profit);
            this.tpProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpProfit.Name = "tpProfit";
            this.tpProfit.Size = new System.Drawing.Size(832, 306);
            this.tpProfit.Text = "Chi Tiết";
            // 
            // spccW64Profit
            // 
            this.spccW64Profit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spccW64Profit.Horizontal = false;
            this.spccW64Profit.Location = new System.Drawing.Point(0, 0);
            this.spccW64Profit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccW64Profit.Name = "spccW64Profit";
            // 
            // spccW64Profit.Panel1
            // 
            this.spccW64Profit.Panel1.Controls.Add(this.dtgvProfitDetails);
            this.spccW64Profit.Panel1.Text = "Panel1";
            // 
            // spccW64Profit.Panel2
            // 
            this.spccW64Profit.Panel2.Controls.Add(this.btnExportExcel);
            this.spccW64Profit.Panel2.Controls.Add(this.lbTotalBill);
            this.spccW64Profit.Panel2.Controls.Add(this.lbCommissions);
            this.spccW64Profit.Panel2.Controls.Add(this.lbNetProfit);
            this.spccW64Profit.Panel2.Controls.Add(this.lbShippingCosts);
            this.spccW64Profit.Panel2.Controls.Add(this.lbGrossProfit);
            this.spccW64Profit.Panel2.Controls.Add(this.lbTotalProfit);
            this.spccW64Profit.Panel2.Text = "Panel2";
            this.spccW64Profit.Size = new System.Drawing.Size(832, 306);
            this.spccW64Profit.SplitterPosition = 232;
            this.spccW64Profit.TabIndex = 1;
            this.spccW64Profit.Text = "splitContainerControlWin641";
            // 
            // dtgvProfitDetails
            // 
            this.dtgvProfitDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProfitDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvProfitDetails.Location = new System.Drawing.Point(0, 0);
            this.dtgvProfitDetails.MainView = this.gvProfitDetails;
            this.dtgvProfitDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvProfitDetails.Name = "dtgvProfitDetails";
            this.dtgvProfitDetails.Size = new System.Drawing.Size(832, 232);
            this.dtgvProfitDetails.TabIndex = 0;
            this.dtgvProfitDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProfitDetails});
            // 
            // gvProfitDetails
            // 
            this.gvProfitDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colBillName,
            this.colCompanyName,
            this.colStaffName,
            this.colStartDate,
            this.colTotalBill,
            this.colTotalPayment,
            this.colRevenue,
            this.colCommissions,
            this.colShippingCosts,
            this.colNote});
            this.gvProfitDetails.DetailHeight = 538;
            this.gvProfitDetails.GridControl = this.dtgvProfitDetails;
            this.gvProfitDetails.GroupPanelText = " ";
            this.gvProfitDetails.Name = "gvProfitDetails";
            this.gvProfitDetails.OptionsEditForm.PopupEditFormWidth = 1200;
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colSTT.AppearanceCell.Options.UseFont = true;
            this.colSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseForeColor = true;
            this.colSTT.Caption = "STT";
            this.colSTT.MinWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 37;
            // 
            // colBillName
            // 
            this.colBillName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colBillName.AppearanceCell.Options.UseFont = true;
            this.colBillName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colBillName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colBillName.AppearanceHeader.Options.UseFont = true;
            this.colBillName.AppearanceHeader.Options.UseForeColor = true;
            this.colBillName.Caption = "Tên Hóa Đơn";
            this.colBillName.FieldName = "BillName";
            this.colBillName.MinWidth = 30;
            this.colBillName.Name = "colBillName";
            this.colBillName.Visible = true;
            this.colBillName.VisibleIndex = 1;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
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
            this.colCompanyName.VisibleIndex = 2;
            // 
            // colStaffName
            // 
            this.colStaffName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colStaffName.AppearanceCell.Options.UseFont = true;
            this.colStaffName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStaffName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStaffName.AppearanceHeader.Options.UseFont = true;
            this.colStaffName.AppearanceHeader.Options.UseForeColor = true;
            this.colStaffName.Caption = "Nhân Viên Bán";
            this.colStaffName.FieldName = "StaffName";
            this.colStaffName.MinWidth = 30;
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.Visible = true;
            this.colStaffName.VisibleIndex = 3;
            // 
            // colStartDate
            // 
            this.colStartDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colStartDate.AppearanceCell.Options.UseFont = true;
            this.colStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStartDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStartDate.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStartDate.AppearanceHeader.Options.UseFont = true;
            this.colStartDate.AppearanceHeader.Options.UseForeColor = true;
            this.colStartDate.Caption = "Ngày Lập";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.MinWidth = 30;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 4;
            // 
            // colTotalBill
            // 
            this.colTotalBill.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colTotalBill.AppearanceCell.Options.UseFont = true;
            this.colTotalBill.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalBill.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalBill.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTotalBill.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colTotalBill.AppearanceHeader.Options.UseFont = true;
            this.colTotalBill.AppearanceHeader.Options.UseForeColor = true;
            this.colTotalBill.Caption = "Tổng Tiền Hóa Đơn";
            this.colTotalBill.FieldName = "TotalBill";
            this.colTotalBill.MinWidth = 30;
            this.colTotalBill.Name = "colTotalBill";
            this.colTotalBill.Visible = true;
            this.colTotalBill.VisibleIndex = 5;
            // 
            // colTotalPayment
            // 
            this.colTotalPayment.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colTotalPayment.AppearanceCell.Options.UseFont = true;
            this.colTotalPayment.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalPayment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalPayment.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTotalPayment.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colTotalPayment.AppearanceHeader.Options.UseFont = true;
            this.colTotalPayment.AppearanceHeader.Options.UseForeColor = true;
            this.colTotalPayment.Caption = "Thanh Toán Trước";
            this.colTotalPayment.FieldName = "TotalPayment";
            this.colTotalPayment.MinWidth = 30;
            this.colTotalPayment.Name = "colTotalPayment";
            this.colTotalPayment.Visible = true;
            this.colTotalPayment.VisibleIndex = 6;
            // 
            // colRevenue
            // 
            this.colRevenue.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colRevenue.AppearanceCell.Options.UseFont = true;
            this.colRevenue.AppearanceCell.Options.UseTextOptions = true;
            this.colRevenue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colRevenue.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colRevenue.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colRevenue.AppearanceHeader.Options.UseFont = true;
            this.colRevenue.AppearanceHeader.Options.UseForeColor = true;
            this.colRevenue.Caption = "Doanh thu";
            this.colRevenue.FieldName = "Revenue";
            this.colRevenue.MinWidth = 30;
            this.colRevenue.Name = "colRevenue";
            this.colRevenue.Visible = true;
            this.colRevenue.VisibleIndex = 7;
            // 
            // colCommissions
            // 
            this.colCommissions.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colCommissions.AppearanceCell.Options.UseFont = true;
            this.colCommissions.AppearanceCell.Options.UseTextOptions = true;
            this.colCommissions.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCommissions.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCommissions.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colCommissions.AppearanceHeader.Options.UseFont = true;
            this.colCommissions.AppearanceHeader.Options.UseForeColor = true;
            this.colCommissions.Caption = "Hoa Hồng";
            this.colCommissions.FieldName = "Commissions";
            this.colCommissions.MinWidth = 30;
            this.colCommissions.Name = "colCommissions";
            this.colCommissions.Visible = true;
            this.colCommissions.VisibleIndex = 8;
            // 
            // colShippingCosts
            // 
            this.colShippingCosts.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colShippingCosts.AppearanceCell.Options.UseFont = true;
            this.colShippingCosts.AppearanceCell.Options.UseTextOptions = true;
            this.colShippingCosts.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colShippingCosts.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colShippingCosts.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colShippingCosts.AppearanceHeader.Options.UseFont = true;
            this.colShippingCosts.AppearanceHeader.Options.UseForeColor = true;
            this.colShippingCosts.Caption = "Phí Vận Chuyển";
            this.colShippingCosts.FieldName = "ShippingCosts";
            this.colShippingCosts.MinWidth = 30;
            this.colShippingCosts.Name = "colShippingCosts";
            this.colShippingCosts.Visible = true;
            this.colShippingCosts.VisibleIndex = 9;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colNote.AppearanceCell.Options.UseFont = true;
            this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNote.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colNote.AppearanceHeader.Options.UseFont = true;
            this.colNote.AppearanceHeader.Options.UseForeColor = true;
            this.colNote.Caption = "Ghi Chú";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 10;
            this.colNote.Width = 84;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Location = new System.Drawing.Point(2, -391);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(160, 35);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "Xuất Ra File Excel";
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.Location = new System.Drawing.Point(58, 4);
            this.lbTotalBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(197, 19);
            this.lbTotalBill.TabIndex = 0;
            this.lbTotalBill.Text = "Tổng Tiền Tất Cả Hóa Đơn:";
            // 
            // lbCommissions
            // 
            this.lbCommissions.Location = new System.Drawing.Point(58, 122);
            this.lbCommissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCommissions.Name = "lbCommissions";
            this.lbCommissions.Size = new System.Drawing.Size(119, 19);
            this.lbCommissions.TabIndex = 0;
            this.lbCommissions.Text = "Tổng Hoa Hồng:";
            // 
            // lbNetProfit
            // 
            this.lbNetProfit.Location = new System.Drawing.Point(58, 151);
            this.lbNetProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNetProfit.Name = "lbNetProfit";
            this.lbNetProfit.Size = new System.Drawing.Size(157, 19);
            this.lbNetProfit.TabIndex = 0;
            this.lbNetProfit.Text = "Lợi Nhuận Cuối Cùng:";
            // 
            // lbShippingCosts
            // 
            this.lbShippingCosts.Location = new System.Drawing.Point(58, 92);
            this.lbShippingCosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbShippingCosts.Name = "lbShippingCosts";
            this.lbShippingCosts.Size = new System.Drawing.Size(118, 19);
            this.lbShippingCosts.TabIndex = 0;
            this.lbShippingCosts.Text = "Phí Vận Chuyển:";
            // 
            // lbGrossProfit
            // 
            this.lbGrossProfit.Location = new System.Drawing.Point(58, 63);
            this.lbGrossProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbGrossProfit.Name = "lbGrossProfit";
            this.lbGrossProfit.Size = new System.Drawing.Size(153, 19);
            this.lbGrossProfit.TabIndex = 0;
            this.lbGrossProfit.Text = "Lợi Nhuận Thu Được:";
            // 
            // lbTotalProfit
            // 
            this.lbTotalProfit.Location = new System.Drawing.Point(58, 34);
            this.lbTotalProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbTotalProfit.Name = "lbTotalProfit";
            this.lbTotalProfit.Size = new System.Drawing.Size(120, 19);
            this.lbTotalProfit.TabIndex = 0;
            this.lbTotalProfit.Text = "Tổng Lợi Nhuận:";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.rdThisYear);
            this.pnlSearch.Controls.Add(this.rdThisDay);
            this.pnlSearch.Controls.Add(this.rdToday);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(2, 34);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(834, 72);
            this.pnlSearch.TabIndex = 0;
            // 
            // rdThisYear
            // 
            this.rdThisYear.AutoSize = true;
            this.rdThisYear.Location = new System.Drawing.Point(447, 9);
            this.rdThisYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdThisYear.Name = "rdThisYear";
            this.rdThisYear.Size = new System.Drawing.Size(99, 23);
            this.rdThisYear.TabIndex = 2;
            this.rdThisYear.Text = "Năm Nay";
            this.rdThisYear.UseVisualStyleBackColor = true;
            // 
            // rdThisDay
            // 
            this.rdThisDay.AutoSize = true;
            this.rdThisDay.Location = new System.Drawing.Point(230, 9);
            this.rdThisDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdThisDay.Name = "rdThisDay";
            this.rdThisDay.Size = new System.Drawing.Size(111, 23);
            this.rdThisDay.TabIndex = 1;
            this.rdThisDay.Text = "Tháng Này";
            this.rdThisDay.UseVisualStyleBackColor = true;
            // 
            // rdToday
            // 
            this.rdToday.AutoSize = true;
            this.rdToday.Checked = true;
            this.rdToday.Location = new System.Drawing.Point(9, 9);
            this.rdToday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdToday.Name = "rdToday";
            this.rdToday.Size = new System.Drawing.Size(141, 23);
            this.rdToday.TabIndex = 0;
            this.rdToday.TabStop = true;
            this.rdToday.Text = "Ngày Hôm Nay";
            this.rdToday.UseVisualStyleBackColor = true;
            // 
            // ucProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcProfit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucProfit";
            this.Size = new System.Drawing.Size(838, 449);
            ((System.ComponentModel.ISupportInitialize)(this.gcProfit)).EndInit();
            this.gcProfit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcProfit)).EndInit();
            this.tcProfit.ResumeLayout(false);
            this.tpProfit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccW64Profit.Panel1)).EndInit();
            this.spccW64Profit.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccW64Profit.Panel2)).EndInit();
            this.spccW64Profit.Panel2.ResumeLayout(false);
            this.spccW64Profit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccW64Profit)).EndInit();
            this.spccW64Profit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProfitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcProfit;
        private DevExpress.XtraEditors.PanelControl pnlSearch;
        private System.Windows.Forms.RadioButton rdThisYear;
        private System.Windows.Forms.RadioButton rdThisDay;
        private System.Windows.Forms.RadioButton rdToday;
        private DevExpress.XtraTab.XtraTabControl tcProfit;
        private DevExpress.XtraTab.XtraTabPage tpProfit;
        private DevExpress.XtraCharts.Wizard.SplitContainerControlWin64 spccW64Profit;
        private DevExpress.XtraGrid.GridControl dtgvProfitDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProfitDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colBillName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalBill;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colRevenue;
        private DevExpress.XtraGrid.Columns.GridColumn colCommissions;
        private DevExpress.XtraGrid.Columns.GridColumn colShippingCosts;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.LabelControl lbTotalBill;
        private DevExpress.XtraEditors.LabelControl lbCommissions;
        private DevExpress.XtraEditors.LabelControl lbNetProfit;
        private DevExpress.XtraEditors.LabelControl lbShippingCosts;
        private DevExpress.XtraEditors.LabelControl lbGrossProfit;
        private DevExpress.XtraEditors.LabelControl lbTotalProfit;
    }
}
