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
using DAO.SQLHelper;
using PM_QuanLyKhoHang.FormDetails;
using BUS.BUS;
using System.Data.SqlClient;

namespace PM_QuanLyKhoHang
{
    public delegate void MyDelegate();
    public delegate void DelegateClearItem();
    public delegate void DelegateShowUserControl();
    public partial class Management : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region "[Enum Rules]"
        public enum Function
        {
            Decentralization,
            Sell,
            Warehouse,
            WarehouseManagement,
            PriceUpdate,
            AddCustomer,
            ListCustomer,
            AddReferrer,
            AddProduct,
            ListProduct,
            AddTypeReferrer,
            UpdateSystem,
            SendEmail,
            Statistics,
            NULL
        }
        public Function GetTypeFunction(int _n)
        {
            switch (_n)
            {
                case 1:
                    return Function.Decentralization;
                case 2:
                    return Function.Sell;
                case 3:
                    return Function.Warehouse;
                case 4:
                    return Function.WarehouseManagement;
                case 5:
                    return Function.PriceUpdate;
                case 6:
                    return Function.AddCustomer;
                case 7:
                    return Function.ListCustomer;
                case 8:
                    return Function.AddReferrer;
                case 9:
                    return Function.AddProduct;
                case 10:
                    return Function.ListProduct;
                case 11:
                    return Function.AddTypeReferrer;
                case 12:
                    return Function.UpdateSystem;
                case 13:
                    return Function.SendEmail;
                case 14:
                    return Function.Statistics;
                
            }
            return Function.NULL;
        }
        #endregion

        #region "[SetUpRules]"
        /// <summary>
        /// cho phep su dung theo phan quyền
        /// </summary>
        private void SetUpRules()
        {
            try
            {
                EnableButton();
                //lấy danh sách các luật được phép.
                List<DecentralizationDTO> list = DecentralizationBUS.SelectByAccountID(UserLogin.ID).Where(p => p.Del == false).ToList();
                if (list.Count > 0)
                {
                    #region "[GetTypeFunction]"
                    foreach (DecentralizationDTO item in list)
                    {
                        switch (GetTypeFunction(item.TypeActID))
                        {
                            case Function.Decentralization:
                                btnDecentralization.Enabled = true;
                                break;
                            case Function.Sell:
                                btnSell.Enabled = true;
                                break;
                            case Function.Warehouse:
                                btnWarehouse.Enabled = true;
                                break;
                            case Function.WarehouseManagement:
                                btnWarehouseManagement.Enabled = true;
                                break;
                            case Function.PriceUpdate:
                                btnPriceUpdate.Enabled = true;
                                break;
                            case Function.AddCustomer:
                                btnAddCustomer.Enabled = true;
                                break;
                            case Function.ListCustomer:
                                btnListCustomer.Enabled = true;
                                break;
                            case Function.AddReferrer:
                                btnAddReferrer.Enabled = true;
                                break;
                            case Function.AddProduct:
                                btnAddProduct.Enabled = true;
                                break;
                            case Function.ListProduct:
                                btnListProduct.Enabled = true;
                                break;
                            case Function.AddTypeReferrer:
                                btnAddTypeReferrer.Enabled = true;
                                break;
                            case Function.UpdateSystem:
                                btnUpdateSystem.Enabled = true;
                                break;
                            case Function.SendEmail:
                                btnSendEmail.Enabled = true;
                                break;
                            case Function.Statistics:
                                btnStatistics.Enabled = true;
                                break;

                        }
                    }
                    #endregion
                }
            }
            catch { }
        }
        #endregion

        #region "[Declare Global Variables]"
        /// <summary>
        /// Thông tin Account đang đăng nhập
        /// </summary>
        public static AccountDTO UserLogin = null;
        public SqlConnection cn = null;

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
            try
            {
                cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
                if (cn.State != ConnectionState.Open)
                {
                    ClassUtils.Utils.MessageBoxERROR("Kết nối thất bại", "Thông báo");
                    return;
                }
            }
            catch {
                ClassUtils.Utils.MessageBoxERROR("Kết nối thất bại", "Thông báo");
                return;
            }
            if (UserLogin == null)
            {
                BtnLogin_ItemClick(null, null);
            }

        }
        #endregion

        #region "[clear Item in pannel]"
        /// <summary>
        /// xóa các control đang hiển thị trên Pannel
        /// </summary>
        private void ClearPannel()
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
        private void BtnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
                if(UserLogin != null)
                {
                    ResetEnableStateButton(true);

                    SetUpRules();

                }
            }
            catch { }
        }
        #endregion

        #region "[Logout]"
        private void BtnLogout_ItemClick(object sender, ItemClickEventArgs e)
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
        private void BtnExits_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "[MyAccount]"
        /// <summary>
        /// Show usercontrol TaiKhoanCuaToi
        /// </summary>
        private void ShowUserControlTaiKhoanCuaToi()
        {
            try
            {
                ucMyAccount uc = new ucMyAccount
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }

        private void BtnMyAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlTaiKhoanCuaToi();
            }
            catch { }
        }
        #endregion

        #region "[AdvancedDecentralization]"
        /// <summary>
        /// hiển thị control phân quyền nâng cao
        /// </summary>
        private void ShowUserControlPhanQuyenNangCao()
        {
            try
            {
                ucAdvancedDecentralization uc = new ucAdvancedDecentralization
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }
        private void BtnDecentralization_ItemClick(object sender, ItemClickEventArgs e)
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
                ucBill uc = new ucBill
                {
                    showBillInfo = ShowBillInfo,
                    clearItem = ClearPannel,
                    itemShow = ShowUserControlAddProduct,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnSell_ItemClick(object sender, ItemClickEventArgs e)
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
                ucCreateBill uc = new ucCreateBill(_listobjBillInfo, _companyID)
                {
                    showBill = ShowBill,
                    itemShow = ShowUserControlAddReferrer,
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);
            }
            catch { }
        }

        private void ShowBill(List<BillInfoDTO> _listobjBillInfo, int _companyID)
        {
            try
            {
                ucBill uc = new ucBill(_listobjBillInfo, _companyID)
                {
                    showBillInfo = ShowBillInfo,
                    Dock = DockStyle.Fill
                };
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
                ucInput uc = new ucInput
                {
                    clearItem = ClearPannel,
                    itemShow = ShowUserControlAddProduct,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnWarehouse_ItemClick(object sender, ItemClickEventArgs e)
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
                ucListInput uc = new ucListInput
                {
                    clearItem = ClearPannel,
                    itemShow = ShowUserControlAddProduct,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnWarehouseManagement_ItemClick(object sender, ItemClickEventArgs e)
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
                ucSalePrice uc = new ucSalePrice
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }

        private void BtnPriceUpdate_ItemClick(object sender, ItemClickEventArgs e)
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
                ucAddCustomers uc = new ucAddCustomers
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnAddCustomer_ItemClick(object sender, ItemClickEventArgs e)
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
                ucListCustomers uc = new ucListCustomers
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnListCustomer_ItemClick(object sender, ItemClickEventArgs e)
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
                ucAddReferrer uc = new ucAddReferrer
                {
                    clearItem = ClearPannel,
                    itemShow = ShowUserControlTypeReferrer,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnAddReferrer_ItemClick(object sender, ItemClickEventArgs e)
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
                ucAddProducts uc = new ucAddProducts
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnAddProduct_ItemClick(object sender, ItemClickEventArgs e)
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
                ucProductInfo uc = new ucProductInfo
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnListProduct_ItemClick(object sender, ItemClickEventArgs e)
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
                ucSaleStatistics uc = new ucSaleStatistics
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnStatistics_ItemClick(object sender, ItemClickEventArgs e)
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
                ucTypeReferrer uc = new ucTypeReferrer
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnAddTypeReferrer_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowUserControlTypeReferrer();
        }
        #endregion
            
        #endregion

        #region "[rbpConfig]"

        #region "[btnConfigure_ItemClick]"
        private void BtnConfigure_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region "[btnTrashCan_ItemClick]"
        private void BtnTrashCan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region "[UpdateSystem]"
        private void BtnUpdateSystem_ItemClick(object sender, ItemClickEventArgs e)
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
                ucSendEmail uc = new ucSendEmail
                {
                    clearItem = ClearPannel,
                    Dock = DockStyle.Fill
                };
                pnlMain.Controls.Add(uc);

            }
            catch { }
        }
        private void BtnSendEmail_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowUserControlSendEmail();
            }
            catch { }
        }
        #endregion

        #region "[SqlServer]"
        private void BtnSqlServer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FormDetails.frmLocation frm = new FormDetails.frmLocation();
                frm.ShowDialog();
            }
            catch { }
        }
        #endregion

        #region "[Enable button]"
        /// <summary>
        /// Enable button
        /// </summary>
        private void EnableButton()
        {
            btnDecentralization.Enabled = false;
            btnSell.Enabled = false;
            btnWarehouse.Enabled = false;
            btnWarehouseManagement.Enabled = false;
            btnPriceUpdate.Enabled = false;
            btnAddCustomer.Enabled = false;
            btnListCustomer.Enabled = false;
            btnAddReferrer.Enabled = false;
            btnAddProduct.Enabled = false;
            btnListProduct.Enabled = false;
            btnAddTypeReferrer.Enabled = false;
            btnUpdateSystem.Enabled = false;
            btnSendEmail.Enabled = false;
            btnStatistics.Enabled = false;

        }
        #endregion
    }
}