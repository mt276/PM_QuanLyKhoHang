using System.Data;

namespace DTO.DTO
{
    public class ReceiveCommissionDTO
    {
        public ReceiveCommissionDTO(int id, string name, string address, string phone, string fax, int typeReferrerID, bool del, string note)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Fax = fax;
            this.TypeReferrerID = typeReferrerID;
            this.Del = del;
            this.Note = note;
        }

        public ReceiveCommissionDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            this.Fax = row["fax"].ToString();
            this.TypeReferrerID = int.Parse(row["typeReferrerID"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public ReceiveCommissionDTO() { }

        private int id;
        private string name;
        private string address;
        private string phone;
        private string fax;
        private int typeReferrerID;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Fax { get => fax; set => fax = value; }
        public int TypeReferrerID { get => typeReferrerID; set => typeReferrerID = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
