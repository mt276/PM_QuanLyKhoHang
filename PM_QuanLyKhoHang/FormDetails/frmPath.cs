using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.FormDetails
{
    public partial class frmPath : DevExpress.XtraEditors.XtraForm
    {
        public frmPath()
        {
            InitializeComponent();
        }
        string strBillName = string.Empty;
        public frmPath(string _strTenHoaDon)
        {
            InitializeComponent();
            strBillName = _strTenHoaDon;
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Program.strPath = txtPath.Text.Trim();
                this.Close();
            }
            catch { }
        }

        private void txtPath_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                //save.Filter = "File Excel|*.xls|*.xlsx";
                if (strBillName == string.Empty)
                {
                    strBillName = "Chi tiết hóa đơn " + DateTime.Now.ToString("dd.MM.yyyy");
                }
                save.FileName = strBillName.Trim() + ".xls";
                DialogResult result = save.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    txtPath.Text = save.FileName;
                }
            }
            catch { }

        }
    }
}