using DAO.DAO;
using DTO.ACK;
using DTO.DTO;
using System.Collections.Generic;
using System.Linq;

namespace BUS.BUS
{
    public class BillBUS
    {
        private static BillDAO handle = new BillDAO();

        #region "[Insert]"
        public static int Insert(BillDTO _obj)
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
        public static BillDTO SelectPrimaryKey(int _iID)
        {
            BillDTO objResult = null;
            try
            {
                objResult = handle.SelectPrimaryKey(_iID);
            }
            catch { }
            return objResult;
        }
        #endregion

        #region "[Update]"
        public static bool Update(BillDTO _obj)
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
        public static List<BillDTO> GetAll()
        {
            List<BillDTO> listResult = new List<BillDTO>();
            try
            {
                listResult = handle.GetAll();
            }
            catch { }
            return listResult;
        }
        #endregion

        #region "[CreateBill]"
        /// <summary>
        /// hàm lập hóa đơn bán hàng
        /// </summary>
        /// <param name="list">danh sách các chi tiết hóa đơn của 1 hóa đơn</param>
        /// <returns></returns>
        public static BillACK CreateBill(List<BillInfoDTO> list, BillDTO _obj)
        {
            BillACK objResult = null;
            try
            {

                double totalBill = 0;
                double totalDividend = 0;
                double overage = 0;
                //insert hóa đơn 
                foreach (BillInfoDTO item in list)
                {
                    //tính tổng tiền hóa đơn
                    double temp = item.SalePrice * item.Count;
                    totalBill += temp;

                    //tính tổng tiền lời trên từng sản phẩm

                    //lấy danh sách các giá nhập thuộc về 1 sản phẩm
                    InputDTO input = InputBUS.GetListInputProductByProductID(item.ProductID).OrderByDescending(p => p.StartDate).FirstOrDefault<InputDTO>();

                    ///tinh tiền lời và thuế doanh nghiệp kh VAT >0 còn nếu không
                    ///có VAT thì doanh nghiệp sẽ hưởng toàn bộ lợi nhuận mà không
                    ///phải đóng thuế doanh nghiệp
                    ///
                    if (input != null)
                    {
                        double profit = (item.SalePrice - input.ImportPrice) * item.Count;
                        if (item.VAT > 0)
                        {
                            double dividend = profit - (item.VAT / 100 * profit);
                            dividend += dividend;
                        }
                        else
                        {
                            //không dóng thuế doanh nghiệp.
                            totalDividend += profit;
                        }
                    }
                }
                
                if (_obj.TotalPayment > totalBill)
                {
                    overage = _obj.TotalPayment - totalBill;
                    _obj.TotalPayment = totalBill;
                }
                //B1: Insert Hóa Đơn
                BillDTO insertBill = new BillDTO();
                insertBill.Name = _obj.Name;
                insertBill.CompanyID = _obj.CompanyID;
                insertBill.AccountID = _obj.AccountID;
                insertBill.TotalBill = totalBill;
                insertBill.TotalPayment = _obj.TotalPayment;
                insertBill.StartDate = _obj.StartDate;
                insertBill.PaymentDueDate = _obj.PaymentDueDate;
                insertBill.Dividend = totalDividend;
                insertBill.Commission = _obj.Commission;
                insertBill.ReceiveCommissionsID = _obj.ReceiveCommissionsID;
                insertBill.ShippingCost = _obj.ShippingCost;
                insertBill.Del = _obj.Del;
                insertBill.Note = _obj.Note;

                //nếu insert thành công thì mã hóa đơn lớn hơn 0
                int billID = Insert(insertBill);
                if (billID > 0)
                {
                    //B2: insert chi tiết hóa đơn
                    foreach (BillInfoDTO itemBillInfo in list)
                    {
                        BillInfoDTO insertBillInfo = new BillInfoDTO();
                        insertBillInfo.BillID = billID;
                        insertBillInfo.ProductID = itemBillInfo.ProductID;
                        insertBillInfo.Count = itemBillInfo.Count;
                        //insertBillInfo.ImportPrice = itemBillInfo.ImportPrice;
                        insertBillInfo.SalePrice = itemBillInfo.SalePrice;
                        insertBillInfo.VAT = itemBillInfo.VAT;
                        insertBillInfo.Divedend = itemBillInfo.Divedend;
                        insertBillInfo.Del = itemBillInfo.Del;
                        insertBillInfo.Note = itemBillInfo.Note;

                        ///
                        int iInsertBillInfo = BillInfoBUS.Insert(insertBillInfo);
                        if (iInsertBillInfo > 0)
                        {
                            try
                            {
                                //cập nhật bảng sản phẩm
                                ProductDTO itemProduct = ProductBUS.SelectPrimaryKey(itemBillInfo.ProductID);
                                itemProduct.Stock -= itemBillInfo.Count;
                                ProductBUS.Update(itemProduct);
                            }
                            catch { }
                            objResult = new BillACK();
                            objResult.Error = string.Empty;
                            objResult.ID = billID;
                            objResult.State = true;
                            objResult.Overage = overage;
                        }
                    }
                    try
                    {
                        //insert chi tiết thanh toán.
                        PaymentInfoDTO paymentInfoItem = new PaymentInfoDTO();
                        paymentInfoItem.BillID = billID;
                        paymentInfoItem.Payment = _obj.TotalPayment;
                        paymentInfoItem.StartDate = _obj.StartDate;
                        paymentInfoItem.StartNextDate = _obj.StartDate;

                        if (totalBill > _obj.TotalPayment)
                        {
                            paymentInfoItem.StartNextDate = _obj.PaymentDueDate;
                        }
                        paymentInfoItem.Del = false;
                        paymentInfoItem.Note = string.Empty;

                        PaymentInfoBUS.Insert(paymentInfoItem);
                    }
                    catch { }
                }
                else
                {
                    objResult = new BillACK();
                    objResult.State = false;
                    objResult.ID = -1;
                    objResult.Error = "Không Thêm Hóa Đơn Được";
                }
            }
            catch { }
            return objResult;
        }
        #endregion

    }
}
