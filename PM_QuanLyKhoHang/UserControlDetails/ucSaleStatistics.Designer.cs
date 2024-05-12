
namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucSaleStatistics
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
            this.pnlMenu = new DevExpress.XtraEditors.PanelControl();
            this.nvcStatistics = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgProductStatistics = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiProductSell = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiProductPriceStatistics = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiChartProductPrices = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgDebtAndBill = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiDebtStatistics = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiBillStatistics = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiVAT = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgWarehouse = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiWarehouseReport = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgExpenditure = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiExpenseInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgProfit = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiProfitOverTime = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportOverTheYears = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvcStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(302, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(579, 489);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.Controls.Add(this.nvcStatistics);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(300, 489);
            this.pnlMenu.TabIndex = 1;
            // 
            // nvcStatistics
            // 
            this.nvcStatistics.ActiveGroup = this.nbgProductStatistics;
            this.nvcStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvcStatistics.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgProductStatistics,
            this.nbgDebtAndBill,
            this.nbgWarehouse,
            this.nbgExpenditure,
            this.nbgProfit});
            this.nvcStatistics.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiProductSell,
            this.nbiProductPriceStatistics,
            this.nbiChartProductPrices,
            this.nbiDebtStatistics,
            this.nbiBillStatistics,
            this.nbiVAT,
            this.nbiWarehouseReport,
            this.nbiExpenseInfo,
            this.nbiProfitOverTime,
            this.nbiReportOverTheYears});
            this.nvcStatistics.Location = new System.Drawing.Point(2, 2);
            this.nvcStatistics.Name = "nvcStatistics";
            this.nvcStatistics.OptionsNavPane.ExpandedWidth = 296;
            this.nvcStatistics.Size = new System.Drawing.Size(296, 485);
            this.nvcStatistics.TabIndex = 0;
            this.nvcStatistics.Text = "navBarControl2";
            // 
            // nbgProductStatistics
            // 
            this.nbgProductStatistics.Caption = "Thống Kê Sản Phẩm";
            this.nbgProductStatistics.Expanded = true;
            this.nbgProductStatistics.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiProductSell),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiProductPriceStatistics),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiChartProductPrices)});
            this.nbgProductStatistics.Name = "nbgProductStatistics";
            // 
            // nbiProductSell
            // 
            this.nbiProductSell.Caption = "Các sản phẩm đã bán";
            this.nbiProductSell.Name = "nbiProductSell";
            this.nbiProductSell.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiProductSell_LinkClicked);
            // 
            // nbiProductPriceStatistics
            // 
            this.nbiProductPriceStatistics.Caption = "Thống kê giá sản phẩm";
            this.nbiProductPriceStatistics.Name = "nbiProductPriceStatistics";
            this.nbiProductPriceStatistics.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiProductPriceStatistics_LinkClicked);
            // 
            // nbiChartProductPrices
            // 
            this.nbiChartProductPrices.Caption = "Biểu đồ thể hiện giá sản phẩm";
            this.nbiChartProductPrices.Name = "nbiChartProductPrices";
            // 
            // nbgDebtAndBill
            // 
            this.nbgDebtAndBill.Caption = "Công Nợ và Hóa Đơn";
            this.nbgDebtAndBill.Expanded = true;
            this.nbgDebtAndBill.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDebtStatistics),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiBillStatistics),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiVAT)});
            this.nbgDebtAndBill.Name = "nbgDebtAndBill";
            // 
            // nbiDebtStatistics
            // 
            this.nbiDebtStatistics.Caption = "Thống kê Công nợ";
            this.nbiDebtStatistics.Name = "nbiDebtStatistics";
            // 
            // nbiBillStatistics
            // 
            this.nbiBillStatistics.Caption = "Thống kê Hóa đơn bán hàng";
            this.nbiBillStatistics.Name = "nbiBillStatistics";
            // 
            // nbiVAT
            // 
            this.nbiVAT.Caption = "Thuế VAT và Thuế Doanh Nghiệp";
            this.nbiVAT.Name = "nbiVAT";
            // 
            // nbgWarehouse
            // 
            this.nbgWarehouse.Caption = "Kho Hàng";
            this.nbgWarehouse.Expanded = true;
            this.nbgWarehouse.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiWarehouseReport)});
            this.nbgWarehouse.Name = "nbgWarehouse";
            // 
            // nbiWarehouseReport
            // 
            this.nbiWarehouseReport.Caption = "Báo Cáo Nhập Kho";
            this.nbiWarehouseReport.Name = "nbiWarehouseReport";
            // 
            // nbgExpenditure
            // 
            this.nbgExpenditure.Caption = "Khoản Chi";
            this.nbgExpenditure.Expanded = true;
            this.nbgExpenditure.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiExpenseInfo)});
            this.nbgExpenditure.Name = "nbgExpenditure";
            // 
            // nbiExpenseInfo
            // 
            this.nbiExpenseInfo.Caption = "Thông Tin Khoản Chi";
            this.nbiExpenseInfo.Name = "nbiExpenseInfo";
            // 
            // nbgProfit
            // 
            this.nbgProfit.Caption = "Lợi Nhuận";
            this.nbgProfit.Expanded = true;
            this.nbgProfit.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiProfitOverTime),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportOverTheYears)});
            this.nbgProfit.Name = "nbgProfit";
            // 
            // nbiProfitOverTime
            // 
            this.nbiProfitOverTime.Caption = "Lợi Nhuận Theo Thời Gian";
            this.nbiProfitOverTime.Name = "nbiProfitOverTime";
            // 
            // nbiReportOverTheYears
            // 
            this.nbiReportOverTheYears.Caption = "Báo Cáo Qua Các Năm";
            this.nbiReportOverTheYears.Name = "nbiReportOverTheYears";
            // 
            // ucSaleStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlMain);
            this.Name = "ucSaleStatistics";
            this.Size = new System.Drawing.Size(885, 489);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nvcStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.PanelControl pnlMenu;
        private DevExpress.XtraNavBar.NavBarControl nvcStatistics;
        private DevExpress.XtraNavBar.NavBarGroup nbgProductStatistics;
        private DevExpress.XtraNavBar.NavBarItem nbiProductSell;
        private DevExpress.XtraNavBar.NavBarItem nbiProductPriceStatistics;
        private DevExpress.XtraNavBar.NavBarItem nbiChartProductPrices;
        private DevExpress.XtraNavBar.NavBarGroup nbgDebtAndBill;
        private DevExpress.XtraNavBar.NavBarItem nbiDebtStatistics;
        private DevExpress.XtraNavBar.NavBarItem nbiBillStatistics;
        private DevExpress.XtraNavBar.NavBarItem nbiVAT;
        private DevExpress.XtraNavBar.NavBarGroup nbgWarehouse;
        private DevExpress.XtraNavBar.NavBarItem nbiWarehouseReport;
        private DevExpress.XtraNavBar.NavBarGroup nbgExpenditure;
        private DevExpress.XtraNavBar.NavBarItem nbiExpenseInfo;
        private DevExpress.XtraNavBar.NavBarGroup nbgProfit;
        private DevExpress.XtraNavBar.NavBarItem nbiProfitOverTime;
        private DevExpress.XtraNavBar.NavBarItem nbiReportOverTheYears;
    }
}
