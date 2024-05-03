using DevExpress.XtraBars;
using PM_QuanLyKhoHang.UserControlDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.DTO;
using PM_QuanLyKhoHang.FormDetails;

namespace PM_QuanLyKhoHang
{
    public partial class Management : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region "[Declare Global Variables]"
        /// <summary>
        /// Thông tin Account đang đăng nhập
        /// </summary>
        public static AccountDTO UserLogin = null;

        #endregion

        #region "[Default Constructor]"
        public Management()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Load]"
        private void Management_Load(object sender, EventArgs e)
        {
            //set lại trạng thái của các button
            ResetEnableStateButton(false);

            if (UserLogin == null)
            {
                btnLogin_ItemClick(null, null);
            }
        }
        #endregion

        #region "[clear Item in pannel]"
        /// <summary>
        /// xóa các control đang hiển thị trên Pannel
        /// </summary>
        private void clearPannel()
        {
            try
            {
                pnlMain.Controls.Clear();
            }
            catch { }
        }
        #endregion

        #region "[rbpLogin]"

        #region "[Login]"
        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
                if(UserLogin != null)
                {
                    ResetEnableStateButton(true);

                }
            }
            catch { }
        }
        #endregion

        #region "[Logout]"
        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (UserLogin != null)
                {
                    UserLogin = null;
                    ResetEnableStateButton(false);
                    MessageBox.Show("Đăng xuất thành công!", "Thông báo");
                    pnlMain.Controls.Clear();
                }
            }
            catch { }
        }
        #endregion
        
        #region "[Reset State Button]"

        /// <summary>
        /// Đặt lại trạng thái của các control
        /// <para>Nếu chưa đăng nhập thì chỉ có nút đăng nhập và nút thoát mới có thể chọn</para>
        /// <para>Còn những nút khác không thể chọn được</para>
        /// </summary>
        /// <param name="_Flag">True: đăng nhập thành công, False: Đăng nhập thất bại</param>
        private void ResetEnableStateButton(bool _Flag)
        {
            try
            {
                btnLogin.Enabled = !_Flag;
                rbpOperation.Visible = rbpConfig.Visible = rbpContact.Visible = btnLogout.Enabled = btnMyAccount.Enabled = btnDecentralization.Enabled = _Flag;

            }
            catch { }

        }
        #endregion

        #region "[Exits]"
        private void btnExits_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "[Show usercontrol MyAccount]"
        /// <summary>
        /// Show usercontrol TaiKhoanCuaToi
        /// </summary>
        private void ShowUserControlTaiKhoanCuaToi()
        {
            try
            {
                ucMyAccount uc = new ucMyAccount();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }

        private void btnMyAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlTaiKhoanCuaToi();
            }
            catch { }
        }
        #endregion

        #region "[ucAdvancedDecentralization]"
        /// <summary>
        /// hiển thị control phân quyền nâng cao
        /// </summary>
        private void ShowUserControlPhanQuyenNangCao()
        {
            try
            {
                ucAdvancedDecentralization uc = new ucAdvancedDecentralization();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        private void btnDecentralization_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlPhanQuyenNangCao();
            }
            catch { }
        }
        #endregion

        #endregion

        #region "[rbpOperation]"

        #region "[btnSell_ItemClick]"
        private void btnSell_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region "[btnWarehouse_ItemClick]"
        private void btnWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region "[btnWarehouseManagement_ItemClick]"
        private void btnWarehouseManagement_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region "[PriceUpdate]"
        private void btnPriceUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                pnlMain.Controls.Clear();
                ucSalePrice uc = new ucSalePrice();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        #endregion

        #region "[Add Customers]"
        private void btnAddCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                pnlMain.Controls.Clear();
                ucAddCustomers uc = new ucAddCustomers();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        #endregion

        #region "[List Customer]"
        private void btnListCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                pnlMain.Controls.Clear();
                ucListCustomers uc = new ucListCustomers();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        #endregion

        #region "[Add Referrer]"
        private void btnAddReferrer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                pnlMain.Controls.Clear();
                ucAddReferrer uc = new ucAddReferrer();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }

        #endregion

        #region "[Add Product]"
        private void btnAddProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                pnlMain.Controls.Clear();
                ucAddProducts uc = new ucAddProducts();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        #endregion

        #region "[btnListProduct_ItemClick]"
        private void btnListProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                pnlMain.Controls.Clear();
                ucProductInfo uc = new ucProductInfo();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        #endregion

        #region "[btnStatistics_ItemClick]"
        private void btnStatistics_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        #region "[Add TypeReferrer]"
        private void btnAddTypeReferrer_ItemClick(object sender, ItemClickEventArgs e)
        {
            ucTypeReferrer uc = new ucTypeReferrer();
            uc.clearItem = clearPannel;
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }
        #endregion

        #endregion

        #endregion

        #region "[rbpConfig]"

        #region "[btnConfigure_ItemClick]"
        private void btnConfigure_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region "[btnTrashCan_ItemClick]"
        private void btnTrashCan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region "[btnUpdateSystem_ItemClick]"
        private void btnUpdateSystem_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #endregion

        #region "[Send Email]"
        private void btnSendEmail_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                pnlMain.Controls.Clear();
                ucSendEmail uc = new ucSendEmail();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        #endregion

    }
}