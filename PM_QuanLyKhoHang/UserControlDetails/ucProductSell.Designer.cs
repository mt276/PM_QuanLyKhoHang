namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucProductSell
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
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.tcListProducts = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.spccListProducts = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dtgvStatistical = new DevExpress.XtraGrid.GridControl();
            this.gvStatistical = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lbEndDate = new DevExpress.XtraEditors.LabelControl();
            this.lbStartDate = new DevExpress.XtraEditors.LabelControl();
            this.dtpkEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcListProducts)).BeginInit();
            this.tcListProducts.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccListProducts.Panel1)).BeginInit();
            this.spccListProducts.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccListProducts.Panel2)).BeginInit();
            this.spccListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatistical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tcListProducts);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(978, 502);
            this.pnlMain.TabIndex = 0;
            // 
            // tcListProducts
            // 
            this.tcListProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcListProducts.Location = new System.Drawing.Point(2, 2);
            this.tcListProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcListProducts.Name = "tcListProducts";
            this.tcListProducts.SelectedTabPage = this.xtraTabPage1;
            this.tcListProducts.Size = new System.Drawing.Size(974, 498);
            this.tcListProducts.TabIndex = 0;
            this.tcListProducts.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.spccListProducts);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(972, 463);
            this.xtraTabPage1.Text = "Thống Kê";
            // 
            // spccListProducts
            // 
            this.spccListProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spccListProducts.Horizontal = false;
            this.spccListProducts.Location = new System.Drawing.Point(0, 0);
            this.spccListProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccListProducts.Name = "spccListProducts";
            // 
            // spccListProducts.Panel1
            // 
            this.spccListProducts.Panel1.Controls.Add(this.panelControl3);
            this.spccListProducts.Panel1.Controls.Add(this.pnlSearch);
            this.spccListProducts.Panel1.Text = "Panel1";
            // 
            // spccListProducts.Panel2
            // 
            this.spccListProducts.Panel2.Text = "Panel2";
            this.spccListProducts.Size = new System.Drawing.Size(972, 463);
            this.spccListProducts.SplitterPosition = 262;
            this.spccListProducts.TabIndex = 0;
            this.spccListProducts.Text = "splitContainerControl1";
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.dtgvStatistical);
            this.panelControl3.Location = new System.Drawing.Point(-2, 89);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(977, 171);
            this.panelControl3.TabIndex = 0;
            // 
            // dtgvStatistical
            // 
            this.dtgvStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvStatistical.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvStatistical.Location = new System.Drawing.Point(2, 2);
            this.dtgvStatistical.MainView = this.gvStatistical;
            this.dtgvStatistical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvStatistical.Name = "dtgvStatistical";
            this.dtgvStatistical.Size = new System.Drawing.Size(973, 167);
            this.dtgvStatistical.TabIndex = 0;
            this.dtgvStatistical.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStatistical});
            // 
            // gvStatistical
            // 
            this.gvStatistical.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colProductName,
            this.colCount,
            this.colStartDate});
            this.gvStatistical.DetailHeight = 538;
            this.gvStatistical.GridControl = this.dtgvStatistical;
            this.gvStatistical.GroupPanelText = " ";
            this.gvStatistical.Name = "gvStatistical";
            this.gvStatistical.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvStatistical.OptionsView.ShowGroupPanel = false;
            this.gvStatistical.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvStatistical_CustomDrawCell);
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colSTT.AppearanceCell.Options.UseFont = true;
            this.colSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseForeColor = true;
            this.colSTT.Caption = "STT";
            this.colSTT.MinWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 95;
            // 
            // colProductName
            // 
            this.colProductName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colProductName.AppearanceCell.Options.UseFont = true;
            this.colProductName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colProductName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colProductName.AppearanceHeader.Options.UseFont = true;
            this.colProductName.AppearanceHeader.Options.UseForeColor = true;
            this.colProductName.Caption = "Tên Sản Phẩm";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 30;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 405;
            // 
            // colCount
            // 
            this.colCount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colCount.AppearanceCell.Options.UseFont = true;
            this.colCount.AppearanceCell.Options.UseTextOptions = true;
            this.colCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCount.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colCount.AppearanceHeader.Options.UseFont = true;
            this.colCount.AppearanceHeader.Options.UseForeColor = true;
            this.colCount.Caption = "Số Lượng Bán";
            this.colCount.FieldName = "SellNumber";
            this.colCount.MinWidth = 30;
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 2;
            this.colCount.Width = 272;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnAll);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lbEndDate);
            this.pnlSearch.Controls.Add(this.lbStartDate);
            this.pnlSearch.Controls.Add(this.dtpkEndDate);
            this.pnlSearch.Controls.Add(this.dtpkStartDate);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(972, 89);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(826, 25);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(120, 35);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "Tất cả";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(698, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(393, 8);
            this.lbEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(28, 19);
            this.lbEndDate.TabIndex = 1;
            this.lbEndDate.Text = "Đến";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(28, 8);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(94, 19);
            this.lbStartDate.TabIndex = 1;
            this.lbStartDate.Text = "Thời Gian Từ";
            // 
            // dtpkEndDate
            // 
            this.dtpkEndDate.Location = new System.Drawing.Point(393, 29);
            this.dtpkEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkEndDate.Name = "dtpkEndDate";
            this.dtpkEndDate.Size = new System.Drawing.Size(298, 27);
            this.dtpkEndDate.TabIndex = 1;
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.Location = new System.Drawing.Point(28, 29);
            this.dtpkStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(298, 27);
            this.dtpkStartDate.TabIndex = 0;
            // 
            // colStartDate
            // 
            this.colStartDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colStartDate.AppearanceCell.Options.UseFont = true;
            this.colStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStartDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStartDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStartDate.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStartDate.AppearanceHeader.Options.UseFont = true;
            this.colStartDate.AppearanceHeader.Options.UseForeColor = true;
            this.colStartDate.Caption = "Ngày bán";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.MinWidth = 30;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 3;
            this.colStartDate.Width = 283;
            // 
            // ucListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucListProducts";
            this.Size = new System.Drawing.Size(978, 502);
            this.Load += new System.EventHandler(this.ucListProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcListProducts)).EndInit();
            this.tcListProducts.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccListProducts.Panel1)).EndInit();
            this.spccListProducts.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccListProducts.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccListProducts)).EndInit();
            this.spccListProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatistical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraTab.XtraTabControl tcListProducts;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SplitContainerControl spccListProducts;
        private DevExpress.XtraGrid.GridControl dtgvStatistical;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStatistical;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl pnlSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl lbEndDate;
        private DevExpress.XtraEditors.LabelControl lbStartDate;
        private System.Windows.Forms.DateTimePicker dtpkEndDate;
        private System.Windows.Forms.DateTimePicker dtpkStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
    }
}
