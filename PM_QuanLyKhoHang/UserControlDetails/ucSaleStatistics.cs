using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucSaleStatistics : UserControl
    {
        public DelegateClearItem clearItem = null;
        public ucSaleStatistics()
        {
            InitializeComponent();
        }

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

        #region "[ProductSell]"
        private void nbiProductPriceStatistics_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                ShowUserControlPProductPriceStatistics();
            }
            catch { }
        }
        private void ShowUserControlPProductPriceStatistics()
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

        
    }
}
