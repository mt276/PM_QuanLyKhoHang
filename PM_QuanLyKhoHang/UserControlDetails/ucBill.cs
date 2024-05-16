using DTO.DTO;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Threading;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public delegate void DelegateShowBillInfo(List<BillInfoDTO> _listobjBillInfo, int _companyID);

    public partial class ucBill : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateShowBillInfo showBillInfo = null;

        public DelegateClearItem clearItem = null;

        public DelegateShowUserControl itemShow = null;

        private List<BillInfoDTO> _listBillInfo = new List<BillInfoDTO>();

        private int _productID = -1;

        private int _selectCompanyID = 0;

        #endregion

        #region "[Default Constructor]"
        public ucBill()
        {
            InitializeComponent();
        }

        public ucBill(List<BillInfoDTO> _listobjBillInfo, int _companyID)
        {
            InitializeComponent();
            _listBillInfo = _listobjBillInfo;
            _selectCompanyID = _companyID;
            LoadDataGridViewProductDetails();
        }
        #endregion

        #region "[Load]"
        private void ucBill_Load(object sender, EventArgs e)
        {


            if(_listBillInfo.Count == 0)
                    btnAddProduct.Enabled = btnCreateBill.Enabled = btnNewBill.Enabled = btnDelete.Enabled = false;

            //LoadComboboxCompany();

            //LoadComboboxUnit();

            //LoadListProduct();

            ThreadProcessManagement();

            #region "[Gridview selection is not allowed]"
            gvBill.OptionsBehavior.Editable = gvBill.OptionsSelection.EnableAppearanceFocusedCell = false;

            gvProductInfo.OptionsBehavior.Editable = gvProductInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[LoadCombobox]"

        private void LoadComboboxUnit()
        {
            List<UnitDTO> listUnit = UnitBUS.GetAll();
            if (listUnit.Count > 0)
            {
                cbUnit.DataSource = listUnit;
                cbUnit.DisplayMember = "Name";
                cbUnit.ValueMember = "ID";
            }
        }
        private void LoadComboboxCompany()
        {
            

            List<CompanyDTO> listCompany = CompanyBUS.GetAll();
            if (listCompany.Count > 0)
            {
                CompanyDTO itemAdd = new CompanyDTO();
                itemAdd.ID = -1;
                itemAdd.Name = "(Chọn Công Ty)";
                listCompany.Add(itemAdd);

                luCompanyName.Properties.DataSource = listCompany;
                luCompanyName.Properties.DisplayMember = "Name";
                luCompanyName.Properties.ValueMember = "ID";
                luCompanyName.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Danh sách công ty"));
                if (_selectCompanyID > 0)
                    luCompanyName.EditValue = _selectCompanyID;
                else
                    luCompanyName.EditValue = luCompanyName.Properties.GetKeyValueByDisplayText("(Chọn Công Ty)");
            }
        }
        #endregion

        #region "[LoadListProduct]"
        private void LoadListProduct()
        {
            try
            {
                List<ProductDTO> list = ProductBUS.GetAll().Where(p => p.Stock > 0).ToList().OrderByDescending(p => p.StartDate).ToList();
                if (list.Count > 0)
                    dtgvProductInfo.DataSource = list;
                dtgvProductInfo.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[Search]"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvProductInfo.DataSource = ProductBUS.SearchProductByname(txtSearch.Text).Where(p=>p.Stock>0).ToList();
            int successfulRows = ((DevExpress.XtraGrid.Views.Grid.GridView)dtgvProductInfo.MainView).RowCount;
            List<ProductDTO> list = ProductBUS.GetAll().Where(p=>p.Stock>0).ToList().OrderByDescending(p => p.StartDate).ToList();

            int listCount = list.Count;

            lbSearchResults.Text = "Kết quả tìm kiếm: " + successfulRows.ToString() + " / " + listCount.ToString();
        }
        #endregion 

        #region "[Insert Product]"
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCount.Text.Trim().Length == 0)
                {
                    ClassUtils.Utils.MessageBoxERROR("Số lượng không được để trống", "Thông báo");
                    return;
                }
                if (_selectCompanyID == 0)
                {
                    ClassUtils.Utils.MessageBoxERROR("Chưa chọn tên công ty", "Thông báo");
                    return;
                }
                if (_selectCompanyID == -1)
                {
                    ClassUtils.Utils.MessageBoxERROR("Chưa chọn tên công ty", "Thông báo");
                    return;
                }
                //kiểm tra số lượng có hợp lý không.
                //nếu > số lượng tồn trong kho--> xuất thông báo ra cho người dùng
                //ngược lại thì cho phép insert.
                if (_productID > 0)
                {
                    #region "[Kiểm tra số lượng sản phẩm trong kho có đủ đáp ứng hay không]"
                    //lấy số lượng mà khách hàng đang mua
                    int saleNumber = int.Parse(txtCount.Text.Trim());

                    //tính số lượng các sản phẩm trong danh sách chi tiết.
                    List<BillInfoDTO> listTemp = _listBillInfo.Where(p => p.ProductID == _productID).ToList();
                    int countTemp = 0;
                    if (listTemp.Count > 0)
                    {
                        foreach (BillInfoDTO irun in listTemp)
                        {
                            countTemp += irun.Count;
                        }
                    }

                    int stock = ProductBUS.SelectPrimaryKey(_productID).Stock;
                    if (saleNumber > stock)
                    {
                        ClassUtils.Utils.MessageBoxERROR("Số lượng sản phẩm không đủ\r\nSố lượng sản phẩm trong kho là " + stock.ToString(), "Thông Báo");
                        return;
                    }
                    if ((countTemp + saleNumber) > stock)
                    {
                        ClassUtils.Utils.MessageBoxERROR("Số lượng sản phẩm không đủ\r\nSố lượng sản phẩm trong kho là " + stock.ToString(), "Thông Báo");
                        return;
                    }
                    #endregion

                    //thêm sản phẩm vào hóa đơn
                    BillInfoDTO item = new BillInfoDTO();
                    item.BillID = -1;
                    item.ProductID = _productID;
                    item.Count = int.Parse(BUS.Utils.UtilsOperator.GeneralPricesIntoDetailedPrices(txtCount.Text.Trim()).ToString());
                    item.SalePrice = double.Parse(txtSalePrice.Text.Trim());
                    item.SalePriceString = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(item.SalePrice.ToString());
                    item.VAT = (int)nrudVAT.Value;
                    //(giá nhập vào - giá bán ra) - VAT*((giá nhập vào - giá bán ra))
                    //Lấy giá nhập vào của 1 sản phẩm
                    double importPrice = 0;
                    try
                    {
                        InputDTO itemInput = InputBUS.GetInputProductByProductID(_productID).OrderByDescending(p => p.StartDate).ToList().FirstOrDefault();
                        if (itemInput != null)
                            importPrice = itemInput.ImportPrice;
                    }
                    catch { }
                    if (importPrice == 0)
                        return;
                    double price = (double.Parse(txtSalePrice.Text.Trim()) - importPrice);

                    //tính tiền lởi của món hàng
                    if (item.VAT > 0)
                        item.Dividend = price - (item.VAT * price / 100);
                    else
                        item.Dividend = price;
                    item.DividendString = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(item.Dividend.ToString());
                    item.Del = false;
                    item.Note = mmedNote.Text.Trim();
                    item.ImportPrice = importPrice;
                    //kiểm tra sản phẩm này đã tồn tại chưa. nếu chưa tồn tại thì thêm vào list
                    //còn nếu đã tồn tại thì kiểm tra.
                    //nếu giá bán trùng với giá bán trước thì số lượng ++, còn giá bán khác thì thêm 
                    //vào như sản phẩm này chưa từng được thêm
                    BillInfoDTO itemFlag = null;
                    try
                    {
                        itemFlag = _listBillInfo.Where(p => p.ProductID == item.ProductID && p.SalePrice == item.SalePrice).FirstOrDefault();
                    }
                    catch { }
                    if (itemFlag != null)
                    {
                        _listBillInfo.Remove(itemFlag);
                        itemFlag.Count += item.Count;
                        itemFlag.VAT = item.VAT;
                        itemFlag.Note = item.Note;
                        //itemFlag = item;
                        _listBillInfo.Add(itemFlag);

                    }
                    else
                        _listBillInfo.Add(item);

                    //reset mã sản phẩm.
                    _productID = -1;
                    LoadDataGridViewProductDetails();
                    ClearData();
                }
            }
            catch { }
        }
        #endregion

        #region "[Cancel]"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ClearData();
                if (_listBillInfo.Count == 0)
                    btnAddProduct.Enabled = btnCreateBill.Enabled = btnNewBill.Enabled = btnDelete.Enabled = false;

            }
            catch { }
        }
        #endregion

        #region "[Delete]"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int[] rowChecks = gvBill.GetSelectedRows();

            if(rowChecks.Length == 0)
            {
                ClassUtils.Utils.MessageBoxInfomation("Không có dòng nào được chọn", "Thông Báo");
                return;
            }
            else
            {
                for (int i = 0; i < rowChecks.Length; i++)
                {
                    BillInfoDTO item = (BillInfoDTO)gvBill.GetRow(rowChecks[i]);
                    BillInfoDTO itemSelect = null;
                    try 
                    { 
                        itemSelect = _listBillInfo.Where(p => p.ProductID == item.ProductID).FirstOrDefault(); 
                    }
                    catch { }
                    if(itemSelect != null)
                    {
                        _listBillInfo.Remove(itemSelect);
                        LoadDataGridViewProductDetails();
                        ClearData();
                    }
                }
            }
            if (_listBillInfo.Count == 0)
                btnCreateBill.Enabled = btnNewBill.Enabled = btnDelete.Enabled = false;

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

        #region "[Create Bill]"
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (showBillInfo != null)
                    showBillInfo(_listBillInfo, _selectCompanyID);
            }
            catch { }
        }
        #endregion

        #region "[New Bill]"
        private void btnNewBill_Click(object sender, EventArgs e)
        {
            try
            {
                _selectCompanyID = -1;
                _productID = -1;
                luCompanyName.EditValue = -1;
                _listBillInfo.Clear();
                LoadDataGridViewProductDetails();
                LoadListProduct();
                if (_listBillInfo.Count == 0)
                    btnCreateBill.Enabled = btnNewBill.Enabled = btnDelete.Enabled = false;
            }
            catch { }
        }
        #endregion

        #region "[Get information in one line ProductInfo]"
        private void gvProductInfo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ClearData();

            ProductDTO productSelect = (ProductDTO)gvProductInfo.GetRow(e.RowHandle);

            if(productSelect != null)
            {
                cbUnit.SelectedValue = productSelect.UnitID;

                txtProductName.Text = productSelect.Name;

                SalePriceDTO salePriceItem = SalePriceBUS.GetListPriceProductByProductID(productSelect.ID).OrderByDescending(p => p.StartDate).FirstOrDefault<SalePriceDTO>();
                txtSalePrice.Text = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(salePriceItem.SalePrice.ToString());
                txtProductName.Text = productSelect.Name;
                _productID = productSelect.ID;

                btnAddProduct.Enabled = true;

            }
            if (_listBillInfo.Count == 0)
                btnCreateBill.Enabled = btnNewBill.Enabled = btnDelete.Enabled = false;
            else
                btnCreateBill.Enabled = btnNewBill.Enabled = btnDelete.Enabled = true;
        }
        #endregion

        #region "[Ordinal number ProductInfo]"
        private void gvProductInfo_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "STT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
                if (e.Column.Name == "colUnitName")
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

        #region "[Ordinal number Bill]" 
        private void gvBill_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();

            }
            catch { }

            try
            {
                //hiển thị tên sản phẩm
                if (e.Column.Name == "colProductID")
                {
                    BillInfoDTO item = (BillInfoDTO)gvBill.GetRow(e.RowHandle);
                    ProductDTO product = null;
                    try
                    {
                        product = ProductBUS.SelectPrimaryKey(item.ProductID);
                    }
                    catch { }
                    if (product != null)
                        e.DisplayText = product.Name;

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
        private void EnableButton(bool isFlag)
        {
            try
            {
                try
                {
                    if (_productID > 0)
                        btnAddProduct.Enabled = isFlag;
                    else
                        btnAddProduct.Enabled = !isFlag;

                    if (dtgvBill.DataSource != null ) 
                        btnDelete.Enabled = btnNewBill.Enabled = btnCreateBill.Enabled = isFlag;
                    else
                        btnDelete.Enabled = btnNewBill.Enabled = btnCreateBill.Enabled = !isFlag;
                }
                catch { }
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
                txtCount.Text = txtProductName.Text = txtSalePrice.Text = mmedNote.Text = string.Empty;
                _productID = -1;
                cbUnit.SelectedIndex = -1;
                nrudVAT.Value = 0;
                btnAddProduct.Enabled = false;
            }
            catch { }
        }
        #endregion

        #region "[LoadDataGridViewProductDetails]"
        /// <summary>
        /// hiển thị chi tiết sản phẩm được mua
        /// </summary>
        private void LoadDataGridViewProductDetails()
        {
            try
            {
                dtgvBill.DataSource = _listBillInfo;
                dtgvBill.RefreshDataSource();
                EnableButton(true);
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

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự phân cách thập phân (nếu có)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }
        }



        #endregion

        #region "[Get information about the currently selected Company]"
        private void luCompanyName_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CompanyDTO itemSelect = (CompanyDTO)luCompanyName.GetSelectedDataRow();
                luCompanyName.ForeColor = Color.Red;
                _selectCompanyID = itemSelect.ID;
            }
            catch { }
        }
        #endregion

        #region "[MultiThread for control]"
        /// <summary>
        /// quản lý các thread trong control này
        /// </summary>
        private void ThreadProcessManagement()
        {
            try
            {
                Thread threadLoadListProduct = new Thread(new ThreadStart(LoadListProductMultiThread));
                Thread threadLoadComboboxCompany = new Thread(new ThreadStart(LoadComboboxCompanyMultiThread));
                Thread threadLoadComboboxUnit = new Thread(new ThreadStart(LoadComboboxUnitMultiThread));

                threadLoadListProduct.IsBackground = true;
                threadLoadComboboxCompany.IsBackground = true;
                threadLoadComboboxUnit.IsBackground = true;

                threadLoadListProduct.Start();
                threadLoadComboboxCompany.Start();
                threadLoadComboboxUnit.Start();


                threadLoadListProduct.Join();
                threadLoadComboboxCompany.Join();
                threadLoadComboboxUnit.Join();
            }
            catch { }
        }

        /// <summary>
        ///load danh sách các sản phẩm lên datagridview bằng multiThread
        /// </summary>
        private void LoadListProductMultiThread()
        {
            try
            {
                if (dtgvProductInfo.InvokeRequired)
                {
                    //chạm đến thread của hệ thống
                    dtgvProductInfo.BeginInvoke(new MyDelegate(LoadListProductMultiThread));
                }
                else
                {
                    lock (dtgvProductInfo)
                    {
                        LoadListProduct();
                        dtgvProductInfo.RefreshDataSource();
                    }
                }
                Thread.Sleep(10);
            }
            catch { }
        }
        private void LoadComboboxCompanyMultiThread()
        {
            try
            {
                if (luCompanyName.InvokeRequired)
                {
                    luCompanyName.BeginInvoke(new MyDelegate(LoadComboboxCompanyMultiThread));
                }
                else
                {
                    lock (luCompanyName)
                    {
                        LoadComboboxCompany();
                    }
                }
                Thread.Sleep(10);
            }
            catch { }
        }

        private void LoadComboboxUnitMultiThread()
        {
            try
            {
                if (cbUnit.InvokeRequired)
                {
                    cbUnit.BeginInvoke(new MyDelegate(LoadComboboxUnitMultiThread));
                }
                else
                {
                    lock (cbUnit)
                    {
                        LoadComboboxUnit();
                    }
                }
                Thread.Sleep(10);
            }
            catch { }
        }
        #endregion

        #region "[Company product details]"
        /// <summary>
        /// <para>khi bấm vào sẽ hiển thị danh sách</para>
        /// <para>các sản phẩm mà công ty này đã mua</para>
        /// <para>trong những hóa đơn trước</para>
        /// <para>sắp xếp thứ tự thời gian giảm dần</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrmListProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if(_selectCompanyID < 0)
                {
                    ClassUtils.Utils.MessageBoxERROR("Vui lòng chọn công ty", "Thông báo");
                    return;
                }
                if(_productID == -1)
                {
                    ClassUtils.Utils.MessageBoxERROR("Vui lòng chọn sản phẩm", "Thông báo");
                    return;
                }

                if (_selectCompanyID > 0 && _productID > 0)
                {
                    FormDetails.frmListProducts frm = new FormDetails.frmListProducts(_productID, _selectCompanyID);
                    frm.ShowDialog();
                }
            }
            catch { }
        }
        #endregion


    }
}
