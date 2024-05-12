using BUS.BUS;
using DTO.ACK;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Utils
{
    public class UtilsOperator
    {
        #region "[Compare time]"
        #region "[1.Two Time Equals]"
        /// <summary>
        /// 1.hai thoi gian bang nhau
        /// </summary>
        /// <param name="_dateA">thời gian a</param>
        /// <param name="_dateB">thời gian b</param>
        /// <returns></returns>
        public static bool CompareSimilarDateTime(DateTime _dateA, DateTime _dateB)
        {
            bool isSuccess = false;
            try
            {
                if (_dateA.Day == _dateB.Day)
                {
                    if (_dateA.Month == _dateB.Month)
                    {
                        if (_dateA.Year == _dateB.Year)
                            return true;
                    }
                }
            }
            catch { }
            return isSuccess;
        }
        #endregion

        #region "2. Time A >= Time B"
        /// <summary>
        /// Thời gian a >= thời gian b
        /// </summary>
        /// <param name="_dateA">Thời gian a</param>
        /// <param name="_dateB">Thời gian b</param>
        /// <returns></returns>
        public static bool TimeAIsGreaterThanTimeB(DateTime _dateA, DateTime _dateB)
        {
            bool isSuccess = false;
            try
            {
                if (_dateA.Day >= _dateB.Day)
                {
                    if (_dateA.Month >= _dateB.Month)
                    {
                        if (_dateA.Year >= _dateB.Year)
                            return true;
                    }
                }
            }
            catch { }
            return isSuccess;
        }

        #endregion
        #endregion

        #region "[Standardize the money chain]"
        /// <summary>
        /// chuẩn hóa chuỗi trước khi hiển thị lên textbox
        /// </summary>
        /// <param name="_strInput">chuỗi gia tiền</param>
        /// <returns></returns>
        public static string StandardizeTheMoneyChain(string _strInput)
        {
            string str = string.Empty;
            try
            {
                int irun = -1;
                int i = 0;
                //kiểm tra xem chuỗi này có phải chuỗi thập phân hay không.
                int location = _strInput.IndexOf(".");
                if (location > -1)
                {
                    //chuỗi thập phân

                    //bước 1: xử lý phần thập phân.
                    string decimalPart = _strInput.Substring(location + 1);

                    irun = -1;
                    //bước 2: xử lý phần số
                    for (i = location - 1; i >= 0; i--)
                    {
                        irun++;
                        if (irun == 3)
                        {
                            irun = 0;
                            str += ",";
                        }
                        str += _strInput[i];
                    }
                    str = ChainReversal(str) + "." + decimalPart;

                }
                else
                {
                    //không phải chuỗi thập phân.
                    for (i = _strInput.Length - 1; i >= 0; i--)
                    {
                        irun++;
                        if (irun == 3)
                        {
                            irun = 0;
                            str += ",";
                        }
                        str += _strInput[i];
                    }
                    //đảo chuỗi
                    str = ChainReversal(str);
                }
            }
            catch { }
            return str;
        }
        private static string ChainReversal(string _strInput)
        {
            string strResult = string.Empty;
            try
            {
                for (int i = _strInput.Length - 1; i >= 0; i--)
                {
                    strResult += _strInput[i];
                }
            }
            catch { }
            return strResult;
        }
        #endregion

        #region "[Process general prices into detailed prices]"
        /// <summary>
        /// xử lý giá chung thành giá chi tiết
        /// <para>vd: 10*3 kết quả sẽ là 30</para>
        /// </summary>
        /// <param name="_strInput">chuỗi cần xử lý</param>
        /// <returns></returns>
        public static double GeneralPricesIntoDetailedPrices(string _strInput)
        {
            double dResult = 0;
            int location = _strInput.Trim().IndexOf("*");
            if (location > -1)
            {
                double l1 = double.Parse(_strInput.Trim().Substring(0, location));
                double l2 = double.Parse(_strInput.Trim().Substring(location + 1));
                dResult = (l1 * l2);
            }
            else
            {
                dResult = double.Parse(_strInput);
            }
            return dResult;
        }
        #endregion

        #region "[Convert BillInfoACK from BillInfoDTO]"
        /// <summary>
        /// chuyển đối tượng BillInfoACK thành đối tượng BillInfoDTO
        /// </summary>
        /// <param name="_obj">đối tượng BillInfoDTO</param>
        /// <returns></returns>
        public static BillInfoACK ConvertFromBillInfoDTO(BillInfoDTO _obj)
        {
            BillInfoACK itemResult = null;
            try
            {
                itemResult = new BillInfoACK();
                itemResult.ID = _obj.ID;
                itemResult.SalePrice = _obj.SalePrice;
                itemResult.SalePriceString = _obj.SalePriceString;
                itemResult.BillID = _obj.BillID;
                itemResult.ProductID = _obj.ProductID;
                itemResult.Count = _obj.Count;
                itemResult.ProductName = ProductBUS.SelectPrimaryKey(_obj.ProductID).Name;
                itemResult.Divedend = _obj.Divedend;
                itemResult.DivedendString = _obj.DivedendString;
                itemResult.VAT = _obj.VAT;
                itemResult.Del = _obj.Del;
                itemResult.Note = _obj.Note;
            }
            catch { }
            return itemResult;
        }

        /// <summary>
        /// chuyển danh sách đối tượng ChiTietHoaDonDTO thành danh 
        /// <para>Sách các đối tượng ChiTietHoaDonACK</para>
        /// </summary>
        /// <param name="_listItems">danh sách đối tượng ChiTietHoaDonDTO</param>
        /// <returns></returns>
        public static List<BillInfoACK> ConvertListFromBillInfoACK(List<BillInfoDTO> _listItems)
        {
            List<BillInfoACK> listResult = new List<BillInfoACK>();
            try
            {
                foreach (BillInfoDTO item in _listItems)
                {
                    item.DivedendString = Utils.UtilsOperator.StandardizeTheMoneyChain(item.Divedend.ToString());
                    item.SalePriceString = Utils.UtilsOperator.StandardizeTheMoneyChain(item.SalePriceString.ToString());
                    listResult.Add(ConvertFromBillInfoDTO(item));
                }
            }
            catch { }
            return listResult;
        }
        #endregion
    }
}
