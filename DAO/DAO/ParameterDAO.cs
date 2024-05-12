using System.Data.SqlClient;
using DTO.DTO;
using System.Data;
using DAO.SQLHelper;
using System.Collections.Generic;

namespace DAO.DAO
{
    public class ParameterDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public ParameterDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(ParameterDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.Parameter(ProductID, Value, del, note)" +
                    "Values({0}, {1}, '{2}', N'{3}')",
                    _obj.ProductID.ToString(), _obj.Value.ToString(), _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.Parameter";
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
                string sql = "DELETE FROM dbo.Parameter WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public ParameterDTO SelectPrimaryKey(int _iID)
        {
            ParameterDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Parameter WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new ParameterDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(ParameterDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    ParameterDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.Parameter SET ProductID = {0}, Value = {1}, Del = '{2}',Note = N'{3}' Where ID = {4}",
                            _obj.ProductID.ToString(), _obj.Value.ToString(), _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<ParameterDTO> GetAll()
        {
            List<ParameterDTO> listResult = new List<ParameterDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Parameter";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ParameterDTO obj = new ParameterDTO(row);
                            listResult.Add(obj);
                        }
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SelectByProductID]"
        /// <summary>
        /// Lấy thông tin thông qua mã sàn phẩm
        /// </summary>
        /// <param name="_ProductID">mã sản phẩm</param>
        /// <returns></returns>
        public ParameterDTO SelectByProductID(int _ProductID)
        {
            ParameterDTO objResult = null;
            try
            {
                if (cn != null)
                {
                    //lấy thông tin điểm theo mã.
                    string sql = "SELECT * FROM dbo.Parameter WHERE ProductID =" + _ProductID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count == 1)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            objResult = new ParameterDTO(row);
                            return objResult;
                        }
                    }
                }
            }
            catch { }
            return objResult;

        }
        #endregion
    }
}
