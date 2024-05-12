using DevExpress.XtraEditors;
using DTO.ACK;
using BUS.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.FormDetails
{
    public partial class frmListProducts : DevExpress.XtraEditors.XtraForm
    {
        #region "[Declare Global Variable]"
        /// <summary>
        /// mã sản phẩm đang được chọn
        /// </summary>
        public int _selectProductID = -1;

        /// <summary>
        /// mã công ty đang được chọn
        /// </summary>
        public int _selectCompanyID = -1;

        #endregion

        #region "[Default Constructor]"
        public frmListProducts()
        {
            InitializeComponent();
        }
        public frmListProducts(int _productID, int _companyID)
        {
            InitializeComponent();
            this._selectCompanyID = _companyID;
            this._selectProductID = _productID;
        }
        #endregion

        #region "[LoadDataGridView]"
        private void LoadDataGridView()
        {
            try
            {
                List<ListProductACK> list = ListProductBUS.GetInfomationProductBelongToCompany(_selectProductID, _selectCompanyID);
                dtgvListProducts.DataSource = list;
                dtgvListProducts.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void frmListProducts_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

            #region "[Gridview selection is not allowed]"
            gvListProducts.OptionsBehavior.Editable = gvListProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[Ordinal number]"
        private void gvListProducts_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name.CompareTo("colSTT") == 0)
                {
                    e.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
            catch { }
        }
        #endregion
    }
}