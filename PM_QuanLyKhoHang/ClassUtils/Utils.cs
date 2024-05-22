using System;
using DTO.DTO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.BUS;

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

        #region "[GetListColor]"
        /// <summary>
        /// lấy danh sách các màu
        /// </summary>
        /// <returns></returns>
        public static List<Color> GetListColor()
        {
            List<Color> listTemp = new List<Color>();
            try
            {
                listTemp.Add(Color.Blue);
                listTemp.Add(Color.Red);
                listTemp.Add(Color.Orange);
                listTemp.Add(Color.Yellow);
                listTemp.Add(Color.Violet);
                listTemp.Add(Color.YellowGreen);
                listTemp.Add(Color.SeaGreen);
                listTemp.Add(Color.Pink);
                listTemp.Add(Color.SlateBlue);
                listTemp.Add(Color.Orchid);
            }
            catch { }
            return listTemp;
        }
        #endregion

        #region "[UpdateRulesApplication]"
        /// <summary>
        /// cập nhật quyền trong hệ thống
        /// </summary>
        /// <returns></returns>
        public static bool UpdateRulesApplication()
        {
            bool isSuccess = false;
            try
            {
                //danh sách các quyền trong hệ thống.
                List<string> listRules = new List<string>();

                #region "[[istRules]"
                listRules.Add("Decentralization");
                listRules.Add("Sell");
                listRules.Add("Warehouse");
                listRules.Add("WarehouseManagement");
                listRules.Add("PriceUpdate");
                listRules.Add("AddCustomer");
                listRules.Add("ListCustomer");
                listRules.Add("AddReferrer");
                listRules.Add("AddProduct");
                listRules.Add("ListProduct");
                listRules.Add("AddTypeReferrer");
                listRules.Add("UpdateSystem");
                listRules.Add("SendEmail");
                listRules.Add("Statistics");
                listRules.Add("ProductSell");
                listRules.Add("ProductPriceStatistics");
                listRules.Add("ProductPriceChart");
                listRules.Add("DebtStatistics");
                listRules.Add("BillStatistics");
                listRules.Add("InputReport");
                #endregion

                //kiểm tra bảng quyền thao tác
                List<TypeActDTO> listTemp = TypeActBUS.GetAll().Where(p => p.Del == false).ToList();
                int count = listTemp.Count;
                if (count > 0)
                {
                    if (count < listRules.Count)
                    {
                        //tìm những luật mới add vào
                        foreach (string sItem in listRules)
                        {

                            if (!CheckStringExistInArray(sItem, listTemp))
                            {
                                InsertRules(sItem);
                            }
                        }
                    }
                }
                else if (count == 0)
                {
                    //add tất cả các luật vào.
                    foreach (string sItem in listRules)
                    {
                        InsertRules(sItem);
                    }
                }

                isSuccess = true;

            }
            catch { }
            return isSuccess;
        }

        private static int InsertRules(string sItem)
        {
            int iResult = -1;
            try
            {
                TypeActDTO insert = new TypeActDTO
                {
                    Name = sItem,
                    Del = false,
                    Note = string.Empty
                };

                return TypeActBUS.Insert(insert);
            }
            catch { }
            return iResult;
        }
        #endregion

        #region "[SelectUniKeyRulesName]"
        /// <summary>
        /// Lấy tên quyền tương ứng bằng tiếng việt có dấu
        /// </summary>
        /// <param name="_iID"></param>
        /// <returns></returns>
        public static string SelectUniKeyRulesName(int _iID)
        {
            string strResult = string.Empty;
            try
            {
                //danh sách các quyền trong hệ thống.
                List<string> listRules = new List<string>();

                #region "ListRules"
                listRules.Add("Phân Quyền");
                listRules.Add("Bán Hàng");
                listRules.Add("Nhập Kho");
                listRules.Add("Quản Lý Kho Hàng");
                listRules.Add("Cập Nhật Giá Bán");
                listRules.Add("Thêm Khách Hàng");
                listRules.Add("Danh Sách Khách Hàng");
                listRules.Add("Thêm Người Giới Thiệu");
                listRules.Add("Thêm Sản Phẩm");
                listRules.Add("Danh Sách Sản Phẩm");
                listRules.Add("Thêm Loại Người Giới Thiệu");
                listRules.Add("Cập Nhật Hệ Thống");
                listRules.Add("Gởi Email");
                listRules.Add("Thống Kê");
                listRules.Add("Các Sản Phẩm Đã Bán");
                listRules.Add("Thống Kê Giá Sản Phẩm");
                listRules.Add("Biểu Đồ Thể Hiện Giá Sản Phẩm");
                listRules.Add("Thống Kê Công Nợ");
                listRules.Add("Thống Kê Hóa Đơn Bán Hàng");
                listRules.Add("Báo Cáo Nhập Kho");
                #endregion
                strResult = listRules[_iID - 1];

            }
            catch { }
            return strResult;
        }
        #endregion

        #region "[CheckStringExistInArray]"
        /// <summary>
        /// Kiểm tra chuỗi có tồn tại trong mảng QuyenThaoTacDTO hay không
        /// </summary>
        /// <param name="_strInput"></param>
        /// <param name="_list"></param>
        /// <returns></returns>
        private static bool CheckStringExistInArray(string _strInput, List<TypeActDTO> _list)
        {
            bool isSuccess = false;
            try
            {
                foreach (TypeActDTO item in _list)
                {
                    if (item.Name.Trim() == _strInput.Trim())
                        return true;
                }
            }
            catch { }
            return isSuccess;
        }
        #endregion

    }
}
