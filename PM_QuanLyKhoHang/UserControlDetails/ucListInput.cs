using DTO.DTO;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucListInput : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;

        public DelegateShowUserControl itemShow = null;

        private static List<InputDTO> listInput = new List<InputDTO>();

        #endregion

        #region "[Default Constructor]"

        public ucListInput()
        {
            InitializeComponent();
        }
        #endregion

        #region "[LoadListProductInfo]"
        private void LoadListProductInfo()
        {
            try
            {
                //lấy danh sách các sản phẩm.
                List<ProductDTO> listProducts = ProductBUS.GetAll();

                //danh sách các sản phẩm sắp hết hàng và hết hàng được ưu tiên lên trên.
                List<ProductDTO> listProductSorts = new List<ProductDTO>();

                foreach (ProductDTO Item in listProducts)
                {
                    //lấy số lượng hàng giới hạn khi sắp hết hàng.
                    int n = ParameterBUS.SelectByProductID(Item.ID).Value;
                    if (Item.Stock <= n)
                    {
                        listProductSorts.Add(Item);
                    }
                }

                if (listProductSorts.Count > 0)
                {
                    foreach (ProductDTO Item in listProductSorts)
                    {
                        ProductDTO Temp = listProducts.Where(p => p.ID == Item.ID).FirstOrDefault();
                        if (Temp != null)
                            listProducts.Remove(Temp);
                    }
                }

                listProducts = listProducts.OrderBy(p => p.Stock).ToList();
                foreach (ProductDTO Item in listProducts)
                {
                    //sắp xếp tăng dần theo số lượng.
                    listProductSorts.Add(Item);
                }

                dtgvProductInfo.DataSource = listProductSorts;
                dtgvProductInfo.RefreshDataSource();

            }
            catch { }
        }

        #endregion

        #region "[Load]"
        private void ucProductInfo_Load(object sender, EventArgs e)
        {
            LoadListProductInfo();
            ShowCountNumber();
            LoadCombobox();
            ClearData();
            #region "[Gridview selection is not allowed]"
            gvProductInfo.OptionsBehavior.Editable = gvProductInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[ShowCountNumber]"
        /// <summary>
        /// Hiển thị số lượng sản phẩm sắp hết hàng
        /// </summary>
        private void ShowCountNumber()
        {
            try
            {
                int number = ProductBUS.GetListHaveNumberStoreSmallerNumberInputLimit().Count;
                lbProductCount.Text = "Số sản phẩm cần nhập: " + number.ToString();
            }
            catch { }
        }
        #endregion

        #region "[Search]"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvProductInfo.DataSource = ProductBUS.SearchProductByname(txtSearch.Text);

            int successfulRows = ((DevExpress.XtraGrid.Views.Grid.GridView)dtgvProductInfo.MainView).RowCount;
            List<ProductDTO> list = ProductBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();

            int listCount = list.Count;

            lbSearchResults.Text = "Kết quả tìm kiếm: " + successfulRows.ToString() + " / " + listCount.ToString();
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
                uc.Update += Uc_Update;
                uc.Delete += Uc_Delete;
            }
            catch { }
        }

        private void Uc_Delete(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void Uc_Update(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void Uc_Insert(object sender, EventArgs e)
        {
            LoadCombobox();
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
                    listInput.Add(inputItem);
                    ClearData();
                    LoadListProductInfo();
                    ShowCountNumber();
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
        private void gvProductInfo_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
                if (e.Column.Name == "colUnit")
                {
                    ProductDTO item = (ProductDTO)gvProductInfo.GetRow(e.RowHandle);
                    UnitDTO itemUnit = UnitBUS.SelectPrimaryKey(item.UnitID);
                    if (item != null && itemUnit != null)
                        e.DisplayText = itemUnit.Name;
                }
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

            // Kiểm tra xem chuỗi có chứa ký tự phân cách hàng nghìn không và chèn ký tự phân cách nếu cần thiết
            if (char.IsDigit(e.KeyChar))
            {
                // Lấy vị trí của con trỏ văn bản
                int selectionStart = txtImportPrice.SelectionStart;
                // Chèn ký tự phân cách hàng nghìn vào vị trí đúng
                txtImportPrice.Text = txtImportPrice.Text.Insert(selectionStart, e.KeyChar.ToString());
                // Đặt lại con trỏ văn bản sau khi chèn ký tự
                txtImportPrice.SelectionStart = selectionStart + 1;
                // Ngăn chặn sự kiện nhập liệu tiếp theo
                e.Handled = true;
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
                txtCount.Text = txtImportPrice.Text = txtSalePrice.Text = string.Empty;
                dtpkStartDate.Value = DateTime.Now;
                cbProductName.SelectedIndex = 0;
            }
            catch { }
        }
        #endregion

        #region "[LoadProductIntoCombobox]"
        private void LoadCombobox()
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

        #region "[Paint one line]"
        private void gvProductInfo_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            //(string)view.GetRowCellValue(e.RowHandle, view.Columns["colSoLuongTon"];

            //lấy thông tin sản phẩm trên 1 dòng.
            ProductDTO product = (ProductDTO)gvProductInfo.GetRow(e.RowHandle);
            if (product != null)
            {
                //lấy số lượng tồn tối thiểu cua sản phẩm này.
                int CountMin = 0;
                try
                {
                    CountMin = ParameterBUS.SelectByProductID(product.ID).Value;
                }
                catch { }
                if (product.Stock <= CountMin)
                {

                    e.Appearance.BackColor = Color.Pink;
                }
                if (e.RowHandle == View.FocusedRowHandle)
                {
                    e.Appearance.BackColor = Color.Pink;
                }
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
