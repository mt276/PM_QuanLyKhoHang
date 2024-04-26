using System;
using System.Data;

namespace DTO.DTO
{
    public class RepresentativeDTO
    {
        public RepresentativeDTO(int id, string name, string phone, int companyID, DateTime startDate, bool del, string note)
        {
            this.ID = id;
            this.Name = name;
            this.Phone = phone;
            this.CompanyID = companyID;
            this.StartDate = startDate;
            this.Del = del;
            this.Note = note;
        }

        public RepresentativeDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.Phone = row["phone"].ToString();
            this.CompanyID = int.Parse(row["companyID"].ToString());
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public RepresentativeDTO() { }

        private int id;
        private string name;
        private string phone;
        private int companyID;
        private DateTime startDate;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int CompanyID { get => companyID; set => companyID = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
