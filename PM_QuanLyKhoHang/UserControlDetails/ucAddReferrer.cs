using DTO.DTO;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucAddReferrer : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;

        private int _iID = -1;
        #endregion

        #region "[Default Constructor]"
        public ucAddReferrer()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Insert TypeReferrer]"
        private void hplTypeReferrer_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            try
            {
                ucTypeReferrer uc = new ucTypeReferrer();
                uc.InsertTR += Uc_InsertTR;
                uc.UpdateTR += Uc_UpdateTR;
                uc.DeleteTR += Uc_DeleteTR;
                uc.Show();
            }
            catch { }
        }

        private void Uc_DeleteTR(object sender, EventArgs e)
        {
            LoadTypeReferrerIntoCombobox(cbTypeReferrer);
        }

        private void Uc_UpdateTR(object sender, EventArgs e)
        {
            LoadTypeReferrerIntoCombobox(cbTypeReferrer);
        }

        private void Uc_InsertTR(object sender, EventArgs e)
        {
            LoadTypeReferrerIntoCombobox(cbTypeReferrer);
        }
        #endregion

        #region "[LoadListAddReferrer]"
        private void LoadListAddReferrer()
        {
            try
            {
                List<ReceiveCommissionDTO> list = ReceiveCommissionBUS.GetAll();
                if (list.Count > 0) 
                    dtgvAddReferrer.DataSource = list;
                dtgvAddReferrer.RefreshDataSource();
            }
            catch { }
        }

        #endregion

        #region "[Load]"
        private void ucAddReferrer_Load(object sender, EventArgs e)
        {
            LoadListAddReferrer();

            LoadTypeReferrerIntoCombobox(cbTypeReferrer);

            EnableButton(true);

            #region "[Gridview selection is not allowed]"
            gvAddReferrer.OptionsBehavior.Editable = gvAddReferrer.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[Insert]"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text.Trim() == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Chưa nhập tên người giới thiệu", "Thông báo");
                    return;
                }

                ReceiveCommissionDTO receiveCommission = new ReceiveCommissionDTO();
                receiveCommission.Name = txtFullName.Text.Trim();
                receiveCommission.Address = mmedAddress.Text.Trim();
                receiveCommission.Phone = txtPhone.Text.Trim();
                receiveCommission.TypeReferrerID = (int)cbTypeReferrer.SelectedValue;
                receiveCommission.Del = false;
                receiveCommission.Note = mmedNote.Text.Trim();

                int id = ReceiveCommissionBUS.Insert(receiveCommission);
                if (id > 0)
                {
                    LoadListAddReferrer();
                    ClearData();
                    ClassUtils.Utils.MessageBoxInfomation("Thêm người giới thiệu thành công", "Thông báo");
                    if (insertAR != null)
                    {
                        insertAR(this, new EventArgs());
                    }

                }
                else
                {
                    ClassUtils.Utils.MessageBoxERROR("Người giới thiệu đã tồn tại", "Thông báo");
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
                if (_iID > 0)
                {
                    if (txtFullName.Text.Trim() == string.Empty)
                    {
                        ClassUtils.Utils.MessageBoxERROR("Chưa nhập tên người giới thiệu", "Thông báo");
                        return;
                    }

                    ReceiveCommissionDTO receiveCommission = ReceiveCommissionBUS.SelectPrimaryKey(_iID);
                    receiveCommission.Name = txtFullName.Text.Trim();
                    receiveCommission.Address = mmedAddress.Text.Trim();
                    receiveCommission.Phone = txtPhone.Text.Trim();
                    receiveCommission.TypeReferrerID = (int)cbTypeReferrer.SelectedValue;
                    receiveCommission.Note = mmedNote.Text.Trim();

                    bool isSuccess = ReceiveCommissionBUS.Update(receiveCommission);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        LoadListAddReferrer();
                        ClearData();
                        ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
                        if (updateAR != null)
                        {
                            updateAR(this, new EventArgs());
                        }
                    }
                    else
                    {
                        ClassUtils.Utils.MessageBoxERROR("Người giới thiệu đã tồn tại", "Thông báo");
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
                if (_iID > 0)
                {
                    ReceiveCommissionDTO receiveCommission = ReceiveCommissionBUS.SelectPrimaryKey(_iID);
                    receiveCommission.Del = true;

                    bool isSuccess = ReceiveCommissionBUS.Update(receiveCommission);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        int deleteResult = DelBUS.DeleteRecordsBasedOnDelValue();
                        if (deleteResult < 0)
                        {
                            // Xử lý khi có lỗi xảy ra trong quá trình xoá
                            receiveCommission.Del = false;
                            ReceiveCommissionBUS.Update(receiveCommission);
                            ClassUtils.Utils.MessageBoxInfomation("Xóa người giới thiệu thất bại", "Thông Báo");
                            ClearData();
                            return;
                        }
                        else
                        {
                            ClassUtils.Utils.MessageBoxInfomation("Xóa người giới thiệu thành công", "Thông Báo");
                            LoadListAddReferrer();
                            ClearData();
                            if (deleteAR != null)
                            {
                                deleteAR(this, new EventArgs());
                            }
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
        private void gvAddReferrer_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();

                if (e.Column.Name == "colTypeReferrerName")
                {
                    ReceiveCommissionDTO item = (ReceiveCommissionDTO)gvAddReferrer.GetRow(e.RowHandle);
                    TypeReferrerDTO itemUnit = TypeReferrerBUS.SelectPrimaryKey(item.TypeReferrerID);
                    if (item != null && itemUnit != null)
                        e.DisplayText = itemUnit.Name;
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
                txtFullName.Text = txtPhone.Text = txtFax.Text = mmedAddress.Text = mmedNote.Text = string.Empty;

            }
            catch { }
        }
        #endregion

        #region "[Get information in one line]"

        private void gvAddReferrer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                ReceiveCommissionDTO receiveCommission = (ReceiveCommissionDTO)gvAddReferrer.GetRow(e.RowHandle);
                if (receiveCommission != null)
                {
                    _iID = receiveCommission.ID;
                    LoadInfomation(receiveCommission);
                    EnableButton(false);
                    cbTypeReferrer.SelectedValue = receiveCommission.TypeReferrerID;
                }
            }
            catch { }
        }
        #endregion

        #region "[Get information and display it on input controls]"
        /// <summary>
        /// Lấy thông tin và hiển thị lên các control nhập liệu
        /// </summary>
        /// <param name="receiveCommission"></param>
        private void LoadInfomation(ReceiveCommissionDTO receiveCommission)
        {
            try
            {
                txtFullName.Text = receiveCommission.Name;
                txtPhone.Text = receiveCommission.Phone;
                txtFax.Text = receiveCommission.Fax;
                mmedAddress.Text = receiveCommission.Address;
                mmedNote.Text = receiveCommission.Note;
                
            }
            catch { }
        }
        private void LoadTypeReferrerIntoCombobox(ComboBox cb)
        {
            cb.DataSource = TypeReferrerBUS.GetAll();
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
        }
        #endregion

        #region "[Event]"
        private event EventHandler insertAR;
        public event EventHandler InsertAR
        {
            add { insertAR += value; }
            remove { insertAR -= value; }
        }
        private event EventHandler updateAR;
        public event EventHandler UpdateAR
        {
            add { updateAR += value; }
            remove { updateAR -= value; }
        }
        private event EventHandler deleteAR;
        public event EventHandler DeleteAR
        {
            add { deleteAR += value; }
            remove { deleteAR -= value; }
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
        #endregion
    }
}
