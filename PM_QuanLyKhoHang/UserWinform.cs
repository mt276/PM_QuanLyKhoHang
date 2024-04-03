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
    public partial class UserWinform : BaseForm
    {
        private Panel pnlUser;
        private TextBox txbUsername;
        private TextBox txbPassword;
        private Button btnLogin;
        private Button btnCancel;
        private bool usernameEntered;
        private bool passwordEntered;

        public UserWinform()
        {
            InitializeComponent();
            this.Icon = new Icon(Application.StartupPath+@"\\icon\\login.ico"); // Đặt biểu tượng cho form
            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\image\\BackgroundImageLogin.jpg"); // Đặt hình ảnh nền cho form
            LoginForm();
        }
        void LoginForm()
        {
            #region Panel
            // Khởi tạo và cấu hình Panel
            pnlUser = new Panel();
            pnlUser.Size = new Size(300, 150);
            pnlUser.BackColor = Color.FromArgb(180, 240, 240, 240); // Màu nền có độ mờ

            // Tính toán vị trí để đặt Panel vào giữa form
            pnlUser.Location = new Point((this.ClientSize.Width - pnlUser.Width) / 2,
                                                               (this.ClientSize.Height - pnlUser.Height) / 2);

            // Thêm Panel vào Form
            this.Controls.Add(pnlUser);
            #endregion

            #region txbUsername
            // Thêm txbUsername vào Panel
            txbUsername = new TextBox();
            txbUsername.Size = new Size(200, 20); // Kích thước txbUsername
            txbUsername.Text = "Tên đăng nhập";
            txbUsername.ForeColor = Color.DarkGray;
            txbUsername.BorderStyle = BorderStyle.None;
            txbUsername.Location = new Point(50, 30); // Vị trí txbUsername
            pnlUser.Controls.Add(txbUsername);

            // Vẽ đường viền dưới của txbPassword
            Label underlineUsername = new Label();
            underlineUsername.BackColor = Color.Black;
            underlineUsername.Location = new Point(txbUsername.Location.X, txbUsername.Location.Y + txbUsername.Height + 5);
            underlineUsername.Size = new Size(txbUsername.Width, 1);
            pnlUser.Controls.Add(underlineUsername);

            // Gắn sự kiện TextChanged cho txbUsername
            txbUsername.TextChanged += (sender, e) =>
            {
                txbUsername.ForeColor = Color.Black;
            };
            txbUsername.KeyPress += (sender, e) =>
            {
                if (!usernameEntered)
                {
                    if (txbUsername.Text == "Tên đăng nhập")
                    {
                        // Nếu txbPassword đang chứa văn bản mặc định, xóa văn bản đó khi người dùng bắt đầu nhập
                        txbUsername.Text = "";
                    }
                    usernameEntered = true;
                }
            };
            #endregion

            # region txbPassword
            // Thêm txbPassword vào Panel
            txbPassword = new TextBox();
            txbPassword.Size = new Size(200, 20); // Kích thước txbPassword 
            txbPassword.Text = "Mật khẩu";
            txbPassword.ForeColor = Color.DarkGray;
            txbPassword.BorderStyle = BorderStyle.None;
            txbPassword.Location = new Point(50, 70); // Vị trí txbPassword
            pnlUser.Controls.Add(txbPassword);

            // Vẽ đường viền dưới của txbPassword
            Label underlineTxbPassword = new Label();
            underlineTxbPassword.BackColor = Color.Black;
            underlineTxbPassword.Location = new Point(txbPassword.Location.X, txbPassword.Location.Y + txbPassword.Height+5);
            underlineTxbPassword.Size = new Size(txbPassword.Width, 1);
            pnlUser.Controls.Add(underlineTxbPassword);

            // Gắn sự kiện TextChanged ch0 txbPassword
            txbPassword.TextChanged += (sender, e) =>
            {
                txbPassword.ForeColor = Color.Black; // Đặt màu văn bản về đen
                txbPassword.PasswordChar = '*'; // Thiết lập PasswordChar
            };

            txbPassword.KeyPress += (sender, e) =>
            {
                if (!passwordEntered)
                {
                    if (txbPassword.Text == "Mật khẩu")
                    {
                        // Nếu txbPassword đang chứa văn bản mặc định, xóa văn bản đó khi người dùng bắt đầu nhập
                        txbPassword.Text = "";
                    }
                    passwordEntered = true;
                }
            };
            #endregion

            #region btnLogin
            // Tạo Button để đăng nhập
            btnLogin = new Button();
            btnLogin.Text = "Đăng nhập";
            btnLogin.Location = new Point(60, 110);
            btnLogin.Size = new Size(70, 30);
            btnLogin.BackColor = Color.MediumSlateBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0; //loại bỏ đường viền
            pnlUser.Controls.Add(btnLogin);
            // Gắn sự kiện Click chp btnLogin
            btnLogin.Click += (sender, e) =>
            {
                string username = txbUsername.Text;
                string password = txbPassword.Text;

                // Thực hiện xử lý đăng nhập ở đây, ví dụ:
                if (username == "admin" && password == "password")
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng!");
                }
            };
            #endregion

            #region btnCancel
            // Tạo Button để hủy bỏ
            btnCancel = new Button();
            btnCancel.Text = "Thoát";
            btnCancel.Location = new Point(165, 110);
            btnCancel.Size = new Size(70, 30);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.BackColor = Color.DarkRed;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0; //loại bỏ đường viền
            pnlUser.Controls.Add(btnCancel);
            // Gắn sự kiện Click chp btnCancel
            btnCancel.Click += (sender, e) =>
            {
                // Thực hiện xử lý hủy bỏ ở đây, ví dụ:
                this.Close(); // Đóng form
            };
            #endregion
        }
    }
}
