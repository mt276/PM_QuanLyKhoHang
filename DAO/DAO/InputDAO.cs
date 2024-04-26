using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class InputDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public InputDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(InputDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.Input(ProductID, count, importPrice, accountID, del, note)" +
                    "Values({0}, {1}, {2}, {3}, '{4}', N'{5}')",
                    _obj.ProductID.ToString(), _obj.Count.ToString(), _obj.ImportPrice.ToString(), _obj.AccountID.ToString(), _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.Input";
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
                string sql = "DELETE FROM dbo.Input WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public InputDTO SelectPrimaryKey(int _iID)
        {
            InputDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Input WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new InputDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(InputDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    InputDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.Input SET ProductID = {0}, count = {1}, importPrice = {2}, accountID = {3}, Del = '{4}',Note = N'{5}' Where ID = {6}",
                            _obj.ProductID.ToString(), _obj.Count.ToString(), _obj.ImportPrice.ToString(), _obj.AccountID.ToString(), _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<InputDTO> GetAll()
        {
            List<InputDTO> listResult = new List<InputDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Input";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            InputDTO obj = new InputDTO(row);
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
