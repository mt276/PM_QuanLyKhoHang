using System.Data;


namespace DTO.DTO
{
    public class DecentralizationDTO
    {
        public DecentralizationDTO(int id, int accountID, int typeActID, bool del)
        {
            this.ID = id;
            this.AccountID = accountID;
            this.TypeActID = typeActID;
            this.Del = del;
        }
        public DecentralizationDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.AccountID = int.Parse(row["accountID"].ToString());
            this.TypeActID = int.Parse(row["typeActID"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
        }
        public DecentralizationDTO() { }

        private int id;
        private int accountID;
        private int typeActID;
        private bool del;

        public int ID { get => id; set => id = value; }
        public int AccountID { get => accountID; set => accountID = value; }
        public int TypeActID { get => typeActID; set => typeActID = value; }
        public bool Del { get => del; set => del = value; }
    }
}
