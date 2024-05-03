using BUS.BUS;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucListCustomers : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;


        private int _iID = -1;
        #endregion

        #region "[Default Constructor]"
        public ucListCustomers()
        {
            InitializeComponent();
        }

        #endregion

        #region "[LoadListCustomers]"
        private void LoadListCustomers()
        {
            try
            {
                List<CompanyDTO> list = CompanyBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();

                if (list.Count > 0)
                    dtgvListCustomers.DataSource = list;
                dtgvListCustomers.RefreshDataSource();
            }
            catch { }
        }

        #endregion

        #region "[Search]"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvListCustomers.DataSource = CompanyBUS.SearchCompanyByname(txtSearch.Text);

            int successfulRows = ((DevExpress.XtraGrid.Views.Grid.GridView)dtgvListCustomers.MainView).RowCount;
            List<CompanyDTO> list = CompanyBUS.GetAll().OrderByDescending(p => p.StartDate).ToList();

            int listCount = list.Count;

            lbSearchResults.Text = "Kết quả tìm kiếm: " + successfulRows.ToString() + " / " + listCount.ToString();
        }
        #endregion

        #region "[Cancel]"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                LoadListCustomers();
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
                    CompanyDTO company = CompanyBUS.SelectPrimaryKey(_iID);
                    company.Del = true;

                    bool isSuccess = CompanyBUS.Update(company);
                    if (isSuccess)
                    {
                        _iID = -1;
                        int deleteResult = DelBUS.DeleteRecordsBasedOnDelValue();
                        if (deleteResult < 0)
                        {
                            // Xử lý khi có lỗi xảy ra trong quá trình xoá
                            company.Del = false;
                            CompanyBUS.Update(company);
                            ClassUtils.Utils.MessageBoxInfomation("Xóa khách hàng thất bại", "Thông Báo");
                            return;
                        }
                        else
                        {
                            ClassUtils.Utils.MessageBoxInfomation("Xóa khách hàng thành công", "Thông Báo");
                            LoadListCustomers();
                            ClearData();


                        }
                    }
                }
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void ucListCustomers_Load(object sender, EventArgs e)
        {
            LoadListCustomers();
            ClearData();
            #region "[Gridview selection is not allowed]"
            gvListCustomers.OptionsBehavior.Editable = gvListCustomers.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[Ordinal number]"
        private void gvListCustomers_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
                if (e.Column.Name == "colRepresentative")
                {
                    CompanyDTO item = (CompanyDTO)gvListCustomers.GetRow(e.RowHandle);
                    RepresentativeDTO itemRe = RepresentativeBUS.SelectByCompanyID(item.ID);
                    if (item != null && itemRe != null)
                        e.DisplayText = itemRe.Name;
                }
            }
            catch { }
        }
        #endregion

        #region "[Get information in one line]"
        private void gvListCustomers_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                CompanyDTO company = (CompanyDTO)gvListCustomers.GetRow(e.RowHandle);
                if (company != null)
                {
                    _iID = company.ID;
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
