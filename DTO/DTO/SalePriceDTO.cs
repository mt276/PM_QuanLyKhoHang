using System;
using System.Data;

namespace DTO.DTO
{
    public class SalePriceDTO
    {
        public SalePriceDTO(int id, int productID, double salePrice, int accountID, DateTime startDate, bool del, string note)
        {
            this.ID = id;
            this.ProductID = productID;
            this.SalePrice = salePrice;
            this.AccountID = accountID;
            this.StartDate = startDate;
            this.Del = del;
            this.Note = note;
        }

        public SalePriceDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.ProductID = int.Parse(row["productID"].ToString());
            this.SalePrice = double.Parse(row["salePrice"].ToString());
            this.AccountID = int.Parse(row["accountID"].ToString());
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public SalePriceDTO() { }

        private int id;
        private int productID;
        private string productName;
        private double salePrice;
        private string salePriceString;
        private int accountID;
        private string accountName;
        private DateTime startDate;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public string SalePriceString { get => salePriceString; set => salePriceString = value; }
        public int AccountID { get => accountID; set => accountID = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
