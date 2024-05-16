using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ACK
{
    public class DeptACK
    {
        public DeptACK(int billID, string billName, int companyID, string companyName, string accountName,
               DateTime startDate, double totalBill, string totalBillString, double totalPayment,
               string totalPaymentString, DateTime paymentDueDate, double commission, string commissionString,
               string receiveCommission, string note, double dept, string deptString)
        {
            this.BillID = billID;
            this.BillName = billName;
            this.CompanyID = companyID;
            this.CompanyName = companyName;
            this.AccountName = accountName;
            this.StartDate = startDate;
            this.TotalBill = totalBill;
            this.TotalBillString = totalBillString;
            this.TotalPayment = totalPayment;
            this.TotalPaymentString = totalPaymentString;
            this.PaymentDueDate = paymentDueDate;
            this.Commission = commission;
            this.CommissionString = commissionString;
            this.ReceiveCommission = receiveCommission;
            this.Note = note;
            this.Dept = dept;
            this.DeptString = deptString;
        }

        public DeptACK(DataRow row)
        {
            this.BillID = int.Parse(row["billID"].ToString());
            this.BillName = row["billName"].ToString();
            this.CompanyID = int.Parse(row["companyID"].ToString());
            this.CompanyName = row["companyName"].ToString();
            this.AccountName = row["accountName"].ToString();
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.TotalBill = double.Parse(row["totalBill"].ToString());
            this.TotalBillString = row["totalBillString"].ToString();
            this.TotalPayment = double.Parse(row["totalPayment"].ToString());
            this.TotalPaymentString = row["totalPaymentString"].ToString();
            this.PaymentDueDate = DateTime.Parse(row["paymentDueDate"].ToString());
            this.Commission = double.Parse(row["commission"].ToString());
            this.CommissionString = row["commissionString"].ToString();
            this.ReceiveCommission = row["receiveCommission"].ToString();
            this.Note = row["note"].ToString();
            this.Dept = double.Parse(row["dept"].ToString());
            this.DeptString = row["deptString"].ToString();
        }

        public DeptACK() { }

        private int billID;
        private string billName;
        private int companyID;
        private string companyName;
        private string accountName;
        private DateTime startDate;
        private double totalBill;
        private string totalBillString;
        private double totalPayment;
        private string totalPaymentString;
        private DateTime paymentDueDate;
        private double commission;
        private string commissionString;
        private string receiveCommission;
        private string note;
        private double dept;
        private string deptString;

        public int BillID { get => billID; set => billID = value; }
        public string BillName { get => billName; set => billName = value; }
        public int CompanyID { get => companyID; set => companyID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public double TotalBill { get => totalBill; set => totalBill = value; }
        public string TotalBillString { get => totalBillString; set => totalBillString = value; }
        public double TotalPayment { get => totalPayment; set => totalPayment = value; }
        public string TotalPaymentString { get => totalPaymentString; set => totalPaymentString = value; }
        public DateTime PaymentDueDate { get => paymentDueDate; set => paymentDueDate = value; }
        public double Commission { get => commission; set => commission = value; }
        public string CommissionString { get => commissionString; set => commissionString = value; }
        public string ReceiveCommission { get => receiveCommission; set => receiveCommission = value; }
        public string Note { get => note; set => note = value; }
        public double Dept { get => dept; set => dept = value; }
        public string DeptString { get => deptString; set => deptString = value; }
    }
}
