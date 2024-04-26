using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.SQLHelper;
using DTO.DTO;

namespace DAO.DAO
{
    public class TypeActDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public TypeActDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(TypeActDTO _obj)
        {
            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.TypeAct(Name, Del, Note) Values(N'{0}','{1}',N'{2}')", _obj.Name, _obj.Del.ToString(), _obj.Note);
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
                string sql = string.Format("Delete from dbo.TypeAct Where ID = {0}", _iID.ToString());
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public TypeActDTO SelectPrimaryKey(int _iID)
        {
            TypeActDTO objResult = null;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("Select * from dbo.TypeAct Where ID = {0}", _iID.ToString());
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new TypeActDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(TypeActDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    TypeActDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.TypeAct Set name = N'{0}', del = '{1}', note = N'{2}' Where ID = {3}", 
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
        public List<TypeActDTO> GetAll()
        {
            List<TypeActDTO> listResult = new List<TypeActDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.TypeAct";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            TypeActDTO obj = new TypeActDTO(row);
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
        public TypeActDTO SelectByName(string _strName)
        {
            TypeActDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = string.Format("SELECT * FROM dbo.TypeAct WHERE name=N'{0}'",_strName);
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new TypeActDTO(row);
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
