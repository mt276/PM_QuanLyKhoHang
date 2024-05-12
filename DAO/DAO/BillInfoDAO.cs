using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class BillInfoDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public BillInfoDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(BillInfoDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.BillInfo (BillID, ProductID, Count, SalePrice, VAT, Dividend, Del, Note) " +
                        "VALUES({0}, {1}, {2}, {3}, {4}, {5}, '{6}', N'{7}')",
                        _obj.BillID.ToString(), _obj.ProductID.ToString(), _obj.Count.ToString(),_obj.SalePrice.ToString(), 
                        _obj.VAT.ToString(), _obj.Divedend.ToString(), _obj.Del.ToString(), _obj.Note);
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
                string sql = "DELETE FROM dbo.BillInfo WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public BillInfoDTO SelectPrimaryKey(int _iID)
        {
            BillInfoDTO objResult = null;
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.BillInfo WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new BillInfoDTO(row);
                        return objResult;
                    }

                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(BillInfoDTO _obj)
        {
            bool isResult = false;
            try
            {
                BillInfoDTO temp = SelectPrimaryKey(_obj.ID);
                if (temp != null)
                {
                    string sql = string.Format("UPDATE dbo.BillInfo SET billID = {0}, productID = {1}, count = {2}, importPrice = {3}, salePrice = {4}, " +
                        "VAT = {5}, Dividend = {6}, Del = '{7}', Note = N'{8}' WHERE ID = {9}",
                        _obj.BillID.ToString(), _obj.ProductID.ToString(), _obj.Count.ToString(), _obj.ImportPrice.ToString(), _obj.SalePrice.ToString(),
                        _obj.VAT.ToString(), _obj.Divedend.ToString(), _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<BillInfoDTO> GetAll()
        {
            List<BillInfoDTO> listResult = new List<BillInfoDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "Select * from dbo.BillInfo";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            BillInfoDTO obj = new BillInfoDTO(row);
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
