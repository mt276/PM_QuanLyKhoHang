using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Utils
{
    public class EnumClassDetails
    {
        public enum TypeImportPriceStatistics
        {
            ByDate,
            ByMonth,
            ByYear,
            Period,
            NULL
        }
        public static TypeImportPriceStatistics GetTypeImportPrice(int _iType)
        {
            TypeImportPriceStatistics item = TypeImportPriceStatistics.NULL;
            try
            {
                switch (_iType)
                {
                    case -1:
                        item = TypeImportPriceStatistics.ByDate;
                        break;
                    case 0:
                        item = TypeImportPriceStatistics.ByMonth;
                        break;
                    case 1:
                        item = TypeImportPriceStatistics.ByYear;
                        break;
                    case 2:
                        item = TypeImportPriceStatistics.Period;
                        break;
                }
            }
            catch { }
            return item;
        }
    }
}
