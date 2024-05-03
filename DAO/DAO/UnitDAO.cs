using System.Data.SqlClient;
using DTO.DTO;
using System.Data;
using DAO.SQLHelper;
using System.Collections.Generic;

namespace DAO.DAO
{
    public class UnitDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public UnitDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(UnitDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string check = string.Format("Select COUNT(*) from dbo.Unit Where name = N'{0}'", _obj.Name);
                    int count = (int)SqlDataHelper.GetMaxID(check, cn);
                    if (count > 0)
                    {
                        return -1;
                    }

                    string sql = string.Format("INSERT INTO dbo.Unit(Name, del, note)" +
                    "Values(N'{0}', '{1}', N'{2}')",
                    _obj.Name, _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.Unit";
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
                string sql = "DELETE FROM dbo.Unit WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public UnitDTO SelectPrimaryKey(int _iID)
        {
            UnitDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Unit WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new UnitDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(UnitDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    string check = string.Format("Select COUNT(*) from dbo.Unit Where name = N'{0}' and id <> {1}", _obj.Name, _obj.ID);
                    int count = (int)SqlDataHelper.GetMaxID(check, cn);
                    if (count > 0)
                    {
                        return false;
                    }

                    UnitDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.Unit SET Name = N'{0}', Del = '{1}',Note = N'{2}' Where ID = {3}",
                            _obj.Name, _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<UnitDTO> GetAll()
        {
            List<UnitDTO> listResult = new List<UnitDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Unit";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            UnitDTO obj = new UnitDTO(row);
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
