using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QuanLyKhoHang.ClassUtils
{
    public class TimeInfo
    {
        private DateTime dateInfo;
        private int id;
        private string name;

        public DateTime DateInfo { get => dateInfo; set => dateInfo = value; }
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
