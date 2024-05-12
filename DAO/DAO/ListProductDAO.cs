using DAO.SQLHelper;
using DTO.ACK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public class ListProductDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public ListProductDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Get a list of product information belonging to a company]"
        /// <summary>
        /// Lấy danh sách các thông tin sàn phẩm thuộc về 1 công ty
        /// </summary>
        /// <param name="_productID">mã sản phẩm</param>
        /// <param name="_companyID">mã công ty</param>
        /// <returns></returns>
        public List<ListProductACK> GetInfomationProductBelongToCompany(int _productID, int _companyID)
        {
            List<ListProductACK> listResult = new List<ListProductACK>();
            try
            {
                if (cn != null)
                {
                    //lấy thông tin điểm theo mã.

                    string sql = string.Format("Select p.Name, p.Dimensions, bi.Count, bi.VAT, bi.SalePrice, bi.Note, b.StartDate " +
                        "from dbo.Bill b, dbo.BillInfo bi, dbo.Products p " +
                        "where b.CompanyID = {0} AND bi.BillID = b.ID AND bi.ProductID = {1} AND bi.ProductID = p.ID " +
                        "Order by (b.Startdate) desc", _companyID.ToString(), _productID.ToString());
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ListProductACK obj = new ListProductACK(row);
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
