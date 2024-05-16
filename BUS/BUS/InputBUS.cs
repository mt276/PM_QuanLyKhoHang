using DAO.DAO;
using DTO.ACK;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BUS.BUS
{
    public class InputBUS
    {
        private static InputDAO handle = new InputDAO();

        #region "[Insert]"
        public static int Insert(InputDTO _obj)
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
        public static InputDTO SelectPrimaryKey(int _iID)
        {
            InputDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(InputDTO _obj)
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
        public static List<InputDTO> GetAll()
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetDate]"
        public static List<InputDTO> GetDate()
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {
                listResult = handle.GetDate();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SearchInputByProductName]"
        public static List<InputDTO> SearchInputByProductName(string name)
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {
                listResult = handle.SearchInputByProductName(name);
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SearchInputByProductNameAndDate]"
        public static List<InputDTO> SearchInputByProductNameAndDate(string name, DateTime startDate, DateTime endDate)
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {
                listResult = handle.SearchInputByProductNameAndDate(name, startDate, endDate);
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetInputProductByProductID]"
        public static List<InputDTO> GetInputProductByProductID(int _ProductID)
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {
                listResult = handle.GetInputProductByProductID(_ProductID);
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetListInputProductByProductID]"
        public static List<InputDTO> GetListInputProductByProductID(int _ProductID)
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {

                listResult = GetInputProductByProductID(_ProductID);
                if (listResult.Count > 0)
                {
                    foreach (InputDTO item in listResult)
                    {
                        item.AccountName = AccountBUS.SelectPrimaryKey(item.AccountID).FullName;
                        item.ProductName = ProductBUS.SelectPrimaryKey(item.ProductID).Name;
                        item.ImportPriceString = Utils.UtilsOperator.StandardizeTheMoneyChain(item.ImportPrice.ToString());
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetInputProductByAccountID]"
        public static List<InputDTO> GetInputProductByAccountID(int _AccountID)
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {
                listResult = handle.GetInputProductByAccountID(_AccountID);
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetListInputProductByProductIDByTime]"
        /// <summary>
        /// Lấy danh sách Nhập của 1 sản phẩm theo thời gian
        /// <para>nếu loại là -1,1,0 thì chỉ cần thời gian bắt đầu còn thời gian kết thúc sẽ truyền mặc định</para>
        /// </summary>
        /// <param name="_ProductID">mã sản phẩm</param>
        /// <param name="_date">thời gian bắt đầu</param>
        /// <param name="_dateEnd">thời gian kết thúc</param>
        /// <param name="_iType">-1: theo ngày, 0: theo tháng,1:theo năm, 2: theo khoản thời gian</param>
        /// <returns></returns>
        public static List<InputDTO> GetListInputProductByProductIDByTime(int _ProductID, DateTime _dateStart, DateTime _dateEnd, int _iType)
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {
                listResult = GetListInputProductByProductID(_ProductID);
                if (listResult.Count > 0)
                {
                    switch (Utils.EnumClassDetails.GetTypeImportPrice(_iType))
                    {
                        case Utils.EnumClassDetails.TypeImportPriceStatistics.ByDate:
                            //lấy danh sách các giá nhập trong ngày hôm nay.
                            listResult = listResult.Where(p => Utils.UtilsOperator.CompareSimilarDateTime(p.StartDate, _dateStart)).ToList();
                            break;
                        case Utils.EnumClassDetails.TypeImportPriceStatistics.ByMonth:
                            listResult = listResult.Where(p => p.StartDate.Month == _dateStart.Month && p.StartDate.Year == _dateStart.Year).ToList();
                            break;
                        case Utils.EnumClassDetails.TypeImportPriceStatistics.ByYear:
                            listResult = listResult.Where(p => p.StartDate.Year == DateTime.Now.Year).ToList();
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

        #region "[DeleteInputProduct]"
        public static bool DeleteInputProduct(int _ProductID, int _InputID, int _Count)
        {
            bool isSuccess = false;
            try
            {
                //cập nhật lại số lượng
                ProductDTO productItem = ProductBUS.SelectPrimaryKey(_ProductID);
                if (productItem != null)
                {
                    if (_Count <= productItem.Stock)
                    {
                        productItem.Stock -= _Count;
                        isSuccess = ProductBUS.Update(productItem);

                        //xóa 1 dòng trong bảng Nhập sản phẩm.
                        isSuccess = handle.Delete(_InputID);
                    }
                }
            }
            catch { }
            return isSuccess;
        }
        #endregion

        #region "[SelectByProductID]"
        /// <summary>
        /// Lấy sản phẩm nhập mới nhất theo mã sản phẩm
        /// </summary>
        /// <param name="_iProductID">mã sản phẩm</param>
        /// <returns></returns>
        public static InputDTO SelectByProductID(int _iProductID)
        {
            InputDTO objResult = null;
            try
            {
                objResult = GetAll().Where(p => p.ProductID == _iProductID).OrderByDescending(p => p.StartDate).FirstOrDefault();
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[GetInputByTimes]"
        /// <summary>
        /// Lấy danh sách sản phẩm bán được theo thời gian
        /// </summary>
        /// <param name="_dateStart">thời gian bắt đầu</param>
        /// <param name="_dateEnd">thời gian kết thúc</param>
        /// <returns></returns>
        public static List<InputDTO> GetInputByTimes(DateTime _dateStart, DateTime _dateEnd)
        {
            List<InputDTO> listResult = new List<InputDTO>();
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
                    listResult = GetAll().Where(p => Utils.UtilsOperator.CompareSimilarDateTime(p.StartDate, dateStart)).ToList();
                else
                    listResult = GetAll().Where(p => Utils.UtilsOperator.TimeAIsGreaterThanTimeB(p.StartDate, dateStart) && Utils.UtilsOperator.TimeAIsGreaterThanTimeB(dateEnd, p.StartDate)).ToList();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SelectByYear]"
        /// <summary>
        /// Danh sách giá nhập trong 1 năm
        /// </summary>
        /// <param name="_iYear"></param>
        /// <returns></returns>
        public static List<InputDTO> SelectByYear(int _iYear)
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {
                listResult = handle.GetByYear(_iYear);
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SelectPricesWithMonthByYear]"
        /// <summary>
        /// Danh sách giá nhập sản phẩm theo từng tháng trong 1 năm
        /// </summary>
        /// <param name="_Year">Năm cần tính</param>
        /// <returns></returns>
        public static List<ImportPriceStatisticsACK> SelectPricesWithMonthByYear(int _Year, int _ProductID)
        {
            List<ImportPriceStatisticsACK> listResult = new List<ImportPriceStatisticsACK>();
            try
            {
                //lấy danh sách giá nhập trong 1 năm
                List<InputDTO> listAll = SelectByYear(_Year);
                if (listAll.Count > 0)
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        ImportPriceStatisticsACK info = new ImportPriceStatisticsACK();
                        info.Month = i;
                        info.ValueAVG = 0;
                        List<InputDTO> listInfo = listAll.Where(p => p.StartDate.Month == i && p.ProductID == _ProductID).ToList();
                        if (listInfo.Count > 0)
                        {
                            double avg = 0;
                            foreach (InputDTO item in listInfo)
                            {
                                avg += item.ImportPrice;
                            }
                            info.ValueAVG = avg / listInfo.Count;
                        }
                        listResult.Add(info);
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SelectImportPriceByYears]"
        /// <summary>
        /// Danh sách các giá nhập sản phẩm theo khaon3 thời gian
        /// </summary>
        /// <param name="_iYearStart">năm bắt đầu</param>
        /// <param name="_iYearEnd">năm kết thúc</param>
        /// <returns></returns>
        public static List<ImportPriceStatisticsByYearACK> SelectImportPriceByYears(int _iYearStart, int _iYearEnd, int _ProductID)
        {
            List<ImportPriceStatisticsByYearACK> listResult = new List<ImportPriceStatisticsByYearACK>();
            try
            {

                int yearStart = _iYearStart;
                int yearEnd = _iYearEnd;
                if (_iYearStart > _iYearEnd)
                {
                    yearStart = _iYearEnd;
                    yearEnd = _iYearStart;
                }
                //lấy danh sách giá nhập theo khoản thời gian

                for (int i = yearStart; i <= yearEnd; i++)
                {
                    ImportPriceStatisticsByYearACK info = new ImportPriceStatisticsByYearACK();
                    info.Year = i;
                    info.ImportPrice = SelectPricesWithMonthByYear(i, _ProductID);
                    listResult.Add(info);
                }

            }
            catch { }
            return listResult;
        }
        #endregion

       
    }
}
