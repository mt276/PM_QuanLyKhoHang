using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ACK
{
    public class ImportPriceStatisticsACK
    {
        private int month;
        private double valueAVG;

        /// <summary>
        /// Giá nhập trong 1 tháng
        /// </summary>
        public int Month { get => month; set => month = value; }

        /// <summary>
        /// Giá nhập trung bình trong 1 tháng
        /// </summary>
        public double ValueAVG { get => valueAVG; set => valueAVG = value; }
    }
}
