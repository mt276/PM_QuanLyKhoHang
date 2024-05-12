using DAO.DAO;
using DTO.ACK;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BUS.BUS
{
    public class ProductBUS
    {
        private static ProductDAO handle = new ProductDAO();

        #region "[Insert]"
        public static int Insert(ProductDTO _obj)
        {
            int iResult = -1;
            try
            {
                iResult = handle.Insert(_obj);
            }
            catch { }
            return iResult;
        }
        #endregion

        #region "[Delete]"
        public static bool Delete(int _iID)
        {
            bool isResult = false;
            try
            {
                isResult = handle.Delete(_iID);
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public static ProductDTO SelectPrimaryKey(int _iID)
        {
            ProductDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(ProductDTO _obj)
        {
            bool isResult = false;
            try
            {
                isResult = handle.Update(_obj);
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[GetAll]"
        public static List<ProductDTO> GetAll()
        {
            List<ProductDTO> listResult = new List<ProductDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SearchProductByname]"
        public static List<ProductDTO> SearchProductByname(string name)
        {
            List<ProductDTO> listResult = new List<ProductDTO>();
            try
            {
                listResult = handle.SearchProductByname(name);
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetListHaveNumberStoreSmallerNumberInputLimit]"
        /// <summary>
        /// Lấy danh sách các sản phẩm có số lượng nhỏ hơn bằng số lượng nhập định mức
        /// </summary>
        /// <returns></returns>
        public static List<ProductDTO> GetListHaveNumberStoreSmallerNumberInputLimit()
        {
            List<ProductDTO> listResult = new List<ProductDTO>();
            try
            {
                //lấy danh sách các sản phẩm trong bảng tham số.
                List<ParameterDTO> listParameter = ParameterBUS.GetAll().Where(p => p.Del == false).ToList();
                if (listParameter.Count > 0)
                {
                    foreach (ParameterDTO item in listParameter)
                    {
                        ProductDTO productInfo = ProductBUS.SelectPrimaryKey(item.ProductID);
                        if (productInfo.Stock <= item.Value)
                            listResult.Add(productInfo);
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetAllSell]"
        public static List<ListProductSellACK> GetAllSell()
        {
            List<ListProductSellACK> listResult = new List<ListProductSellACK>();
            try
            {
                DAO.DAO.StatisticalDAO m_Handle = new DAO.DAO.StatisticalDAO();
                listResult = m_Handle.GetAllProductSell();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetAllSellByTimes]"
        /// <summary>
        /// Lấy danh sách sản phẩm bán được theo thời gian
        /// </summary>
        /// <param name="_dateStart">thời gian bắt đầu</param>
        /// <param name="_dateEnd">thời gian kết thúc</param>
        /// <returns></returns>
        public static List<ListProductSellACK> GetAllSellByTimes(DateTime _dateStart, DateTime _dateEnd)
        {
            List<ListProductSellACK> listResult = new List<ListProductSellACK>();
            try
            {
                DateTime dateStart = _dateStart;
                DateTime dateEnd = _dateEnd;
                if (Utils.UtilsOperator.TimeAIsGreaterThanTimeB(_dateStart, _dateEnd))
                {
                    dateStart = _dateEnd;
                    dateEnd = _dateStart;
                }
                if (Utils.UtilsOperator.CompareSimilarDateTime(dateEnd, dateStart))
                    listResult = GetAllSell().Where(p => Utils.UtilsOperator.CompareSimilarDateTime(p.StartDate, dateStart)).ToList();
                else
                    listResult = GetAllSell().Where(p => Utils.UtilsOperator.TimeAIsGreaterThanTimeB(p.StartDate, dateStart) && Utils.UtilsOperator.TimeAIsGreaterThanTimeB(dateEnd, p.StartDate)).ToList();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetListProduct]"
        /// <summary>
        /// Lấy danh sách các sản phẩm dành cho thống kê
        /// </summary>
        /// <returns></returns>
        public static List<ProductPriceStatisticACK> GetListProduct()
        {
            List<ProductPriceStatisticACK> listResult = new List<ProductPriceStatisticACK>();
            try
            {
                //lấy danh sách các sản phẩm.
                List<ProductDTO> listProduct = GetAll();
                if (listProduct.Count > 0)
                {
                    //lấy giá nhập và giá bán mới nhất của từng sản phẩm
                    foreach (ProductDTO item in listProduct)
                    {
                        ProductPriceStatisticACK info = new ProductPriceStatisticACK();
                        info.ProductID = item.ID;
                        info.ProductName = item.Name;
                        double salePrice = 0;
                        SalePriceDTO itemGiaBan = SalePriceBUS.GetPriceProductByProductID(item.ID);
                        if (itemGiaBan != null)
                            salePrice = itemGiaBan.SalePrice;
                        info.SalePrice = salePrice;
                        info.SalePriceString = Utils.UtilsOperator.StandardizeTheMoneyChain(info.SalePrice.ToString());
                        double importPrice = 0;
                        InputDTO itemImportPrice = InputBUS.SelectByProductID(item.ID);
                        if (itemImportPrice != null)
                            importPrice = itemImportPrice.ImportPrice;
                        info.ImportPrice = importPrice;
                        info.ImportPriceString = Utils.UtilsOperator.StandardizeTheMoneyChain(info.ImportPrice.ToString());

                        listResult.Add(info);
                    }
                }
            }
            catch { }
            return listResult;
        }

        #endregion
    }
}
