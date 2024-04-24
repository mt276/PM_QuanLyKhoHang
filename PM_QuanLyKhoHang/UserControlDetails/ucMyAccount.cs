using BUS.BUS;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucMyAccount : UserControl
    {
        public delegate void DelegateClearItem();
        public DelegateClearItem clearItem = null;


        #region "[Default Constructor]"
        public ucMyAccount()
        {
            InitializeComponent();
        }

        #endregion

        #region "[Load Picterbox]"
        /// <summary>
        /// Lấy hình đại diện load lên control picturebox
        /// </summary>
        private void LoadImageAvatar()
        {
            try
            {
                string strUrl = null;
                try
                {
                    strUrl = Properties.Settings.Default.LocationImageUser;
                }
                catch { }
                if (strUrl != null)
                {
                    Image img = Image.FromFile(strUrl);
                    ptbMyAccount.Image = img;
                }
            }
            catch { }
        }
        #endregion

        #region "[Get Image Path]"
        private void txtLocation_DoubleClick(object sender, EventArgs e)
        {
            btnBrowse_Click(null, null);
        }
        #endregion

        #region  "[Click the Browse Button to Get Image Path]"
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg, *.jpeg, *.png, *.gif, *.bmp, *.ico)|*.jpg; *.jpeg; *.png; *.gif; *.bmp; *.ico|All files (*.*)|*.*";
                open.FilterIndex = 1;
                open.RestoreDirectory = true;
                DialogResult result = open.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Properties.Settings.Default.LocationImageUser = open.FileName;

                    //load hình ảnh lên picturebox
                    ptbMyAccount.Image = Image.FromFile(Properties.Settings.Default.LocationImageUser);

                    Properties.Settings.Default.Save();
                }
            }
            catch { }
        }
        #endregion

        #region "[UpdatePass]"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra mật khẩu có đúng với user này không
                if (Management.UserLogin.Password.Trim() == txtOldPass.Text.Trim())
                {
                    //Kiểm tra hai mật khẩu mới có giống nhau không
                    if(txtNewPass.Text.Trim() == txtRePass.Text.Trim())
                    {
                        //Cập nhật mật khẩu mới
                        lblsOldPass.Visible = lblsNewPass.Visible = lblsRePass.Visible = false;
                        Management.UserLogin.Password = txtNewPass.Text.Trim();
                        bool isSuccess = AccountBUS.Update(Management.UserLogin);
                        if (isSuccess)
                        {
                            Properties.Settings.Default.Password = string.Empty;
                            Properties.Settings.Default.Save();
                            MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
                            return;
                        }
                    }
                    else
                    {
                        lblsNewPass.Visible = lblsRePass.Visible = true;
                        MessageBox.Show("Mật khẩu mới vừa thay đổi không giống nhau", "Thông báo");
                        return;
                    }
                }
                else
                {
                    lblsOldPass.Visible = true;
                    MessageBox.Show("Mật khẩu không đúng. Xin Nhập lại", "Thông báo");
                    return;
                }
            }
            catch { }
        }
        #endregion

        #region "[Cancel]"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControlInput();
            }
            catch { }
        }
        private void ClearControlInput()
        {
            try
            {
                txtOldPass.Text = txtNewPass.Text = txtRePass.Text = string.Empty;
            }
            catch { }
        }

        #endregion

        #region "[Load]"
        private void ucMyAccount_Load(object sender, EventArgs e)
        {
            try
            {
                //load hình ảnh
                ptbMyAccount.Image = Image.FromFile(Properties.Settings.Default.LocationImageUser);

                lblsOldPass.Visible = lblsNewPass.Visible = lblsRePass.Visible = true;
                //load thông tin lên các label.
                if (Management.UserLogin != null)
                    LoadInfomationInLabelControl(Management.UserLogin);
            }
            catch { }
        }
        #endregion

        #region "[MyAccountInfo]"
        /// <summary>
        /// Load các thông tin lên các control
        /// </summary>
        /// <param name="AccountDTO"></param>
        private void LoadInfomationInLabelControl(AccountDTO _accountItem)
        {
            try
            {
                lbFullName.Text += " " + _accountItem.FullName;
                lbAddress.Text += " " + _accountItem.Address;
                lbTypeID.Text += " " + TypeAccountBUS.SelectPrimaryKey(_accountItem.TypeID).Name;
                lbUserName.Text += " " + _accountItem.UserName;
            }
            catch { }
        }
        #endregion 

        #region "[Exits]"
        private void btnExits_Click(object sender, EventArgs e)
        {
            try
            {
                if (clearItem != null)
                    clearItem();
            }
            catch { }
        }
        #endregion
    }
}
