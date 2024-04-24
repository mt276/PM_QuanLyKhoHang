using BUS.BUS;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        #region "[Default Constructor]"
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Login]"
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //Nếu đăng nhập thành công
                Management.UserLogin = AccountBUS.Login(txtUserName.Text, txtPass.Text);

                //kiểm tra nếu nhân viên này đã bị xóa thì không cho đăng nhập vào hệ thống
                if (Management.UserLogin != null)
                {
                    if (Management.UserLogin.Del)
                        Management.UserLogin = null;
                }

                #region "[RememberLogin]"
                if(Management.UserLogin != null)
                {
                    //Nếu chọn chức năng lưu mật khẩu
                    if (checkRememberLogin.Checked)
                    {
                        Properties.Settings.Default.UserName = txtUserName.Text;
                        Properties.Settings.Default.Password = txtPass.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        //nếu không chọn thì xóa trong bộ nhớ máy tính
                        Properties.Settings.Default.UserName = string.Empty;
                        Properties.Settings.Default.Password = string.Empty;
                        Properties.Settings.Default.Save();
                    }
                    btnCancel_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng\nLiên Hệ với giám đốc để lấy lại mật khẩu hoặc \nxin cấp mới", "Đăng Nhập Thất Bại");
                }
                #endregion
            }
            catch { }
        }
        #endregion

        #region "[Cancel]"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch { }
        }
        #endregion

        #region "[Load]"
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                ShowUserNameAndPass();

            }
            catch { }
        }
        #endregion

        #region "[DisplayRememberLogin]"
        /// <summary>
        /// Hiển thị username và pass word nếu lần trước nhân viên đã chọn chức năng lưu
        /// </summary>
        private void ShowUserNameAndPass()
        {
            try
            {
                checkRememberLogin.Checked = false;
                if (Properties.Settings.Default.UserName != null)
                {
                    if (Properties.Settings.Default.Password != null)
                    {
                        //hiển thị tên đăng nhập
                        txtUserName.Text = Properties.Settings.Default.UserName;
                        txtPass.Text = Properties.Settings.Default.Password;
                        checkRememberLogin.Checked = true;
                    }
                }
            }
            catch { }
        }
        #endregion
    }
}