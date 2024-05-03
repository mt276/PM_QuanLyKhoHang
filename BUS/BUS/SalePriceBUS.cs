﻿using DAO.DAO;
using DTO.DTO;
using System.Collections.Generic;

namespace BUS.BUS
{
    public class SalePriceBUS
    {
        private static SalePriceDAO handle = new SalePriceDAO();

        #region "[Insert]"
        public static int Insert(SalePriceDTO _obj)
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
        public static SalePriceDTO SelectPrimaryKey(int _iID)
        {
            SalePriceDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(SalePriceDTO _obj)
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
        public static List<SalePriceDTO> GetAll()
        {
            List<SalePriceDTO> listResult = new List<SalePriceDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[SelectByInputID]"
        public static SalePriceDTO SelectByInputID(int _iID)
        {
            SalePriceDTO objResult = null;
            try
            {
                objResult = handle.SelectByInputID(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

    }
}
