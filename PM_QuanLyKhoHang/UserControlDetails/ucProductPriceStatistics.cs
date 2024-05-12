using DTO.DTO;
using DTO.ACK;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucProductPriceStatistics : UserControl
    {
        #region "[Declare Global Variable]"
        /// <summary>
        /// loại thống kê
        /// <para>-1: theo ngày</para>
        /// <para>0: theo tháng</para>
        /// <para>1: theo năm</para>
        /// <para>2: theo khoản thời gian</para>
        /// <para>-1: tất cả</para>
        /// </summary>
        private int type = -2;
        private delegate void MyDelegateInput(List<InputDTO> _listInput);
        private delegate void MyDelegateSalePrice(List<SalePriceDTO> _listSalePrice);
        #endregion

        #region "[Default Constructor]"
        public ucProductPriceStatistics()
        {
            InitializeComponent();
        }

        #endregion

        #region "[Ordinal number]"
        private void gvProductInfo_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colPSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
        }

        private void gvInput_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colISTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
        }


        private void gvSalePrice_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
        }
        #endregion

        #region "[Get information in one  ProductInfo line]"
        private void gvProductInfo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                ProductPriceStatisticACK item = (ProductPriceStatisticACK)gvProductInfo.GetRow(e.RowHandle);
                if (item != null)
                {
                    List<InputDTO> listInput = new List<InputDTO>();
                    List<SalePriceDTO> listSalePrice = new List<SalePriceDTO>();
                    if (type == -2)
                    {
                        //hiển thị danh sách các giá nhập của 1 sản phẩm
                        listInput = InputBUS.GetListInputProductByProductID(item.ProductID).OrderByDescending(p => p.StartDate).ToList();


                        //hiển thị chi tiết giá bán theo từng sàn phẩm
                        listSalePrice =SalePriceBUS.GetListPriceProductByProductID(item.ProductID).OrderByDescending(p => p.StartDate).ToList();

                    }
                    else
                    {
                        listInput = InputBUS.GetListInputProductByProductIDByTime(item.ProductID, dtpkStartDate.Value, dtpkEndDate.Value, type)
                            .OrderByDescending(p => p.StartDate).ToList();
                        listSalePrice = SalePriceBUS.GetListPriceProductByProductIDByTime(item.ProductID, dtpkStartDate.Value, dtpkEndDate.Value, type)
                            .OrderByDescending(p => p.StartDate).ToList();

                    }

                    LoadDataGridViewInput(listInput);
                    LoadDataGridViewSalePrice(listSalePrice);
                }
            }
            catch { }
        }
        #endregion

        #region "[LoadDataGridViewProduct]"
        /// <summary>
        /// load thông tin sản phẩm
        /// </summary>
        private void LoadDataGridViewProduct()
        {
            try
            {
                List<ProductPriceStatisticACK> list = ProductBUS.GetListProduct();
                dtgvProductInfo.DataSource = list;
                dtgvProductInfo.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[LoadDataGridViewSalePrice]"
        /// <summary>
        /// hiển thị chi tiết giá bán của 1 sản phẩm
        /// </summary>
        /// <param name="_listSalePrice"></param>
        private void LoadDataGridViewSalePrice(List<SalePriceDTO> _listSalePrice)
        {
            try
            {
                dtgvSalePrice.DataSource = _listSalePrice;
                dtgvSalePrice.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[LoadDataGridViewInput]"
        /// <summary>
        /// hiển thị danh sách các chi tiết nhập sản phẩm theo mã sản phẩm
        /// </summary>
        /// <param name="_listInput">danh sách các sản phẩm</param>
        private void LoadDataGridViewInput(List<InputDTO> _listInput)
        {
            try
            {
                dtgvInput.DataSource = _listInput;
                dtgvInput.RefreshDataSource();
            }
            catch { }
        }
        #endregion

        #region "[VisibleControl]"
        /// <summary>
        /// ẩn hiện control tương ứng
        /// <para>Nếu chọn 1 trong rd: theo tháng, theo ngày, theo năm thì hiện 1 lable và 1 control datetimepicker</para>
        /// <para>Nếu chọn rd khoản thời gian thì hiện cả hai</para>
        /// </summary>
        /// <param name="_isFlag">true: khi chọn 1 trong 3 rd, false: khi chọn rd khoản thời gian</param>
        private void VisibleControl(bool _isFlag)
        {
            try
            {
                if (_isFlag)
                {
                    lbStartDate.Visible = dtpkStartDate.Visible = true;
                    lbStartDate.Text = "Chọn thời gian";
                    lbEndDate.Visible = dtpkEndDate.Visible = false;
                }
                else
                {
                    lbStartDate.Visible = dtpkStartDate.Visible = lbEndDate.Visible = dtpkEndDate.Visible = true;
                    lbStartDate.Text = "Thời gian từ";
                    lbEndDate.Text = "Đến";
                }
            }
            catch { }
        }
        #endregion

        #region "[Check Radio]"
        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdAll.Checked)
                {
                    type = -2;
                    lbStartDate.Visible = dtpkStartDate.Visible = lbEndDate.Visible = dtpkEndDate.Visible = false;
                }
            }
            catch { }
        }

        private void rdByDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //ẩn hiện các control tương ứng.
                VisibleControl(true);
                type = -1;
            }
            catch { }
        }

        private void rdByMonth_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                VisibleControl(true);
                type = 0;
            }
            catch { }
        }

        private void rdByYear_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                VisibleControl(true);
                type = 1;
            }
            catch { }
        }

        private void rdPeriod_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                VisibleControl(false);
                type = 2;
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void ucProductPriceStatistics_Load(object sender, EventArgs e)
        {
            Thread threadtgvProduct = new Thread(new ThreadStart(ThreadLoadDataGridViewProduct));
            threadtgvProduct.IsBackground = true;
            threadtgvProduct.Start();
            threadtgvProduct.Join();
        }
        #endregion

        #region "[MultiThread]"
        /// <summary>
        /// load thông tin lên dgv sản phẩm bằng multithread
        /// </summary>
        private void ThreadLoadDataGridViewProduct()
        {
            try
            {
                if (dtgvProductInfo.InvokeRequired)
                {
                    dtgvProductInfo.BeginInvoke(new MyDelegate(ThreadLoadDataGridViewProduct));
                }
                else
                {
                    lock (dtgvProductInfo)
                    {
                        LoadDataGridViewProduct();
                    }
                }
                Thread.Sleep(10);
            }
            catch { }
        }
        private void ThreadLoadDataGridViewInput(object _list)
        {
            try
            {
                List<InputDTO> _listInput = (List<InputDTO>)_list;
                if (dtgvInput.InvokeRequired)
                {
                    //dgvChiTietNhap.BeginInvoke(new  m_MyDelegateProduct(ThreadLoadDataGridViewStoreProducts));
                    dtgvInput.Invoke(new MyDelegateInput(ThreadLoadDataGridViewInput), _list);
                }
                else
                {
                    lock (dtgvInput)
                    {
                        LoadDataGridViewInput(_listInput);
                    }
                }
                Thread.Sleep(10);
            }
            catch { }
        }
        private void ThreadLoadDataGridViewSalePrice(object _list)
        {
            try
            {
                List<SalePriceDTO> listGiaBanSanPham = (List<SalePriceDTO>)_list;
                if (dtgvSalePrice.InvokeRequired)
                {
                    //dgvChiTietGiaBan.BeginInvoke(new m_MyDelegatePrice(ThreadLoadDataGridViewPriceProduct));
                    dtgvSalePrice.Invoke(new MyDelegateSalePrice(ThreadLoadDataGridViewSalePrice), _list);
                }
                else
                {
                    lock (dtgvSalePrice)
                    {
                        LoadDataGridViewSalePrice(listGiaBanSanPham);
                    }
                }
                Thread.Sleep(10);
            }
            catch { }
        }
        #endregion
    }
}
