namespace PM_QuanLyKhoHang.FormDetails
{
    partial class frmPath
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
            this.pnlControlPath = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.lbControlPath = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControlPath)).BeginInit();
            this.pnlControlPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlPath
            // 
            this.pnlControlPath.Controls.Add(this.btnCancel);
            this.pnlControlPath.Controls.Add(this.btnOK);
            this.pnlControlPath.Controls.Add(this.txtPath);
            this.pnlControlPath.Controls.Add(this.lbControlPath);
            this.pnlControlPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlPath.Location = new System.Drawing.Point(0, 0);
            this.pnlControlPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlControlPath.Name = "pnlControlPath";
            this.pnlControlPath.Size = new System.Drawing.Size(644, 152);
            this.pnlControlPath.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(315, 104);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Thoát";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(170, 104);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Chấp Nhận";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(18, 45);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(608, 26);
            this.txtPath.TabIndex = 0;
            // 
            // lbControlPath
            // 
            this.lbControlPath.Location = new System.Drawing.Point(18, 18);
            this.lbControlPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbControlPath.Name = "lbControlPath";
            this.lbControlPath.Size = new System.Drawing.Size(119, 19);
            this.lbControlPath.TabIndex = 0;
            this.lbControlPath.Text = "Nhập đường dẫn";
            // 
            // frmPath
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(644, 152);
            this.Controls.Add(this.pnlControlPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPath";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đường dẫn";
            ((System.ComponentModel.ISupportInitialize)(this.pnlControlPath)).EndInit();
            this.pnlControlPath.ResumeLayout(false);
            this.pnlControlPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlControlPath;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.TextEdit txtPath;
        private DevExpress.XtraEditors.LabelControl lbControlPath;
    }
}