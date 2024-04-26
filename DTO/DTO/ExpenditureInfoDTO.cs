using System;
using System.Data;


namespace DTO.DTO
{
    public class ExpenditureInfoDTO
    {
        public ExpenditureInfoDTO(int id, int expenditureID, double price, DateTime startDate, bool del, string note)
        {
            this.ID = id;
            this.ExpenditureID = expenditureID;
            this.Price = price;
            this.StartDate = startDate;
            this.Del = del;
            this.Note = note;
        }

        public ExpenditureInfoDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.ExpenditureID = int.Parse(row["expenditureID"].ToString());
            this.Price = double.Parse(row["price"].ToString());
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public ExpenditureInfoDTO() { }

        private int id;
        private int expenditureID;
        private string expenditureName;
        private double price;
        private string priceString;
        private DateTime startDate;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public int ExpenditureID { get => expenditureID; set => expenditureID = value; }
        public string ExpenditureName { get => expenditureName; set => expenditureName = value; }
        public double Price { get => price; set => price = value; }
        public string PriceString { get => priceString; set => priceString = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
