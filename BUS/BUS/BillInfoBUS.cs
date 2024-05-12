using DAO.DAO;
using DTO.DTO;
using System.Collections.Generic;

namespace BUS.BUS
{
    public class BillInfoBUS
    {
        private static BillInfoDAO handle = new BillInfoDAO();

        #region "[Insert]"
        public static int Insert(BillInfoDTO _obj)
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
        public static BillInfoDTO SelectPrimaryKey(int _iID)
        {
            BillInfoDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(BillInfoDTO _obj)
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
        public static List<BillInfoDTO> GetAll()
        {
            List<BillInfoDTO> listResult = new List<BillInfoDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SumPrices]"
        /// <summary>
        /// Tính tổng tiền của chi tiết hóa đơn
        /// </summary>
        /// <param name="_listInput">danh sách các chi tiết hóa đơn</param>
        /// <returns></returns>
        public static double SumPrices(List<BillInfoDTO> _listInput)
        {
            double dResult = 0;
            try
            {
                if (_listInput.Count > 0)
                {
                    foreach (BillInfoDTO item in _listInput)
                    {
                        dResult += 1.0 * (item.Count * item.SalePrice);
                    }
                }
            }
            catch { }
            return dResult;
        }


        #endregion

    }
}
