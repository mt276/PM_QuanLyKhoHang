using System;
using System.Data;


namespace DTO.DTO
{
    public class ExpenditureDTO
    {
        public ExpenditureDTO(int id, string name, DateTime startDate, double expenditure, int accountID,  bool del, string note)
        {
            this.ID = id;
            this.Name = name;
            this.StartDate = startDate;
            this.Expenditure = expenditure;
            this.AccountID = accountID;
            this.Del = del;
            this.Note = note;
        }

        public ExpenditureDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.Expenditure = double.Parse(row["expenditure"].ToString());
            this.AccountID = int.Parse(row["accountID"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public ExpenditureDTO() { }

        private int id;
        private string name;
        private DateTime startDate;
        private double expenditure;
        private string totalBillString;
        private int accountID;
        private string accountName;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public double Expenditure { get => expenditure; set => expenditure = value; }
        public string TotalBillString { get => totalBillString; set => totalBillString = value; }
        public int AccountID { get => accountID; set => accountID = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
