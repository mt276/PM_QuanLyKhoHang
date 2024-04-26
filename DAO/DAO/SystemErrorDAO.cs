using System.Data.SqlClient;
using DTO.DTO;
using System.Data;
using DAO.SQLHelper;
using System.Collections.Generic;

namespace DAO.DAO
{
    public class SystemErrorDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public SystemErrorDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(SystemErrorDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.SystemError(NameErr, NameFn, del, note)" +
                    "Values(N'{0}', N'{1}', '{2}', N'{3}')",
                    _obj.NameErr, _obj.NameFn, _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.SystemError";
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
                string sql = "DELETE FROM dbo.SystemError WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public SystemErrorDTO SelectPrimaryKey(int _iID)
        {
            SystemErrorDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.SystemError WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new SystemErrorDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(SystemErrorDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    SystemErrorDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.SystemError SET NameErr = N'{0}', NameFn = N'{1}', Del = '{2}',Note = N'{3}' Where ID = {4}",
                            _obj.NameErr, _obj.NameFn, _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<SystemErrorDTO> GetAll()
        {
            List<SystemErrorDTO> listResult = new List<SystemErrorDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.SystemError";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            SystemErrorDTO obj = new SystemErrorDTO(row);
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
