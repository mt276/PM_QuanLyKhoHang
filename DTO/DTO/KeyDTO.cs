using System.Data;


namespace DTO.DTO
{
    public class KeyDTO
    {
        public KeyDTO(int id, string timeDateLine, bool del)
        {
            this.ID = id;
            this.TimeDateLine = timeDateLine;
            this.Del = del;
        }
        public KeyDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.TimeDateLine = row["timeDateLine"].ToString();
            this.Del = bool.Parse(row["del"].ToString());
        }

        public KeyDTO() { }

        private int id;
        private string timeDateLine;
        private bool del;

        public int ID { get => id; set => id = value; }
        public string TimeDateLine { get => timeDateLine; set => timeDateLine = value; }
        public bool Del { get => del; set => del = value; }
    }
}
