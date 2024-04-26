﻿using DAO.SQLHelper;
using DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class ExpenditureInfoDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public ExpenditureInfoDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[Insert]"
        public int Insert(ExpenditureInfoDTO _obj)
        {

            int iResult = -1;
            try
            {
                if (cn != null)
                {
                    string sql = string.Format("INSERT INTO dbo.ExpenditureInfo(ExpenditureID, Price, del, note)" +
                    "Values({0}, {1}, '{2}', N'{3}')",
                    _obj.ExpenditureID.ToString(), _obj.Price.ToString(), _obj.Del.ToString(), _obj.Note);
                    iResult = SqlDataHelper.ExecuteNonQuery(sql, cn);
                    if (iResult == 1)
                    {
                        sql = "SELECT MAX(ID) FROM  dbo.ExpenditureInfo";
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
                string sql = "DELETE FROM dbo.ExpenditureInfo WHERE ID= " + _iID.ToString();
                int iR = SqlDataHelper.ExecuteNonQuery(sql, cn);
                if (iR > 0)
                    isResult = true;
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public ExpenditureInfoDTO SelectPrimaryKey(int _iID)
        {
            ExpenditureInfoDTO objResult = null;
            try
            {

                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.ExpenditureInfo WHERE ID=" + _iID.ToString();
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    foreach (DataRow row in dt.Rows)
                    {
                        objResult = new ExpenditureInfoDTO(row);
                        return objResult;
                    }
                }
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public bool Update(ExpenditureInfoDTO _obj)
        {
            bool isResult = false;
            try
            {
                if (cn != null)
                {
                    ExpenditureInfoDTO temp = SelectPrimaryKey(_obj.ID);
                    if (temp != null)
                    {
                        string sql = string.Format("UPDATE dbo.ExpenditureInfo SET ExpenditureID = {0}, Price = {1}, Del = '{2}',Note = N'{3}' Where ID = {4}",
                            _obj.ExpenditureID.ToString(), _obj.Price.ToString(), _obj.Del.ToString(), _obj.Note, _obj.ID.ToString());
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
        public List<ExpenditureInfoDTO> GetAll()
        {
            List<ExpenditureInfoDTO> listResult = new List<ExpenditureInfoDTO>();
            try
            {
                if (cn != null)
                {
                    string sql = "SELECT * FROM dbo.ExpenditureInfo";
                    DataTable dt = SqlDataHelper.GetDataToStringSQL(sql, cn);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ExpenditureInfoDTO obj = new ExpenditureInfoDTO(row);
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
