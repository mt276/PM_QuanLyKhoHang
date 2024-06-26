﻿namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucSalePrice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gcPriceUpdate = new DevExpress.XtraEditors.GroupControl();
            this.spccPriceUpdate = new DevExpress.XtraEditors.SplitContainerControl();
            this.dtgvProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lbAccountName = new DevExpress.XtraEditors.LabelControl();
            this.btnExits = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdatePrice = new DevExpress.XtraEditors.SimpleButton();
            this.lbUpdateDate = new DevExpress.XtraEditors.LabelControl();
            this.txtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.lbSalePrice = new DevExpress.XtraEditors.LabelControl();
            this.lbImportPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbStartDate = new DevExpress.XtraEditors.LabelControl();
            this.lbCount = new DevExpress.XtraEditors.LabelControl();
            this.lbProductName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcPriceUpdate)).BeginInit();
            this.gcPriceUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccPriceUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccPriceUpdate.Panel1)).BeginInit();
            this.spccPriceUpdate.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccPriceUpdate.Panel2)).BeginInit();
            this.spccPriceUpdate.Panel2.SuspendLayout();
            this.spccPriceUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPriceUpdate
            // 
            this.gcPriceUpdate.Controls.Add(this.spccPriceUpdate);
            this.gcPriceUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPriceUpdate.Location = new System.Drawing.Point(0, 0);
            this.gcPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcPriceUpdate.Name = "gcPriceUpdate";
            this.gcPriceUpdate.Size = new System.Drawing.Size(1138, 509);
            this.gcPriceUpdate.TabIndex = 0;
            this.gcPriceUpdate.Text = "Cập nhật giá bán cho sản phẩm";
            // 
            // spccPriceUpdate
            // 
            this.spccPriceUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spccPriceUpdate.Location = new System.Drawing.Point(2, 34);
            this.spccPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccPriceUpdate.Name = "spccPriceUpdate";
            // 
            // spccPriceUpdate.Panel1
            // 
            this.spccPriceUpdate.Panel1.Controls.Add(this.dtgvProduct);
            this.spccPriceUpdate.Panel1.Text = "Panel1";
            // 
            // spccPriceUpdate.Panel2
            // 
            this.spccPriceUpdate.Panel2.Controls.Add(this.btnAdd);
            this.spccPriceUpdate.Panel2.Controls.Add(this.lbAccountName);
            this.spccPriceUpdate.Panel2.Controls.Add(this.btnExits);
            this.spccPriceUpdate.Panel2.Controls.Add(this.btnCancel);
            this.spccPriceUpdate.Panel2.Controls.Add(this.btnUpdatePrice);
            this.spccPriceUpdate.Panel2.Controls.Add(this.lbUpdateDate);
            this.spccPriceUpdate.Panel2.Controls.Add(this.txtSalePrice);
            this.spccPriceUpdate.Panel2.Controls.Add(this.lbSalePrice);
            this.spccPriceUpdate.Panel2.Controls.Add(this.lbImportPrice);
            this.spccPriceUpdate.Panel2.Controls.Add(this.lbStartDate);
            this.spccPriceUpdate.Panel2.Controls.Add(this.lbCount);
            this.spccPriceUpdate.Panel2.Controls.Add(this.lbProductName);
            this.spccPriceUpdate.Panel2.Text = "Panel2";
            this.spccPriceUpdate.Size = new System.Drawing.Size(1134, 473);
            this.spccPriceUpdate.SplitterPosition = 592;
            this.spccPriceUpdate.TabIndex = 0;
            this.spccPriceUpdate.Text = "splitContainerControl1";
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dtgvProduct.MainView = this.gvProduct;
            this.dtgvProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.Size = new System.Drawing.Size(592, 473);
            this.dtgvProduct.TabIndex = 0;
            this.dtgvProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colProductName,
            this.colNote});
            this.gvProduct.DetailHeight = 538;
            this.gvProduct.GridControl = this.dtgvProduct;
            this.gvProduct.GroupPanelText = "Danh sách sản phẩm chưa cập nhật giá bán";
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvProduct.RowHeight = 38;
            this.gvProduct.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvProduct_RowClick);
            this.gvProduct.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvInput_CustomDrawCell);
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colSTT.AppearanceCell.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseForeColor = true;
            this.colSTT.Caption = "STT";
            this.colSTT.MinWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 112;
            // 
            // colProductName
            // 
            this.colProductName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colProductName.AppearanceCell.Options.UseFont = true;
            this.colProductName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colProductName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colProductName.AppearanceHeader.Options.UseFont = true;
            this.colProductName.AppearanceHeader.Options.UseForeColor = true;
            this.colProductName.Caption = "Tên Sản Phẩm";
            this.colProductName.FieldName = "Name";
            this.colProductName.MinWidth = 30;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 112;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colNote.AppearanceCell.Options.UseFont = true;
            this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNote.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colNote.AppearanceHeader.Options.UseFont = true;
            this.colNote.AppearanceHeader.Options.UseForeColor = true;
            this.colNote.Caption = "Ghi Chú";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 2;
            this.colNote.Width = 112;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 393);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAccountName
            // 
            this.lbAccountName.Location = new System.Drawing.Point(17, 17);
            this.lbAccountName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(107, 19);
            this.lbAccountName.TabIndex = 5;
            this.lbAccountName.Text = "Tên nhân viên:";
            this.lbAccountName.Visible = false;
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(492, 393);
            this.btnExits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(112, 35);
            this.btnExits.TabIndex = 4;
            this.btnExits.Text = "&Đóng Lại";
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(370, 393);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Location = new System.Drawing.Point(249, 393);
            this.btnUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(112, 35);
            this.btnUpdatePrice.TabIndex = 4;
            this.btnUpdatePrice.Text = "&Cập Nhật";
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // lbUpdateDate
            // 
            this.lbUpdateDate.Location = new System.Drawing.Point(17, 293);
            this.lbUpdateDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbUpdateDate.Name = "lbUpdateDate";
            this.lbUpdateDate.Size = new System.Drawing.Size(107, 19);
            this.lbUpdateDate.TabIndex = 3;
            this.lbUpdateDate.Text = "Ngày cập nhật:";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(160, 238);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(303, 26);
            this.txtSalePrice.TabIndex = 2;
            this.txtSalePrice.TextChanged += new System.EventHandler(this.txtSalePrice_TextChanged);
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // lbSalePrice
            // 
            this.lbSalePrice.Location = new System.Drawing.Point(67, 243);
            this.lbSalePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSalePrice.Name = "lbSalePrice";
            this.lbSalePrice.Size = new System.Drawing.Size(60, 19);
            this.lbSalePrice.TabIndex = 1;
            this.lbSalePrice.Text = "Giá bán:";
            // 
            // lbImportPrice
            // 
            this.lbImportPrice.Location = new System.Drawing.Point(58, 193);
            this.lbImportPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbImportPrice.Name = "lbImportPrice";
            this.lbImportPrice.Size = new System.Drawing.Size(69, 19);
            this.lbImportPrice.TabIndex = 0;
            this.lbImportPrice.Text = "Giá nhập:";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(43, 143);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(82, 19);
            this.lbStartDate.TabIndex = 0;
            this.lbStartDate.Text = "Ngày nhập:";
            // 
            // lbCount
            // 
            this.lbCount.Location = new System.Drawing.Point(28, 93);
            this.lbCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(98, 19);
            this.lbCount.TabIndex = 0;
            this.lbCount.Text = "Số lượng tồn:";
            // 
            // lbProductName
            // 
            this.lbProductName.Location = new System.Drawing.Point(20, 43);
            this.lbProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(107, 19);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Tên sản phẩm:";
            // 
            // ucSalePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcPriceUpdate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucSalePrice";
            this.Size = new System.Drawing.Size(1138, 509);
            this.Load += new System.EventHandler(this.ucSalePrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPriceUpdate)).EndInit();
            this.gcPriceUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccPriceUpdate.Panel1)).EndInit();
            this.spccPriceUpdate.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccPriceUpdate.Panel2)).EndInit();
            this.spccPriceUpdate.Panel2.ResumeLayout(false);
            this.spccPriceUpdate.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccPriceUpdate)).EndInit();
            this.spccPriceUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcPriceUpdate;
        private DevExpress.XtraEditors.SplitContainerControl spccPriceUpdate;
        private DevExpress.XtraGrid.GridControl dtgvProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraEditors.LabelControl lbImportPrice;
        private DevExpress.XtraEditors.LabelControl lbStartDate;
        private DevExpress.XtraEditors.LabelControl lbCount;
        private DevExpress.XtraEditors.LabelControl lbProductName;
        private DevExpress.XtraEditors.TextEdit txtSalePrice;
        private DevExpress.XtraEditors.LabelControl lbSalePrice;
        private DevExpress.XtraEditors.LabelControl lbUpdateDate;
        private DevExpress.XtraEditors.SimpleButton btnExits;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdatePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.LabelControl lbAccountName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}
