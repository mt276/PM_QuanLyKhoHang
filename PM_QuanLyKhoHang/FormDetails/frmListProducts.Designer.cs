
namespace PM_QuanLyKhoHang.FormDetails
{
    partial class frmListProducts
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgvDisplay = new DevExpress.XtraGrid.GridControl();
            this.gvListProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDisplay
            // 
            this.dtgvDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDisplay.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDisplay.Location = new System.Drawing.Point(0, 0);
            this.dtgvDisplay.MainView = this.gvListProducts;
            this.dtgvDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDisplay.Name = "dtgvDisplay";
            this.dtgvDisplay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.dtgvDisplay.Size = new System.Drawing.Size(1098, 403);
            this.dtgvDisplay.TabIndex = 0;
            this.dtgvDisplay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListProducts});
            // 
            // gvListProducts
            // 
            this.gvListProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colNameProduct,
            this.colSpecification,
            this.colCount,
            this.colVAT,
            this.colSalePrice,
            this.colSaleDay,
            this.colNote});
            this.gvListProducts.DetailHeight = 512;
            this.gvListProducts.GridControl = this.dtgvDisplay;
            this.gvListProducts.GroupPanelText = "Danh Sách Sản Phẩm";
            this.gvListProducts.Name = "gvListProducts";
            this.gvListProducts.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvListProducts.RowHeight = 37;
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colSTT.AppearanceCell.Options.UseFont = true;
            this.colSTT.AppearanceCell.Options.UseForeColor = true;
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseForeColor = true;
            this.colSTT.Caption = "STT";
            this.colSTT.MinWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 54;
            // 
            // colNameProduct
            // 
            this.colNameProduct.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colNameProduct.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colNameProduct.AppearanceCell.Options.UseFont = true;
            this.colNameProduct.AppearanceCell.Options.UseForeColor = true;
            this.colNameProduct.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNameProduct.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colNameProduct.AppearanceHeader.Options.UseFont = true;
            this.colNameProduct.AppearanceHeader.Options.UseForeColor = true;
            this.colNameProduct.Caption = "Tên Sản Phẩm";
            this.colNameProduct.FieldName = "NameProduct";
            this.colNameProduct.MinWidth = 30;
            this.colNameProduct.Name = "colNameProduct";
            this.colNameProduct.Visible = true;
            this.colNameProduct.VisibleIndex = 1;
            this.colNameProduct.Width = 141;
            // 
            // colSpecification
            // 
            this.colSpecification.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colSpecification.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colSpecification.AppearanceCell.Options.UseFont = true;
            this.colSpecification.AppearanceCell.Options.UseForeColor = true;
            this.colSpecification.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSpecification.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSpecification.AppearanceHeader.Options.UseFont = true;
            this.colSpecification.AppearanceHeader.Options.UseForeColor = true;
            this.colSpecification.Caption = "Quy Cách";
            this.colSpecification.FieldName = "Specification";
            this.colSpecification.MinWidth = 30;
            this.colSpecification.Name = "colSpecification";
            this.colSpecification.Visible = true;
            this.colSpecification.VisibleIndex = 2;
            this.colSpecification.Width = 134;
            // 
            // colCount
            // 
            this.colCount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colCount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colCount.AppearanceCell.Options.UseFont = true;
            this.colCount.AppearanceCell.Options.UseForeColor = true;
            this.colCount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCount.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colCount.AppearanceHeader.Options.UseFont = true;
            this.colCount.AppearanceHeader.Options.UseForeColor = true;
            this.colCount.Caption = "Số Lượng";
            this.colCount.FieldName = "Count";
            this.colCount.MinWidth = 30;
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 3;
            this.colCount.Width = 141;
            // 
            // colVAT
            // 
            this.colVAT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colVAT.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colVAT.AppearanceCell.Options.UseFont = true;
            this.colVAT.AppearanceCell.Options.UseForeColor = true;
            this.colVAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colVAT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colVAT.AppearanceHeader.Options.UseFont = true;
            this.colVAT.AppearanceHeader.Options.UseForeColor = true;
            this.colVAT.Caption = "VAT";
            this.colVAT.FieldName = "VAT";
            this.colVAT.MinWidth = 30;
            this.colVAT.Name = "colVAT";
            this.colVAT.Visible = true;
            this.colVAT.VisibleIndex = 4;
            this.colVAT.Width = 141;
            // 
            // colSalePrice
            // 
            this.colSalePrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colSalePrice.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colSalePrice.AppearanceCell.Options.UseFont = true;
            this.colSalePrice.AppearanceCell.Options.UseForeColor = true;
            this.colSalePrice.AppearanceCell.Options.UseTextOptions = true;
            this.colSalePrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSalePrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSalePrice.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSalePrice.AppearanceHeader.Options.UseFont = true;
            this.colSalePrice.AppearanceHeader.Options.UseForeColor = true;
            this.colSalePrice.Caption = "Giá Bán";
            this.colSalePrice.FieldName = "SalePrice";
            this.colSalePrice.MinWidth = 30;
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.Visible = true;
            this.colSalePrice.VisibleIndex = 5;
            this.colSalePrice.Width = 141;
            // 
            // colSaleDay
            // 
            this.colSaleDay.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colSaleDay.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colSaleDay.AppearanceCell.Options.UseFont = true;
            this.colSaleDay.AppearanceCell.Options.UseForeColor = true;
            this.colSaleDay.AppearanceCell.Options.UseTextOptions = true;
            this.colSaleDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleDay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSaleDay.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSaleDay.AppearanceHeader.Options.UseFont = true;
            this.colSaleDay.AppearanceHeader.Options.UseForeColor = true;
            this.colSaleDay.Caption = "Ngày Bán";
            this.colSaleDay.FieldName = "SaleDay";
            this.colSaleDay.MinWidth = 30;
            this.colSaleDay.Name = "colSaleDay";
            this.colSaleDay.Visible = true;
            this.colSaleDay.VisibleIndex = 6;
            this.colSaleDay.Width = 141;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colNote.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colNote.AppearanceCell.Options.UseFont = true;
            this.colNote.AppearanceCell.Options.UseForeColor = true;
            this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNote.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colNote.AppearanceHeader.Options.UseFont = true;
            this.colNote.AppearanceHeader.Options.UseForeColor = true;
            this.colNote.Caption = "Ghi Chú";
            this.colNote.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 169;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // frmListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 403);
            this.Controls.Add(this.dtgvDisplay);
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListProducts";
            this.ShowInTaskbar = false;
            this.Text = "Danh sách các sản phẩm và giá bán trong những lần mua trước đây";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgvDisplay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colNameProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleDay;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecification;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}