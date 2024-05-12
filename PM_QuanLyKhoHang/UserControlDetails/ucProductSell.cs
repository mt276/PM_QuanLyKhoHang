using BUS.BUS;
using DTO.ACK;
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
    public partial class ucProductSell : UserControl
    {
        List<ListProductSellACK> listSell = new List<ListProductSellACK>();

        #region "[Default Constructor]"
        public ucProductSell()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Load]"
        private void ucListProducts_Load(object sender, EventArgs e)
        {

            try
            {
                listSell = ProductBUS.GetAllSell();

                //load danh sách các sản phẩm bán được trong năm nay.
                LoadDataGridView();
            }
            catch { }
        }
        #endregion

        #region "[LoadDataGridView]"
        private void LoadDataGridView()
        {
            try
            {
                List<ListProductSellACK> listShow = listSell.Where(p => p.StartDate.Year == DateTime.Now.Year).ToList();
                if (listSell.Count > 0)
                {
                    List<ProductStatisticACK> listStatistic = GetListProductStatistic(listShow);
                    dtgvStatistical.DataSource = listStatistic;
                    dtgvStatistical.RefreshDataSource();
                }
            }
            catch { }

        }

        private void LoadDataGridView(List<ListProductSellACK> _listSell)
        {
            try
            {

                List<ProductStatisticACK> listStatistic = GetListProductStatistic(_listSell);
                dtgvStatistical.DataSource = listStatistic;
                dtgvStatistical.RefreshDataSource();


            }
            catch { }
        }
        #endregion

        #region "[Khởi tạo danh sách thời gian]"
        /// <summary>
        /// Khởi tạo danh sách thời gian
        /// </summary>
        private List<ClassUtils.TimeInfo> InitTime()
        {
            List<ClassUtils.TimeInfo> time = new List<ClassUtils.TimeInfo>();
            try
            {
                if (listSell.Count > 0)
                {
                    if (time.Count == 0)
                    {
                        ClassUtils.TimeInfo info = new ClassUtils.TimeInfo();
                        info.ID = -1;
                        info.Name = "Tất cả";
                        info.DateInfo = DateTime.Now;
                        time.Add(info);
                    }
                    int iRun = 0;
                    foreach (ListProductSellACK item in listSell)
                    {
                        //kiểm tra trùng trước khi thêm.
                        DateTime datetime = item.StartDate;
                        if (!CheckTimeNotExist(time, datetime))
                        {
                            iRun++;
                            ClassUtils.TimeInfo info = new ClassUtils.TimeInfo();
                            info.ID = iRun;
                            info.Name = datetime.ToString("dd.MM.yyyy");
                            info.DateInfo = datetime;
                            time.Add(info);
                        }
                    }
                }
            }
            catch { }
            return time;
        }
        #endregion

        #region "[CheckTimeNotExist]"
        /// <summary>
        /// kiểm tra thời gian coi trong mảng có tồn tại hay chưa
        /// </summary>
        /// <param name="_time">danh sách các thời gian có sẵn</param>
        /// <param name="dateTime">thời gian cần kiềm tra</param>
        /// <returns></returns>
        private bool CheckTimeNotExist(List<ClassUtils.TimeInfo> _time, DateTime dateTime)
        {
            bool isSuccess = false;
            try
            {
                foreach (ClassUtils.TimeInfo item in _time)
                {
                    DateTime time = item.DateInfo;
                    if (BUS.Utils.UtilsOperator.CompareSimilarDateTime(time, dateTime))
                    {
                        return true;

                    }
                }
            }
            catch { }
            return isSuccess;
        }
        #endregion

        #region "[GetListProductStatistic]"
        private List<ProductStatisticACK> GetListProductStatistic(List<ListProductSellACK> _listInput)
        {
            List<ProductStatisticACK> listStatistic = new List<ProductStatisticACK>();
            try
            {
                // Tạo một danh sách các cặp (productID, StartDate) để thống kê số lượng bán cho mỗi sản phẩm trong mỗi ngày
                var productSaleDates = _listInput.Select(item => new { ProductID = item.ProductID, StartDate = item.StartDate.Date }).Distinct();

                foreach (var productSaleDate in productSaleDates)
                {
                    ProductStatisticACK itemAdd = new ProductStatisticACK();

                    // Lấy tên sản phẩm
                    itemAdd.ProductName = ProductBUS.SelectPrimaryKey(productSaleDate.ProductID).Name;

                    // Tính tổng số lượng bán của sản phẩm trong mỗi ngày
                    int sellNumber = _listInput.Where(p => p.ProductID == productSaleDate.ProductID && p.StartDate.Date == productSaleDate.StartDate).Sum(p => p.Count);
                    itemAdd.SellNumber = sellNumber;

                    // Gán ngày bán hàng
                    itemAdd.StartDate = productSaleDate.StartDate;

                    listStatistic.Add(itemAdd);
                }
            }
            catch { }
            return listStatistic;
        }
        #endregion

        #region "[Ordinal number]"
        private void gvStatistical_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
        }
        #endregion

        #region "[Search]"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<ListProductSellACK> list = ProductBUS.GetAllSellByTimes(dtpkStartDate.Value, dtpkEndDate.Value);
                LoadDataGridView(list);
            }
            catch { }
        }
        #endregion

        #region "[ShowALL]"
        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataGridView();
            }
            catch { }
        }
        #endregion

    }
}
