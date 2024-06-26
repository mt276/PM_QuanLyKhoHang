﻿using DAO.DAO;
using DTO.DTO;
using System.Collections.Generic;

namespace BUS.BUS
{
    public static class TypeActBUS
    {
        private static TypeActDAO handle = new TypeActDAO();


        #region "[Insert]"
        public static int Insert(TypeActDTO _obj)
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
        public static TypeActDTO SelectPrimaryKey(int _iID)
        {
            TypeActDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(TypeActDTO _obj)
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

        #region "[Get All]"
        public static List<TypeActDTO> GetAll()
        {
            List<TypeActDTO> listResult = new List<TypeActDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[Select By Name]"
        public static TypeActDTO SelectByName(string _strName)
        {
            TypeActDTO objResult = null;
            try
            {
                objResult = handle.SelectByName(_strName);
            }
            catch { }
            return objResult;
        }
        #endregion
    }
}
