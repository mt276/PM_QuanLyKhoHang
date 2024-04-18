namespace PM_QuanLyKhoHang.FormDetails
{
    partial class frmBackupAndRestoreDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupAndRestoreDatabase));
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.radioButtonBK = new System.Windows.Forms.RadioButton();
            this.radioButtonRS = new System.Windows.Forms.RadioButton();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(51, 99);
            this.lbName.Margin = new System.Windows.Forms.Padding(4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(351, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Chọn đường dẫn đến thu mục cần backup dữ liệu";
            // 
            // radioButtonBK
            // 
            this.radioButtonBK.AutoSize = true;
            this.radioButtonBK.Checked = true;
            this.radioButtonBK.Location = new System.Drawing.Point(36, 50);
            this.radioButtonBK.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonBK.Name = "radioButtonBK";
            this.radioButtonBK.Size = new System.Drawing.Size(153, 23);
            this.radioButtonBK.TabIndex = 0;
            this.radioButtonBK.TabStop = true;
            this.radioButtonBK.Text = "Backup Database";
            this.radioButtonBK.UseVisualStyleBackColor = true;
            this.radioButtonBK.CheckedChanged += new System.EventHandler(this.radioButtonBK_CheckedChanged);
            // 
            // radioButtonRS
            // 
            this.radioButtonRS.AutoSize = true;
            this.radioButtonRS.Location = new System.Drawing.Point(348, 50);
            this.radioButtonRS.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRS.Name = "radioButtonRS";
            this.radioButtonRS.Size = new System.Drawing.Size(156, 23);
            this.radioButtonRS.TabIndex = 1;
            this.radioButtonRS.Text = "Restore Database";
            this.radioButtonRS.UseVisualStyleBackColor = true;
            this.radioButtonRS.CheckedChanged += new System.EventHandler(this.radioButtonRS_CheckedChanged);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(51, 127);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(480, 26);
            this.txtPath.TabIndex = 2;
            this.txtPath.DoubleClick += new System.EventHandler(this.txtPath_DoubleClick);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(134, 187);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&Đồng ý";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(290, 187);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmBackupAndRestoreDatabase
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(608, 240);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.radioButtonRS);
            this.Controls.Add(this.radioButtonBK);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmBackupAndRestoreDatabase.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupAndRestoreDatabase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup End Restore Database";
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbName;
        private System.Windows.Forms.RadioButton radioButtonBK;
        private System.Windows.Forms.RadioButton radioButtonRS;
        private DevExpress.XtraEditors.TextEdit txtPath;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}