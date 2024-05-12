namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucConfigure
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dgvThamSo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThongSoKyThuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvThamSoThietLap = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThongSoLyThuat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongToiThieu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnNextAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnThietLap = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuongToiThieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamSoThietLap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongToiThieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(515, 332);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.btnBack);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnBackAll);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnThoat);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnHuy);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnNextAll);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnThietLap);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnNext);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtSoLuongToiThieu);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(511, 328);
            this.splitContainerControl1.SplitterPosition = 202;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.dgvThamSo);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.dgvThamSoThietLap);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(511, 202);
            this.splitContainerControl2.SplitterPosition = 258;
            this.splitContainerControl2.TabIndex = 2;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // dgvThamSo
            // 
            this.dgvThamSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThamSo.Location = new System.Drawing.Point(0, 0);
            this.dgvThamSo.MainView = this.gridView1;
            this.dgvThamSo.Name = "dgvThamSo";
            this.dgvThamSo.Size = new System.Drawing.Size(258, 202);
            this.dgvThamSo.TabIndex = 0;
            this.dgvThamSo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colTenSanPham,
            this.colThongSoKyThuat,
            this.colSoLuongToiThieu});
            this.gridView1.GridControl = this.dgvThamSo;
            this.gridView1.GroupPanelText = "Danh sách các sản phẩm";
            this.gridView1.Name = "gridView1";
            //this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            //this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSTT.AppearanceCell.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseForeColor = true;
            this.colSTT.Caption = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 25;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTenSanPham.AppearanceCell.Options.UseFont = true;
            this.colTenSanPham.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTenSanPham.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colTenSanPham.AppearanceHeader.Options.UseFont = true;
            this.colTenSanPham.AppearanceHeader.Options.UseForeColor = true;
            this.colTenSanPham.Caption = "Tên Sản Phẩm";
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 1;
            this.colTenSanPham.Width = 55;
            // 
            // colThongSoKyThuat
            // 
            this.colThongSoKyThuat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colThongSoKyThuat.AppearanceCell.Options.UseFont = true;
            this.colThongSoKyThuat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colThongSoKyThuat.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colThongSoKyThuat.AppearanceHeader.Options.UseFont = true;
            this.colThongSoKyThuat.AppearanceHeader.Options.UseForeColor = true;
            this.colThongSoKyThuat.Caption = "Thông Số Kỹ Thuật";
            this.colThongSoKyThuat.FieldName = "ThongSoKyThuat";
            this.colThongSoKyThuat.Name = "colThongSoKyThuat";
            this.colThongSoKyThuat.Visible = true;
            this.colThongSoKyThuat.VisibleIndex = 2;
            this.colThongSoKyThuat.Width = 55;
            // 
            // colSoLuongToiThieu
            // 
            this.colSoLuongToiThieu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSoLuongToiThieu.AppearanceCell.Options.UseFont = true;
            this.colSoLuongToiThieu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSoLuongToiThieu.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSoLuongToiThieu.AppearanceHeader.Options.UseFont = true;
            this.colSoLuongToiThieu.AppearanceHeader.Options.UseForeColor = true;
            this.colSoLuongToiThieu.Caption = "Số Lượng Tối Thiểu";
            this.colSoLuongToiThieu.FieldName = "GiaTri";
            this.colSoLuongToiThieu.Name = "colSoLuongToiThieu";
            this.colSoLuongToiThieu.Visible = true;
            this.colSoLuongToiThieu.VisibleIndex = 3;
            this.colSoLuongToiThieu.Width = 57;
            // 
            // dgvThamSoThietLap
            // 
            this.dgvThamSoThietLap.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.dgvThamSoThietLap.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgvThamSoThietLap.Location = new System.Drawing.Point(0, 0);
            this.dgvThamSoThietLap.MainView = this.gridView2;
            this.dgvThamSoThietLap.Name = "dgvThamSoThietLap";
            this.dgvThamSoThietLap.Size = new System.Drawing.Size(248, 202);
            this.dgvThamSoThietLap.TabIndex = 0;
            this.dgvThamSoThietLap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT1,
            this.colTenSanPham1,
            this.colThongSoLyThuat1,
            this.colSoLuongToiThieu1});
            this.gridView2.GridControl = this.dgvThamSoThietLap;
            this.gridView2.GroupPanelText = "Danh sách các sản phẩm cần thiết lập";
            this.gridView2.Name = "gridView2";
            //this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            //this.gridView2.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView2_CustomDrawCell);
            // 
            // colSTT1
            // 
            this.colSTT1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSTT1.AppearanceCell.Options.UseFont = true;
            this.colSTT1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSTT1.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSTT1.AppearanceHeader.Options.UseFont = true;
            this.colSTT1.AppearanceHeader.Options.UseForeColor = true;
            this.colSTT1.Caption = "STT";
            this.colSTT1.Name = "colSTT1";
            this.colSTT1.Visible = true;
            this.colSTT1.VisibleIndex = 0;
            this.colSTT1.Width = 25;
            // 
            // colTenSanPham1
            // 
            this.colTenSanPham1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTenSanPham1.AppearanceCell.Options.UseFont = true;
            this.colTenSanPham1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTenSanPham1.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colTenSanPham1.AppearanceHeader.Options.UseFont = true;
            this.colTenSanPham1.AppearanceHeader.Options.UseForeColor = true;
            this.colTenSanPham1.Caption = "Tên Sản Phẩm";
            this.colTenSanPham1.FieldName = "TenSanPham";
            this.colTenSanPham1.Name = "colTenSanPham1";
            this.colTenSanPham1.Visible = true;
            this.colTenSanPham1.VisibleIndex = 1;
            this.colTenSanPham1.Width = 55;
            // 
            // colThongSoLyThuat1
            // 
            this.colThongSoLyThuat1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colThongSoLyThuat1.AppearanceCell.Options.UseFont = true;
            this.colThongSoLyThuat1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colThongSoLyThuat1.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colThongSoLyThuat1.AppearanceHeader.Options.UseFont = true;
            this.colThongSoLyThuat1.AppearanceHeader.Options.UseForeColor = true;
            this.colThongSoLyThuat1.Caption = "Thông Số Kỹ Thuật";
            this.colThongSoLyThuat1.FieldName = "ThongSoKyThuat";
            this.colThongSoLyThuat1.Name = "colThongSoLyThuat1";
            this.colThongSoLyThuat1.Visible = true;
            this.colThongSoLyThuat1.VisibleIndex = 2;
            this.colThongSoLyThuat1.Width = 55;
            // 
            // colSoLuongToiThieu1
            // 
            this.colSoLuongToiThieu1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSoLuongToiThieu1.AppearanceCell.Options.UseFont = true;
            this.colSoLuongToiThieu1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSoLuongToiThieu1.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSoLuongToiThieu1.AppearanceHeader.Options.UseFont = true;
            this.colSoLuongToiThieu1.AppearanceHeader.Options.UseForeColor = true;
            this.colSoLuongToiThieu1.Caption = "Số Lượng Tối Thiểu";
            this.colSoLuongToiThieu1.FieldName = "GiaTri";
            this.colSoLuongToiThieu1.Name = "colSoLuongToiThieu1";
            this.colSoLuongToiThieu1.Visible = true;
            this.colSoLuongToiThieu1.VisibleIndex = 3;
            this.colSoLuongToiThieu1.Width = 59;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.Location = new System.Drawing.Point(327, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<";
           // this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBackAll
            // 
            this.btnBackAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBackAll.Location = new System.Drawing.Point(250, 1);
            this.btnBackAll.Name = "btnBackAll";
            this.btnBackAll.Size = new System.Drawing.Size(75, 23);
            this.btnBackAll.TabIndex = 2;
            this.btnBackAll.Text = "<<";
            //this.btnBackAll.Click += new System.EventHandler(this.btnBackAll_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(433, 95);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            //this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(250, 95);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            //this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnNextAll
            // 
            this.btnNextAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNextAll.Location = new System.Drawing.Point(157, 1);
            this.btnNextAll.Name = "btnNextAll";
            this.btnNextAll.Size = new System.Drawing.Size(75, 23);
            this.btnNextAll.TabIndex = 1;
            this.btnNextAll.Text = ">>";
           // this.btnNextAll.Click += new System.EventHandler(this.btnNextAll_Click);
            // 
            // btnThietLap
            // 
            this.btnThietLap.Location = new System.Drawing.Point(169, 95);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(75, 23);
            this.btnThietLap.TabIndex = 5;
            this.btnThietLap.Text = "Thiết Lập";
           // this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.Location = new System.Drawing.Point(76, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = ">";
           // this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtSoLuongToiThieu
            // 
            this.txtSoLuongToiThieu.Location = new System.Drawing.Point(176, 39);
            this.txtSoLuongToiThieu.Name = "txtSoLuongToiThieu";
            this.txtSoLuongToiThieu.Size = new System.Drawing.Size(168, 20);
            this.txtSoLuongToiThieu.TabIndex = 4;
            //this.txtSoLuongToiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongToiThieu_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(79, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số Lượng Tối Thiểu";
            // 
            // ucThongSoKyThuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucThongSoKyThuat";
            this.Size = new System.Drawing.Size(515, 332);
            //this.Load += new System.EventHandler(this.ucThongSoKyThuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamSoThietLap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongToiThieu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnBackAll;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNextAll;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraGrid.GridControl dgvThamSoThietLap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl dgvThamSo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThietLap;
        private DevExpress.XtraEditors.TextEdit txtSoLuongToiThieu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham1;
        private DevExpress.XtraGrid.Columns.GridColumn colThongSoLyThuat1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongToiThieu1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colThongSoKyThuat;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongToiThieu;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
    }
}
