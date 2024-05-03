using DAO.DAO;
using DTO.DTO;
using System.Collections.Generic;

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


    }
}
