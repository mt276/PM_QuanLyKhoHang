using DTO.ACK;
using DTO.DTO;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucDebtStatistics : UserControl
    {
        #region "[Declare Global Variable]"
        private int billID = -1;
        #endregion

        #region "[Default Constructor]"
        public ucDebtStatistics()
        {
            InitializeComponent();
        }


        #endregion

        #region "[LoadDataGridViewDeptStatistics]"
        /// <summary>
        /// Load danh sách các công nợ lên datagrdiview
        /// </summary>
        private void LoadDataGridViewDeptStatistics()
        {
            try
            {
                //Lấy danh sách các công nợ.
                List<DeptACK> listDept = BillBUS.GetAllDept();

                dtgvDeptStatistics.DataSource = listDept;
                dtgvDeptStatistics.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void ucDebtStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataGridViewDeptStatistics();

                #region "[Gridview selection is not allowed]"
                gvDeptStatistics.OptionsBehavior.Editable = gvDeptStatistics.OptionsSelection.EnableAppearanceFocusedCell = false;
                gvPaymentInfo.OptionsBehavior.Editable = gvPaymentInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
                #endregion
            }
            catch { }
        }
        #endregion

        #region "[Ordinal number]"
        private void gvDeptStatistics_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
        }

        private void gvPaymentInfo_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colPSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
        }
        #endregion

        #region "[ClearLable]"
        private void ClearLable()
        {
            try
            {
                lbCompanyName.Text = "Tên Công Ty: ";
                lbAddress.Text = "Địa Chỉ: ";
                lbPhone.Text = "Điện Thoại: ";
                lbFax.Text = "Fax: ";
                lbStartDate.Text = "Ngày Tạo: ";
                lbNote.Text = "Ghi Chú: ";
            }
            catch { }
        }
        #endregion

        #region "[EnableLable]"
        /// <summary>
        /// enable các lable thông tin của công ty
        /// </summary>
        /// <param name="_isFlag"></param>
        private void EnableLable(bool _isFlag)
        {
            try
            {
                lbAddress.Visible = lbPhone.Visible = lbFax.Visible =
                    lbNote.Visible = lbStartDate.Visible = lbCompanyName.Visible = _isFlag;
            }
            catch { }
        }
        #endregion

        #region "[LoadDataGriViewPaymentInfo]"
        /// <summary>
        /// hiển thị danh sách các chi tiết thanh toán
        /// </summary>
        /// <param name="_billID">mã hóa đơn</param>
        private void LoadDataGriViewPaymentInfo(int _billID)
        {
            try
            {
                List<PaymentInfoDTO> list = PaymentInfoBUS.SelectByBillID(_billID);

                dtgvPaymentInfo.DataSource = list;
                dtgvPaymentInfo.RefreshDataSource();

            }
            catch { }

        }
        #endregion

        #region "[LoadInfomationCompany]"
        /// <summary>
        /// hiển thị thông tin của công ty
        /// </summary>
        /// <param name="_billID"></param>
        private void LoadInfomationCompany(int _billID)
        {
            try
            {

                CompanyDTO item = CompanyBUS.SelectPrimaryKey(_billID);
                if (item != null)
                {
                    EnableLable(true);
                    ClearLable();
                    lbCompanyName.Text = "Tên Công Ty: " + item.Name;
                    lbAddress.Text = "Địa Chỉ: " + item.Address;
                    lbPhone.Text = "Điện Thoại: " + item.Phone;
                    lbFax.Text = "Fax: " + item.Fax;
                    lbStartDate.Text = "Ngày Tạo: " + item.StartDate.ToString("dd.MM.yyyy");
                    lbNote.Text = "Ghi Chú: " + item.Note;
                }

            }
            catch { }
        }
        #endregion

        #region "[Get information in one line]"
        private void gvDeptStatistics_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DeptACK item = (DeptACK)gvDeptStatistics.GetRow(e.RowHandle);

                //load thông tin thông tin công ty.
                LoadInfomationCompany(item.CompanyID);

                //load danh sách số lần thanh toán
                LoadDataGriViewPaymentInfo(item.BillID);
                billID = item.BillID;

                txtDept.Text = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(item.Dept.ToString());

                txtChange.Text = string.Empty;
            }
            catch { }
        }

        #endregion

        #region "[Clear]"
        private void Clear()
        {
            try
            {
                dtpkPaymentDueDate.Value = DateTime.Now;
                txtPayExtra.Text = string.Empty;
            }
            catch { }
        }
        #endregion

        #region "[Update]"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                double dept = 0;
                string strInputDept = txtDept.Text.Trim();
                if (strInputDept != string.Empty)
                    dept = double.Parse(strInputDept);
                if (dept == 0)
                {
                    ClassUtils.Utils.MessageBoxInfomation("Khách hàng đã trả đủ tiền", "Thông báo");
                    return;
                }
                else if (dept > 0)
                {
                    string str = txtPayExtra.Text.Trim();
                    if (str != string.Empty)
                    {
                        if (billID > 0)
                        {
                            //tiền thanh toán thêm
                            double payExtra = double.Parse(str);

                            //láy đối tượng hóa đơn hiện tại
                            BillDTO billInfo = BillBUS.SelectPrimaryKey(billID);

                            //Lấy tổng tiền sau khi đã thanh toán thêm
                            double totalAddPayment = billInfo.TotalPayment + payExtra;
                            if (totalAddPayment > billInfo.TotalBill)
                            {
                                double change = totalAddPayment - billInfo.TotalBill;
                                txtChange.Text = BUS.Utils.UtilsOperator.StandardizeTheMoneyChain(change.ToString());
                                ClassUtils.Utils.MessageBoxInfomation("Số tiền Khách Hàng trả đã bị dư:\r\n" + change.ToString(), "Thông Báo");
                                payExtra = (billInfo.TotalBill - change);
                            }

                            DateTime paymentDueDate = dtpkPaymentDueDate.Value;
                            PaymentInfoDTO item = new PaymentInfoDTO();
                            item.BillID = billID;
                            item.Payment = payExtra;
                            item.StartDate = paymentDueDate;
                            item.StartNextDate = paymentDueDate;

                            int paymentID = PaymentInfoBUS.Insert(item);

                            billInfo.TotalPayment += payExtra;
                            billInfo.PaymentDueDate = paymentDueDate;
                            bool _isBillID = BillBUS.Update(billInfo);
                            if ((_isBillID) && (paymentID > 0))
                            {
                                Clear();
                                LoadDataGridViewDeptStatistics();
                                ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
                                return;
                            }
                        }
                    }
                    else
                    {
                        ClassUtils.Utils.MessageBoxERROR("Tiền Trả Thêm Không được trống", "Thông Báo");
                        return;
                    }
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
                Clear();
                txtChange.Text = string.Empty;
            }
            catch { }
        }
        #endregion

        #region "[Only enter numbers]"
        private void txtPayExtra_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPayExtra.Text, out decimal salePrice))
            {
                // Chuyển đổi giá trị thành chuỗi có định dạng tiền tệ
                txtPayExtra.Text = salePrice.ToString("#,##0");
                // Di chuyển con trỏ về cuối textbox
                txtPayExtra.SelectionStart = txtPayExtra.Text.Length;
            }
        }

        private void txtPayExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự phân cách thập phân (nếu có)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }

            // Kiểm tra xem đã có ký tự phân cách thập phân (',' hoặc '.') trong textbox chưa
            bool hasDecimalSeparator = txtPayExtra.Text.Contains(".") || txtPayExtra.Text.Contains(",");

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
                    e.KeyChar = txtPayExtra.Text.Contains(".") ? ',' : '.';
                }
            }
        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDept.Text, out decimal salePrice))
            {
                // Chuyển đổi giá trị thành chuỗi có định dạng tiền tệ
                txtDept.Text = salePrice.ToString("#,##0");
                // Di chuyển con trỏ về cuối textbox
                txtDept.SelectionStart = txtDept.Text.Length;
            }
        }

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
        #endregion
    }
}
