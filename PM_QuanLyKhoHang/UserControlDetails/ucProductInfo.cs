using BUS.BUS;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucProductInfo : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;


        private int _iID = -1;
        #endregion

        #region "[Default Constructor]"
        public ucProductInfo()
        {
            InitializeComponent();
        }

        #endregion

        #region "[LoadListProductInfo]"
        private void LoadListProductInfo()
        {
            try
            {
                List<ProductDTO> list = ProductBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();

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
            dtgvProductInfo.DataSource = ProductBUS.SearchProductByname(txtSearch.Text);

            int successfulRows = ((DevExpress.XtraGrid.Views.Grid.GridView)dtgvProductInfo.MainView).RowCount;
            List<ProductDTO> list = ProductBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();

            int listCount = list.Count;

            lbSearchResults.Text = "Kết quả tìm kiếm: " + successfulRows.ToString() + " / " + listCount.ToString();
        }
        #endregion

        #region "[Cancel]"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                LoadListProductInfo();
                ClearData();
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
                        int deleteResult = DelBUS.DeleteRecordsBasedOnDelValue();
                        if (deleteResult < 0)
                        {
                            // Xử lý khi có lỗi xảy ra trong quá trình xoá
                            product.Del = false;
                            ProductBUS.Update(product);
                            ClassUtils.Utils.MessageBoxInfomation("Xóa sản phẩm thất bại", "Thông Báo");
                            return;
                        }
                        else
                        {
                            ClassUtils.Utils.MessageBoxInfomation("Xóa sản phẩm thành công", "Thông Báo");
                            LoadListProductInfo();
                            ClearData();


                        }
                    }
                }
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void ucProductInfo_Load(object sender, EventArgs e)
        {
            LoadListProductInfo();
            ClearData();
            #region "[Gridview selection is not allowed]"
            gvProductInfo.OptionsBehavior.Editable = gvProductInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[Ordinal number]"
        private void gvProductInfo_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
                if (e.Column.Name == "colUnit")
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

        #region "[Get information in one line]"
        private void gvProductInfo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                ProductDTO product = (ProductDTO)gvProductInfo.GetRow(e.RowHandle);
                if (product != null)
                {
                    _iID = product.ID;                    
                }
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

                txtSearch.Text = string.Empty;
                lbSearchResults.Text = "Kết quả tìm kiếm";
            }
            catch { }
        }
        #endregion
    }
}
