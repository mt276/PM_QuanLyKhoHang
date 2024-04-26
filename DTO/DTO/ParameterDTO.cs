using System.Data;

namespace DTO.DTO
{
    public class ParameterDTO
    {
        public ParameterDTO(int id, int productID, int value, bool del, string note)
        {
            this.ID = id;
            this.ProductID = productID;
            this.Value = value;
            this.Del = del;
            this.Note = note;
        }

        public ParameterDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.ProductID = int.Parse(row["productID"].ToString());
            this.Value = int.Parse(row["value"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public ParameterDTO() { }

        private int id;
        private int productID;
        private string productName;
        private string configure;
        private int value;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Configure { get => configure; set => configure = value; }
        public int Value { get => value; set => this.value = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
