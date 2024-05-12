using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ACK
{
    public class ProductPriceStatisticACK
    {
        public ProductPriceStatisticACK(int productID, string productName, double importPrice, double salePrice)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.ImportPrice = importPrice;
            this.SalePrice = salePrice;
        }

        public ProductPriceStatisticACK(DataRow row)
        {
            this.ProductID = int.Parse(row["productID"].ToString());
            this.ProductName = row["productName"].ToString();
            this.ImportPrice = double.Parse(row["importPrice"].ToString());
            this.SalePrice = double.Parse(row["salePrice"].ToString());
        }

        public ProductPriceStatisticACK()
        {
        }

        private int productID;
        private string productName;
        private double importPrice;
        private string importPriceString;
        private double salePrice;
        private string salePriceString;

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double ImportPrice { get => importPrice; set => importPrice = value; }
        public string ImportPriceString { get => importPriceString; set => importPriceString = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public string SalePriceString { get => salePriceString; set => salePriceString = value; }
    }
}
