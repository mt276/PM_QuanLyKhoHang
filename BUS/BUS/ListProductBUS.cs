using DTO.ACK;
using System.Collections.Generic;

namespace BUS.BUS
{
    public class ListProductBUS
    {
        private static DAO.DAO.ListProductDAO handle = new DAO.DAO.ListProductDAO();
        public static List<ListProductACK> GetInfomationProductBelongToCompany(int _productID, int _companyID)
        {
            List<ListProductACK> listResult = new List<ListProductACK>();
            try
            {
                listResult = handle.GetInfomationProductBelongToCompany(_productID, _companyID);
                foreach (ListProductACK item in listResult)
                {
                    item.SalePriceString = Utils.UtilsOperator.StandardizeTheMoneyChain(item.SalePrice.ToString());
                }

            }
            catch { }
            return listResult;
        }
    }
}
