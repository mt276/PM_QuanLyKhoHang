using System.Data;

namespace DTO.ACK
{
    public class BillInfoACK
    {
        public BillInfoACK(int id, int billID, int productID, int count, double importPrice, double salePrice, int vat, double divedend, bool del, string note)
        {
            this.ID = id;
            this.BillID = billID;
            this.ProductID = productID;
            this.Count = count;
            this.ImportPrice = importPrice;
            this.SalePrice = salePrice;
            this.VAT = vat;
            this.Divedend = divedend;
            this.Del = del;
            this.Note = note;
        }

        public BillInfoACK(DataRow row)
        {
            this.ID = int.Parse(row["id"].ToString());
            this.BillID = int.Parse(row["billID"].ToString());
            this.ProductID = int.Parse(row["productID"].ToString());
            this.Count = int.Parse(row["count"].ToString());
            this.ImportPrice = double.Parse(row["importPrice"].ToString());
            this.SalePrice = double.Parse(row["salePrice"].ToString());
            this.VAT = int.Parse(row["vat"].ToString());
            this.Divedend = double.Parse(row["divedend"].ToString());
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }

        public BillInfoACK() { }

        private int id;
        private int billID;
        private int productID;
        private string productName;
        private int count;
        private double importPrice;
        private double salePrice;
        private string salePriceString;
        private int vat;
        private double divedend;
        private string divedendString;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public int BillID { get => billID; set => billID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int Count { get => count; set => count = value; }
        public double ImportPrice { get => importPrice; set => importPrice = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public string SalePriceString { get => salePriceString; set => salePriceString = value; }
        public int VAT { get => vat; set => vat = value; }
        public double Divedend { get => divedend; set => divedend = value; }
        public string DivedendString { get => divedendString; set => divedendString = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
