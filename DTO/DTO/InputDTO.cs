using System;
using System.Data;


namespace DTO.DTO
{
    public class InputDTO
    {
        public InputDTO(int id, int productID, int count, double importPrice, int accountID, DateTime startDate, bool del, string note)
        {
            this.ID = id;
            this.ProductID = productID;
            this.Count = count;
            this.ImportPrice = importPrice;
            this.AccountID = accountID;
            this.StartDate = startDate;
            this.Del = del;
            this.Note = note;
        }

        public InputDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.ProductID = int.Parse(row["productID"].ToString());
            this.Count = int.Parse(row["count"].ToString());
            this.ImportPrice = double.Parse(row["importPrice"].ToString());
            this.AccountID = int.Parse(row["accountID"].ToString());
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public InputDTO() { }

        private int id;
        private int productID;
        private string productName;
        private int count;
        private double importPrice;
        private string importPriceString;
        private DateTime startDate;
        private int accountID;
        private string accountName;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int Count { get => count; set => count = value; }
        public double ImportPrice { get => importPrice; set => importPrice = value; }
        public string ImportPriceString { get => importPriceString; set => importPriceString = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public int AccountID { get => accountID; set => accountID = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
