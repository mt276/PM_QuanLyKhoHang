using System.Data;

namespace DTO.DTO
{
    public class SystemErrorDTO
    {
        public SystemErrorDTO(int id, string nameErr, string nameFn, bool del, string note)
        {
            this.ID = id;
            this.NameErr = nameErr;
            this.NameFn = nameFn;
            this.Del = del;
            this.Note = note;
        }

        public SystemErrorDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.NameErr = row["nameErr"].ToString();
            this.NameFn = row["nameFn"].ToString();
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public SystemErrorDTO() { }

        private int id;
        private string nameErr;
        private string nameFn;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public string NameErr { get => nameErr; set => nameErr = value; }
        public string NameFn { get => nameFn; set => nameFn = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
