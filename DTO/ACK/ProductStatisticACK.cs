using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ACK
{
    public class ProductStatisticACK
    {
        private string productName;
        private int sellNumber;
        private DateTime startDate;

        public string ProductName { get => productName; set => productName = value; }
        public int SellNumber { get => sellNumber; set => sellNumber = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
    }
}
