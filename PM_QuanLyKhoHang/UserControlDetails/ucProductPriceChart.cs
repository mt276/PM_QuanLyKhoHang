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
using System.Windows.Forms.DataVisualization.Charting;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucProductPriceChart : UserControl
    {

        #region "[Declare Global Variable]"
        /// <summary>
        /// true: theo khoản thời gian, false: theo từng năm
        /// </summary>
        private bool priceVolatility = false;
        #endregion

        #region "[Default Constructor]"
        public ucProductPriceChart()
        {
            InitializeComponent();
        }
        #endregion

        #region "[ByYear]"
        /// <summary>
        /// biến động giá trong năm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdByYear_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdByYear.Checked)
                {
                    priceVolatility = false;
                    EnableControl();
                    lbStartDate.Text = "Chọn thời gian";
                }
            }
            catch { }
        }

        #endregion

        #region "[Period]
        /// <summary>
        /// Biến động giá theo khoản thời gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdPeriod_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdPeriod.Checked)
                {
                    priceVolatility = true;
                    EnableControl();
                    lbStartDate.Text = "Từ Năm";
                }
            }
            catch { }
        }
        #endregion

        #region "[EnableControl]"
        private void EnableControl()
        {
            try
            {
                lbEndDate.Visible = cbEndDate.Visible = priceVolatility;

            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void ucProductPriceChart_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCombobox();

                LoadProduct();
            }
            catch { }
        }
        #endregion

        #region "[LoadProduct]"
        private void LoadProduct()
        {
            try
            {
                List<ProductDTO> list = ProductBUS.GetAll();
                cbProduct.DataSource = list;
                cbProduct.DisplayMember = "Name";
                cbProduct.ValueMember = "ID";
            }
            catch { }
        }
        #endregion

        #region "[LoadCombobox]"

        private void LoadCombobox()
        {
            try
            {
                List<int> Year1 = new List<int>();
                List<int> Year2 = new List<int>();
                for (int i = 2000; i <= DateTime.Now.Year; i++)
                {
                    Year1.Add(i);
                    Year2.Add(i);
                }

                cbStartDate.DataSource = Year1;
                cbEndDate.DataSource = Year2;
            }
            catch { }
        }
        #endregion

        #region "[Show]"
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (priceVolatility)
                {
                    //lấy danh sách các giá sản phẩm trong các năm
                    List<ImportPriceStatisticsByYearACK> listYears = InputBUS.SelectImportPriceByYears((int)cbStartDate.SelectedItem, (int)cbEndDate.SelectedItem, (int)cbProduct.SelectedValue);
                    LineGraphByYears(listYears);
                }
                else
                {
                    //lấy danh sách giá sản phẩm trong 1 năm.
                    List<ImportPriceStatisticsACK> listOneYear = InputBUS.SelectPricesWithMonthByYear((int)cbStartDate.SelectedItem, (int)cbProduct.SelectedValue);
                    LineGraphOneYear(listOneYear);
                }
            }
            catch { }
        }
        #endregion

        #region "[LineGraphByYear]"
        /// <summary>
        /// vể biễu đồ đường thể hiện sự biến động giá qua các năm
        /// </summary>
        /// <param name="listYears"></param>
        private void LineGraphByYears(List<ImportPriceStatisticsByYearACK> listYears)
        {
            try
            {
                chartProductPrice.Titles.Clear();
                chartProductPrice.Titles.Add("BIỂU ĐỒ THỂ HIỆN BIẾN ĐỘNG GIÁ TỪ NĂM " + ((int)cbStartDate.SelectedItem).ToString() + " ĐẾN NĂM " + ((int)cbEndDate.SelectedItem).ToString());

                //tìm giá trị max cho truc y.
                chartProductPrice.ChartAreas[0].AxisY.Maximum = MaxByYears(listYears);
                chartProductPrice.Series.Clear();

                for (int i = 0; i < listYears.Count; i++)
                {
                    Series s = new Series();
                    s.ChartType = SeriesChartType.Line;
                    s.Name = "Nam:" + listYears[i].Year.ToString();
                    s.BorderColor = ClassUtils.Utils.GetListColor()[i];
                    for (int j = 0; j < listYears[i].ImportPrice.Count; j++)
                    {
                        DataPoint p = new DataPoint();
                        //p.XValue = i;
                        p.SetValueY(listYears[i].ImportPrice[j].ValueAVG);
                        p.AxisLabel = "Month:" + (i + 1).ToString();
                        s.Points.Add(p);
                    }
                    chartProductPrice.Series.Add(s);
                }
            }
            catch { }
        }
        #endregion

        #region "[MaxByYears]"
        private double MaxByYears(List<ImportPriceStatisticsByYearACK> listYears)
        {
            double dResult = 0;
            try
            {
                foreach (ImportPriceStatisticsByYearACK item in listYears)
                {
                    double dR = MaxOneYear(item.ImportPrice);
                    if (dR > dResult)
                        dResult = dR;
                    
                }
            }
            catch { }
            return dResult;
        }
        #endregion

        #region "[LineGraphOneYear]"
        /// <summary>
        /// biểu đồ cột
        /// </summary>
        /// <param name="listOneYear"></param>
        private void LineGraphOneYear(List<ImportPriceStatisticsACK> listOneYear)
        {
            try
            {
                chartProductPrice.Titles.Clear();
                chartProductPrice.Titles.Add("BIỂU ĐỒ THỂ HIỆN BIẾN ĐỘNG GIÁ TRONG NĂM " + ((int)cbStartDate.SelectedItem).ToString());

                //tìm giá trị max cho truc y.
                chartProductPrice.ChartAreas[0].AxisY.Maximum = MaxOneYear(listOneYear);
                chartProductPrice.Series.Clear();

                Series s = new Series();
                s.ChartType = SeriesChartType.Column;
                s.Name = "Gia Nhap";
                for (int j = 0; j < listOneYear.Count; j++)
                {
                    DataPoint p = new DataPoint();
                    //p.XValue = i;
                    p.SetValueY(listOneYear[j].ValueAVG);
                    p.AxisLabel = "Month:" + (j + 1).ToString();
                    s.Points.Add(p);
                }
                chartProductPrice.Series.Add(s);
            }
            catch { }
        }
        #endregion

        #region "[MaxOneYear]"
        private double MaxOneYear(List<ImportPriceStatisticsACK> listOneYear)
        {
            double dResult = 0;
            try
            {
                foreach (ImportPriceStatisticsACK item in listOneYear)
                {
                    if (dResult < item.ValueAVG)
                        dResult = item.ValueAVG;
                }
            }
            catch { }
            return dResult;
        }
        #endregion
    }
}
