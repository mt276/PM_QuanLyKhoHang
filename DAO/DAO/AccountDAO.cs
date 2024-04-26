using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class AccountDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public AccountDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(AccountDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.Account(userName,fullName,Address,typeID,Del,Note)" +
                    "Values('{0}', N'{1}', N'{2}', {3}, '{4}', N'{5}')",
                    _obj.UserName, _obj.FullName, _obj.Address.ToString(), _obj.TypeID.ToString(), _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.Account";
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
                string sql = "DELETE FROM dbo.Account WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public AccountDTO SelectPrimaryKey(int _iID)
        {
            AccountDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Account WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new AccountDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(AccountDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    AccountDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {


                        string sql = string.Format("UPDATE dbo.Account SET userName = N'{0}', password = '{1}', fullName = N'{2}', Address = N'{3}',typeID = {4}, Del = '{5}',Note = N'{6}' Where ID = {7}",
                            _obj.UserName, _obj.Password.ToString(), _obj.FullName.ToString(), _obj.Address.ToString(), _obj.TypeID.ToString(), _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<AccountDTO> GetAll()
        {
            List<AccountDTO> listResult = new List<AccountDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Account";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            AccountDTO obj = new AccountDTO(row);
                            listResult.Add(obj);
                        }
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[Select By UserName And Pass]"
        public AccountDTO SelectByUserNameAnhPass(string _strUserName, string _strPass)
        {
            AccountDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = string.Format("SELECT * FROM dbo.Account WHERE userName ='{0}' and Password = '{1}'",_strUserName,_strPass);
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count >0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            objResult = new AccountDTO(row);
                            return objResult;
                        }
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Select By UserName]"
        public AccountDTO SelectByUserName(string _strUserName)
        {
            AccountDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = string.Format("SELECT * FROM dbo.Account WHERE userName ='{0}'", _strUserName);
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            objResult = new AccountDTO(row);
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
