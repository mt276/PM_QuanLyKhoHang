using System;
using System.Data;


namespace DTO.DTO
{
    public class PaymentInfoDTO
    {
        public PaymentInfoDTO(int id, int billID, double payment, DateTime startDate, DateTime startNextDate, bool del, string note) 
        {
            this.ID = id;
            this.BillID = billID;
            this.Payment = payment;
            this.StartDate = startDate;
            this.StartNextDate = startNextDate;
            this.Del = del;
            this.Note = note;
        }

        public PaymentInfoDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.BillID = int.Parse(row["billID"].ToString());
            this.Payment = double.Parse(row["payment"].ToString());
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.StartNextDate = DateTime.Parse(row["startNextDate"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public PaymentInfoDTO() { }

        private int id;
        private int billID;
        private double payment;
        private string paymentString;
        private DateTime startDate;
        private DateTime startNextDate;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public int BillID { get => billID; set => billID = value; }
        public double Payment { get => payment; set => payment = value; }
        public string PaymentString { get => paymentString; set => paymentString = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime StartNextDate { get => startNextDate; set => startNextDate = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
