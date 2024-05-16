using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class PaymentInfoDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public PaymentInfoDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(PaymentInfoDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.PaymentInfo(BillID, Payment, StartNextDate, Del, note)" +
                    "Values({0}, {1}, '{2}', '{3}', N'{4}')",
                    _obj.BillID.ToString(), _obj.Payment.ToString(), _obj.StartNextDate.ToString(), _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.PaymentInfo";
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
                string sql = "DELETE FROM dbo.PaymentInfo WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public PaymentInfoDTO SelectPrimaryKey(int _iID)
        {
            PaymentInfoDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.PaymentInfo WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new PaymentInfoDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(PaymentInfoDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    PaymentInfoDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.PaymentInfo SET BillID = {0}, Payment = {1}, StartNextDate = '{2}', Del = '{3}',Note = N'{4}' Where ID = {5}",
                            _obj.BillID.ToString(), _obj.Payment.ToString(), _obj.StartNextDate.ToString(), _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<PaymentInfoDTO> GetAll()
        {
            List<PaymentInfoDTO> listResult = new List<PaymentInfoDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.PaymentInfo";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            PaymentInfoDTO obj = new PaymentInfoDTO(row);
                            listResult.Add(obj);
                        }
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SelectByOrderID]"
        public List<PaymentInfoDTO> SelectByBillID(int _billID)
        {
            List<PaymentInfoDTO> listResult = new List<PaymentInfoDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.PaymentInfo WHERE BillID = " + _billID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            PaymentInfoDTO obj = new PaymentInfoDTO(row);
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
