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
    public delegate void MyDelegate();
    public delegate void DelegateClearItem();
    public delegate void DelegateShowUserControl();
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

        #region "[Bill]"
        private void ShowUserControlBill()
        {
            try
            {
                pnlMain.Controls.Clear();
                ucBill uc = new ucBill();
                uc.showBillInfo = ShowBillInfo;
                uc.clearItem = clearPannel;
                uc.itemShow = ShowUserControlAddProduct;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void btnSell_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlBill();
            }
            catch { }
        }

        public void ShowBillInfo(List<BillInfoDTO> _listobjBillInfo, int _companyID)
        {
            try
            {
                ucCreateBill uc = new ucCreateBill(_listobjBillInfo, _companyID);
                uc.showBill = ShowBill;
                uc.itemShow = ShowUserControlAddReferrer;
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }

        private void ShowBill(List<BillInfoDTO> _listobjBillInfo, int _companyID)
        {
            try
            {
                ucBill uc = new ucBill(_listobjBillInfo, _companyID);
                uc.showBillInfo = ShowBillInfo;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        
        #endregion

        #region "[Input]"

        private void ShowUserControlInput()
        {
            try
            {
                pnlMain.Controls.Clear();
                ucInput uc = new ucInput();
                uc.clearItem = clearPannel;
                uc.itemShow = ShowUserControlAddProduct;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void btnWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlInput();
            }
            catch { }
        }
        #endregion

        #region "[ListInput]"

        private void ShowUserControlListInput()
        {
            try
            {
                pnlMain.Controls.Clear();
                ucListInput uc = new ucListInput();
                uc.clearItem = clearPannel;
                uc.itemShow = ShowUserControlAddProduct;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void btnWarehouseManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlListInput();
            }
            catch { }
        }
        #endregion

        #region "[PriceUpdate]"
        private void ShowUserControlPriceUpdate()
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

        private void btnPriceUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlPriceUpdate();
            }
            catch { }
        }
        #endregion

        #region "[Add Customers]"
        private void ShowUserControlAddCustomers()
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
        private void btnAddCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlAddCustomers();
            }
            catch { }
        }
        #endregion

        #region "[List Customer]"
        private void ShowUserControlListCustomer()
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
        private void btnListCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlListCustomer();
            }
            catch { }
        }
        #endregion

        #region "[Add Referrer]"
        private void ShowUserControlAddReferrer()
        {
            try
            {
                pnlMain.Controls.Clear();
                ucAddReferrer uc = new ucAddReferrer();
                uc.clearItem = clearPannel;
                uc.itemShow = ShowUserControlTypeReferrer;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void btnAddReferrer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlAddReferrer();
            }
            catch { }
        }

        #endregion

        #region "[Add Product]"
        private void ShowUserControlAddProduct()
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
        private void btnAddProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlAddProduct();
            }
            catch { }
        }
        #endregion

        #region "[ProductInfo]"
        private void ShowUserControlProductInfo()
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
        private void btnListProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlProductInfo();
            }
            catch { }
        }
        #endregion

        #region "[Statistics]"
        private void ShowUserControlStatistics()
        {
            try
            {
                pnlMain.Controls.Clear();
                ucSaleStatistics uc = new ucSaleStatistics();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void btnStatistics_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlStatistics();
            }
            catch { }
        }
        #endregion

        #region "[Add TypeReferrer]"
        private void ShowUserControlTypeReferrer()
        {
            try
            {
                ucTypeReferrer uc = new ucTypeReferrer();
                uc.clearItem = clearPannel;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void btnAddTypeReferrer_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowUserControlTypeReferrer();
        }
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

        #region "[UpdateSystem]"
        private void btnUpdateSystem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
        }
        #endregion

        #endregion

        #region "[Send Email]"
        private void ShowUserControlSendEmail()
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
        private void btnSendEmail_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlSendEmail();
            }
            catch { }
        }
        #endregion

        #region "[SqlServer]"
        private void btnSqlServer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FormDetails.frmLocation frm = new FormDetails.frmLocation();
                frm.ShowDialog();
            }
            catch { }
        }
        #endregion
    }
}