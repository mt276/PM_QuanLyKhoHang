using DAO.DAO;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS
{
    public class TypeAccountBUS
    {
        private static TypeAccountDAO Handle = new TypeAccountDAO();

        #region "[Insert]"
        public static int Insert(TypeAccountDTO _obj)
        {
            int iResult = -1;
            try
            {
                iResult = Handle.Insert(_obj);
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
                isResult = Handle.Delete(_iID);
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public static TypeAccountDTO SelectPrimaryKey(int _iID)
        {
            TypeAccountDTO objResult = null;
            try
            {
                objResult = Handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(TypeAccountDTO _obj)
        {
            bool isResult = false;
            try
            {
                isResult = Handle.Update(_obj);
            }
            catch { }
            return isResult;
        }
        #endregion
        #region "[GetAll]"
        public static List<TypeAccountDTO> GetAll()
        {
            List<TypeAccountDTO> listResult = new List<TypeAccountDTO>();
            try
            {
                listResult = Handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

    }
}
