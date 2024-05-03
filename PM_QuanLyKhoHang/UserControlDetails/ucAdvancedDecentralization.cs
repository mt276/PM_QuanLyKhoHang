using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO.DTO;
using BUS.BUS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using PM_QuanLyKhoHang.ClassUtils;
using DevExpress.XtraBars.Docking;
using System.Text.RegularExpressions;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucAdvancedDecentralization : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;

        /// <summary>
        /// Mã Tài Khoản
        /// </summary>
        private int _iID = -1;

        /// <summary>
        /// Danh sách các quyền trong hệ thống
        /// </summary>
        List<TypeActDTO> listTypeAct = new List<TypeActDTO>();

        #endregion

        #region "[Default Constructor]"
        public ucAdvancedDecentralization()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Insert Account]"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                #region "[Check The Controls]"
                if (txtFullName.Text.Trim() == string.Empty)
                {
                    lblsFullName.Visible = true;
                    ClassUtils.Utils.MessageBoxERROR("Tên tài khoản không được bỏ trống", "Thông báo");
                    return;
                }
                string userName = txtUserName.Text.Trim();
                if (userName == string.Empty)
                {
                    lblsUserName.Visible = true;
                    ClassUtils.Utils.MessageBoxERROR("Tên đăng nhập không được bỏ trống", "Thông báo");
                    return;
                }
                else if (!Regex.IsMatch(userName, @"^[a-zA-Z0-9_]+$"))
                {
                    lblsUserName.Visible = true;
                    ClassUtils.Utils.MessageBoxERROR("Tên đăng nhập không được chứa ký tự đặc biệt", "Thông báo");
                    return;
                }
                #endregion

                bool item = AccountBUS.SelectByUserName(txtUserName.Text.Trim());
                if (item == true)
                {
                    lblsUserName.Visible = true;
                    ClassUtils.Utils.MessageBoxERROR("Tên đăng nhập đã có người sử dụng", "Thông báo");
                    return;
                }
                else
                {
                    AccountDTO acc = new AccountDTO();
                    acc.UserName = txtUserName.Text.Trim();
                    acc.FullName = txtFullName.Text.Trim();
                    acc.Address = mmedAddress.Text.Trim();
                    acc.TypeID = (int)cbTypeID.SelectedValue;
                    acc.Del = false;
                    acc.Note = mmedNote.Text.Trim();

                    int id = AccountBUS.Insert(acc);
                    if (id > 0)
                    {
                        LoadListAccount();
                    }
                    dpnlDecentralization.Close();

                }
            }
            catch { }
        }
        #endregion

        #region "[Update Account]"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_iID > 0)
                {
                    AccountDTO acc = AccountBUS.SelectPrimaryKey(_iID);
                    acc.FullName = txtFullName.Text.Trim();
                    acc.UserName = txtUserName.Text.Trim();
                    acc.TypeID = (int)cbTypeID.SelectedValue;
                    acc.Address = mmedAddress.Text.Trim();
                    acc.Note = mmedNote.Text.Trim();

                    bool isSuccess = AccountBUS.Update(acc);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        LoadListAccount();
                        ClearData();
                        ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
                    }
                }
            }
            catch { }
        }
        #endregion

        #region "[Load List Account]"
        /// <summary>
        /// Load danh sách các nhân viên
        /// </summary>
        private void LoadListAccount()
        {
            try
            {
                List<AccountDTO> acc = AccountBUS.GetAll();
                dtgvAccount.DataSource = acc;
                dtgvAccount.RefreshDataSource();
            }
            catch { }
        }

        #endregion

        #region "[Delete]"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_iID > 0)
                {
                    AccountDTO acc = AccountBUS.SelectPrimaryKey(_iID);
                    acc.Del = true;

                    bool isSuccess = AccountBUS.Update(acc);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        ClassUtils.Utils.MessageBoxInfomation("Xóa Tài khoản thành công", "Thông Báo");
                        DelBUS.DeleteRecordsBasedOnDelValue();
                        LoadListAccount();
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

        #region "[Load]"
        private void ucAdvancedDecentralization_Load(object sender, EventArgs e)
        {
            try
            {
                //load danh sách các tài khoản
                LoadListAccount();
                LoadTypeIDIntoCombobox(cbTypeID);
                cbTypeID.SelectedIndex = 1;

                dpnlDecentralization.Close();
                EnableButton(true);

                #region "[Gridview selection is not allowed]"
                gvAccount.OptionsBehavior.Editable = gvAccount.OptionsSelection.EnableAppearanceFocusedCell = false;
                #endregion

            }
            catch { }
        }
        #endregion

        #region "[EnableButton]"
        /// <summary>
        /// Kích hoạt Button 
        /// </summary>
        /// <param name="_Flag"></param>
        private void EnableButton(bool _Flag)
        {
            try
            {
                btnDelete.Enabled = btnUpdate.Enabled = !_Flag;
                btnAdd.Enabled = _Flag;
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
                txtFullName.Text = mmedAddress.Text = mmedNote.Text = txtUserName.Text = string.Empty;
                lblsFullName.Visible = lblsUserName.Visible = false;
                txtUserName.ReadOnly = false;
                dtpkStartDate.Enabled = true;
                dtpkStartDate.Value = DateTime.Now;
                cbTypeID.SelectedIndex = 1;
                lbHeader.Text = "Thêm Mới Tài Khoản";
            }
            catch { }
        }
        #endregion

        #region "[Get information in one line]"
        private void gvAccount_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                AccountDTO acc = (AccountDTO)gvAccount.GetRow(e.RowHandle);
                if (acc != null)
                {
                    _iID = acc.ID;
                    LoadInfomation(acc);
                    EnableButton(false);
                    cbTypeID.SelectedValue = acc.TypeID;
                    txtUserName.ReadOnly = true;
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
        /// <param name="acc"></param>
        private void LoadInfomation(AccountDTO acc)
        {
            try
            {
                txtFullName.Text = acc.FullName;
                txtUserName.Text = acc.UserName;
                mmedAddress.Text = acc.Address;
                mmedNote.Text = acc.Note;
                dtpkStartDate.Value = acc.StartDate;
                lbHeader.Text = "Thông Tin Chi Tiết Tài Khoản";

            }
            catch { }
        }

        private void LoadTypeIDIntoCombobox(ComboBox cb)
        {
            cb.DataSource = TypeAccountBUS.GetAll();
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
        }
        #endregion

        #region "[Ordinal number]"
        private void gvAccount_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();

            }
            catch { }
        }
        #endregion

    }
}
