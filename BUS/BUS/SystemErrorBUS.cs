﻿using DAO.DAO;
using DTO.DTO;
using System.Collections.Generic;

namespace BUS.BUS
{
    public class SystemErrorBUS
    {
        private static SystemErrorDAO handle = new SystemErrorDAO();

        #region "[Insert]"
        public static int Insert(SystemErrorDTO _obj)
        {
            int iResult = -1;
            try
            {
                iResult = handle.Insert(_obj);
            }
            catch { }
            return iResult;
        }
        #endregion

        #region "[Delete]"
        public static bool Delete(int _iID)
        {
            bool isResult = false;
            try
            {
                isResult = handle.Delete(_iID);
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[Select Primary Key]"
        public static SystemErrorDTO SelectPrimaryKey(int _iID)
        {
            SystemErrorDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(SystemErrorDTO _obj)
        {
            bool isResult = false;
            try
            {
                isResult = handle.Update(_obj);
            }
            catch { }
            return isResult;
        }
        #endregion

        #region "[GetAll]"
        public static List<SystemErrorDTO> GetAll()
        {
            List<SystemErrorDTO> listResult = new List<SystemErrorDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

    }
}
