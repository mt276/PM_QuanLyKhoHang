using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO.DAO
{
    public class ReceiveCommissionDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public ReceiveCommissionDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(ReceiveCommissionDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string check = string.Format("Select COUNT(*) from dbo.ReceiveCommission Where name = N'{0}' AND  phone = N'{1}' ", _obj.Name, _obj.Phone);
                    int count = (int)SqlDataHelper.GetMaxID(check, cn);
                    if (count > 0)
                    {
                        return -1;
                    }

                    string sql = string.Format("INSERT INTO dbo.ReceiveCommission(name,address,phone,fax, TypeReferrerID, Del,Note)" +
                    "Values(N'{0}', N'{1}', N'{2}', N'{3}', {4}, '{5}', N'{6}')",
                    _obj.Name, _obj.Address, _obj.Phone, _obj.Fax, _obj.TypeReferrerID.ToString(), _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.ReceiveCommission";
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
                string sql = "DELETE FROM dbo.ReceiveCommission WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public ReceiveCommissionDTO SelectPrimaryKey(int _iID)
        {
            ReceiveCommissionDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.ReceiveCommission WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new ReceiveCommissionDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(ReceiveCommissionDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    ReceiveCommissionDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string check = string.Format("Select COUNT(*) from dbo.ReceiveCommission Where name = N'{0}' AND  phone = N'{1}' AND id <> {2}", _obj.Name, _obj.Phone, _obj.ID);
                        int count = (int)SqlDataHelper.GetMaxID(check, cn);
                        if (count > 0)
                        {
                            return false;
                        }

                        string sql = string.Format("UPDATE dbo.ReceiveCommission SET name = N'{0}', address = N'{1}', phone = N'{2}', fax = N'{3}'" +
                            "TypeReferrerID = {4} , Del = '{5}',Note = N'{6}' Where ID = {7}",
                             _obj.Name, _obj.Address, _obj.Phone, _obj.Fax, _obj.TypeReferrerID.ToString(), _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<ReceiveCommissionDTO> GetAll()
        {
            List<ReceiveCommissionDTO> listResult = new List<ReceiveCommissionDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.ReceiveCommission";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ReceiveCommissionDTO obj = new ReceiveCommissionDTO(row);
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
