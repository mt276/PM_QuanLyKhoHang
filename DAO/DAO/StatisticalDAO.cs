using DAO.SQLHelper;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO.DAO
{
    public class StatisticalDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public StatisticalDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[GetAllProductSell]"
        public List<DTO.ACK.ListProductSellACK> GetAllProductSell()
        {
            List<DTO.ACK.ListProductSellACK> listResult = new List<DTO.ACK.ListProductSellACK>();
            try
            {
                if (cn != null)
                {
                    string sql = "Select bi.BillID, b.StartDate, b.TotalBill, b.TotalPayment, b.PaymentDueDate, b.Dividend, bi.ProductID, p.Name, bi.Count, bi.Dividend, bi.VAT " +
                                 "from dbo.Bill b, dbo.BillInfo bi, dbo.Products p "+
                                 "where bi.BillID = b.ID AND bi.ProductID = p.ID "+
                                 "Order by(b.Startdate) desc ";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            DTO.ACK.ListProductSellACK obj = new DTO.ACK.ListProductSellACK(row);                            
                            listResult.Add(obj);
                        }
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion
    }
}
