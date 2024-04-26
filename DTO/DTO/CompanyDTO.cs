using System;
using System.Data;


namespace DTO.DTO
{
    public class CompanyDTO
    {
        public CompanyDTO(int id, string name, string address, string phone, string fax, DateTime startDate, bool del, string note)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Fax = fax;
            this.StartDate = startDate;
            this.Del = del;
            this.Note = note;
        }

        public CompanyDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            this.Fax = row["fax"].ToString();
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public CompanyDTO() { }

        private int id;
        private string name;
        private string address;
        private string phone;
        private string fax;
        private DateTime startDate;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Fax { get => fax; set => fax = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
