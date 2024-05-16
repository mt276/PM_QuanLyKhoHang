using DTO.DTO;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucInput : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;

        public DelegateShowUserControl itemShow = null;

        bool isFlag = false;

        InputDTO inputSelect = null;

        private static List<InputDTO> _listInput = new List<InputDTO>();
        #endregion

        #region "[Default Constructor]"

        public ucInput()
        {
            InitializeComponent();
        }
        #endregion

        #region "[LoadListInput]"
        private void LoadListInput()
        {
            try
            {

                    List<InputDTO> list = InputBUS.GetInputProductByAccountID(Management.UserLogin.ID);
                    list = list.OrderByDescending(p => p.StartDate).ToList();
                    dtgvInput.DataSource = list;
                    dtgvInput.RefreshDataSource();

                
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void ucInput_Load(object sender, EventArgs e)
        {
            LoadListInput();

            EnableButton(true);

            LoadComboBox();

            #region "[Gridview selection is not allowed]"
            gvInput.OptionsBehavior.Editable = gvInput.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[Insert Product]"
        private void lklbAddProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (itemShow != null)
                    itemShow();
                ucAddProducts uc = new ucAddProducts();
                uc.Insert += Uc_Insert;
                uc.UpdateAP += Uc_Update;
                uc.Delete += Uc_Delete;            
            }
            catch { }
        }

        private void Uc_Delete(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void Uc_Update(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void Uc_Insert(object sender, EventArgs e)
        {
            LoadComboBox();
        }
        #endregion

        #region "[Insert]"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra trước khi nhập.
                string strCount = txtCount.Text.Trim();
                if (strCount == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Số Lượng không được trống", "Thông Báo");
                    return;
                }
                string strImportPrice = txtImportPrice.Text.Trim();
                string strSalePrice = txtSalePrice.Text.Trim();
                if (strImportPrice == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Giá Nhập không được trống", "Thông Báo");
                    return;
                }
                if (strSalePrice == string.Empty)
                {
                    strSalePrice = strImportPrice;
                    txtSalePrice.Text = strSalePrice;
                    //ClassUtils.Utils.MessageBoxERROR("Giá Bán không được trống", "Thông Báo");
                    //return;
                }
                //xử lý số lượng trường hợp 10*3
                int count = (int)BUS.Utils.UtilsOperator.GeneralPricesIntoDetailedPrices(strCount);
                InputDTO inputItem = new InputDTO();
                inputItem.ProductID = int.Parse(cbProductName.SelectedValue.ToString());
                inputItem.Count = count;
                inputItem.ImportPrice = double.Parse(strImportPrice);
                inputItem.ImportPriceString = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(inputItem.ImportPrice.ToString());
                inputItem.AccountID = Management.UserLogin.ID;
                inputItem.StartDate = dtpkStartDate.Value;
                inputItem.Del = false;
                inputItem.Note = mmedNote.Text;

                double salePrice = double.Parse(strSalePrice);
                if (salePrice > 0.0)
                {
                    try
                    {
                        //Thêm 1 dòng giá bán mới.
                        SalePriceBUS.InsertPriceSellProduct(salePrice, inputItem.ProductID, Management.UserLogin.ID, inputItem.StartDate);
                    }
                    catch { }
                }
                //insert vào bảng nhập kho

                int inputID = InputBUS.Insert(inputItem);
                if (inputID > 0)
                {
                    inputItem.ID = inputID;
                    _listInput.Add(inputItem);
                    ClearData();
                    LoadListInput();
                    ClassUtils.Utils.MessageBoxInfomation("Thêm sản phẩm vào kho thành công", "Thông báo");
                }
                else
                {
                    ClassUtils.Utils.MessageBoxERROR("Thêm sản phẩm vào kho thất bại", "Thông báo");
                }

            }
            catch { }
        }
        #endregion

        #region "[Update]"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputSelect != null)
                {

                    InputDTO itemObj = _listInput.Where(p => p.ID == inputSelect.ID).FirstOrDefault();
                    inputSelect.ProductID = int.Parse(cbProductName.SelectedValue.ToString());
                    inputSelect.Count = int.Parse(txtCount.Text.Trim());
                    inputSelect.ImportPrice = double.Parse(txtImportPrice.Text.Trim());
                    inputSelect.StartDate = dtpkStartDate.Value;
                    inputSelect.Note = mmedNote.Text.Trim();

                    double salePrice = 0.0;
                    try
                    {
                        salePrice = double.Parse(txtSalePrice.Text.Trim());
                    }
                    catch { }

                    SalePriceDTO salePriceItem = new SalePriceDTO();
                    salePriceItem.ProductID = inputSelect.ProductID;
                    salePriceItem.SalePrice = salePrice;
                    salePriceItem.AccountID = Management.UserLogin.ID;
                    salePriceItem.StartDate = inputSelect.StartDate;
                    salePriceItem.Del = false;
                    salePriceItem.Note = string.Empty;

                    SalePriceBUS.UpdatePriceSellOfProduct(salePriceItem);

                    bool isSuccess = InputBUS.Update(inputSelect);
                    if (isSuccess)
                    {
                        if(itemObj != null)
                        {
                            _listInput.Remove(itemObj);
                            _listInput.Add(inputSelect);
                        }
                        EnableButton(true);
                        LoadListInput();
                        ClearData();
                        ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
                    }
                    else
                    {
                        ClassUtils.Utils.MessageBoxERROR("Cập nhật thất bại", "Thông báo");
                    }

                }
            }
            catch { }
        }
        #endregion

        #region "[Delete]"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputSelect != null)
                {
                    bool isSuccess = InputBUS.DeleteInputProduct(inputSelect.ProductID, inputSelect.ID, inputSelect.Count);
                    if (isSuccess)
                    {
                        InputDTO item = _listInput.Where(p => p.ID == inputSelect.ID).FirstOrDefault();
                        if (item != null)
                            _listInput.Remove(inputSelect);
                        LoadListInput();
                        ClearData();
                        EnableButton(true);
                        ClassUtils.Utils.MessageBoxInfomation("Xóa thành công", "Thông Báo");

                    }
                    else
                    {
                        ClassUtils.Utils.MessageBoxERROR("Xóa thất bại", "Thông Báo");

                    }
                }
            }
            catch { }
        }
        #endregion

        #region "[ListInput]"
        private void btnListInput_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isFlag == false)
                {
                    LoadListInput();
                    btnShowAll.Text = "Hiển thị mới thêm trong ngày";
                    isFlag = false;
                    
                }
                else
                {
                    //load danh sách mới thêm trong ngày
                    List<InputDTO> listAll = InputBUS.GetDate().Where(p=>p.AccountID==Management.UserLogin.ID).ToList();

                    if (listAll.Count >= 0)
                    {
                        dtgvInput.DataSource = listAll;
                        dtgvInput.RefreshDataSource();
                        btnShowAll.Text = "Hiển thị tất cả";
                        isFlag = true;
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

                if (e.Column.Name == "colAccountInput")
                {
                    InputDTO item = (InputDTO)gvInput.GetRow(e.RowHandle);
                    AccountDTO itemA = AccountBUS.SelectPrimaryKey(item.AccountID);
                    if (item != null && itemA != null)
                        e.DisplayText = itemA.UserName;
                }
                if (e.Column.Name == "colSalePrice")
                {
                    InputDTO item = (InputDTO)gvInput.GetRow(e.RowHandle);
                    SalePriceDTO itemS = null;
                    try
                    {
                        /*
                         * lấy giá bán
                         * B1: Lấy danh sách các giá bán của 1 sản phẩm có thời gian từ thời gian Item trở về trước
                         * B2: Sắp xếp giảm dần và lấy phần tử đầu tiên
                         */
                        itemS = SalePriceBUS.GetListPriceProductByProductID(item.ProductID).
                            Where(p => (BUS.Utils.UtilsOperator.CompareSimilarDateTime(p.StartDate, item.StartDate)))
                            .OrderByDescending(p => p.StartDate).FirstOrDefault();
                    }
                    catch { }
                    if (itemS != null)
                        e.DisplayText = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(itemS.SalePrice.ToString());
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
                InputDTO item = (InputDTO)gvInput.GetRow(e.RowHandle);
                if (item != null)
                {
                    //_iID = item.ID;

                    inputSelect = new InputDTO();
                    inputSelect = item;

                    ProductDTO product = ProductBUS.SelectPrimaryKey(item.ProductID);
                    cbProductName.SelectedIndex = cbProductName.FindStringExact(product.Name);
                    txtImportPrice.Text = item.ImportPrice.ToString();
                    txtCount.Text = item.Count.ToString();
                    dtpkStartDate.Value = DateTime.Parse(item.StartDate.ToString());
                    mmedNote.Text = item.Note;

                    //lấy giá bán của sản phẩm này có ngày = ngày nhập sản phẩm
                    double salePrice = 0.0;
                    try
                    {
                        salePrice = SalePriceBUS.GetListPriceProductByProductID(item.ProductID).
                            Where(p => (BUS.Utils.UtilsOperator.CompareSimilarDateTime(p.StartDate, item.StartDate))).
                            OrderByDescending(p => p.StartDate).FirstOrDefault().SalePrice;
                    }
                    catch { }
                    if (salePrice > 0.0)
                        txtSalePrice.Text = salePrice.ToString();
                    else
                        txtSalePrice.Text = string.Empty;
                    EnableButton(false);
                }
            }
            catch { }
        }
        #endregion

        #region "[EnableButton]"
        /// <summary>
        /// Kích hoạt Button 
        /// </summary>
        /// <param name="_Flag"></param>
        private void EnableButton(bool _isFlag)
        {
            try
            {
                btnDelete.Enabled = btnUpdate.Enabled = !_isFlag;
                btnAdd.Enabled = _isFlag;
                dtpkStartDate.Enabled = _isFlag;
            }
            catch { }
        }
        #endregion

        #region "[Only enter numbers]"
        private void txtImportPrice_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtImportPrice.Text, out decimal salePrice))
            {
                // Chuyển đổi giá trị thành chuỗi có định dạng tiền tệ
                txtImportPrice.Text = salePrice.ToString("#,##0");
                // Di chuyển con trỏ về cuối textbox
                txtImportPrice.SelectionStart = txtImportPrice.Text.Length;
            }
        }

        private void txtImportPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự phân cách thập phân (nếu có)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }

            // Kiểm tra xem đã có ký tự phân cách thập phân (',' hoặc '.') trong textbox chưa
            bool hasDecimalSeparator = txtImportPrice.Text.Contains(".") || txtImportPrice.Text.Contains(",");

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
                    e.KeyChar = txtImportPrice.Text.Contains(".") ? ',' : '.';
                }
            }

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
                EnableButton(true);

                txtCount.Text = txtImportPrice.Text = txtSalePrice.Text = string.Empty;
                dtpkStartDate.Value = DateTime.Now;
                cbProductName.SelectedIndex = 0;
            }
            catch { }
        }
        #endregion

        #region "[LoadComboBox]"
        private void LoadComboBox()
        {
            List<ProductDTO> listProduct = ProductBUS.GetAll();
            if (listProduct.Count > 0)
            {
                cbProductName.DataSource = listProduct;
                cbProductName.DisplayMember = "Name";
                cbProductName.ValueMember = "ID";
            }

            List<UnitDTO> listUnit = UnitBUS.GetAll();
            if (listUnit.Count > 0)
            {
                cbUnit.DataSource = listUnit;
                cbUnit.DisplayMember = "Name";
                cbUnit.ValueMember = "ID";
            }
        }


        #endregion

        #region "[DisplayUnitNameByProductName]"
        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //load tên đơn vị tính tương ứng với từng sản phẩm.
                ProductDTO item = (ProductDTO)cbProductName.SelectedItem;
                cbUnit.SelectedValue = item.UnitID;
            }
            catch { }
        }
        #endregion


    }
}
