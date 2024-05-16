using DTO.DTO;
using DTO.ACK;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucBillStatistics : UserControl
    {
        #region "[Default Constructor]"
        public ucBillStatistics()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Ordinal number]"
        private void gvCompany_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colCSTT") 
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
        }

        private void gvListBill_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colLSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
            BillDTO item = (BillDTO)gvListBill.GetRow(e.RowHandle);
            try
            {
                if (e.Column.Name == "colLCompanyName") 
                {

                    e.DisplayText = CompanyBUS.SelectPrimaryKey(item.CompanyID).Name;
                }
            }
            catch { }
            try
            {
                if (e.Column.Name == "colLAccountName") 
                {
                    e.DisplayText = AccountBUS.SelectPrimaryKey(item.AccountID).FullName;
                }
            }
            catch { }
            try
            {
                if (e.Column.Name == "colReceiveCommission") 
                {
                    if(item.ReceiveCommissionsID>0)
                    e.DisplayText = ReceiveCommissionBUS.SelectPrimaryKey(item.ReceiveCommissionsID).Name;
                }
            }
            catch { }
        }

        private void gvBillInfo_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colBSTT") 
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
            try
            {
                if (e.Column.Name == "colProductName") 
                {
                    BillInfoDTO item = (BillInfoDTO)gvBillInfo.GetRow(e.RowHandle);
                    e.DisplayText = ProductBUS.SelectPrimaryKey(item.ProductID).Name;
                }
            }
            catch { }
        }

        #endregion

        #region "[Get information in one line]"
        private void gvCompany_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                CompanyDTO item = (CompanyDTO)gvCompany.GetRow(e.RowHandle);
                //load danh sach các hoa đơn của công ty theo thứ tự thòi gian gần nhất.
                List<BillDTO> list = BillBUS.SelectByCompanyID(item.ID).OrderByDescending(p => p.StartDate).ToList();
                LoadDataGridViewBill(list);
            }
            catch { }
        }
        private void gvListBill_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                //hiển thị chi tiết hóa đơn.
                BillDTO item = (BillDTO)gvListBill.GetRow(e.RowHandle);

                List<BillInfoDTO> list = BillInfoBUS.SelectByBillID(item.ID);
                LoadDataGridViewBillInfo(list);
            }
            catch { }
        }
        #endregion

        #region "[LoadDataGridViewBillInfo]"
        /// <summary>
        /// Lấy danh sách chi tiết của hóa đơn
        /// </summary>
        /// <param name="_list"></param>
        private void LoadDataGridViewBillInfo(List<BillInfoDTO> _list)
        {
            try
            {
                dtgvBillInfo.DataSource = _list;
                dtgvBillInfo.RefreshDataSource();

            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void ucBillStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                //load danh sách các hóa đơn
                LoadDataGridViewBill();

                //load danh sách các khách hàng(congty)
                LoadCompany();

                #region "[Gridview selection is not allowed]"
                gvCompany.OptionsBehavior.Editable = gvCompany.OptionsSelection.EnableAppearanceFocusedCell = false;
                gvBillInfo.OptionsBehavior.Editable = gvBillInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
                gvListBill.OptionsBehavior.Editable = gvListBill.OptionsSelection.EnableAppearanceFocusedCell = false;
                #endregion
            }
            catch { }
        }
        #endregion

        #region "[LoadCompany]"
        /// <summary>
        /// load dnah sách các khách hàng
        /// </summary>
        private void LoadCompany()
        {
            try
            {
                List<CompanyDTO> listCompany = CompanyBUS.GetAll();
                dtgvCompany.DataSource = listCompany;
                dtgvCompany.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[LoadDataGriViewBill]"
        /// <summary>
        /// Lấy danh sách các hóa đơn
        /// </summary>
        private void LoadDataGridViewBill()
        {
            try
            {
                List<BillDTO> list = BillBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();
                if (list.Count > 0)
                {
                    dtgvListBill.DataSource = list;
                    dtgvListBill.RefreshDataSource();
                }
            }
            catch { }
        }
        private void LoadDataGridViewBill(List<BillDTO> _list)
        {
            try
            {
                
                dtgvListBill.DataSource = _list;
                dtgvListBill.RefreshDataSource();

            }
            catch { }
        }
        #endregion

        #region "[Search]"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy danh sách các hóa đơn theo thời gian
                List<BillDTO> list = BillBUS.GetAllBillByTimes(dtpkStartDate.Value, dtpkEndDate.Value);
                LoadDataGridViewBill(list);
            }
            catch { }
        }
        #endregion

        #region "[ShowAll]"

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadDataGridViewBill();
        }
        #endregion

        #region "[export ra file excel]"
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                List<BillInfoDTO> items = (List<BillInfoDTO>)dtgvBillInfo.DataSource;
                if (items == null)
                {
                    ClassUtils.Utils.MessageBoxERROR("Không có dữ liệu", "Thông báo");
                    return;
                }
                if (items.Count > 0)
                {
                    Program.strPath = string.Empty;
                    FormDetails.frmPath frm = new FormDetails.frmPath();
                    frm.ShowDialog();
                    if (Program.strPath != string.Empty)
                    {
                        Thread threadMain = new Thread(new ThreadStart(ThreadExportFileExcel));
                        threadMain.IsBackground = true;
                        threadMain.Start();

                    }
                }

            }
            catch { }
        }
        #endregion

        #region "[Export]"
        public void Export(GridView data, string sheetName, string _strPath)
        {
            try
            {
                BillDTO itemBill = new BillDTO();
                itemBill = BillBUS.SelectPrimaryKey(((BillInfoDTO)gvBillInfo.GetRow(0)).BillID);
                #region "[tạo đối tượng excel]"
                //Tạo các đối tượng Excel
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbooks oBooks;
                Microsoft.Office.Interop.Excel.Sheets oSheets;
                Microsoft.Office.Interop.Excel.Workbook oBook;
                Microsoft.Office.Interop.Excel.Worksheet oSheet;
                #endregion

                #region "[tạo mới một workbook]"
                //Tạo mới một Excel WorkBook 
                //oExcel.Visible = true;
                oExcel.DisplayAlerts = false;
                oExcel.Application.SheetsInNewWorkbook = 1;
                oBooks = oExcel.Workbooks;
                #endregion

                #region "[tạo mới 1 sheet]"
                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
                oSheets = oBook.Worksheets;
                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
                oSheet.Name = sheetName;
                #endregion

                oSheet.PageSetup.PrintGridlines = false;
                oSheet.PageSetup.PrintHeadings = false;

                #region "[Tạo tiêu đề]"
                // Tạo phần đầu nếu muốn
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "M1");
                head.MergeCells = true;
                head.Value2 = "Hóa Đơn Ngày " + itemBill.StartDate.ToString("dd.MM.yyyy");
                head.Font.Bold = true;
                head.Font.Name = "Tahoma";
                head.Font.Size = "18";
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                #endregion

                #region "[Khởi tạo thông tin bên ngoài]"
                CompanyDTO itemCompany = CompanyBUS.SelectPrimaryKey(itemBill.CompanyID);

                // so dien thoai
                Microsoft.Office.Interop.Excel.Range billName = oSheet.get_Range("B2", "C2");
                billName.MergeCells = true;
                billName.Value2 = "Tên Hoá Đơn: " + itemBill.Name;
                //dienthoai.Font.Bold = true;
                billName.Font.Name = "Tahoma";
                billName.Font.Size = "10";
                billName.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //fax
                Microsoft.Office.Interop.Excel.Range companyName = oSheet.get_Range("B3", "C3");
                companyName.MergeCells = true;
                companyName.Value2 = "Tên Công Ty Bán: " + itemCompany.Name;
                //diachi.Font.Bold = true;
                companyName.Font.Name = "Tahoma";
                companyName.Font.Size = "10";
                companyName.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                // dia chi
                Microsoft.Office.Interop.Excel.Range address = oSheet.get_Range("B4", "C4");
                address.MergeCells = true;
                address.Value2 = "Địa Chỉ: " + itemCompany.Address;
                //diachi.Font.Bold = true;
                address.Font.Name = "Tahoma";
                address.Font.Size = "10";
                address.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //tong tien hoa don
                Microsoft.Office.Interop.Excel.Range phone = oSheet.get_Range("B5", "C5");
                phone.MergeCells = true;
                phone.Value2 = "Điện Thoại: " + itemCompany.Phone;
                //diachi.Font.Bold = true;
                phone.Font.Name = "Tahoma";
                phone.Font.Size = "10";
                phone.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //tra truoc
                Microsoft.Office.Interop.Excel.Range fax = oSheet.get_Range("B6", "C6");
                fax.MergeCells = true;
                fax.Value2 = "Fax:" + itemCompany.Fax;
                //diachi.Font.Bold = true;
                fax.Font.Name = "Tahoma";
                fax.Font.Size = "10";
                fax.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range accountName = oSheet.get_Range("B7", "C7");
                accountName.MergeCells = true;
                accountName.Value2 = "Nhân Viên Lập: " + AccountBUS.SelectPrimaryKey(itemBill.AccountID).FullName;
                //diachi.Font.Bold = true;
                accountName.Font.Name = "Tahoma";
                accountName.Font.Size = "10";
                accountName.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                ///chau

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range startDate = oSheet.get_Range("D2", "E2");
                startDate.MergeCells = true;
                startDate.Value2 = "Ngày Lập: " + itemBill.StartDate.ToString("dd.MM.yyyy");
                //diachi.Font.Bold = true;
                startDate.Font.Name = "Tahoma";
                startDate.Font.Size = "10";
                startDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range totalBill = oSheet.get_Range("D3", "E3");
                totalBill.MergeCells = true;
                totalBill.Value2 = "Tổng Tiền Hóa Đơn: " + itemBill.TotalBill.ToString();
                //diachi.Font.Bold = true;
                totalBill.Font.Name = "Tahoma";
                totalBill.Font.Size = "10";
                totalBill.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range totalPayment = oSheet.get_Range("D4", "E4");
                totalPayment.MergeCells = true;
                totalPayment.Value2 = "Trả Trước: " + itemBill.TotalPayment.ToString();
                //traTruoc.Font.Bold = true;
                totalPayment.Font.Name = "Tahoma";
                totalPayment.Font.Size = "10";
                totalPayment.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range dividend = oSheet.get_Range("D5", "E5");
                dividend.MergeCells = true;
                dividend.Value2 = "Tiền Lời: " + itemBill.Dividend.ToString();
                //diachi.Font.Bold = true;
                dividend.Font.Name = "Tahoma";
                dividend.Font.Size = "10";
                dividend.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range receiveCommission = oSheet.get_Range("D6", "E6");
                receiveCommission.MergeCells = true;
                string strReceiveCommission = string.Empty;
                if(itemBill.ReceiveCommissionsID>0)
                    strReceiveCommission = ReceiveCommissionBUS.SelectPrimaryKey(itemBill.ReceiveCommissionsID).Name;
                
                receiveCommission.Value2 = "Tên người Nhận Hoa Hồng:" + strReceiveCommission;
                //diachi.Font.Bold = true;
                receiveCommission.Font.Name = "Tahoma";
                receiveCommission.Font.Size = "10";
                receiveCommission.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range commission = oSheet.get_Range("D7", "E7");
                commission.MergeCells = true;
                string strCommission = string.Empty;
                try
                {
                    strCommission = itemBill.Commission.ToString();
                }
                catch { }
                commission.Value2 = "Tiền Hoa Hồng: " + strCommission;
                //diachi.Font.Bold = true;
                commission.Font.Name = "Tahoma";
                commission.Font.Size = "10";
                commission.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range shippingCost = oSheet.get_Range("F2", "H2");
                shippingCost.MergeCells = true;
                shippingCost.Value2 = "Phí Vận Chuyển: " + itemBill.ShippingCost.ToString();
                //diachi.Font.Bold = true;
                shippingCost.Font.Name = "Tahoma";
                shippingCost.Font.Size = "10";
                shippingCost.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //phi van chuyen
                Microsoft.Office.Interop.Excel.Range note = oSheet.get_Range("F3", "H3");
                note.MergeCells = true;
                note.Value2 = "Ghi Chú: " + itemBill.Note;
                //diachi.Font.Bold = true;
                note.Font.Name = "Tahoma";
                note.Font.Size = "10";
                note.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                #endregion


                #region "[tạo tiêu đề bảng]"
                // Tạo tiêu đề cột 
                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A9", "A9");
                cl1.Value2 = "STT";
                cl1.ColumnWidth = 5;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B9", "B9");
                cl2.Value2 = "Tên Sản Phẩm";
                cl2.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C9", "C9");
                cl3.Value2 = "Số Lượng";
                cl3.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D9", "D9");
                cl4.Value2 = "Giá Bán";
                cl4.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E9", "E9");
                cl5.Value2 = "VAT";
                cl5.ColumnWidth = 20;


                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F9", "F9");
                cl6.Value2 = "Tiền Lời";
                cl6.ColumnWidth = 20;
                //
                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G9", "G9");
                cl7.Value2 = "Ghi Chú";
                cl7.ColumnWidth = 50;


                #endregion


                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A9", "G9");
                rowHead.Font.Bold = true;

                // Kẻ viền
                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                // Thiết lập màu nền
                rowHead.Interior.ColorIndex = 15;
                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.



                object[,] arr = new object[data.RowCount, 7];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng
                int stt = 1;
                for (int r = 0; r < data.RowCount; r++)
                {
                    BillInfoDTO item_billInfo = new BillInfoDTO();

                    item_billInfo = (BillInfoDTO)gvBillInfo.GetRow(r);

                    //NangLuongTieuDiem_Management.LoaiSanPham_SelectByPrimaryKey(item.LoaiSanPhamID).TenLoaiSanPham

                    arr[r, 0] = stt;                                     // cot stt
                    arr[r, 1] = ProductBUS.SelectPrimaryKey(item_billInfo.ProductID).Name;
                    arr[r, 2] = item_billInfo.Count.ToString();
                    arr[r, 3] = item_billInfo.SalePriceString;
                    arr[r, 4] = item_billInfo.VAT.ToString();
                    arr[r, 5] = item_billInfo.DividendString;
                    arr[r, 6] = item_billInfo.Note;
                    stt++;

                }

                //Thiết lập vùng điền dữ liệu
                int rowStart = 10;
                int columnStart = 1;

                int rowEnd = rowStart + data.RowCount - 1;
                int columnEnd = 7;

                // Ô bắt đầu điền dữ liệu
                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
                // Ô kết thúc điền dữ liệu
                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
                // Lấy về vùng điền dữ liệu
                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                ////Điền dữ liệu vào vùng đã thiết lập
                range.Value2 = arr;

                // Kẻ viền
                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT
                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                //them phan footer
                string t = "G" + (rowEnd + 1).ToString();
                string h = "G" + (rowEnd + 4).ToString();
                Microsoft.Office.Interop.Excel.Range footer = oSheet.get_Range(t, t);
                footer.Value2 = "Tp.HCM, Ngày " + DateTime.Now.Day.ToString() + " Tháng " + DateTime.Now.Month.ToString() + " Năm " + DateTime.Now.Year.ToString() + "\r\n Nhân Viên Lập(Ký Tên)";
                footer.ColumnWidth = 40;
                Microsoft.Office.Interop.Excel.Range Contentfooter = oSheet.get_Range(h, h);
                Contentfooter.Value2 = Management.UserLogin.FullName;
                Contentfooter.ColumnWidth = 40;


                //save file
                object missValue = System.Reflection.Missing.Value;

                oBook.SaveAs(_strPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, missValue, missValue, missValue, missValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
                oBook.Close();
                oExcel.Quit();
            }
            catch { }
        }
        #endregion

        #region "[ThreadExportFileExcel]"
        private void ThreadExportFileExcel()
        {
            try
            {
                Export(gvBillInfo, "BillInfo", Program.strPath);
            }
            catch { }
        }
        #endregion

    }
}
 