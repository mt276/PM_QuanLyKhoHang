using DTO.DTO;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucAddProducts : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;

        /// <summary>
        /// Mã sản phẩm đang được chọn
        /// </summary>
        private int _iID = -1;
        #endregion

        #region "[Default Constructor]"
        public ucAddProducts()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Insert Unit]"
        private void lklbAddUnit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FormDetails.frmUnit frm = new FormDetails.frmUnit();
                frm.InsertUnit += Frm_InsertUnit;
                frm.UpdateUnit += Frm_UpdateUnit;
                frm.DeleteUnit += Frm_DeleteUnit;
                frm.ShowDialog();
            }
            catch { }
        }

        private void Frm_DeleteUnit(object sender, EventArgs e)
        {
            LoadUnitIntoCombobox(cbUnit);
        }

        private void Frm_UpdateUnit(object sender, EventArgs e)
        {
            LoadUnitIntoCombobox(cbUnit);
        }

        private void Frm_InsertUnit(object sender, EventArgs e)
        {
            LoadUnitIntoCombobox(cbUnit);
        }
        #endregion

        #region "[LoadListAddProducts]"
        private void LoadListAddProducts()
        {
            try
            {
                List<ProductDTO> list = ProductBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();
                if (list.Count > 0) 
                    dtgvAddProducts.DataSource = list;
                dtgvAddProducts.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void ucAddProducts_Load(object sender, EventArgs e)
        {
            LoadListAddProducts();

            LoadUnitIntoCombobox(cbUnit);

            EnableButton(true);

            #region "[Gridview selection is not allowed]"
            gvAddProducts.OptionsBehavior.Editable = gvAddProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[Insert]"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text.Trim() == string.Empty)
                {
                    ClassUtils.Utils.MessageBoxERROR("Chưa nhập tên sản phẩm", "Thông báo");
                    return;
                }

                ProductDTO product = new ProductDTO();
                product.Name = txtProductName.Text.Trim();
                product.InputSource = txtInputSource.Text.Trim();
                product.Dimensions = mmedDimensions.Text.Trim();
                product.UnitID = (int)cbUnit.SelectedValue;
                product.Del = false;
                product.Note = mmedNote.Text.Trim();

                int id = ProductBUS.Insert(product);
                if (id > 0)
                {
                    LoadListAddProducts();
                    ClearData();
                    ClassUtils.Utils.MessageBoxInfomation("Thêm sản phẩm thành công", "Thông báo");
                    if (insert != null)
                    {
                        insert(this, new EventArgs());
                    }

                }
                else
                {
                    ClassUtils.Utils.MessageBoxERROR("Tên sản phẩm đã tồn tại", "Thông báo");
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
                    if (txtProductName.Text.Trim() == string.Empty)
                    {
                        ClassUtils.Utils.MessageBoxERROR("Chưa nhập tên sản phẩm", "Thông báo");
                        return;
                    }

                    ProductDTO product = ProductBUS.SelectPrimaryKey(_iID);
                    product.Name = txtProductName.Text.Trim();
                    product.InputSource = txtInputSource.Text.Trim();
                    product.Dimensions = mmedDimensions.Text.Trim();
                    product.UnitID = (int)cbUnit.SelectedValue;
                    product.Note = mmedNote.Text.Trim();

                    bool isSuccess = ProductBUS.Update(product);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        LoadListAddProducts();
                        ClearData();
                        ClassUtils.Utils.MessageBoxInfomation("Cập nhật thành công", "Thông báo");
                        if (update != null)
                        {
                            update(this, new EventArgs());
                        }
                    }
                    else
                    {
                        ClassUtils.Utils.MessageBoxERROR("Tên sản phẩm đã tồn tại", "Thông báo");
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
                    ProductDTO product = ProductBUS.SelectPrimaryKey(_iID);
                    product.Del = true;

                    bool isSuccess = ProductBUS.Update(product);
                    if (isSuccess)
                    {
                        _iID = -1;
                        EnableButton(true);
                        int deleteResult = DelBUS.DeleteRecordsBasedOnDelValue();
                        if (deleteResult < 0)
                        {
                            // Xử lý khi có lỗi xảy ra trong quá trình xoá
                            product.Del = false;
                            ProductBUS.Update(product);
                            ClassUtils.Utils.MessageBoxInfomation("Xóa sản phẩm thất bại", "Thông Báo");
                            ClearData();
                            return;
                        }
                        else
                        {
                            ClassUtils.Utils.MessageBoxInfomation("Xóa sản phẩm thành công", "Thông Báo");
                            LoadListAddProducts();
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
        private void gvAddProducts_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();

                if (e.Column.Name == "colUnit")
                {
                    ProductDTO item = (ProductDTO)gvAddProducts.GetRow(e.RowHandle);
                    UnitDTO itemUnit = UnitBUS.SelectPrimaryKey(item.UnitID);
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
                txtProductName.Text = txtInputSource.Text = mmedDimensions.Text = mmedNote.Text = string.Empty;
                dtpkStartDate.Enabled = true;

            }
            catch { }
        }
        #endregion

        #region "[Get information in one line]"

        private void gvAddProducts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                ProductDTO product = (ProductDTO)gvAddProducts.GetRow(e.RowHandle);
                if (product != null)
                {
                    _iID = product.ID;
                    LoadInfomation(product);
                    EnableButton(false);
                    cbUnit.SelectedValue = product.UnitID;
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
        /// <param name="product"></param>
        private void LoadInfomation(ProductDTO product)
        {
            try
            {
                txtProductName.Text = product.Name;
                txtInputSource.Text = product.InputSource;
                mmedDimensions.Text = product.Dimensions;
                mmedNote.Text = product.Note;
                dtpkStartDate.Value = product.StartDate;
                
            }
            catch { }
        }
        private void LoadUnitIntoCombobox(ComboBox cb)
        {
            cb.DataSource = UnitBUS.GetAll();
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
        }
        #endregion

        #region "[Event]"
        private event EventHandler insert;
        public event EventHandler Insert
        {
            add { insert += value; }
            remove { insert -= value; }
        }
        private event EventHandler update;
        public event EventHandler UpdateAP
        {
            add { update += value; }
            remove { update -= value; }
        }
        private event EventHandler delete;
        public event EventHandler Delete
        {
            add { delete += value; }
            remove { delete -= value; }
        }
        #endregion
    }
}
