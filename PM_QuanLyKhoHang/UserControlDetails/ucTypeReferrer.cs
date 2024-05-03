using DTO.DTO;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;
  
namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucTypeReferrer : UserControl
    {

        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;

        private int _iID = -1;
        #endregion

        #region "[Default Constructor]"
        public ucTypeReferrer()
        {
            InitializeComponent();
        }

        #endregion

        #region "[LoadListTypeReferrer]"
        private void LoadListTypeReferrer()
        {
            try
            {
                List<TypeReferrerDTO> type = TypeReferrerBUS.GetAll().OrderByDescending(p=> p.StartDate).ToList();
                dtgvTypeReferrer.DataSource = type;
                dtgvTypeReferrer.RefreshDataSource();
            }
            catch { }
        }

        #endregion

        #region "[Insert]"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTypeName.Text.Trim() == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Chưa nhập tên loại người giới thiệu", "Thông báo");
                    return;
                }

                TypeReferrerDTO type = new TypeReferrerDTO();
                type.Name = txtTypeName.Text.Trim();
                type.Del = false;
                type.Note = mmedNote.Text.Trim();

                int id = TypeReferrerBUS.Insert(type);
                if (id > 0)
                {
                    LoadListTypeReferrer();
                    ClassUtils.Utils.MessageBoxInfomation("Thêm loại người giới thiệu thành công", "Thông báo");
                    if (insertTR != null)
                    {
                        insertTR(this, new EventArgs());
                    }
                }
                else
                {
                    ClassUtils.Utils.MessageBoxERROR("Tên loại người giới thiệu đã tồn tại", "Thông báo");
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
                    if (txtTypeName.Text.Trim() == string.Empty)
                    {
                        ClassUtils.Utils.MessageBoxERROR("Chưa nhập tên loại người giới thiệu", "Thông báo");
                        return;
                    }

                    TypeReferrerDTO type = TypeReferrerBUS.SelectPrimaryKey(_iID);
                    type.Name = txtTypeName.Text.Trim();
                    type.Note = mmedNote.Text.Trim();

                    bool isSuccess = TypeReferrerBUS.Update(type);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        LoadListTypeReferrer();
                        ClearData();
                        ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
                        if (updateTR != null)
                        {
                            updateTR(this, new EventArgs());
                        }
                    }
                    else
                    {
                        ClassUtils.Utils.MessageBoxERROR("Tên loại người giới thiệu đã tồn tại", "Thông báo");
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
                    TypeReferrerDTO type = TypeReferrerBUS.SelectPrimaryKey(_iID);
                    type.Del = true;

                    bool isSuccess = TypeReferrerBUS.Update(type);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        int deleteResult = DelBUS.DeleteRecordsBasedOnDelValue();
                        if (deleteResult < 0)
                        {
                            // Xử lý khi có lỗi xảy ra trong quá trình xoá
                            type.Del = false;
                            TypeReferrerBUS.Update(type);
                            ClassUtils.Utils.MessageBoxInfomation("Loại người giới thiệu đang được sử dụng", "Thông Báo");
                            ClearData();
                            return;
                        }
                        else
                        {
                            ClassUtils.Utils.MessageBoxInfomation("Xóa loại người giới thiệu thành công", "Thông Báo");
                            LoadListTypeReferrer();
                            ClearData();
                            if (deleteTR != null)
                            {
                                deleteTR(this, new EventArgs());
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

        #region "[Load]"
        private void ucTypeReferrer_Load(object sender, EventArgs e)
        {
            try
            {
                LoadListTypeReferrer();

                EnableButton(true);

                #region "[Gridview selection is not allowed]"
                gvTypeReferrer.OptionsBehavior.Editable = gvTypeReferrer.OptionsSelection.EnableAppearanceFocusedCell = false;
                #endregion

            }
            catch { }
        }
        #endregion

        #region "[Ordinal number]"
        private void gvTypeReferrer_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
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
                txtTypeName.Text = mmedNote.Text = string.Empty;
                dtpkStartDate.Value = DateTime.Now;
            }
            catch { }
        }
        #endregion

        #region "[Get information in one line]"
        private void gvTypeReferrer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                TypeReferrerDTO type = (TypeReferrerDTO)gvTypeReferrer.GetRow(e.RowHandle);
                if (type != null)
                {
                    _iID = type.ID;
                    LoadInfomation(type);
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
        /// <param name="type"></param>
        private void LoadInfomation(TypeReferrerDTO type)
        {
            try
            {
                txtTypeName.Text = type.Name;
                mmedNote.Text = type.Note;
            }
            catch { }
        }
        #endregion
    
        #region "[Event]"
        private event EventHandler insertTR;
        public event EventHandler InsertTR
        {
            add { insertTR += value; }
            remove { insertTR -= value; }
        }
        private event EventHandler updateTR;
        public event EventHandler UpdateTR
        {
            add { updateTR += value; }
            remove { updateTR -= value; }
        }
        private event EventHandler deleteTR;
        public event EventHandler DeleteTR
        {
            add { deleteTR += value; }
            remove { deleteTR -= value; }
        }
        #endregion

        
    }
}
