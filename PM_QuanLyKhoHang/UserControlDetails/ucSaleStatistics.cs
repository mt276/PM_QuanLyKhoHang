using BUS.BUS;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucSaleStatistics : UserControl
    {
        public DelegateClearItem clearItem = null;

        #region "[Default Constructor]"
        public ucSaleStatistics()
        {
            InitializeComponent();
        }
        #endregion

        #region "[enum Rules]"
        private enum Rules
        {
            ProductSell,
            ProductPriceStatistics,
            ProductPriceChart,
            DebtStatistics,
            BillStatistics,
            InputReport,
            NULL
        }
        private Rules GetType(int _iType)
        {
            Rules item = Rules.NULL;
            try
            {
                switch (_iType)
                {
                    case 15:
                        item = Rules.ProductSell;
                        break;
                    case 16:
                        item = Rules.ProductPriceStatistics;
                        break;
                    case 17:
                        item = Rules.ProductPriceChart;
                        break;
                    case 18:
                        item = Rules.DebtStatistics;
                        break;
                    case 19:
                        item = Rules.BillStatistics;
                        break;                   
                    case 20:
                        item = Rules.InputReport;
                        break;
                }
            }
            catch { }
            return item;
        }
        #endregion

        #region "[Load]"
        private void ucSaleStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                //các chức năng chưa được cấp quyền.
                EnabledLink();

                //kiểm tra phân quyền chi tiết.
                List<DecentralizationDTO> listPhanQuyen = DecentralizationBUS.SelectByAccountID(Management.UserLogin.ID);
                if (listPhanQuyen.Count > 0)
                {
                    foreach (DecentralizationDTO item in listPhanQuyen)
                    {
                        switch (GetType(item.TypeActID))
                        {                          
                                                      
                            case Rules.ProductSell:
                                nbiProductSell.Enabled = true;
                                break;
                            case Rules.ProductPriceStatistics:
                                nbiProductPriceStatistics.Enabled = true;
                                break;
                            case Rules.ProductPriceChart:
                                nbiChartProductPrices.Enabled = true;
                                break;
                            case Rules.DebtStatistics:
                                nbiDebtStatistics.Enabled = true;
                                break;
                            case Rules.BillStatistics:
                                nbiBillStatistics.Enabled = true;
                                break;
                            case Rules.InputReport:
                                nbiInputReport.Enabled = true;
                                break;

                        }
                    }
                }

            }
            catch { }
        }
        #endregion

        #region "[EnabledLink]"
        /// <summary>
        /// cấp quyền cho các chức năng
        /// </summary>
        private void EnabledLink()
        {
            try
            {
                nbiProductSell.Enabled =
                nbiProductPriceStatistics.Enabled =
                nbiChartProductPrices.Enabled =
                nbiDebtStatistics.Enabled =
                nbiBillStatistics.Enabled = 
                nbiInputReport.Enabled = false;
            }
            catch { }
        }
        #endregion

        #region "[ProductSell]"
        private void nbiProductSell_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                ShowUserControlProductSell();
            }
            catch { }
        }
        private void ShowUserControlProductSell()
        {
            try
            {
                //lấy danh sách tất cả các sản phẩm bán được.
                ucProductSell uc = new ucProductSell();
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }

        #endregion

        #region "[ProductPriceStatistics]"
        private void nbiProductPriceStatistics_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                ShowUserControlProductPriceStatistics();
            }
            catch { }
        }
        private void ShowUserControlProductPriceStatistics()
        {
            try
            {
                ucProductPriceStatistics uc = new ucProductPriceStatistics();
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }


        #endregion

        #region "[InputReport]"
        private void nbiWarehouseReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                ShowUserControlWarehouseReport();
            }
            catch { }
        }

        private void ShowUserControlWarehouseReport()
        {
            try
            {
                ucInputReport uc = new ucInputReport();
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        #endregion

        #region "[ChartProductPrices]"
        private void nbiChartProductPrices_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                ShowUserControlChartProductPrices();
            }
            catch { }
        }
        private void ShowUserControlChartProductPrices()
        {
            try
            {
                ucProductPriceChart uc = new ucProductPriceChart();
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        #endregion

        #region "[DebtStatistics]"
        private void nbiDebtStatistics_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                ShowUserControlDebtStatistics();
            }
            catch { }
        }
        private void ShowUserControlDebtStatistics()
        {
            try
            {
                ucDebtStatistics uc = new ucDebtStatistics();
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        #endregion

        #region "[BillStatistics]"
        private void nbiBillStatistics_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                ShowUserControlBillStatistics();
            }
            catch { }
        }
        private void ShowUserControlBillStatistics()
        {
            try
            {
                ucBillStatistics uc = new ucBillStatistics();
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }

        #endregion

        
    }
}
