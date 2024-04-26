using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang.ClassUtils
{
    public class Utils
    {
        #region "[MessageBoxInfomation]"
        /// <summary>
        /// hiện thông báo cho hoạt động thành công
        /// </summary>
        /// <param name="_strMessage">nội dung thông báo</param>
        /// <param name="_strComponent">tiêu đề</param>
        public static DialogResult MessageBoxInfomation(string _strMessage, string _strComponent)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(_strMessage, _strComponent, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region "[MessageBoxERROR]"
        /// <summary>
        /// hiện thông báo cho hoạt động thất bại
        /// </summary>
        /// <param name="_strMessage">nội dung thông báo</param>
        /// <param name="_strComponent">tiêu đề</param>
        public static DialogResult MessageBoxERROR(string _strMessage, string _strComponent)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(_strMessage, _strComponent, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region "[MessageBoxQuestion]"
        /// <summary>
        /// Hiện thông báo hỏi khách hàng
        /// </summary>
        /// <param name="_strMessage">nội dung thông báo</param>
        /// <param name="_strComponent">tiêu đề</param>
        /// <returns></returns>
        public static DialogResult MessageBoxQuestion(string _strMessage, string _strComponent)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(_strMessage, _strComponent, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        #endregion

    }
}
