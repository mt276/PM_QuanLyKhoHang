using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ACK
{
    public class ListProductSellACK
    {
        public ListProductSellACK(int billID, DateTime startDate, double totalBill, double totalPayment, DateTime paymentDueDate, double dividendBill, int productID, int count, double dividendProduct, int vat) 
        {
            this.BillID = billID;
            this.StartDate = startDate;
            this.TotalBill = totalBill;
            this.TotalPayment = totalPayment;
            this.PaymentDueDate = paymentDueDate;
            this.DividendBill = dividendBill;
            this.ProductID = productID;
            this.Count = count;
            this.DividendProduct = dividendProduct;
            this.VAT = vat;
        }

        public ListProductSellACK(DataRow row) 
        {
            this.BillID = int.Parse(row["billID"].ToString());
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.TotalBill = double.Parse(row["totalBill"].ToString());
            this.TotalPayment = double.Parse(row["totalPayment"].ToString());
            this.PaymentDueDate = DateTime.Parse(row["paymentDueDate"].ToString());
            this.DividendBill = double.Parse(row["dividend"].ToString());
            this.ProductID = int.Parse(row["productID"].ToString());
            this.Count = int.Parse(row["count"].ToString());
            this.DividendProduct = double.Parse(row["dividend"].ToString());
            this.VAT = int.Parse(row["vat"].ToString());
        }

        public ListProductSellACK() { }

        private int billID;
        private DateTime startDate;
        private double totalBill;
        private double totalPayment;
        private DateTime paymentDueDate;
        private double dividendBill;
        private int productID;
        private int count;
        private double dividendProduct;
        private int vat;

        public int BillID { get => billID; set => billID = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public double TotalBill { get => totalBill; set => totalBill = value; }
        public double TotalPayment { get => totalPayment; set => totalPayment = value; }
        public DateTime PaymentDueDate { get => paymentDueDate; set => paymentDueDate = value; }
        public double DividendBill { get => dividendBill; set => dividendBill = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int Count { get => count; set => count = value; }
        public double DividendProduct { get => dividendProduct; set => dividendProduct = value; }
        public int VAT { get => vat; set => vat = value; }
    }
}
