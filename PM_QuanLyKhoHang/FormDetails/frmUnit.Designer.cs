namespace PM_QuanLyKhoHang.FormDetails
{
    partial class frmUnit
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lbControlNote = new DevExpress.XtraEditors.LabelControl();
            this.txtUnitName = new DevExpress.XtraEditors.TextEdit();
            this.lbControlUnitName = new DevExpress.XtraEditors.LabelControl();
            this.mmedNote = new DevExpress.XtraEditors.MemoEdit();
            this.dtgvUnit = new DevExpress.XtraGrid.GridControl();
            this.gvUnit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gbAction);
            this.splitContainerControl1.Panel1.Controls.Add(this.lbControlNote);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtUnitName);
            this.splitContainerControl1.Panel1.Controls.Add(this.lbControlUnitName);
            this.splitContainerControl1.Panel1.Controls.Add(this.mmedNote);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.dtgvUnit);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(656, 533);
            this.splitContainerControl1.SplitterPosition = 208;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.btnUpdate);
            this.gbAction.Controls.Add(this.btnDelete);
            this.gbAction.Controls.Add(this.btnCancel);
            this.gbAction.Controls.Add(this.btnAdd);
            this.gbAction.Location = new System.Drawing.Point(486, 18);
            this.gbAction.Margin = new System.Windows.Forms.Padding(4);
            this.gbAction.Name = "gbAction";
            this.gbAction.Padding = new System.Windows.Forms.Padding(4);
            this.gbAction.Size = new System.Drawing.Size(166, 189);
            this.gbAction.TabIndex = 2;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Thao tác";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(24, 146);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.ToolTip = "Cập nhật đơn vị tính";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 104);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.ToolTip = "Xóa đơn vị tính này";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(24, 64);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.ToolTip = "Hủy thao tác thêm này";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.ToolTip = "Thêm đơn vị tính mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbControlNote
            // 
            this.lbControlNote.Location = new System.Drawing.Point(40, 78);
            this.lbControlNote.Margin = new System.Windows.Forms.Padding(4);
            this.lbControlNote.Name = "lbControlNote";
            this.lbControlNote.Size = new System.Drawing.Size(54, 19);
            this.lbControlNote.TabIndex = 0;
            this.lbControlNote.Text = "Ghi chú";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(124, 28);
            this.txtUnitName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(320, 26);
            this.txtUnitName.TabIndex = 1;
            this.txtUnitName.ToolTip = "Tên đơn vị";
            this.txtUnitName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbControlUnitName
            // 
            this.lbControlUnitName.Location = new System.Drawing.Point(40, 28);
            this.lbControlUnitName.Margin = new System.Windows.Forms.Padding(4);
            this.lbControlUnitName.Name = "lbControlUnitName";
            this.lbControlUnitName.Size = new System.Drawing.Size(76, 19);
            this.lbControlUnitName.TabIndex = 0;
            this.lbControlUnitName.Text = "Tên đơn vị";
            // 
            // mmedNote
            // 
            this.mmedNote.Location = new System.Drawing.Point(124, 78);
            this.mmedNote.Margin = new System.Windows.Forms.Padding(4);
            this.mmedNote.Name = "mmedNote";
            this.mmedNote.Size = new System.Drawing.Size(320, 89);
            this.mmedNote.TabIndex = 2;
            this.mmedNote.ToolTip = "Ghi chú cho tên đơn vị này";
            this.mmedNote.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // dtgvUnit
            // 
            this.dtgvUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvUnit.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvUnit.Location = new System.Drawing.Point(0, 0);
            this.dtgvUnit.MainView = this.gvUnit;
            this.dtgvUnit.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvUnit.Name = "dtgvUnit";
            this.dtgvUnit.Size = new System.Drawing.Size(656, 310);
            this.dtgvUnit.TabIndex = 0;
            this.dtgvUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUnit});
            // 
            // gvUnit
            // 
            this.gvUnit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colName,
            this.colNote});
            this.gvUnit.DetailHeight = 512;
            this.gvUnit.GridControl = this.dtgvUnit;
            this.gvUnit.GroupPanelText = " ";
            this.gvUnit.Name = "gvUnit";
            this.gvUnit.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvUnit.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvUnit_RowClick);
            this.gvUnit.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvUnit_CustomDrawCell);
            // 
            // colSTT
            // 
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.Caption = "STT";
            this.colSTT.MinWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 45;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 30;
            this.colID.Name = "colID";
            this.colID.Width = 112;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "Tên Đơn Vị Tính";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 30;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 289;
            // 
            // colNote
            // 
            this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNote.AppearanceHeader.Options.UseFont = true;
            this.colNote.Caption = "Ghi chú";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 30;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 2;
            this.colNote.Width = 294;
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 533);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm ĐơnVị Tính";
            this.Load += new System.EventHandler(this.frmUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.gbAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.GroupBox gbAction;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl lbControlNote;
        private DevExpress.XtraEditors.TextEdit txtUnitName;
        private DevExpress.XtraEditors.LabelControl lbControlUnitName;
        private DevExpress.XtraEditors.MemoEdit mmedNote;
        private DevExpress.XtraGrid.GridControl dtgvUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
    }
}