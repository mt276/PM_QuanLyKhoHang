using DAO.DAO;
using DTO.DTO;
using System.Collections.Generic;

namespace BUS.BUS
{
    public class RepresentativeBUS
    {
        private static RepresentativeDAO handle = new RepresentativeDAO();

        #region "[Insert]"
        public static int Insert(RepresentativeDTO _obj)
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
        public static RepresentativeDTO SelectPrimaryKey(int _iID)
        {
            RepresentativeDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(RepresentativeDTO _obj)
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
        public static List<RepresentativeDTO> GetAll()
        {
            List<RepresentativeDTO> listResult = new List<RepresentativeDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[GetListByRepresentativeID]"
        public static List<RepresentativeDTO> GetListByRepresentativeID(int _iIDCompany)
        {
            List<RepresentativeDTO> listResult = new List<RepresentativeDTO>();
            try
            {
                listResult = handle.GetListByRepresentativeID(_iIDCompany);
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[DeleteByRepresentativeID]"
        public static bool DeleteByRepresentativeID(int _iIDCompany)
        {
            bool isResult = false;
            try
            {
                isResult = handle.DeleteByRepresentativeID(_iIDCompany);
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[SelectByCompanyID]"
        public static RepresentativeDTO SelectByCompanyID(int _iID)
        {
            RepresentativeDTO objResult = null;
            try
            {
                objResult = handle.SelectByCompanyID(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion
    }
}
