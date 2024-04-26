using System;
using System.Data;


namespace DTO.DTO
{
    public class BillDTO
    {
        public BillDTO(int id, string name, int companyID,  int accountID,  DateTime startDate, double totalBill, double totalPayment,  
            DateTime paymentDueDate, double dividend,  double commission, int receiveCommissionID,  double shippingCost,  bool del, string note)
        {
            this.ID = id;
            this.Name = name;
            this.CompanyID = companyID;
            this.AccountID = accountID;
            this.StartDate = startDate;
            this.TotalBill = totalBill;
            this.TotalPayment = totalPayment;
            this.PaymentDueDate = paymentDueDate;
            this.Dividend = dividend;
            this.Commission = commission;
            this.ReceiveCommissionsID = receiveCommissionID;
            this.ShippingCost = shippingCost;
            this.Del = del;
            this.Note = note;
        }
        public BillDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.CompanyID = int.Parse(row["companyID"].ToString());
            this.AccountID = int.Parse(row["accountID"].ToString());
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.TotalBill = double.Parse(row["totalBill"].ToString());
            this.TotalPayment = double.Parse(row["totalPayment"].ToString());
            this.PaymentDueDate = DateTime.Parse(row["paymentDueDate"].ToString());
            this.Dividend = double.Parse(row["dividend"].ToString());
            this.Commission = double.Parse(row["commission"].ToString());
            this.ReceiveCommissionsID = int.Parse(row["receiveCommissionID"].ToString());
            this.ShippingCost = double.Parse(row["shippingCost"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }
        public BillDTO() { }

        private int id;
        private string name;
        private int companyID;
        private string companyName;
        private int accountID;
        private string accountName;
        private DateTime startDate;
        private double totalBill;
        private string totalBillString;
        private double totalPayment;
        private string totalPaymentString;
        private DateTime paymentDueDate;
        private double dividend;
        private string dividendString;
        private double commission;
        private string commissionString;
        private int receiveCommissionID;
        private string receiveCommissionName;
        private double shippingCost;
        private string shippingCostString;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int CompanyID { get => companyID; set => companyID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public int AccountID { get => accountID; set => accountID = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public double TotalBill { get => totalBill; set => totalBill = value; }
        public string TotalBillString { get => totalBillString; set => totalBillString = value; }
        public double TotalPayment { get => totalPayment; set => totalPayment = value; }
        public string TotalPaymentString { get => totalPaymentString; set => totalPaymentString = value; }
        public DateTime PaymentDueDate { get => paymentDueDate; set => paymentDueDate = value; }
        public double Dividend { get => dividend; set => dividend = value; }
        public string DividendString { get => dividendString; set => dividendString = value; }
        public double Commission { get => commission; set => commission = value; }
        public string CommissionString { get => commissionString; set => commissionString = value; }
        public int ReceiveCommissionsID { get => receiveCommissionID; set => receiveCommissionID = value; }
        public string ReceiveCommissionName { get => receiveCommissionName; set => receiveCommissionName = value; }
        public double ShippingCost { get => shippingCost; set => shippingCost = value; }
        public string ShippingCostString { get => shippingCostString; set => shippingCostString = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
