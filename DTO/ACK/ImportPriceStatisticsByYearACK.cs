using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ACK
{
    public class ImportPriceStatisticsByYearACK
    {
        private int year;
        private List<ImportPriceStatisticsACK> _importPrice = new List<ImportPriceStatisticsACK>();

        public int Year { get => year; set => year = value; }
        public List<ImportPriceStatisticsACK> ImportPrice { get => _importPrice; set => _importPrice = value; }
    }
}
