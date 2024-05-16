using DAO.SQLHelper;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class BillDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public BillDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(BillDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.Bill (Name, CompanyID, AccountID, TotalBill, TotalPayment,StartDate, " +
                        "PaymentDueDate, Dividend, Commission, ReceiveCommissionID, Del, Note, ShippingCost)" +
                        "VALUES ( N'{0}', {1}, {2}, {3}, {4}, '{5}','{6}', {7}, {8}, {9}, '{10}', N'{11}', {12})",
                        _obj.Name, _obj.CompanyID.ToString(), _obj.AccountID.ToString(), _obj.TotalBill.ToString(), _obj.TotalPayment.ToString(),
                        _obj.StartDate.ToString(), _obj.PaymentDueDate.ToString(), _obj.Dividend.ToString(), _obj.Commission.ToString(),
                        _obj.ReceiveCommissionsID>0?_obj.ReceiveCommissionsID.ToString(): "NULL", 
                        _obj.Del.ToString(), _obj.Note, _obj.ShippingCost.ToString());
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "Select MAX(ID) From dbo.Bill";
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
                string sql = "DELETE FROM dbo.Bill WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public BillDTO SelectPrimaryKey(int _iID)
        {
            BillDTO objResult = null;
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.Bill WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new BillDTO(row);
                        return objResult;
                    }

                }
            }
            catch { }
            return objResult;   
        }
        #endregion

        #region "[Update]"
        public bool Update(BillDTO _obj)
        {
            bool isResult = false;
            try
            {
                BillDTO temp = SelectPrimaryKey(_obj.ID);
                if (temp != null)
                {
                    string sql = string.Format("UPDATE dbo.Bill SET name = N'{0}', companyID = {1}, accountID = {2}, totalBill = {3}, TotalPayment = {4}, " +
                        "StartDate ='{5}', PaymentDueDate = '{6}', Dividend = {7}, Commission = {8}, ReceiveCommissionID = {9}, Del = '{10}', Note = N'{11}', ShippingCost = {12} WHERE ID = {13}",
                        _obj.Name, _obj.CompanyID.ToString(), _obj.AccountID.ToString(), _obj.TotalBill.ToString(), _obj.TotalPayment.ToString(),
                        _obj.StartDate.ToString(), _obj.PaymentDueDate.ToString(), _obj.Dividend.ToString(), _obj.Commission.ToString(),
                        (_obj.ReceiveCommissionsID > 0 ? _obj.ReceiveCommissionsID.ToString() : "NULL"),
                        _obj.Del.ToString(), _obj.Note, _obj.ShippingCost.ToString(), _obj.ID.ToString());
                    int result = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (result > 0)
                        isResult = true;
                }
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Get All]"
        public List<BillDTO> GetAll()
        {
            List<BillDTO> listResult = new List<BillDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "Select * from dbo.Bill";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            BillDTO obj = new BillDTO(row);
                            listResult.Add(obj);
                        }
                    }
                }
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SelectByCompanyID]"
        public List<BillDTO> SelectByCompanyID(int _iCompanyID)
        {
            List<BillDTO> listResult = new List<BillDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "Select * from dbo.Bill Where CompanyID = " + _iCompanyID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            BillDTO obj = new BillDTO(row);
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
