using DTO.DTO;
using DTO.ACK;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public delegate void DelegateShowBill(List<BillInfoDTO> _listobjBillInfo, int _companyID);

    public partial class ucCreateBill : UserControl
    {

        #region "[Declare Global Variable]"
        public DelegateShowBill showBill = null;

        public DelegateClearItem clearItem = null;

        public DelegateShowUserControl itemShow = null;

        private List<BillInfoDTO> _billInfo = new List<BillInfoDTO>();

        private int m_companyID = -1;

        string billName = string.Empty;
        #endregion

        #region "[Default Constructor]"
        public ucCreateBill()
        {
            InitializeComponent();
        }
        public ucCreateBill(List<BillInfoDTO> _listobjBillInfo, int _companyID)
        {
            InitializeComponent();
            _billInfo = _listobjBillInfo;
            m_companyID = _companyID;
        }
        #endregion

        #region "[Insert ReceiveCommission]"
        private void hplReceiveCommission_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            try
            {
                if (itemShow != null)
                    itemShow();
            }
            catch { }
        }
        #endregion

        #region "[LoadListCreateBill]"
        private void LoadListCreateBill()
        {
            try
            {
                List<BillInfoACK> list = BUS.Utils.UtilsOperator.ConvertListFromBillInfoACK(_billInfo);
                dtgvCreateBill.DataSource = list;
            }
            catch { }
        }

        #endregion

        #region "[LoadCombobox]"

        private void LoadComboboxAddReferrer()
        {
            try
            {
                List<ReceiveCommissionDTO> items = ReceiveCommissionBUS.GetAll();
                if (items.Count > 0)
                {
                    ReceiveCommissionDTO itemAdd = new ReceiveCommissionDTO();
                    itemAdd.ID = -1;
                    itemAdd.Name = "(Chọn)";
                    items.Add(itemAdd);

                    luReceiveCommission.Properties.DataSource = items;
                    luReceiveCommission.Properties.DisplayMember = "Name";
                    luReceiveCommission.Properties.ValueMember = "ID";
                    luReceiveCommission.Properties.Columns.Add(new LookUpColumnInfo("Name", "Danh sách Người giới thiệu"));
                    luReceiveCommission.EditValue = -1;//lookUpEditCongTy.Properties.GetKeyValueByDisplayText("(Chọn)");

                }
            }
            catch { }
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

                luCustomerName.Properties.DataSource = listCompany;
                luCustomerName.Properties.DisplayMember = "Name";
                luCustomerName.Properties.ValueMember = "ID";
                luCustomerName.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Danh sách công ty"));
                if (m_companyID > 0)
                    luCustomerName.EditValue = m_companyID;
                else
                    luCustomerName.EditValue = luCustomerName.Properties.GetKeyValueByDisplayText("(Chọn Công Ty)");
            }
        }
        #endregion

        #region "[LoadPriceOrder]"
        private void LoadPriceOrder()
        {
            try
            {
                txtTotalBill.Text = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(BillInfoBUS.SumPrices(_billInfo).ToString());
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void ucCreateBill_Load(object sender, EventArgs e)
        {
            LoadListCreateBill();

            LoadComboboxCompany();

            LoadComboboxAddReferrer();

            LoadPriceOrder();

            #region "[Gridview selection is not allowed]"
            gvCreateBill.OptionsBehavior.Editable = gvCreateBill.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[CreateBill]"
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_companyID > 0)
                {
                    BillDTO bill = new BillDTO();
                    bill.Name = txtBillName.Text.Trim();
                    bill.CompanyID = m_companyID;
                    bill.AccountID = Management.UserLogin.ID;
                    bill.StartDate = dtpkStartDate.Value;
                    bill.TotalBill = 0;
                    bill.TotalPayment = double.Parse(txtPrepay.Text.Trim());
                    bill.PaymentDueDate = dtpkPaymentDate.Value;
                    bill.Dividend = 0;
                    bill.Commission = 0;
                    try { bill.Commission = double.Parse(txtCommission.Text.Trim()); }
                    catch { }
                    bill.ReceiveCommissionsID = -1;
                    try
                    {
                        bill.ReceiveCommissionsID = (int)luReceiveCommission.EditValue;
                    }
                    catch { }

                    double shippingCost = 0;
                    if (txtShippingCosts.Text.Trim() != string.Empty)
                        shippingCost = double.Parse(txtShippingCosts.Text.Trim());
                    bill.ShippingCost = shippingCost;
                    bill.Del = false;
                    bill.Note = mmedNote.Text.Trim();
                    BillACK ack = null;
                    if (_billInfo.Count > 0)
                        ack = BillBUS.CreateBill(_billInfo, bill);
                    if (ack != null)
                    {
                        if (ack.State)
                        {
                            string notification = "Lập Hóa đơn thành công";
                            if (ack.Overage > 0)
                            {
                                string change = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(ack.Overage.ToString());
                                notification += " \r\nTiền Thối Lại:" + change;
                                txtChange.Text = change;
                            }
                            //hiển thị thông báo thành công và kết thúc chức năng này.
                            ClassUtils.Utils.MessageBoxInfomation(notification, "Thông Báo");
                            return;
                        }
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
                int[] RowSelects = gvCreateBill.GetSelectedRows();
                if (RowSelects.Length > 0)
                {
                    for (int i = 0; i < RowSelects.Length; i++)
                    {
                        //lấy thông tin dòng được xóa
                        BillInfoDTO itemDelete = (BillInfoDTO)gvCreateBill.GetRow(RowSelects[0]);
                        if (itemDelete != null)
                        {
                            BillInfoDTO itemDelList = _billInfo.Where(p => p.ProductID == itemDelete.ProductID && p.SalePrice == itemDelete.SalePrice && p.VAT == itemDelete.VAT).FirstOrDefault();
                            _billInfo.Remove(itemDelList);

                        }
                    }
                    LoadListCreateBill();
                }
            }
            catch { }
        }
        #endregion

        #region "[Prev]"
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (showBill != null)
                showBill(_billInfo, m_companyID);
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

        #region "[Get information about the currently selected Company]"
        private void luCompanyName_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CompanyDTO itemSelect = (CompanyDTO)luCustomerName.GetSelectedDataRow();
                luCustomerName.ForeColor = Color.Red;
                m_companyID = itemSelect.ID;
            }
            catch { }
        }
        #endregion

        #region "[Ordinal number]"
        private void gvCreateBill_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
        }
        #endregion

        #region "[Export Excel]"
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {


                Program.strPath = string.Empty;
                billName = "Hóa Đơn Bán Hàng " + txtBillName.Text.Trim();
                FormDetails.frmPath frm = new FormDetails.frmPath(billName);
                frm.ShowDialog();

                if (Program.strPath != string.Empty)
                {
                    Thread threadMain = new Thread(new ThreadStart(ThreadExportFileExcel));
                    threadMain.IsBackground = true;
                    threadMain.Start();
                }
            }
            catch { }
        }
        #endregion

        #region "[Export]"
        public void Export(GridView data, string sheetName, string title, string _strPath)
        {
            try
            {
                #region "[create object excel]"
                //Tạo các đối tượng Excel
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbooks oBooks;
                Microsoft.Office.Interop.Excel.Sheets oSheets;
                Microsoft.Office.Interop.Excel.Workbook oBook;
                Microsoft.Office.Interop.Excel.Worksheet oSheet;
                #endregion

                #region "[Create workbook]"
                //Tạo mới một Excel WorkBook 
                //oExcel.Visible = true;
                oExcel.DisplayAlerts = false;
                oExcel.Application.SheetsInNewWorkbook = 1;
                oBooks = oExcel.Workbooks;
                #endregion

                #region "[Create sheet]"
                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
                oSheets = oBook.Worksheets;
                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
                oSheet.Name = sheetName;
                #endregion

                oSheet.PageSetup.PrintGridlines = false;
                oSheet.PageSetup.PrintHeadings = false;

                #region "[Create title]"
                // Tạo phần đầu nếu muốn
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "M1");
                head.MergeCells = true;
                head.Value2 = title;
                head.Font.Bold = true;
                head.Font.Name = "Tahoma";
                head.Font.Size = "18";
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                #endregion

                #region "[Initialize external information]"
                // tạo thông tin khách hàng
                // Tên
                Microsoft.Office.Interop.Excel.Range name = oSheet.get_Range("B2", "B2");
                name.MergeCells = true;
                name.Value2 = "Tên khách hàng: ";
                //ten.Font.Bold = true;
                name.Font.Name = "Tahoma";
                name.Font.Size = "10";
                name.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //số điện thoại
                Microsoft.Office.Interop.Excel.Range phone = oSheet.get_Range("B3", "B3");
                phone.MergeCells = true;
                phone.Value2 = "Điện thoại: ";
                //dienthoai.Font.Bold = true;
                phone.Font.Name = "Tahoma";
                phone.Font.Size = "10";
                phone.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //fax
                Microsoft.Office.Interop.Excel.Range fax = oSheet.get_Range("B4", "B4");
                fax.MergeCells = true;
                fax.Value2 = "Địa chỉ: ";
                //diachi.Font.Bold = true;
                fax.Font.Name = "Tahoma";
                fax.Font.Size = "10";
                fax.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                // dia chi
                Microsoft.Office.Interop.Excel.Range address = oSheet.get_Range("B5", "B5");
                address.MergeCells = true;
                address.Value2 = "Địa chỉ: ";
                //diachi.Font.Bold = true;
                address.Font.Name = "Tahoma";
                address.Font.Size = "10";
                address.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //tong tien hoa don
                Microsoft.Office.Interop.Excel.Range totalBill = oSheet.get_Range("B6", "B6");
                totalBill.MergeCells = true;
                totalBill.Value2 = "Tổng tiền hóa đơn: ";
                //diachi.Font.Bold = true;
                totalBill.Font.Name = "Tahoma";
                totalBill.Font.Size = "10";
                totalBill.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //tra truoc
                Microsoft.Office.Interop.Excel.Range prepay = oSheet.get_Range("B7", "B7");
                prepay.MergeCells = true;
                prepay.Value2 = "Trả trước: ";
                //diachi.Font.Bold = true;
                prepay.Font.Name = "Tahoma";
                prepay.Font.Size = "10";
                prepay.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range shippingCost = oSheet.get_Range("B8", "B8");
                shippingCost.MergeCells = true;
                shippingCost.Value2 = "Phí vận chuyển: ";
                //diachi.Font.Bold = true;
                shippingCost.Font.Name = "Tahoma";
                shippingCost.Font.Size = "10";
                shippingCost.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //ngay lap
                Microsoft.Office.Interop.Excel.Range startDate = oSheet.get_Range("B9", "B9");
                startDate.MergeCells = true;
                startDate.Value2 = "Ngày lập: ";
                //diachi.Font.Bold = true;
                startDate.Font.Name = "Tahoma";
                startDate.Font.Size = "10";
                startDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                #endregion

                //đối tượng công ty.
                CompanyDTO company = CompanyBUS.SelectPrimaryKey((int)(luCustomerName.EditValue));

                #region "[Information for the external object]"
                // Ten detail
                Microsoft.Office.Interop.Excel.Range companyName = oSheet.get_Range("C2", "M2");
                companyName.MergeCells = true;
                companyName.Value2 = company.Name;
                //ten.Font.Bold = true;
                companyName.Font.Name = "Tahoma";
                companyName.Font.Size = "10";
                companyName.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                // so dien thoai detail
                Microsoft.Office.Interop.Excel.Range companyPhone = oSheet.get_Range("C3", "M3");
                companyPhone.MergeCells = true;
                companyPhone.Value2 = company.Phone;
                //dienthoai.Font.Bold = true;
                companyPhone.Font.Name = "Tahoma";
                companyPhone.Font.Size = "10";
                companyPhone.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //fax
                Microsoft.Office.Interop.Excel.Range companyFax = oSheet.get_Range("C4", "M4");
                companyFax.MergeCells = true;
                companyFax.Value2 = company.Fax;
                //dienthoai.Font.Bold = true;
                companyFax.Font.Name = "Tahoma";
                companyFax.Font.Size = "10";
                companyFax.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                // dia chi detail 
                Microsoft.Office.Interop.Excel.Range companyAddress = oSheet.get_Range("C5", "M5");
                companyAddress.MergeCells = true;
                companyAddress.Value2 = company.Address;
                //diachi.Font.Bold = true;
                companyAddress.Font.Name = "Tahoma";
                companyAddress.Font.Size = "10";
                companyAddress.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //tông tien hoa don detail
                Microsoft.Office.Interop.Excel.Range totalBillDetails = oSheet.get_Range("C6", "M6");
                totalBillDetails.MergeCells = true;
                double temp = double.Parse(txtTotalBill.Text);
                if (temp > double.Parse(txtTotalBill.Text))
                {
                    temp = double.Parse(txtTotalBill.Text);
                }
                totalBillDetails.Value2 = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(temp.ToString());
                //diachi.Font.Bold = true;
                totalBillDetails.Font.Name = "Tahoma";
                totalBillDetails.Font.Size = "10";
                totalBillDetails.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                // tra truoc detail
                Microsoft.Office.Interop.Excel.Range totalPrepayDetails = oSheet.get_Range("C7", "M7");
                totalPrepayDetails.MergeCells = true;
                totalPrepayDetails.Value2 = txtPrepay.Text;
                //diachi.Font.Bold = true;
                totalPrepayDetails.Font.Name = "Tahoma";
                totalPrepayDetails.Font.Size = "10";
                totalPrepayDetails.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range shippingCostDetails = oSheet.get_Range("C8", "M8");
                shippingCostDetails.MergeCells = true;
                shippingCostDetails.Value2 = txtShippingCosts.Text;
                //diachi.Font.Bold = true;
                shippingCostDetails.Font.Name = "Tahoma";
                shippingCostDetails.Font.Size = "10";
                shippingCostDetails.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //ngay lap detail
                Microsoft.Office.Interop.Excel.Range startDateDetails = oSheet.get_Range("C9", "M9");
                startDateDetails.MergeCells = true;
                startDateDetails.Value2 = dtpkStartDate.Value.ToString("dd.MM.yyyy");
                //diachi.Font.Bold = true;
                startDateDetails.Font.Name = "Tahoma";
                startDateDetails.Font.Size = "10";
                startDateDetails.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                #endregion

                #region "[tạo tiêu đề bảng]"
                // Tạo tiêu đề cột 
                Microsoft.Office.Interop.Excel.Range colSTT = oSheet.get_Range("A11", "A11");
                colSTT.Value2 = "STT";
                colSTT.ColumnWidth = 5;

                Microsoft.Office.Interop.Excel.Range colProduct = oSheet.get_Range("B11", "B11");
                colProduct.Value2 = "Sản Phẩm";
                colProduct.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range colCount = oSheet.get_Range("C11", "C11");
                colCount.Value2 = "Số Lượng";
                colCount.ColumnWidth = 20.0;

                Microsoft.Office.Interop.Excel.Range colSalePrice = oSheet.get_Range("D11", "D11");
                colSalePrice.Value2 = "Giá Bán";
                colSalePrice.ColumnWidth = 10.0;

                Microsoft.Office.Interop.Excel.Range colVAT = oSheet.get_Range("E11", "E11");
                colVAT.Value2 = "VAT";
                colVAT.ColumnWidth = 15.0;


                Microsoft.Office.Interop.Excel.Range colNote = oSheet.get_Range("F11", "F11");
                colNote.Value2 = "Ghi Chú";
                colNote.ColumnWidth = 20.0;
                #endregion


                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A11", "F11");
                rowHead.Font.Bold = true;

                // Kẻ viền
                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                // Thiết lập màu nền
                rowHead.Interior.ColorIndex = 15;
                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.



                object[,] arr = new object[data.RowCount, 6];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng
                int stt = 1;
                for (int r = 0; r < data.RowCount; r++)
                {
                    BillInfoACK itemProduct = new BillInfoACK();

                    itemProduct = (BillInfoACK)gvCreateBill.GetRow(r);

                    //NangLuongTieuDiem_Management.LoaiSanPham_SelectByPrimaryKey(item.LoaiSanPhamID).TenLoaiSanPham

                    arr[r, 0] = stt;                                     // cot stt
                    arr[r, 1] = itemProduct.ProductName;        // cot ten san pham
                    arr[r, 2] = itemProduct.Count;           //so luong
                    arr[r, 3] = itemProduct.SalePrice;            // giá bán
                    arr[r, 4] = itemProduct.VAT;               //VAT
                    //arr[r, 5] = item_sanpham.TienLoi;           // tiền lời
                    arr[r, 5] = itemProduct.Note;     // cot ghi chu
                    stt++;

                }

                //Thiết lập vùng điền dữ liệu
                int rowStart = 12;
                int columnStart = 1;

                int rowEnd = rowStart + data.RowCount - 1;
                int columnEnd = 6;

                // Ô bắt đầu điền dữ liệu
                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
                // Ô kết thúc điền dữ liệu
                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
                // Lấy về vùng điền dữ liệu
                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập
                range.Value2 = arr;

                // Kẻ viền
                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT
                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                //save file
                object missValue = System.Reflection.Missing.Value;

                oBook.SaveAs(_strPath, Excel.XlFileFormat.xlWorkbookNormal, missValue, missValue, missValue, missValue, Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
                oBook.Close();
                oExcel.Quit();
            }
            catch { }
        }
        #endregion

        #region "[Multithread Export File excel]"
        void ThreadExportFileExcel()
        {
            try
            {
                Export(gvCreateBill, "Hóa đơn bán hàng", billName, Program.strPath);
            }
            catch { }
        }
        #endregion

        #region "[Only enter numbers]"

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtChange.Text, out decimal salePrice))
            {
                // Chuyển đổi giá trị thành chuỗi có định dạng tiền tệ
                txtChange.Text = salePrice.ToString("#,##0");
                // Di chuyển con trỏ về cuối textbox
                txtChange.SelectionStart = txtChange.Text.Length;
            }
        }

        private void txtPrepay_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrepay.Text, out decimal salePrice))
            {
                // Chuyển đổi giá trị thành chuỗi có định dạng tiền tệ
                txtPrepay.Text = salePrice.ToString("#,##0");
                // Di chuyển con trỏ về cuối textbox
                txtPrepay.SelectionStart = txtPrepay.Text.Length;
            }
        }

        private void txtPrepay_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự phân cách thập phân (nếu có)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }

            // Kiểm tra xem đã có ký tự phân cách thập phân (',' hoặc '.') trong textbox chưa
            bool hasDecimalSeparator = txtPrepay.Text.Contains(".") || txtPrepay.Text.Contains(",");

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
                    e.KeyChar = txtPrepay.Text.Contains(".") ? ',' : '.';
                }
            }
        }

        private void txtTotalBill_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalBill.Text, out decimal salePrice))
            {
                // Chuyển đổi giá trị thành chuỗi có định dạng tiền tệ
                txtTotalBill.Text = salePrice.ToString("#,##0");
                // Di chuyển con trỏ về cuối textbox
                txtTotalBill.SelectionStart = txtTotalBill.Text.Length;
            }
        }

        private void txtCommission_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCommission.Text, out decimal salePrice))
            {
                // Chuyển đổi giá trị thành chuỗi có định dạng tiền tệ
                txtCommission.Text = salePrice.ToString("#,##0");
                // Di chuyển con trỏ về cuối textbox
                txtCommission.SelectionStart = txtCommission.Text.Length;
            }
        }

        private void txtShippingCosts_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtShippingCosts.Text, out decimal salePrice))
            {
                // Chuyển đổi giá trị thành chuỗi có định dạng tiền tệ
                txtShippingCosts.Text = salePrice.ToString("#,##0");
                // Di chuyển con trỏ về cuối textbox
                txtShippingCosts.SelectionStart = txtShippingCosts.Text.Length;
            }
        }

        private void txtShippingCosts_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự phân cách thập phân (nếu có)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }

            // Kiểm tra xem đã có ký tự phân cách thập phân (',' hoặc '.') trong textbox chưa
            bool hasDecimalSeparator = txtShippingCosts.Text.Contains(".") || txtShippingCosts.Text.Contains(",");

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
                    e.KeyChar = txtShippingCosts.Text.Contains(".") ? ',' : '.';
                }
            }
        }
        #endregion

    }
}
