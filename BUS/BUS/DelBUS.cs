using DAO.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS
{
    public class DelBUS
    {
        public static int DeleteRecordsBasedOnDelValue()
        {
            int iResult = -1;
            try
            {
                DelDAO handle = new DelDAO();
                iResult = handle.DeleteRecordsBasedOnDelValue();
            }
            catch { }
            return iResult;
        }
    }
}
