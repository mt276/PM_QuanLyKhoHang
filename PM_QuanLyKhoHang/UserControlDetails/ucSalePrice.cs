using DTO.DTO;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucSalePrice : UserControl
    {

        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;

        private int _iID = -1;
        #endregion

        #region "[Default Constructor]"
        public ucSalePrice()
        {
            InitializeComponent();
        }
        #endregion

        #region "[LoadListPriceUpdate]"
        private void LoadListPriceUpdate()
        {
            try
            {
                List<InputDTO> list = InputBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();
                if (list.Count > 0)
                    dtgvInput.DataSource = list;
                dtgvInput.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[ShowInfomation]"
        private void ShowInfomation(InputDTO inputInfo)
        {
            
            ProductDTO product = ProductBUS.SelectPrimaryKey(inputInfo.ProductID);
            lbProductName.Text = "Tên sản phẩm:         " + product.Name;
            lbCount.Text = "Số lượng nhập:         " + string.Format("{0:N0}", inputInfo.Count);
            lbImportPrice.Text = "Giá nhập:         " + string.Format("{0:N0}",inputInfo.ImportPrice);
            lbStartDate.Text = "Ngày nhập:         " + inputInfo.StartDate.Day.ToString() + "/" + inputInfo.StartDate.Month.ToString() + "/" + inputInfo.StartDate.Year.ToString();
            DateTime date = DateTime.Now;
            lbUpdateDate.Text = "Ngày cập nhật:         " + date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();
            SalePriceDTO salePrice = SalePriceBUS.SelectByInputID(inputInfo.ID);
            if (salePrice != null)
            {
                btnAdd.Enabled = false;
                btnUpdatePrice.Enabled = true;
                txtSalePrice.Text = salePrice.SalePrice.ToString();
                AccountDTO acc = AccountBUS.SelectPrimaryKey(salePrice.AccountID);
                lbAccountName.Text = "Nhân viên nhập:         " + acc.FullName;                    
            }
            else
            {
                btnAdd.Enabled = true;
                btnUpdatePrice.Enabled = false;
                txtSalePrice.Text = string.Empty;
                lbAccountName.Text = "Nhân viên nhập:";
            }

        }
        #endregion

        #region "[Load]"
        private void ucPriceUpdate_Load(object sender, EventArgs e)
        {
            LoadListPriceUpdate();

            #region "[Gridview selection is not allowed]"
            gvInput.OptionsBehavior.Editable = gvInput.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[Insert]"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_iID > 0)
                {

                    if (txtSalePrice.Text.Trim() == string.Empty)
                    {
                        ClassUtils.Utils.MessageBoxERROR("Chưa nhập giá bán", "Thông báo");
                        return;
                    }

                    SalePriceDTO salePriceInfo = new SalePriceDTO();
                    salePriceInfo.InputID = _iID;
                    salePriceInfo.SalePrice = double.Parse(txtSalePrice.Text.Trim());
                    salePriceInfo.AccountID = Management.UserLogin.ID;
                    salePriceInfo.StartDate = DateTime.Now;
                    salePriceInfo.Del = false;
                    salePriceInfo.Note = string.Empty;

                    int iResult = SalePriceBUS.Insert(salePriceInfo);
                    if (iResult > 0)
                    {
                        LoadListPriceUpdate();
                        ClearData();
                        ClassUtils.Utils.MessageBoxInfomation("Thêm giá bán thành công", "Thông báo");
                    }
                    else
                    {
                        ClassUtils.Utils.MessageBoxInfomation("Thêm giá bán thất bại", "Thông báo");
                    }
                    _iID = -1;

                }
            }
            catch { }
        }
        #endregion

        #region "[UpdatePrice]"
        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (_iID > 0)
                {
                    
                    if (txtSalePrice.Text.Trim() == string.Empty)
                    {
                        ClassUtils.Utils.MessageBoxERROR("Chưa nhập giá bán", "Thông báo");
                        return;
                    }

                    SalePriceDTO salePriceInfo = SalePriceBUS.SelectByInputID(_iID);
                    salePriceInfo.SalePrice = double.Parse(txtSalePrice.Text.Trim());
                    salePriceInfo.AccountID = Management.UserLogin.ID;
                    salePriceInfo.StartDate = DateTime.Now;

                    bool isSuccess = SalePriceBUS.Update(salePriceInfo);
                    if (isSuccess)
                    {
                        _iID = -1;
                        LoadListPriceUpdate();
                        ClearData();
                        ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
                    }
                    else
                    {
                        ClassUtils.Utils.MessageBoxInfomation("Cập nhật giá bán thất bại", "Thông báo");
                    }

                }
            }
            catch { }
        }
        #endregion

        #region "[Cancel]"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try { ClearData(); }
            catch { }
        }
        #endregion

        #region "[Exits]"
        private void btnExits_Click(object sender, EventArgs e)
        {
            try
            {
                if (clearItem != null)
                    clearItem();
            }
            catch { }
        }
        #endregion

        #region "[Clear data in control input]"
        /// <summary>
        /// clear data in control input
        /// </summary>
        private void ClearData()
        {
            try
            {
                lbAccountName.Text = "Nhân viên nhập:";
                lbProductName.Text = "Tên sản phẩm:";
                lbCount.Text = "Số lượng nhập:";
                lbStartDate.Text = "Ngày nhập:";
                lbUpdateDate.Text = "Ngày cập nhật:";
                lbImportPrice.Text = "Giá nhập:";
                txtSalePrice.Text = string.Empty;
            }
            catch { }
        }
        #endregion

        #region "[Ordinal number]"

        private void gvInput_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();

                if (e.Column.Name == "colProductName")
                {
                    InputDTO item = (InputDTO)gvInput.GetRow(e.RowHandle);
                    ProductDTO itemP = ProductBUS.SelectPrimaryKey(item.ProductID);
                    if (item != null && itemP != null)
                        e.DisplayText = itemP.Name;
                }
            }
            catch { }
        }
        #endregion

        #region "[Get information in one line]"
        private void gvInput_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                //lấy thông tin của dòng đang được chọn
                InputDTO inputInfo = (InputDTO)gvInput.GetRow(e.RowHandle);
                if (inputInfo != null)
                {
                    _iID = inputInfo.ID;
                    ShowInfomation(inputInfo);
                }
            }
            catch { }
        }
        #endregion

        #region "[Only enter numbers]"
        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự phân cách thập phân (nếu có)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }

            // Kiểm tra xem đã có ký tự phân cách thập phân (',' hoặc '.') trong textbox chưa
            bool hasDecimalSeparator = txtSalePrice.Text.Contains(".") || txtSalePrice.Text.Contains(",");

            // Kiểm tra ký tự hiện tại có phải là ký tự phân cách thập phân hay không
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                // Nếu đã có ký tự phân cách thập phân trong textbox, không cho phép nhập thêm
                if (hasDecimalSeparator)
                {
                    e.Handled = true;
                    return;
                }
                // Nếu chưa có ký tự phân cách thập phân, thêm vào textbox
                else
                {
                    // Thay thế ký tự phân cách thập phân thành ký tự thích hợp (ví dụ: nếu ký tự phân cách là '.', thì thay bằng ',')
                    e.KeyChar = txtSalePrice.Text.Contains(".") ? ',' : '.';
                }
            }

            // Kiểm tra xem chuỗi có chứa ký tự phân cách hàng nghìn không và chèn ký tự phân cách nếu cần thiết
            if (char.IsDigit(e.KeyChar))
            {
                // Lấy vị trí của con trỏ văn bản
                int selectionStart = txtSalePrice.SelectionStart;
                // Chèn ký tự phân cách hàng nghìn vào vị trí đúng
                txtSalePrice.Text = txtSalePrice.Text.Insert(selectionStart, e.KeyChar.ToString());
                // Đặt lại con trỏ văn bản sau khi chèn ký tự
                txtSalePrice.SelectionStart = selectionStart + 1;
                // Ngăn chặn sự kiện nhập liệu tiếp theo
                e.Handled = true;
            }
        }

        private void txtSalePrice_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalePrice.Text, out decimal salePrice))
            {
                // Chuyển đổi giá trị thành chuỗi có định dạng tiền tệ
                txtSalePrice.Text = salePrice.ToString("#,##0");
                // Di chuyển con trỏ về cuối textbox
                txtSalePrice.SelectionStart = txtSalePrice.Text.Length;
            }
        }
        #endregion


    }
}
