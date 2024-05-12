using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.FormDetails
{
    public partial class frmLocation : DevExpress.XtraEditors.XtraForm
    {
        #region "[Declare Global Variable]"
        /// <summary>
        /// đường dẫn đến CSDL
        /// </summary>
        private string strConnection = "";
        #endregion

        #region "[Default Constructor]"
        public frmLocation()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Load]"
        private void frmLocation_Load(object sender, EventArgs e)
        {
            try
            {
                rdwindows.Checked = true;
                SetStateControlWhileChosenRadibutton(rdwindows.Checked);
            }
            catch { }
        }
        #endregion

        #region "[Check]"
        private void SetStateControlWhileChosenRadibutton(bool _isFlag)
        {
            try
            {
                txtUserName.Enabled = txtPassword.Enabled = !_isFlag;
            }
            catch { }
        }

        private void rdwindows_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetStateControlWhileChosenRadibutton(true);
            }
            catch { }
        }

        private void rdSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetStateControlWhileChosenRadibutton(false);
            }
            catch { }
        }

        #endregion

        #region "[Test Connection]"
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (txtSeverName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Server Name Don't Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (strConnection != null)
                MessageBox.Show("Test conection Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Test conection Fail", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region "[Refresh]"
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSeverName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Server Name Don't Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //lấy tên server name và user name , mật khẩu.
                string strServerName = txtSeverName.Text.Trim();
                string strUserName = txtUserName.Text.Trim();
                string strPassword = txtPassword.Text.Trim();
                List<string> listDatabaseName = new List<string>();


                if (rdSqlServer.Checked)
                    strConnection = "server=" + strServerName + ";uid=" + strUserName + ";pwd=" + strPassword;

                if (rdwindows.Checked)
                    strConnection = @"Server=" + strServerName + ";Integrated Security=SSPI;";

                SqlConnection SqlCon = new SqlConnection(strConnection);
                SqlCon.Open();


                SqlCommand SqlCom = new SqlCommand("SELECT name FROM sys.databases", SqlCon);

                SqlDataReader SqlDR;
                SqlDR = SqlCom.ExecuteReader();

                while (SqlDR.Read())
                {
                    listDatabaseName.Add(SqlDR["name"].ToString());
                }

                //load danh sách các database name lên combobox
                cbDatabaseName.DataSource = listDatabaseName;

            }
            catch {}
        }
        #endregion

        #region "[OK]"
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy thông tin tên database.
                string nameDatabase = cbDatabaseName.SelectedItem.ToString();
                strConnection = strConnection + ";database=" + nameDatabase;
                //thực hiện cấu hình đường dẫn vào file text.


                //ghi file text = 
                //ClassUtils.Utils.WriteFileText( strConnection);
                Properties.Settings.Default.LocationSqlserver = strConnection;
                Properties.Settings.Default.Save();
                ClassUtils.Utils.MessageBoxInfomation("Đã cập nhật đường dẫn đến CSDL\r\nHãy thoát khỏi hệ thống để chương trình hoạt động tốt hơn\r\n\r\nXin Cám Ơn!", "Thông Báo");
                this.Close();

            }
            catch { }
        }
        #endregion

        #region "[Cancel]"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        #endregion
    }
}