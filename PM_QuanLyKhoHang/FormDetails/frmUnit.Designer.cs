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
            this.gvUnit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtgvDisplay = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.dtgvDisplay);
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
            this.gbAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAction.Name = "gbAction";
            this.gbAction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAction.Size = new System.Drawing.Size(166, 189);
            this.gbAction.TabIndex = 2;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Thao tác";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(24, 146);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.ToolTip = "Cập nhật đơn vị tính";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 104);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.ToolTip = "Xóa đơn vị tính này";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(24, 64);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.ToolTip = "Hủy thao tác thêm này";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.ToolTip = "Thêm đơn vị tính mới";
            // 
            // lbControlNote
            // 
            this.lbControlNote.Location = new System.Drawing.Point(40, 73);
            this.lbControlNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbControlNote.Name = "lbControlNote";
            this.lbControlNote.Size = new System.Drawing.Size(54, 19);
            this.lbControlNote.TabIndex = 0;
            this.lbControlNote.Text = "Ghi chú";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(124, 35);
            this.txtUnitName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(320, 26);
            this.txtUnitName.TabIndex = 1;
            this.txtUnitName.ToolTip = "Tên đơn vị";
            this.txtUnitName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbControlUnitName
            // 
            this.lbControlUnitName.Location = new System.Drawing.Point(40, 35);
            this.lbControlUnitName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbControlUnitName.Name = "lbControlUnitName";
            this.lbControlUnitName.Size = new System.Drawing.Size(76, 19);
            this.lbControlUnitName.TabIndex = 0;
            this.lbControlUnitName.Text = "Tên đơn vị";
            // 
            // mmedNote
            // 
            this.mmedNote.Location = new System.Drawing.Point(124, 73);
            this.mmedNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mmedNote.Name = "mmedNote";
            this.mmedNote.Size = new System.Drawing.Size(320, 89);
            this.mmedNote.TabIndex = 2;
            this.mmedNote.ToolTip = "Ghi chú cho tên đơn vị này";
            this.mmedNote.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // gvUnit
            // 
            this.gvUnit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colID,
            this.colUnitName,
            this.colNote});
            this.gvUnit.DetailHeight = 512;
            this.gvUnit.GridControl = this.dtgvDisplay;
            this.gvUnit.GroupPanelText = " ";
            this.gvUnit.Name = "gvUnit";
            this.gvUnit.OptionsEditForm.PopupEditFormWidth = 1200;
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
            // colUnitName
            // 
            this.colUnitName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colUnitName.AppearanceHeader.Options.UseFont = true;
            this.colUnitName.Caption = "Tên Đơn Vị Tính";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.MinWidth = 30;
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 1;
            this.colUnitName.Width = 289;
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
            // dtgvDisplay
            // 
            this.dtgvDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDisplay.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDisplay.Location = new System.Drawing.Point(0, 0);
            this.dtgvDisplay.MainView = this.gvUnit;
            this.dtgvDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDisplay.Name = "dtgvDisplay";
            this.dtgvDisplay.Size = new System.Drawing.Size(656, 310);
            this.dtgvDisplay.TabIndex = 0;
            this.dtgvDisplay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUnit});
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 533);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm ĐơnVị Tính";
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
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisplay)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dtgvDisplay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
    }
}