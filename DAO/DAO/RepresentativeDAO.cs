using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class RepresentativeDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public RepresentativeDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(RepresentativeDTO _obj)
        {
            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.Representative(name,phone, CompanyID, Del, Note) Values(N'{0}', N'{1}', {2}, '{3}', N'{4}')",
                        _obj.Name, _obj.Phone, _obj.CompanyID.ToString(), _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "Select MAX(ID) FROM dbo.Representative";
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
                string sql = string.Format("Delete from dbo.Representative Where ID = {0}", _iID.ToString());
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public RepresentativeDTO SelectPrimaryKey(int _iID)
        {
            RepresentativeDTO objResult = null;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("Select * from dbo.Representative Where ID = {0}", _iID.ToString());
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new RepresentativeDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(RepresentativeDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    RepresentativeDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.Representative Set name = N'{0}', phone = N'{1}', CompanyID = {2}, del = '{3}', Note = N'{4}' Where ID = {4}",
                            _obj.Name, _obj.Phone, _obj.CompanyID.ToString(), _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<RepresentativeDTO> GetAll()
        {
            List<RepresentativeDTO> listResult = new List<RepresentativeDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Representative";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            RepresentativeDTO obj = new RepresentativeDTO(row);
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
