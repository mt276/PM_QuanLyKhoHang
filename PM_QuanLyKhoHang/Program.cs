using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang
{
    static class Program
    {
        /// <summary>
        /// đường dẫn backup dữ liệu
        /// </summary>
        public static string strPath = string.Empty;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Management());
            //Application.Run(new FormDetails.frmUnit());
        }

    }
} 
