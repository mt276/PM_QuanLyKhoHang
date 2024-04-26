using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class SalePriceDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public SalePriceDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(SalePriceDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.SalePrice(ProductID, SalePrice, AccountID, del, note)" +
                    "Values({0}, {1}, {2}, '{3}', N'{4}')",
                    _obj.ProductID.ToString(), _obj.SalePrice.ToString(), _obj.AccountID.ToString(), _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.SalePrice";
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
                string sql = "DELETE FROM dbo.SalePrice WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public SalePriceDTO SelectPrimaryKey(int _iID)
        {
            SalePriceDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.SalePrice WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new SalePriceDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(SalePriceDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    SalePriceDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.SalePrice SET ProductID = {0}, SalePrice = {1}, AccountID = {2}, Del = '{3}',Note = N'{4}' Where ID = {5}",
                            _obj.ProductID.ToString(), _obj.SalePrice.ToString(), _obj.AccountID.ToString(), _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
                        int result = SqlDataHelper.ExecuteNonQuery(sql, cn);
                        if (result > 0)
                            isResult = true;
                    }
                }
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Get All]"
        public List<SalePriceDTO> GetAll()
        {
            List<SalePriceDTO> listResult = new List<SalePriceDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.SalePrice";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            SalePriceDTO obj = new SalePriceDTO(row);
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
