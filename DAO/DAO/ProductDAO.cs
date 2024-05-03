using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class ProductDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public ProductDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(ProductDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string check = string.Format("Select COUNT(*) from dbo.Products Where name = N'{0}'", _obj.Name);
                    int count = (int)SqlDataHelper.GetMaxID(check, cn);
                    if (count > 0)
                    {
                        return -1;
                    }

                    string sql = string.Format("INSERT INTO dbo.Products(name, dimensions, UnitID, Stock, InputSource, Del, Note) " +
                        "VALUES(N'{0}', N'{1}', {2}, {3}, N'{4}', '{5}', N'{6}')",
                        _obj.Name, _obj.Dimensions.ToString(), _obj.UnitID.ToString(), _obj.Stock.ToString(),
                        _obj.InputSource, _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "Select MAX(ID) From dbo.Bill";
                        iResult = SqlDataHelper.GetMaxID(sql, cn);
                    }
                }
            }
            catch { }
            return iResult;
        }
        #endregion

        #region "[Delete]"
        public bool Delete(int _iID)
        {
            bool isResult = false;
            try
            {
                string sql = "DELETE FROM dbo.Products WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public ProductDTO SelectPrimaryKey(int _iID)
        {
            ProductDTO objResult = null;
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Products WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new ProductDTO(row);
                        return objResult;
                    }

                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(ProductDTO _obj)
        {
            bool isResult = false;
            try
            {
                ProductDTO temp = SelectPrimaryKey(_obj.ID);
                if (temp != null)
                {
                    string check = string.Format("Select COUNT(*) from dbo.Products Where name = N'{0}' and id <> {1}", _obj.Name, _obj.ID);
                    int count = (int)SqlDataHelper.GetMaxID(check, cn);
                    if (count > 0)
                    {
                        return false;
                    }

                    string sql = string.Format("UPDATE dbo.Products SET name = N'{0}', dimensions = N'{1}', UnitID = {2}, Stock = {3}, InputSource = N'{4}', " +
                        "Del = '{5}', Note = N'{6}' WHERE ID = {7}",
                        _obj.Name, _obj.Dimensions.ToString(), _obj.UnitID.ToString(), _obj.Stock.ToString(),
                        _obj.InputSource, _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
                    int result = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (result > 0)
                        isResult = true;
                }
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Get All]"
        public List<ProductDTO> GetAll()
        {
            List<ProductDTO> listResult = new List<ProductDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "Select * from dbo.Products";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ProductDTO obj = new ProductDTO(row);
                            listResult.Add(obj);
                        }
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SearchProductByname]"
        public List<ProductDTO> SearchProductByname(string name)
        {
            List<ProductDTO> listResult = new List<ProductDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("SELECT * FROM dbo.Products WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ProductDTO obj = new ProductDTO(row);
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
