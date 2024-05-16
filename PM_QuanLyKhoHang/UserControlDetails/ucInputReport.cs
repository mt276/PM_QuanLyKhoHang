using BUS.BUS;
using DTO.ACK;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucInputReport : UserControl
    {
        #region "[Declare Global Variable]"
        /// <summary>
        /// danh sách các sản phẩm tìm thấy
        /// </summary>
        List<InputDTO> _listInput = new List<InputDTO>();
        #endregion

        #region "[Default Constructor]"

        public ucInputReport()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Ordinal number]"
        private void gvInputList_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "colLSTT")
                e.DisplayText = (e.RowHandle + 1).ToString();

            if (e.Column.Name == "colLProductName")
            {
                InputDTO item = (InputDTO)gvListInput.GetRow(e.RowHandle);
                ProductDTO itemP = ProductBUS.SelectPrimaryKey(item.ProductID);
                if (item != null && itemP != null)
                    e.DisplayText = itemP.Name;
            }

            if (e.Column.Name == "colLAccountName")
            {
                InputDTO item = (InputDTO)gvListInput.GetRow(e.RowHandle);
                AccountDTO itemA = AccountBUS.SelectPrimaryKey(item.AccountID);
                if (item != null && itemA != null)
                    e.DisplayText = itemA.FullName;
            }
        }

        private void gvListProducts_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "colPSTT")
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gvInputDetails_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "colDSTT")
                e.DisplayText = (e.RowHandle + 1).ToString();

            InputDTO item = (InputDTO)gvInputDetails.GetRow(e.RowHandle);

            if (e.Column.Name == "colDProductName")
            {
                e.DisplayText = ProductBUS.SelectPrimaryKey(item.ProductID).Name;
            }

            if (e.Column.Name == "colDAccountName")
            {
                e.DisplayText = AccountBUS.SelectPrimaryKey(item.AccountID).FullName;
            }
        }

        #endregion

        #region "[Load]"
        private void ucInputReport_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

            LoadDataGridViewProduct();

            #region "[Gridview selection is not allowed]"
            gvListInput.OptionsBehavior.Editable = gvListInput.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvInputDetails.OptionsBehavior.Editable = gvInputDetails.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvListProducts.OptionsBehavior.Editable = gvListProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[LoadDataGridViewProduct]"
        private void LoadDataGridViewProduct()
        {
            try
            {
                List<ProductDTO> list = ProductBUS.GetAll();
                dtgvListProducts.DataSource = list;
                dtgvListProducts.RefreshDataSource();
            }
            catch { }

        }
        #endregion

        #region "[LoadDataGridView]"
        /// <summary>
        /// load datagridview
        /// </summary>
        private void LoadDataGridView()
        {
            try
            {
                //lấy danh sách các sản phẩm nhập của nhân viên này vừa nhập sắp xếp theo thời gian giảm dần
                List<InputDTO> list =InputBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();
                if (list.Count > 0)
                    dtgvListInput.DataSource = list;
            }
            catch { }
        }
        /// <summary>
        /// load datagridview có truyền tham số
        /// </summary>
        /// <param name="_list">mảng đối tượng cần hiển thị</param>
        private void LoadDataGridView(List<InputDTO> _list)
        {
            try
            {
                if (_list.Count > 0)
                {
                    dtgvListInput.DataSource = _list;
                    dtgvListInput.RefreshDataSource();
                }
            }
            catch { }
        }
        #endregion

        #region "[LoadDataGridViewProductDetails]"
        /// <summary>
        /// hiển thị chi tiết sản phẩm nhập
        /// </summary>
        /// <param name="list"></param>
        private void LoadDataGridViewProductDetails(List<InputDTO> list)
        {
            try
            {

                dtgvInputDetails.DataSource = list.OrderByDescending(p => p.StartDate).ToList();
                dtgvInputDetails.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[Search]"
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string str = txtSearch.Text.Trim();
            DateTime startDate = dtpkStart.Value;
            DateTime endDate = dtpkEnd.Value;

            if (str != string.Empty)
            {
                if (BUS.Utils.UtilsOperator.CompareSimilarDateTime(startDate, endDate))
                {
                    dtgvListInput.DataSource = InputBUS.SearchInputByProductName(str);

                }
                else
                {
                    List<InputDTO> list = InputBUS.SearchInputByProductNameAndDate(str, startDate, endDate);
                    LoadDataGridView(list);
                }
            }
            else
            {
                if (BUS.Utils.UtilsOperator.CompareSimilarDateTime(startDate, endDate))
                    return;///không thực hiện chức năng tìm kiếm cho trường hợp này
                else
                {
                    //tìm kiếm theo khoản thời gian
                    List<InputDTO> list = InputBUS.GetInputByTimes(startDate, endDate);
                    LoadDataGridView(list);
                }
            }

            List<InputDTO> listResult = InputBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();
            int listCount = listResult.Count;
            int successfulRows = ((DevExpress.XtraGrid.Views.Grid.GridView)dtgvListInput.MainView).RowCount;
            lbSearchResults.Text = "Kết quả tìm kiếm: " + successfulRows.ToString() + " / " + listCount.ToString();

        }
        #endregion

        #region "[Cancel]"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            dtpkStart.Value = dtpkEnd.Value = DateTime.Now;
            LoadDataGridView();
        }

        #endregion

        #region "[Get information in one line ListProducts]"

        private void gvListProducts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                ProductDTO item = (ProductDTO)gvListProducts.GetRow(e.RowHandle);
                List<InputDTO> list = InputBUS.GetListInputProductByProductID(item.ID);
                LoadDataGridViewProductDetails(list);
            }
            catch { }
        }
        #endregion
    }
}
