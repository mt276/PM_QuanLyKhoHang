using DAO.DAO;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BUS.BUS
{
    public class SalePriceBUS
    {
        private static SalePriceDAO handle = new SalePriceDAO();

        #region "[Insert]"
        public static int Insert(SalePriceDTO _obj)
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
        public static SalePriceDTO SelectPrimaryKey(int _iID)
        {
            SalePriceDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(SalePriceDTO _obj)
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
        public static List<SalePriceDTO> GetAll()
        {
            List<SalePriceDTO> listResult = new List<SalePriceDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetInputProductByProductID]"
        public static List<SalePriceDTO> GetListByProductID(int _ProductID)
        {
            List<SalePriceDTO> listResult = new List<SalePriceDTO>();
            try
            {
                listResult = handle.GetListByProductID(_ProductID);
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetListPriceProductByProductID]"
        /// <summary>
        /// Lấy giá bán sản phẩm theo mã sản phẩm
        /// </summary>
        /// <param name="_ProductID">mã sản phẩm</param>
        /// <returns></returns>
        public static List<SalePriceDTO> GetListPriceProductByProductID(int _ProductID)
        {
            List<SalePriceDTO> listResult = new List<SalePriceDTO>();
            try
            {

                listResult = GetListByProductID(_ProductID);
                if (listResult.Count > 0)
                {
                    foreach (SalePriceDTO item in listResult)
                    {
                        item.AccountName = AccountBUS.SelectPrimaryKey(item.AccountID).FullName;
                        item.ProductName = ProductBUS.SelectPrimaryKey(item.ProductID).Name;
                        item.SalePriceString = Utils.UtilsOperator.StandardizeTheMoneyChain(item.SalePrice.ToString());
                    }
                }
            }
            catch { }
            return listResult;
        }

        /// <summary>
        /// Lấy 1 giá bán của sản phẩm đang sử dụng(Giá mới nhất)
        /// </summary>
        /// <param name="_ProductID">Mã sản phẩm</param>
        /// <returns></returns>
        public static SalePriceDTO GetPriceProductByProductID(int _ProductID)
        {
            SalePriceDTO objResult = null;
            try
            {
                objResult = handle.GetListByProductID(_ProductID).OrderByDescending(p => p.StartDate).ToList().First();
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[InsertPriceSellProduct]"
        /// <summary>
        /// Thêm mới 1 giá bán
        /// </summary>
        /// <param name="_dSalePrice">giá bán</param>
        /// <param name="_iProductID">mã sản phẩm</param>
        /// <param name="_iAccountID">mã nhân viên cập nhật</param>
        /// <returns></returns>
        public static bool InsertPriceSellProduct(double _dSalePrice, int _iProductID, int _iAccountID, DateTime _dDate)
        {
            bool isSuccess = false;
            try
            {
                int ID = -1;

                #region "[Declare SalePrice]"
                SalePriceDTO itemInsert = new SalePriceDTO();
                itemInsert.ProductID = _iProductID;
                itemInsert.SalePrice = _dSalePrice;
                itemInsert.AccountID = _iAccountID;
                itemInsert.StartDate = _dDate;
                itemInsert.Del = false;
                itemInsert.Note = string.Empty;
                #endregion

                //kiễm tra giá bán lần cuối cùng cập nhật có giống giá bán này không.
                SalePriceDTO salePriceItem = null;
                try
                {
                    salePriceItem = GetListByProductID(_iProductID).OrderByDescending(p => p.StartDate).FirstOrDefault();
                }
                catch { }
                if (salePriceItem != null)
                {
                    if (salePriceItem.SalePrice == _dSalePrice)
                        return false;
                    else
                    {
                        ID = Insert(itemInsert);
                    }
                }
                else
                {
                    ID = Insert(itemInsert);
                }
                if (ID > -1)
                    return true;
            }
            catch { }

            return isSuccess;
        }
        #endregion

        #region "[UpdatePriceSellOfProductm]"
        /// <summary>
        /// cập nhật giá bán của sản phẩm
        /// </summary>
        /// <param name="_obj"></param>
        /// <returns></returns>
        public static bool UpdatePriceSellOfProduct(SalePriceDTO _obj)
        {
            bool isSuccess = false;
            try
            {
                //kiểm tra giá sản phẩm của thời gian này đã tồn tại chưa, nếu rồi thì cập nhật, nếu chưa thì insert
                SalePriceDTO item = null;
                try { item = GetAll().Where(p => Utils.UtilsOperator.CompareSimilarDateTime(p.StartDate, _obj.StartDate) == true).FirstOrDefault(); }
                catch { }
                if (item != null)
                {
                    item.SalePrice = _obj.SalePrice;
                    isSuccess = Update(item);
                }
                else
                {
                    int ID = Insert(_obj);
                    if (ID > 0)
                        return true;
                }

            }
            catch { }
            return isSuccess;
        }
        #endregion

        #region "[GetListPriceProductByProductIDByTime]"
        /// <summary>
        /// Lấy giá bán của sản phẩm theo thời gian
        /// </summary>
        /// <param name="_ProductID">mã sản phẩm</param>
        /// <param name="_dateStart">thời gian bắt đầu</param>
        /// <param name="_dateEnd">thời gian kết thúc</param>
        /// <param name="_iType">-1: theo ngày, 0: theo tháng,1: theo năm, 2: theo khoản thời gian</param>
        /// <returns></returns>
        public static List<SalePriceDTO> GetListPriceProductByProductIDByTime(int _ProductID, DateTime _dateStart, DateTime _dateEnd, int _iType)
        {
            List<SalePriceDTO> listResult = new List<SalePriceDTO>();
            try
            {
                listResult = GetListPriceProductByProductID(_ProductID);
                if (listResult.Count > 0)
                {
                    switch (Utils.EnumClassDetails.GetTypeImportPrice(_iType))
                    {
                        case Utils.EnumClassDetails.TypeImportPriceStatistics.ByDate:
                            listResult = listResult.Where(p => Utils.UtilsOperator.CompareSimilarDateTime(p.StartDate, _dateStart)).ToList();
                            break;
                        case Utils.EnumClassDetails.TypeImportPriceStatistics.ByMonth:
                            listResult = listResult.Where(p => p.StartDate.Month == _dateStart.Month && p.StartDate.Year == _dateStart.Year).ToList();
                            break;
                        case Utils.EnumClassDetails.TypeImportPriceStatistics.ByYear:
                            listResult = listResult.Where(p => p.StartDate.Year == _dateStart.Year).ToList();
                            break;
                        case Utils.EnumClassDetails.TypeImportPriceStatistics.Period:
                            DateTime dateStart = _dateStart;
                            DateTime dateEnd = _dateEnd;
                            if (Utils.UtilsOperator.TimeAIsGreaterThanTimeB(_dateStart, _dateEnd))
                            {
                                dateStart = _dateEnd;
                                dateEnd = _dateStart;
                            }
                            listResult = listResult.Where(p => Utils.UtilsOperator.TimeAIsGreaterThanTimeB(p.StartDate, dateStart)
                                && Utils.UtilsOperator.TimeAIsGreaterThanTimeB(dateEnd, p.StartDate)).ToList();
                            break;
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

    }
}
