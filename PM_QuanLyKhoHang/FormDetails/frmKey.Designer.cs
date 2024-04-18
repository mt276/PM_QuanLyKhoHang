namespace PM_QuanLyKhoHang.FormDetails
{
    partial class frmKey
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
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.gbKey = new System.Windows.Forms.GroupBox();
            this.txtKey = new DevExpress.XtraEditors.TextEdit();
            this.linklbPurchaseTheLicense = new System.Windows.Forms.LinkLabel();
            this.gbKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(192, 120);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&Kích Hoạt";
            this.btnOK.ToolTipTitle = "Kích hoạt key bản quyền";
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(314, 120);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(112, 34);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Thoát";
            this.btncancel.ToolTipTitle = "Thoát khỏi chức năng này";
            // 
            // gbKey
            // 
            this.gbKey.Controls.Add(this.txtKey);
            this.gbKey.Location = new System.Drawing.Point(18, 1);
            this.gbKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKey.Name = "gbKey";
            this.gbKey.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKey.Size = new System.Drawing.Size(440, 80);
            this.gbKey.TabIndex = 1;
            this.gbKey.TabStop = false;
            this.gbKey.Text = "CD Key";
            // 
            // txtKey
            // 
            this.txtKey.EditValue = "";
            this.txtKey.Location = new System.Drawing.Point(9, 29);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(420, 26);
            this.txtKey.TabIndex = 0;
            // 
            // linklbPurchaseTheLicense
            // 
            this.linklbPurchaseTheLicense.AutoSize = true;
            this.linklbPurchaseTheLicense.Location = new System.Drawing.Point(40, 126);
            this.linklbPurchaseTheLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklbPurchaseTheLicense.Name = "linklbPurchaseTheLicense";
            this.linklbPurchaseTheLicense.Size = new System.Drawing.Size(117, 19);
            this.linklbPurchaseTheLicense.TabIndex = 2;
            this.linklbPurchaseTheLicense.TabStop = true;
            this.linklbPurchaseTheLicense.Text = "Mua bản quyền";
            // 
            // frmKey
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(465, 158);
            this.Controls.Add(this.linklbPurchaseTheLicense);
            this.Controls.Add(this.gbKey);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKey";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Key Bản Quyền";
            this.gbKey.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private System.Windows.Forms.GroupBox gbKey;
        private System.Windows.Forms.LinkLabel linklbPurchaseTheLicense;
        private DevExpress.XtraEditors.TextEdit txtKey;
    }
}