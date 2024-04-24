using DAO.DAO;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS
{
    public class AccountBUS
    {
        private static AccountDAO Hanlde = new AccountDAO();

        #region "[Insert]"
        public static int Insert(AccountDTO _obj)
        {
            int iResult = -1;
            try
            {
                iResult = Hanlde.Insert(_obj);
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
                isResult = Hanlde.Delete(_iID);
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[SelectPrimaryKey]"
        public static AccountDTO SelectPrimaryKey(int _iID)
        {
            AccountDTO objResult = null;
            try
            {
                objResult = Hanlde.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(AccountDTO _obj)
        {
            bool isResult = false;
            try
            {
                isResult = Hanlde.Update(_obj);
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[GetAll]"
        public static List<AccountDTO> GetAll()
        {
            List<AccountDTO> listResult = new List<AccountDTO>();
            try
            {
                listResult = Hanlde.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[Login]"
        public static AccountDTO Login(string _UserName, string _Pass)
        {
            AccountDTO obj = null;
            try
            {
                obj = Hanlde.SelectByUserNameAnhPass(_UserName, _Pass);
            }
            catch { }
            return obj;
        }
        #endregion

        #region "[Profile]"
        public static bool SelectByUserName(string _strUserName)
        {
            bool objResult = false;
            try
            {
                if (Hanlde.SelectByUserName(_strUserName) != null)
                    objResult = true;
            }
            catch { }
            return objResult;
        }
        #endregion
    }
}
