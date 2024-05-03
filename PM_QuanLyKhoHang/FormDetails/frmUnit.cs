using BUS.BUS;
using DTO.DTO;
using System;
using System.Collections.Generic;


namespace PM_QuanLyKhoHang.FormDetails
{
    public partial class frmUnit : DevExpress.XtraEditors.XtraForm
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;

        /// <summary>
        /// Mã đơn vị
        /// </summary>
        private int _iID = -1;
        #endregion

        #region "[Default Constructor]"
        public frmUnit()
        {
            InitializeComponent();
        }

        #endregion

        #region "[LoadListUnit]"
        private void LoadListUnit()
        {
            try
            {
                List<UnitDTO> unit = UnitBUS.GetAll();
                dtgvUnit.DataSource = unit;
                dtgvUnit.RefreshDataSource();
            }
            catch { }
        }

        #endregion

        #region "[Insert]"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUnitName.Text.Trim() == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Chưa nhập tên đơn vị", "Thông báo");
                    return;
                }

                UnitDTO unit = new UnitDTO();
                unit.Name = txtUnitName.Text.Trim();
                unit.Del = false;
                unit.Note = mmedNote.Text.Trim();

                int id = UnitBUS.Insert(unit);
                if (id > 0)
                {
                    LoadListUnit();
                    ClassUtils.Utils.MessageBoxInfomation("Thêm đơn vị thành công", "Thông báo");
                    if (insert != null)
                    {
                        insert(this, new EventArgs());
                    }
                }
                else
                {
                    ClassUtils.Utils.MessageBoxERROR("Tên đơn vị đã tồn tại", "Thông báo");
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
                    if (txtUnitName.Text.Trim() == string.Empty)
                    {
                        ClassUtils.Utils.MessageBoxERROR("Chưa nhập tên đơn vị", "Thông báo");
                        return;
                    }

                    UnitDTO unit = UnitBUS.SelectPrimaryKey(_iID);
                    unit.Name = txtUnitName.Text.Trim();
                    unit.Note = mmedNote.Text.Trim();

                    bool isSuccess = UnitBUS.Update(unit);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        LoadListUnit();
                        ClearData();
                        ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
                        if (update != null)
                        {
                            update(this, new EventArgs());
                        }
                    }
                    else
                    {
                        ClassUtils.Utils.MessageBoxERROR("Tên đơn vị đã tồn tại", "Thông báo");
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
                    UnitDTO unit = UnitBUS.SelectPrimaryKey(_iID);
                    unit.Del = true;

                    bool isSuccess = UnitBUS.Update(unit);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        int deleteResult = DelBUS.DeleteRecordsBasedOnDelValue();
                        if (deleteResult < 0)
                        {
                            // Xử lý khi có lỗi xảy ra trong quá trình xoá
                            unit.Del = false;
                            UnitBUS.Update(unit);
                            ClassUtils.Utils.MessageBoxInfomation("Đơn vị đang được sử dụng", "Thông Báo");
                            ClearData();
                            return;
                        }
                        else
                        {
                            ClassUtils.Utils.MessageBoxInfomation("Xóa Đơn vị thành công", "Thông Báo");
                            LoadListUnit();
                            ClearData();
                            if (delete != null)
                            {
                                delete(this, new EventArgs());
                            }
                        }
                    }
                }
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void frmUnit_Load(object sender, EventArgs e)
        {
            try
            {
                //load danh sách các đơn vị tính
                LoadListUnit();

                EnableButton(true);

                #region "[Gridview selection is not allowed]"
                gvUnit.OptionsBehavior.Editable = gvUnit.OptionsSelection.EnableAppearanceFocusedCell = false;
                #endregion

            }
            catch { }
        }
        #endregion

        #region "[Ordinal number]"
        private void gvUnit_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
                txtUnitName.Text = mmedNote.Text = string.Empty;
            }
            catch { }
        }
        #endregion

        #region "[Get information in one line]"
        private void gvUnit_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                UnitDTO unit = (UnitDTO)gvUnit.GetRow(e.RowHandle);
                if (unit != null)
                {
                    _iID = unit.ID;
                    LoadInfomation(unit);
                    EnableButton(false);
                }
            }
            catch { }
        }
        #endregion

        #region "[Get information and display it on input controls]"
        /// <summary>
        /// Lấy thông tin và hiển thị lên các control nhập liệu
        /// </summary>
        /// <param name="unit"></param>
        private void LoadInfomation(UnitDTO unit)
        {
            try
            {
                txtUnitName.Text = unit.Name;
                mmedNote.Text = unit.Note;
            }
            catch { }
        }
        #endregion

        #region "[Event]"
        private event EventHandler insert;
        public event EventHandler InsertUnit
        {
            add { insert += value; }
            remove { insert -= value; }
        }
        private event EventHandler update;
        public event EventHandler UpdateUnit
        {
            add { update += value; }
            remove { update -= value; }
        }
        private event EventHandler delete;
        public event EventHandler DeleteUnit
        {
            add { delete += value; }
            remove { delete -= value; }
        }
        #endregion

    }
}