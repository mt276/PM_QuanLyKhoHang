using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucSendEmail : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;
        #endregion

        #region "[Default Constructor]"
        public ucSendEmail()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Exits]"
        private void btnExits_Click(object sender, EventArgs e)
        {
            if (clearItem != null)
                clearItem();
        }
        #endregion

        #region "[OK]"
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSend = true;
                lbIsSendEmail.Visible = lbIsPassword.Visible = lbIsRecipient.Visible =  lbIsTitle.Visible = lbIsContent.Visible = false;
                if (txtSendEmail.Text == string.Empty)
                {
                    lbIsSendEmail.Visible = true;
                    ClassUtils.Utils.MessageBoxERROR("Vui lòng nhập Email", "Thông báo");
                    isSend = false;
                    return;
                }
                if (txtPassword.Text == string.Empty)
                {
                    lbIsPassword.Visible = true;
                    ClassUtils.Utils.MessageBoxERROR("Vui lòng nhập Mật khẩu", "Thông báo");
                    isSend = false;
                    return;
                }
                if (txtSupportEmail.Text == string.Empty)
                {
                    lbIsRecipient.Visible = true;
                    ClassUtils.Utils.MessageBoxERROR("Vui lòng nhập Email người nhận", "Thông báo");
                    isSend = false;
                    return;
                }
                if (txtTitle.Text == string.Empty)
                {
                    lbIsTitle.Visible = true;
                    ClassUtils.Utils.MessageBoxERROR("Vui lòng nhập Tiêu đề", "Thông báo");
                    isSend = false;
                    return;
                }
                if (mmedContent.Text == string.Empty)
                {
                    lbIsContent.Visible = true;
                    ClassUtils.Utils.MessageBoxERROR("Vui lòng nhập Nội dung", "Thông báo");
                    isSend = false;
                    return;
                }
                if (isSend == true)
                {
                    string from, to, pass, content, title;
                    from = txtSendEmail.Text.Trim();
                    to = txtSupportEmail.Text.Trim();
                    pass = txtPassword.Text.Trim();
                    title = txtTitle.Text.Trim();
                    content = mmedContent.Text.Trim();

                    MailMessage mail = new MailMessage(from, to, pass, content);
                    //mail.To.Add(to);
                    //mail.From = new MailAddress(from);
                    //mail.Subject = txtTitle.Text.Trim();
                    //mail.Body = mmedContent.Text.Trim();

                    //int flag = cbEmail.SelectedIndex;
                    //string strSmtp = "";
                    //bool SSl = false;
                    //switch (flag)
                    //{
                    //    case 0:
                    //        strSmtp = "smtp.mail.yahoo.com";
                    //        break;
                    //    case 1:
                    //        strSmtp = "smtp.gmail.com";
                    //        SSl = true;
                    //        break;
                    //}

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(mail);
                        ClassUtils.Utils.MessageBoxInfomation("Đã gửi Email thành công", "Thông báo");
                    }
                    catch
                    {
                        ClassUtils.Utils.MessageBoxERROR("Gửi Email thất bại", "Thông báo");
                    }

                    //if (SendEmail(txtSendEmail.Text.Trim() + "@" + cbEmail.Text, txtPassword.Text.Trim(), txtTitle.Text.Trim(), mmedContent.Text.Trim(), txtSupportEmail.Text, cbEmail.SelectedIndex))
                    //{
                    //    ClassUtils.Utils.MessageBoxInfomation("Đã gửi Email thành công", "Thông báo");
                    //}
                    //else
                    //{
                    //    ClassUtils.Utils.MessageBoxERROR("Gửi Email thất bại", "Thông báo");
                    //}
                }
            }
            catch
            {

            }
        }
        #endregion

        #region "[SendEmail]"
        /// <summary>
        /// SendEmail
        /// </summary>
        protected bool SendEmail(string sendEmail, string passWord, string title, string content, string recepient, int flag)
        {
            try
            {
                string strSmtp = "";
                bool SSl = false;
                switch (flag)
                {
                    case 0:
                        strSmtp = "smtp.mail.yahoo.com";
                        break;
                    case 1:
                        strSmtp = " smtp.gmail.com";
                        SSl = true;
                        break;
                }
                using (var client = new SmtpClient(strSmtp, 587))
                {
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new NetworkCredential(sendEmail, passWord);
                    client.EnableSsl = SSl;
                    var mail = new MailMessage();
                    mail.From = new MailAddress(sendEmail);
                    mail.To.Add(recepient);
                    mail.Subject = title;
                    mail.Body = content;
                    client.Send(mail);
                }
            }
            catch
            {

            }
            return true;
            
        }
        #endregion
    }
}
