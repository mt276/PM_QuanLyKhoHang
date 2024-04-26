using System.Data.SqlClient;
using DTO.DTO;
using System.Data;
using DAO.SQLHelper;
using System.Collections.Generic;

namespace DAO.DAO
{
    public class TypeReferrerDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public TypeReferrerDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(TypeReferrerDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.TypeReferrer(Name, del, note)" +
                    "Values(N'{0}', '{1}', N'{2}')",
                    _obj.Name, _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.TypeReferrer";
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
                string sql = "DELETE FROM dbo.TypeReferrer WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public TypeReferrerDTO SelectPrimaryKey(int _iID)
        {
            TypeReferrerDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.TypeReferrer WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new TypeReferrerDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(TypeReferrerDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    TypeReferrerDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.TypeReferrer SET Name = N'{0}', Del = '{1}',Note = N'{2}' Where ID = {3}",
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
        public List<TypeReferrerDTO> GetAll()
        {
            List<TypeReferrerDTO> listResult = new List<TypeReferrerDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.TypeReferrer";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            TypeReferrerDTO obj = new TypeReferrerDTO(row);
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
