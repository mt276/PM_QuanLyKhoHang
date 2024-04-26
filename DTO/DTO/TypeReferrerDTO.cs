using System;
using System.Data;

namespace DTO.DTO
{
    public class TypeReferrerDTO
    {
        public TypeReferrerDTO(int id, string name, DateTime startDate, bool del, string note)
        {
            this.ID = id;
            this.Name = name;
            this.StartDate = startDate;
            this.Del = del;
            this.Note = note;
        }

        public TypeReferrerDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public TypeReferrerDTO() { }

        private int id;
        private string name;
        private DateTime startDate;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
