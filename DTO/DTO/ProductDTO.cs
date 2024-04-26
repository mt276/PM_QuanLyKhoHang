using System;
using System.Data;


namespace DTO.DTO
{
    public class ProductDTO
    {
        public ProductDTO (int id, string name, string dimensions, int unitID, int stock, DateTime startDate, string inputSource, bool del, string note)
        {
            this.ID = id;
            this.Name = name;
            this.Dimensions = dimensions;
            this.UnitID = unitID;
            this.Stock = stock;
            this.StartDate = startDate;
            this.InputSource = inputSource;
            this.Del = del;
            this.Note = note;
        }
        
        public ProductDTO(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.Dimensions = row["dimensions"].ToString();
            this.UnitID = int.Parse(row["unitID"].ToString());
            this.Stock = int.Parse(row["stock"].ToString());
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
            this.InputSource = row["inputSource"].ToString();
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public ProductDTO() { }

        private int id;
        private string name;
        private string dimensions;
        private int unitID;
        private int stock;
        private DateTime startDate;
        private string inputSource;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Dimensions { get => dimensions; set => dimensions = value; }
        public int UnitID { get => unitID; set => unitID = value; }
        public int Stock { get => stock; set => stock = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public string InputSource { get => inputSource; set => inputSource = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
