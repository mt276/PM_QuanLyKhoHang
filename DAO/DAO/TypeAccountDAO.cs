using DAO.SQLHelper;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public class TypeAccountDAO
    {
        public SqlConnection cn = null;
        #region "[khởi tạo cơ bản]"
        public TypeAccountDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(TypeAccountDTO _obj)
        {
            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.TypeAccount(Name, Del, Note) Values(N'{0}','{1}',N'{2}')", _obj.Name, _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "Select MAX(ID) FROM dbo.TypeAct";
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
                string sql = string.Format("Delete from dbo.TypeAccount Where ID = {0}", _iID.ToString());
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public TypeAccountDTO SelectPrimaryKey(int _iID)
        {
            TypeAccountDTO objResult = null;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("Select * from dbo.TypeAccount Where ID = {0}", _iID.ToString());
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow Row in dt.Rows)
                    {
                        objResult = new TypeAccountDTO(Row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion
        #region "[Update]"
        public bool Update(TypeAccountDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    TypeAccountDTO Temp = SelectPrimaryKey(_obj.ID);
                    if (Temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.TypeAccount Set name = N'{0}', del = '{1}', note = N'{2}' Where ID = {3}",
                            _obj.Name, _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
                        int Result = SqlDataHelper.ExecuteNonQuery(sql, cn);
                        if (Result > 0)
                            isResult = true;
                    }
                }
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Get All]"
        public List<TypeAccountDTO> GetAll()
        {
            List<TypeAccountDTO> listResult = new List<TypeAccountDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.TypeAccount";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow Row in dt.Rows)
                        {
                            TypeAccountDTO obj = new TypeAccountDTO(Row);
                            listResult.Add(obj);
                        }
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[Select By Name]"
        public TypeAccountDTO SelectByName(string _strName)
        {
            TypeAccountDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = string.Format("SELECT * FROM dbo.TypeAccount WHERE name=N'{0}'", _strName);
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow Row in dt.Rows)
                    {
                        objResult = new TypeAccountDTO(Row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion
    }
}
