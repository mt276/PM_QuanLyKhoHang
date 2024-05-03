using DAO.DAO;
using DTO.DTO;
using System;
using System.Collections.Generic;

namespace BUS.BUS
{
    public class KeyBUS
    {
        #region "[Insert Key]"
        public static bool InsertKey(KeyDTO _item)
        {
            bool isSuccess = false;
            try
            {
                KeyDAO m_Handle = new KeyDAO();
                KeyDTO item = null;
                try
                {

                    item = m_Handle.SelectPrimaryKey();
                }
                catch { }
                if (item != null)
                {
                    isSuccess = m_Handle.Update(_item.TimeDateLine);
                }
                else
                {
                    int ID = m_Handle.Insert(_item);
                    if (ID > 0)
                        isSuccess = true;

                }
            }
            catch { }
            return isSuccess;
        }
        #endregion

        #region "[Check Key]"
        public static bool CheckKey()
        {
            bool isSuccess = false;
            try
            {
                KeyDAO m_Handle = new KeyDAO();
                string text = m_Handle.SelectPrimaryKey().TimeDateLine;
                string mask = "64A119EKEY" + DateTime.Now.ToString("dd.MM.yyyy");
                int i = text.IndexOf("64A119EKEY") + 10;
                string d = text.Substring(i);
                if (DateTime.Parse(d) > DateTime.Now)
                    return true;

            }
            catch { }
            return isSuccess;
        }
        #endregion

    }
}
