using DTO.DTO;
using System;
using System.Collections.Generic;
using BUS.BUS;
using System.Windows.Forms;
using System.Linq;

namespace PM_QuanLyKhoHang.UserControlDetails
{
    public partial class ucCreateBill : UserControl
    {
        #region "[Declare Global Variable]"
        public DelegateClearItem clearItem = null;

        private int _iID = -1;
        #endregion

        #region "[Default Constructor]"
        public ucCreateBill()
        {
            InitializeComponent();
        }
        #endregion

        #region "[Insert ReceiveCommission]"
        private void hplReceiveCommission_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            try
            {
                ucAddReferrer uc = new ucAddReferrer();
                uc.InsertAR += Uc_Insert;
                uc.UpdateAR += Uc_Update;
                uc.DeleteAR += Uc_Delete;
                uc.Show();
            }
            catch { }
        }

        private void Uc_Delete(object sender, EventArgs e)
        {
            //LoadTypeReferrerIntoCombobox(cbTypeReferrer);
        }

        private void Uc_Update(object sender, EventArgs e)
        {
            //LoadTypeReferrerIntoCombobox(cbTypeReferrer);
        }

        private void Uc_Insert(object sender, EventArgs e)
        {
            //LoadTypeReferrerIntoCombobox(cbTypeReferrer);
        }
        #endregion

        #region "[LoadListCreateBill]"
        private void LoadListCreateBill()
        {
            try
            {
                List<BillDTO> list = BillBUS.GetAll().OrderByDescending(p=>p.StartDate).ToList();
                if (list.Count > 0)
                    dtgvCreateBill.DataSource = list;
                dtgvCreateBill.RefreshDataSource();
            }
            catch { }
        }

        #endregion

        #region "[Load]"
        private void ucAddProducts_Load(object sender, EventArgs e)
        {
            LoadListCreateBill();

            //LoadUnitIntoCombobox(cbUnit);

            //EnableButton(true);

            #region "[Gridview selection is not allowed]"
            gvCreateBill.OptionsBehavior.Editable = gvCreateBill.OptionsSelection.EnableAppearanceFocusedCell = false;
            #endregion
        }
        #endregion

        #region "[CreateBill]"
        private void btnCreateBill_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "[Delete]"
        private void btnDelete_Click(object sender, EventArgs e)
        {

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


        #region "[Ordinal number]"
        private void gvCreateBill_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSTT")
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch { }
        }
        #endregion

        private void gvCreateBill_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }


        //#region "[EnableButton]"
        ///// <summary>
        ///// Kích hoạt Button 
        ///// </summary>
        ///// <param name="_Flag"></param>
        //private void EnableButton(bool _Flag)
        //{
        //    try
        //    {
        //        btnDelete.Enabled = btnUpdate.Enabled = !_Flag;
        //        btnAdd.Enabled = _Flag;
        //    }
        //    catch { }
        //}
        //#endregion

        //#region "[Clear data in control input]"
        ///// <summary>
        ///// clear data in control input
        ///// </summary>
        //private void ClearData()
        //{
        //    try
        //    {
        //        EnableButton(true);
        //        txtProductName.Text = txtInputSource.Text = mmedDimensions.Text = mmedNote.Text = string.Empty;
        //        dtpkStartDate.Enabled = true;

        //    }
        //    catch { }
        //}
        //#endregion

        //#region "[Get information in one line]"

        //private void gvAddProducts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    try
        //    {
        //        ProductDTO product = (ProductDTO)gvAddProducts.GetRow(e.RowHandle);
        //        if (product != null)
        //        {
        //            _iID = product.ID;
        //            LoadInfomation(product);
        //            EnableButton(false);
        //            cbUnit.SelectedValue = product.UnitID;
        //            dtpkStartDate.Enabled = false;
        //        }
        //    }
        //    catch { }
        //}
        //#endregion

        //#region "[Get information and display it on input controls]"
        ///// <summary>
        ///// Lấy thông tin và hiển thị lên các control nhập liệu
        ///// </summary>
        ///// <param name="product"></param>
        //private void LoadInfomation(ProductDTO product)
        //{
        //    try
        //    {
        //        txtProductName.Text = product.Name;
        //        txtInputSource.Text = product.InputSource;
        //        mmedDimensions.Text = product.Dimensions;
        //        mmedNote.Text = product.Note;
        //        dtpkStartDate.Value = product.StartDate;

        //    }
        //    catch { }
        //}
        //private void LoadUnitIntoCombobox(ComboBox cb)
        //{
        //    cb.DataSource = UnitBUS.GetAll();
        //    cb.DisplayMember = "Name";
        //    cb.ValueMember = "ID";
        //}
        //#endregion
    }
}
