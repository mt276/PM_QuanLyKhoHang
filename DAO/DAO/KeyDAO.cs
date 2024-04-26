using System.Data.SqlClient;
using DTO.DTO;
using System.Data;
using DAO.SQLHelper;

namespace DAO.DAO
{
    public class KeyDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public KeyDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(KeyDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    string sql = string.Format("INSERT INTO dbo.FKey(TimeDateLine, del)" +
                     "Values('{0}', '{1}')",
                     _obj.TimeDateLine, _obj.Del.ToString());
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM dbo.FKey";
                        iResult = SqlDataHelper.GetMaxID(sql, cn);
                    }
                }
            }
            catch { }
            return iResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public KeyDTO SelectPrimaryKey()
        {
            KeyDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.FKey where ID=1";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new KeyDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(string _strKey)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    KeyDTO temp = SelectPrimaryKey();
                    temp.TimeDateLine = _strKey;
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.FKey SET TimeDateLine = '{0}', Del = '{1}', Where ID = 1",
                            temp.TimeDateLine, temp.Del.ToString());
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
    }
}
