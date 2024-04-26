using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO.DAO
{
    public class CompanyDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public CompanyDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(CompanyDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.Company(name,address,phone,fax,Del,Note)" +
                    "Values(N'{0}', N'{1}', N'{2}', N'{3}', '{4}', N'{5}')",
                    _obj.Name, _obj.Address, _obj.Phone, _obj.Fax, _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.Company";
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
                string sql = "DELETE FROM dbo.Company WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public CompanyDTO SelectPrimaryKey(int _iID)
        {
            CompanyDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Company WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new CompanyDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(CompanyDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    CompanyDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.Company SET name = N'{0}', address = N'{1}', phone = N'{2}', fax = N'{3}', Del = '{4}',Note = N'{5}' Where ID = {6}",
                             _obj.Name, _obj.Address, _obj.Phone, _obj.Fax, _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<CompanyDTO> GetAll()
        {
            List<CompanyDTO> listResult = new List<CompanyDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Company";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            CompanyDTO obj = new CompanyDTO(row);
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
