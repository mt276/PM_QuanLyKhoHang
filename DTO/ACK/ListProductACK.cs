using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ACK
{
    public class ListProductACK
    {
        public ListProductACK(string name, string dimensions, int count, int vat, double salePrice, string note, DateTime startDate)
        {
            this.Name = name;
            this.Dimensions = dimensions;
            this.Count = count;
            this.VAT = vat;
            this.SalePrice = salePrice;
            this.Note = note;
            this.StartDate = startDate;
        }

        public ListProductACK(DataRow row)
        {
            this.Name = row["Name"].ToString();
            this.Dimensions = row["Dimensions"].ToString();
            this.Count = int.Parse(row["Count"].ToString());
            this.VAT = int.Parse(row["vat"].ToString());
            this.SalePrice = double.Parse(row["SalePrice"].ToString());
            this.Note = row["note"].ToString();
            this.StartDate = DateTime.Parse(row["startDate"].ToString());
        }

        public ListProductACK() { }

        private string name;
        private string dimensions;
        private int count;
        private int vat;
        private double salePrice;
        private string salePriceString;
        private DateTime startDate;
        private string note;

        public string Name { get => name; set => name = value; }
        public string Dimensions { get => dimensions; set => dimensions = value; }
        public int Count { get => count; set => count = value; }
        public int VAT { get => vat; set => vat = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public string SalePriceString { get => salePriceString; set => salePriceString = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public string Note { get => note; set => note = value; }
    }
}
