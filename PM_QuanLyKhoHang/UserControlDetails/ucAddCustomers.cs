using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucAddCustomers : UserControl
    {
        #region "[Declare Global Variable]"

        bool isFlag = false;

        public DelegateClearItem clearItem = null;

        private List<CompanyDTO> listCompany = new List<CompanyDTO>();


        private int _iIDCompany = -1;

        private int _iIDRe = -1;
        #endregion

        #region "[Default Constructor]"
        public ucAddCustomers()
        {
            InitializeComponent();
        }
        #endregion

        #region "[LoadListAddCustomers]"
        private void LoadListAddCustomers()
        {
            try
            {
                List<CompanyDTO> list = CompanyBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();
                if (list.Count > 0)
                    dtgvAddCustomers.DataSource = list;
                dtgvAddCustomers.RefreshDataSource();
            }
            catch { }
        }

        #endregion

        #region "[Load]"
        private void ucAddCustomers_Load(object sender, EventArgs e)
        {
            LoadListAddCustomers();

            EnableButton(true);

            #region "[Gridview selection is not allowed]"
            gvAddCustomers.OptionsBehavior.Editable = gvAddCustomers.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[Insert]"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCompanyName.Text.Trim() == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Tên công ty không được bỏ trống", "Thông Báo");
                    return;
                }
                if (mmedAddress.Text.Trim() == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Địa chỉ công ty không được bỏ trống", "Thông Báo");
                    return;
                }
                if (txtPhone.Text.Trim() == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Điện Thoại công ty không được bỏ trống", "Thông Báo");
                    return;
                }
                if (txtRepresentative.Text.Trim() == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Tên người đại diện không được bỏ trống", "Thông báo");
                    return;
                }


                CompanyDTO insertCompany = new CompanyDTO();
                insertCompany.Name = txtCompanyName.Text.Trim();
                insertCompany.Address = mmedAddress.Text.Trim();
                insertCompany.Phone = txtPhone.Text.Trim();
                insertCompany.Fax = txtFax.Text.Trim();
                insertCompany.Del = false;
                insertCompany.Note = mmedNote.Text.Trim();

                int idCompany = CompanyBUS.Insert(insertCompany);
                if (idCompany > 0)
                {
                    insertCompany.ID = idCompany;
                    listCompany.Add(insertCompany);

                    RepresentativeDTO insertRe = new RepresentativeDTO();
                    insertRe.Name = txtRepresentative.Text.Trim();
                    insertRe.Phone = txtPhoneRepresentative.Text.Trim();
                    insertRe.CompanyID = idCompany;
                    insertRe.Del = false;
                    insertRe.Note = string.Empty;

                    int idRe = RepresentativeBUS.Insert(insertRe);
                    if (idRe > 0)
                    {
                        LoadListAddCustomers();
                        ClearData();
                        ClassUtils.Utils.MessageBoxInfomation("Thêm khách hàng thành công", "Thông báo");
                        return;

                    }

                }
                else
                {
                    ClassUtils.Utils.MessageBoxERROR("Tên công ty đã tồn tại", "Thông báo");
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
                if (_iIDCompany > 0)
                {
                    CompanyDTO companyInfo = listCompany.Where(p => p.ID == _iIDCompany).FirstOrDefault();

                    CompanyDTO companyRemove = null;
                    if (companyInfo != null)
                    {
                        companyRemove = companyInfo;

                        companyInfo.Name = txtCompanyName.Text;
                        companyInfo.Address = mmedAddress.Text;
                        companyInfo.Phone = txtPhone.Text;
                        companyInfo.Fax = txtFax.Text;
                        companyInfo.Note = mmedNote.Text;

                        RepresentativeDTO reInfo = RepresentativeBUS.GetListByRepresentativeID(companyInfo.ID).OrderByDescending(p => p.StartDate).FirstOrDefault<RepresentativeDTO>();
                        if (reInfo != null)
                        {
                            reInfo.Name = txtRepresentative.Text;
                            reInfo.Phone = txtPhoneRepresentative.Text;

                            RepresentativeBUS.Update(reInfo);
                        }
                        bool isSuccess = CompanyBUS.Update(companyInfo);

                        if (companyRemove != null)
                        {
                            listCompany.Remove(companyRemove);
                            listCompany.Add(companyInfo);
                            ClearData();
                            LoadListAddCustomers();
                        }
                    }
                    else
                    {
                        /*
                         * Ngày tạo: 16/12/2013
                         * nếu khách hàng này không phải là khách hàng vửa thêm thì 
                         * kiểm tra và thông báo cho người dùng biết.
                         */
                        string strcomment = "Thông tin khách hàng này đã được nhập từ những";
                        strcomment += "\r\nngày trước bạn có chắc muốn sửa đổi chúng";
                        strcomment += "\r\nviệc thay đổi thông tin đã được nhập từ ";
                        strcomment += "\r\nnhững lần nhập trước trước có thể gây mất";
                        strcomment += "\r\n tính nhất của dữ liệu! Nếu bạn chắc rằng ";
                        strcomment += "\r\nđều đó không xảy ra thì hãy bấm OK, bấm Cancel để Hủy";
                        DialogResult result = ClassUtils.Utils.MessageBoxQuestion(strcomment, "Xác nhận thông tin");
                        if (result == DialogResult.OK)
                        {
                            //thực hiện cập nhật thông tin bất chấp thông tin trước có như thế nào.
                            companyInfo = CompanyBUS.SelectPrimaryKey(_iIDCompany);
                            if (companyInfo != null && companyInfo.Del == false)
                            {
                                companyInfo.Name = txtCompanyName.Text;
                                companyInfo.Address = mmedAddress.Text;
                                companyInfo.Phone = txtPhone.Text;
                                companyInfo.Fax = txtFax.Text;
                                companyInfo.Note = mmedNote.Text;

                                //cập nhật thông tin công ty.
                                bool update = CompanyBUS.Update(companyInfo);
                                if (update)
                                {
                                    //cập nhật thông tin người đại diện của công ty
                                    RepresentativeDTO re = RepresentativeBUS.GetListByRepresentativeID(_iIDCompany).Where(p => p.Del == false).OrderByDescending(p => p.StartDate).FirstOrDefault();
                                    if (re != null)
                                    {
                                        //cập nhật thông tin 
                                        re.Name = txtRepresentative.Text.Trim();
                                        re.Phone = txtPhoneRepresentative.Text.Trim();

                                    RepresentativeBUS.Update(re);
                                    }
                                    ClearData();
                                    isFlag = false;
                                    btnShowAll_Click(null, null);
                                    ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
                                }

                            }
                        }
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

        #region "[Delete]"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_iIDCompany > 0)
                {
                    CompanyDTO delete = CompanyBUS.SelectPrimaryKey(_iIDCompany);
                    delete.Del = true;

                    bool isSuccess = CompanyBUS.Update(delete);
                    if (isSuccess)
                    {
                        _iIDCompany = -1;
                        EnableButton(true);
                        int deleteResult = DelBUS.DeleteRecordsBasedOnDelValue();
                        if (deleteResult < 0)
                        {
                            // Xử lý khi có lỗi xảy ra trong quá trình xoá
                            delete.Del = false;
                            CompanyBUS.Update(delete);
                            ClassUtils.Utils.MessageBoxInfomation("Xóa khách hàng thất bại", "Thông Báo");
                            ClearData();
                            return;
                        }
                        else
                        {
                            ClassUtils.Utils.MessageBoxInfomation("Xóa khách hàng thành công", "Thông Báo");
                            LoadListAddCustomers();
                            ClearData();
                        }
                    }
                }
            }
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
        private void gvAddCustomers_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
                if (e.Column.Name == "colRepresentative")
                {
                    CompanyDTO item = (CompanyDTO)gvAddCustomers.GetRow(e.RowHandle);
                    RepresentativeDTO itemRe = RepresentativeBUS.SelectByCompanyID(item.ID);
                    if (item != null && itemRe != null)
                        e.DisplayText = itemRe.Name;
                }

            }
            catch { }
        }
        #endregion

        #region "[EnableButton]"
        /// <summary>
        /// Kích hoạt Button 
        /// </summary>
        /// <param name="_isFlag"></param>
        private void EnableButton(bool _isFlag)
        {
            try
            {
                btnDelete.Enabled = btnUpdate.Enabled = !_isFlag;
                btnAdd.Enabled = _isFlag;
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
                EnableButton(true);
                txtCompanyName.Text = txtFax.Text = txtPhone.Text = txtRepresentative.Text = txtPhoneRepresentative.Text = string.Empty;
                mmedAddress.Text = mmedNote.Text = string.Empty;
                dtpkStartDate.Enabled = true;

            }
            catch { }
        }
        #endregion

        #region "[Get information in one line]"

        private void gvAddCustomers_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                CompanyDTO gvAdd = (CompanyDTO)gvAddCustomers.GetRow(e.RowHandle);
                if (gvAdd != null)
                {
                    _iIDCompany = gvAdd.ID;
                    LoadInfomation(gvAdd);
                    EnableButton(false);
                    dtpkStartDate.Enabled = false;
                }
            }
            catch { }
        }
        #endregion

        #region "[Get information and display it on input controls]"
        /// <summary>
        /// Lấy thông tin và hiển thị lên các control nhập liệu
        /// </summary>
        /// <param name="companyItem"></param>
        private void LoadInfomation(CompanyDTO companyItem)
        {
            try
            {
                txtCompanyName.Text = companyItem.Name;
                mmedAddress.Text = companyItem.Address;
                txtPhone.Text = companyItem.Phone;
                txtFax.Text = companyItem.Fax;
                mmedNote.Text = companyItem.Note;
                dtpkStartDate.Value = companyItem.StartDate;

                RepresentativeDTO reItem = RepresentativeBUS.GetListByRepresentativeID(companyItem.ID).OrderByDescending(p => p.StartDate).FirstOrDefault<RepresentativeDTO>();
                if (reItem != null)
                {
                    txtRepresentative.Text = reItem.Name;
                    txtPhoneRepresentative.Text = reItem.Phone;
                    _iIDRe = reItem.ID;
                }

                _iIDCompany = companyItem.ID;

            }
            catch { }
        }
        #endregion

        #region "[ShowAll]"
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFlag == false)
                {
                    //load danh sách mới thêm trong ngày
                    List<CompanyDTO> listAll = CompanyBUS.GetDate();

                    if (listAll.Count >= 0)
                    {
                        dtgvAddCustomers.DataSource = listAll;
                        dtgvAddCustomers.RefreshDataSource();
                        btnShowAll.Text = "Hiển thị tất cả";
                        isFlag = true;
                    }
                }
                else
                {
                    LoadListAddCustomers();
                    btnShowAll.Text = "Hiển thị mới thêm trong ngày";                    
                    isFlag = false;
                }
            }
            catch { }
        }
        #endregion

        #region "[Only enter numbers]"
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            catch { }
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            catch { }
        }

        private void txtPhoneRepresentative_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            catch { }
        }

        #endregion
    }
}
