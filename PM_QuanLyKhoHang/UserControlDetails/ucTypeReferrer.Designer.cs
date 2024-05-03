namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class ucTypeReferrer
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
            this.gcTypeReferrer = new DevExpress.XtraEditors.GroupControl();
            this.spccTypeReferrer = new DevExpress.XtraEditors.SplitContainerControl();
            this.dtpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            this.lbStartDate = new DevExpress.XtraEditors.LabelControl();
            this.lbTypeName = new DevExpress.XtraEditors.LabelControl();
            this.txtTypeName = new DevExpress.XtraEditors.TextEdit();
            this.btnExits = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.mmedNote = new DevExpress.XtraEditors.MemoEdit();
            this.dtgvTypeReferrer = new DevExpress.XtraGrid.GridControl();
            this.gvTypeReferrer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTypeReferrer)).BeginInit();
            this.gcTypeReferrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccTypeReferrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spccTypeReferrer.Panel1)).BeginInit();
            this.spccTypeReferrer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccTypeReferrer.Panel2)).BeginInit();
            this.spccTypeReferrer.Panel2.SuspendLayout();
            this.spccTypeReferrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTypeReferrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTypeReferrer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gcTypeReferrer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(976, 503);
            this.pnlMain.TabIndex = 0;
            // 
            // gcTypeReferrer
            // 
            this.gcTypeReferrer.Controls.Add(this.spccTypeReferrer);
            this.gcTypeReferrer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTypeReferrer.Location = new System.Drawing.Point(2, 2);
            this.gcTypeReferrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcTypeReferrer.Name = "gcTypeReferrer";
            this.gcTypeReferrer.Size = new System.Drawing.Size(972, 499);
            this.gcTypeReferrer.TabIndex = 0;
            this.gcTypeReferrer.Text = "Loại Người Giới Thiệu";
            // 
            // spccTypeReferrer
            // 
            this.spccTypeReferrer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spccTypeReferrer.Horizontal = false;
            this.spccTypeReferrer.Location = new System.Drawing.Point(2, 34);
            this.spccTypeReferrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spccTypeReferrer.Name = "spccTypeReferrer";
            // 
            // spccTypeReferrer.Panel1
            // 
            this.spccTypeReferrer.Panel1.Controls.Add(this.dtpkStartDate);
            this.spccTypeReferrer.Panel1.Controls.Add(this.lbNote);
            this.spccTypeReferrer.Panel1.Controls.Add(this.lbStartDate);
            this.spccTypeReferrer.Panel1.Controls.Add(this.lbTypeName);
            this.spccTypeReferrer.Panel1.Controls.Add(this.txtTypeName);
            this.spccTypeReferrer.Panel1.Controls.Add(this.btnExits);
            this.spccTypeReferrer.Panel1.Controls.Add(this.btnCancel);
            this.spccTypeReferrer.Panel1.Controls.Add(this.btnUpdate);
            this.spccTypeReferrer.Panel1.Controls.Add(this.btnDelete);
            this.spccTypeReferrer.Panel1.Controls.Add(this.btnAdd);
            this.spccTypeReferrer.Panel1.Controls.Add(this.mmedNote);
            this.spccTypeReferrer.Panel1.Text = "Panel1";
            // 
            // spccTypeReferrer.Panel2
            // 
            this.spccTypeReferrer.Panel2.Controls.Add(this.dtgvTypeReferrer);
            this.spccTypeReferrer.Panel2.Text = "Panel2";
            this.spccTypeReferrer.Size = new System.Drawing.Size(968, 463);
            this.spccTypeReferrer.SplitterPosition = 208;
            this.spccTypeReferrer.TabIndex = 0;
            this.spccTypeReferrer.Text = "splitContainerControl1";
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.Location = new System.Drawing.Point(206, 89);
            this.dtpkStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(298, 27);
            this.dtpkStartDate.TabIndex = 2;
            // 
            // lbNote
            // 
            this.lbNote.Location = new System.Drawing.Point(546, 25);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(57, 19);
            this.lbNote.TabIndex = 2;
            this.lbNote.Text = "Ghi Chú";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(10, 95);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(68, 19);
            this.lbStartDate.TabIndex = 2;
            this.lbStartDate.Text = "Ngày Tạo";
            // 
            // lbTypeName
            // 
            this.lbTypeName.Location = new System.Drawing.Point(10, 30);
            this.lbTypeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbTypeName.Name = "lbTypeName";
            this.lbTypeName.Size = new System.Drawing.Size(187, 19);
            this.lbTypeName.TabIndex = 2;
            this.lbTypeName.Text = "Tên Loại Người Giới Thiệu";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(206, 25);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(300, 26);
            this.txtTypeName.TabIndex = 1;
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(806, 157);
            this.btnExits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(112, 35);
            this.btnExits.TabIndex = 8;
            this.btnExits.Text = "Thoát";
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(416, 157);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(676, 157);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(546, 157);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(285, 157);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mmedNote
            // 
            this.mmedNote.Location = new System.Drawing.Point(627, 25);
            this.mmedNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mmedNote.Name = "mmedNote";
            this.mmedNote.Size = new System.Drawing.Size(332, 91);
            this.mmedNote.TabIndex = 3;
            // 
            // dtgvTypeReferrer
            // 
            this.dtgvTypeReferrer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTypeReferrer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvTypeReferrer.Location = new System.Drawing.Point(0, 0);
            this.dtgvTypeReferrer.MainView = this.gvTypeReferrer;
            this.dtgvTypeReferrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvTypeReferrer.Name = "dtgvTypeReferrer";
            this.dtgvTypeReferrer.Size = new System.Drawing.Size(968, 240);
            this.dtgvTypeReferrer.TabIndex = 0;
            this.dtgvTypeReferrer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTypeReferrer});
            // 
            // gvTypeReferrer
            // 
            this.gvTypeReferrer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colTypeName,
            this.colStartDate,
            this.colDelete,
            this.colNote});
            this.gvTypeReferrer.DetailHeight = 538;
            this.gvTypeReferrer.GridControl = this.dtgvTypeReferrer;
            this.gvTypeReferrer.GroupPanelText = " ";
            this.gvTypeReferrer.Name = "gvTypeReferrer";
            this.gvTypeReferrer.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvTypeReferrer.RowHeight = 46;
            this.gvTypeReferrer.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvTypeReferrer_RowClick);
            this.gvTypeReferrer.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvTypeReferrer_CustomDrawCell);
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
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
            this.colSTT.Width = 52;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 30;
            this.colID.Name = "colID";
            this.colID.Width = 112;
            // 
            // colTypeName
            // 
            this.colTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colTypeName.AppearanceCell.Options.UseFont = true;
            this.colTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTypeName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colTypeName.AppearanceHeader.Options.UseFont = true;
            this.colTypeName.AppearanceHeader.Options.UseForeColor = true;
            this.colTypeName.Caption = "Tên Loại";
            this.colTypeName.FieldName = "Name";
            this.colTypeName.MinWidth = 30;
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 1;
            this.colTypeName.Width = 292;
            // 
            // colStartDate
            // 
            this.colStartDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colStartDate.AppearanceCell.Options.UseFont = true;
            this.colStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStartDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStartDate.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStartDate.AppearanceHeader.Options.UseFont = true;
            this.colStartDate.AppearanceHeader.Options.UseForeColor = true;
            this.colStartDate.Caption = "Ngày Tạo";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.MinWidth = 30;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            this.colStartDate.Width = 292;
            // 
            // colDelete
            // 
            this.colDelete.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 15F);
            this.colDelete.AppearanceCell.Options.UseFont = true;
            this.colDelete.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colDelete.AppearanceHeader.Options.UseFont = true;
            this.colDelete.Caption = "Xoa";
            this.colDelete.FieldName = "Delete";
            this.colDelete.MinWidth = 30;
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 112;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.colNote.AppearanceCell.Options.UseFont = true;
            this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNote.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colNote.AppearanceHeader.Options.UseFont = true;
            this.colNote.AppearanceHeader.Options.UseForeColor = true;
            this.colNote.Caption = "Ghi Chú";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 3;
            this.colNote.Width = 300;
            // 
            // ucTypeReferrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucTypeReferrer";
            this.Size = new System.Drawing.Size(976, 503);
            this.Load += new System.EventHandler(this.ucTypeReferrer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTypeReferrer)).EndInit();
            this.gcTypeReferrer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccTypeReferrer.Panel1)).EndInit();
            this.spccTypeReferrer.Panel1.ResumeLayout(false);
            this.spccTypeReferrer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spccTypeReferrer.Panel2)).EndInit();
            this.spccTypeReferrer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spccTypeReferrer)).EndInit();
            this.spccTypeReferrer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTypeReferrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTypeReferrer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.GroupControl gcTypeReferrer;
        private DevExpress.XtraEditors.SplitContainerControl spccTypeReferrer;
        private DevExpress.XtraGrid.GridControl dtgvTypeReferrer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTypeReferrer;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.LabelControl lbNote;
        private DevExpress.XtraEditors.LabelControl lbStartDate;
        private DevExpress.XtraEditors.LabelControl lbTypeName;
        private DevExpress.XtraEditors.TextEdit txtTypeName;
        private DevExpress.XtraEditors.SimpleButton btnExits;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.MemoEdit mmedNote;
        private System.Windows.Forms.DateTimePicker dtpkStartDate;
    }
}
