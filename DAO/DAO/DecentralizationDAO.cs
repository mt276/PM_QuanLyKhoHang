using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class DecentralizationDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public DecentralizationDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(DecentralizationDTO _obj)
        {
            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.Decentralization(AccountID, TypeActID, Del) Values({0} ,{1}, '{2}')", _obj.AccountID.ToString(),_obj.TypeActID.ToString(),_obj.Del.ToString());
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "Select MAX(ID) FROM dbo.Decentralization";
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
                string sql = string.Format("Delete from dbo.Decentralization Where ID = {0}", _iID.ToString());
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public DecentralizationDTO SelectPrimaryKey(int _iID)
        {
            DecentralizationDTO objResult = null;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("Select * from dbo.Decentralization Where ID = {0}", _iID.ToString());
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new DecentralizationDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(DecentralizationDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    DecentralizationDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.Decentralization Set AccountID = {0}, TypeActID = {1}, del = '{2}' Where ID = {3}",
                            _obj.AccountID.ToString(), _obj.TypeActID.ToString(), _obj.Del.ToString(), _obj.ID.ToString());
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
        public List<DecentralizationDTO> GetAll()
        {
            List<DecentralizationDTO> listResult = new List<DecentralizationDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Decentralization";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            DecentralizationDTO obj = new DecentralizationDTO(row);
                            listResult.Add(obj);
                        }
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[Select By AccountID, TypeActID]"
        public DecentralizationDTO SelectByID(int _accountID, int _typeActID)
        {
            DecentralizationDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = string.Format("SELECT * FROM dbo.Decentralization WHERE AccountID = {0} and TypeActID = {1}", _accountID.ToString(), _typeActID.ToString());
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new DecentralizationDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[SelectByAccountID]"
        public List<DecentralizationDTO> SelectByAccountID(int _iAccountID)
        {
            List<DecentralizationDTO> listResult = new List<DecentralizationDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Decentralization where AccountID = " + _iAccountID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            DecentralizationDTO obj = new DecentralizationDTO(row);
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
