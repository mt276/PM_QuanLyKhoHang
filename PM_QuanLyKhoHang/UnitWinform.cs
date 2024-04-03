using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang
{
    public partial class UnitWinform : BaseForm
    {
        private Panel pnltxbUnit = new Panel();
        private TextBox txbUnit;
        private bool keyEntered;

        public UnitWinform()
        {
            InitializeComponent();
            SetUptxbUnit();
        }
        void SetUptxbUnit()
        {
            #region pnltxbUnit
            // Tạo pnltxbUnit
            pnltxbUnit.AutoSize = true;
            pnltxbUnit.Size = new Size(this.ClientSize.Width-40, 50);
            pnltxbUnit.Location = new Point(20,10);
            pnltxbUnit.BackColor = Color.White;
            this.Controls.Add(pnltxbUnit);

                #region
                // Thêm txbUsername vào Panel
                txbUnit = new TextBox();
                txbUnit.Size = new Size(200, 30); // Kích thước txbUsername
                txbUnit.Text = "Nhập đơn vị đo";
                txbUnit.ForeColor = Color.DarkGray;
                txbUnit.BorderStyle = BorderStyle.None;
                txbUnit.Location = new Point(50, 20); // Vị trí txbUsername
                pnltxbUnit.Controls.Add(txbUnit);

                // Vẽ đường viền dưới của txbPassword
                Label underlineUsername = new Label();
                underlineUsername.BackColor = Color.Black;
                underlineUsername.Location = new Point(txbUnit.Location.X, txbUnit.Location.Y + txbUnit.Height + 8);
                underlineUsername.Size = new Size(txbUnit.Width, 1);
                pnltxbUnit.Controls.Add(underlineUsername);

                // Gắn sự kiện TextChanged cho txbUsername
                txbUnit.TextChanged += (sender, e) =>
                {
                    txbUnit.ForeColor = Color.Black;
                };
                txbUnit.KeyPress += (sender, e) =>
                {
                    if (!keyEntered)
                    {
                        if (txbUnit.Text == "Nhập đơn vị đo")
                        {
                            // Nếu txbPassword đang chứa văn bản mặc định, xóa văn bản đó khi người dùng bắt đầu nhập
                            txbUnit.Text = "";
                        }
                        keyEntered = true;
                    }
                };
                #endregion
            #endregion
        }
    }
}
