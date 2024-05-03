using DAO.SQLHelper;
using System.Data.SqlClient;


namespace DAO.DAO
{
    public class DelDAO
    {
        public SqlConnection cn = null;

        #region "[Connect]"
        public DelDAO()
        {
            cn = SqlDataHelper.Connect(SqlDataHelper.strConnectionString);
        }
        #endregion

        #region "[DeleteRecordsBasedOnDelValue]"
        public int DeleteRecordsBasedOnDelValue()
        {
            int iResult = -1;
            try
            {
                iResult = SQLHelper.SqlDataHelper.ExecuteNonQuery("exec USP_DeleteRecordsBasedOnDelValue", cn);
            }
            catch { }
            return iResult;
        }

        #endregion
    }
}
