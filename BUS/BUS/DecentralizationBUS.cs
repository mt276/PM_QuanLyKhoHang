using DAO.DAO;
using DTO.DTO;
using System.Collections.Generic;

namespace BUS.BUS
{
    public class DecentralizationBUS
    {
        private static DecentralizationDAO handle = new DecentralizationDAO();

        #region "[Insert]"
        public static int Insert(DecentralizationDTO _obj)
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
        public static DecentralizationDTO SelectPrimaryKey(int _iID)
        {
            DecentralizationDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(DecentralizationDTO _obj)
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
        public static List<DecentralizationDTO> GetAll()
        {
            List<DecentralizationDTO> listResult = new List<DecentralizationDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[Decentralization]"
        /// <summary>
        /// Phân quyền
        /// </summary>
        /// <param name="_obj"></param>
        /// <returns></returns>
        public static bool Decentralization(DecentralizationDTO _obj)
        {
            bool isSuccess = false;
            try
            {
                DecentralizationDAO m_Handle = new DecentralizationDAO();
                DecentralizationDTO item = null;
                try
                {
                    item = m_Handle.SelectByID(_obj.AccountID, _obj.TypeActID);
                }
                catch { }
                if (item != null)
                {
                    item.Del = _obj.Del;
                    isSuccess = Update(item);
                }
                else
                {
                    if (!_obj.Del)
                    {
                        //thêm mới.
                        int ID = Insert(_obj);
                        if (ID > 0)
                            isSuccess = true;
                    }
                }
            }
            catch { }
            return isSuccess;
        }
        #endregion

        #region "[SelectByAccountID]"
        public static List<DecentralizationDTO> SelectByAccountID(int _iUserID)
        {
            List<DecentralizationDTO> listResult = new List<DecentralizationDTO>();
            try
            {
                DecentralizationDAO m_Handle = new DecentralizationDAO();
                listResult = m_Handle.SelectByAccountID(_iUserID);
            }
            catch { }
            return listResult;
        }
        #endregion

    }
}
