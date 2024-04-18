namespace PM_QuanLyKhoHang.FormDetails
{
    partial class frmUpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateCustomer));
            this.dedDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.txtPhoneRepresentative = new DevExpress.XtraEditors.TextEdit();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            this.lbDateCreated = new DevExpress.XtraEditors.LabelControl();
            this.lbFax = new DevExpress.XtraEditors.LabelControl();
            this.txtNameRepresentative = new DevExpress.XtraEditors.TextEdit();
            this.lbPhoneRepresentative = new DevExpress.XtraEditors.LabelControl();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.lbNameRepresentative = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.lbPhone = new DevExpress.XtraEditors.LabelControl();
            this.lbAddress = new DevExpress.XtraEditors.LabelControl();
            this.lbCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.mmedAddress = new DevExpress.XtraEditors.MemoEdit();
            this.mmedNote = new DevExpress.XtraEditors.MemoEdit();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneRepresentative.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameRepresentative.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dedDateCreated
            // 
            this.dedDateCreated.EditValue = null;
            this.dedDateCreated.Location = new System.Drawing.Point(782, 155);
            this.dedDateCreated.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dedDateCreated.Name = "dedDateCreated";
            this.dedDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedDateCreated.Size = new System.Drawing.Size(264, 26);
            this.dedDateCreated.TabIndex = 7;
            this.dedDateCreated.ToolTip = "Ngày công ty tham gia hệ thống";
            this.dedDateCreated.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // txtPhoneRepresentative
            // 
            this.txtPhoneRepresentative.Location = new System.Drawing.Point(782, 105);
            this.txtPhoneRepresentative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneRepresentative.Name = "txtPhoneRepresentative";
            this.txtPhoneRepresentative.Size = new System.Drawing.Size(262, 26);
            this.txtPhoneRepresentative.TabIndex = 6;
            this.txtPhoneRepresentative.ToolTip = "Số điện thoại người đại diện";
            this.txtPhoneRepresentative.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbNote
            // 
            this.lbNote.Location = new System.Drawing.Point(1076, 7);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(57, 19);
            this.lbNote.TabIndex = 10;
            this.lbNote.Text = "Ghi Chú";
            // 
            // lbDateCreated
            // 
            this.lbDateCreated.Location = new System.Drawing.Point(696, 157);
            this.lbDateCreated.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbDateCreated.Name = "lbDateCreated";
            this.lbDateCreated.Size = new System.Drawing.Size(68, 19);
            this.lbDateCreated.TabIndex = 11;
            this.lbDateCreated.Text = "Ngày Tạo";
            // 
            // lbFax
            // 
            this.lbFax.Location = new System.Drawing.Point(729, 7);
            this.lbFax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbFax.Name = "lbFax";
            this.lbFax.Size = new System.Drawing.Size(24, 19);
            this.lbFax.TabIndex = 9;
            this.lbFax.Text = "Fax";
            // 
            // txtNameRepresentative
            // 
            this.txtNameRepresentative.Location = new System.Drawing.Point(782, 55);
            this.txtNameRepresentative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameRepresentative.Name = "txtNameRepresentative";
            this.txtNameRepresentative.Size = new System.Drawing.Size(262, 26);
            this.txtNameRepresentative.TabIndex = 5;
            this.txtNameRepresentative.ToolTip = "Tên người đại diện";
            this.txtNameRepresentative.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbPhoneRepresentative
            // 
            this.lbPhoneRepresentative.Location = new System.Drawing.Point(555, 107);
            this.lbPhoneRepresentative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPhoneRepresentative.Name = "lbPhoneRepresentative";
            this.lbPhoneRepresentative.Size = new System.Drawing.Size(213, 19);
            this.lbPhoneRepresentative.TabIndex = 4;
            this.lbPhoneRepresentative.Text = "Số Điện Thoại Người Đại Diện";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(782, 5);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(264, 26);
            this.txtFax.TabIndex = 4;
            this.txtFax.ToolTip = "Fax";
            this.txtFax.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbNameRepresentative
            // 
            this.lbNameRepresentative.Location = new System.Drawing.Point(627, 57);
            this.lbNameRepresentative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNameRepresentative.Name = "lbNameRepresentative";
            this.lbNameRepresentative.Size = new System.Drawing.Size(140, 19);
            this.lbNameRepresentative.TabIndex = 6;
            this.lbNameRepresentative.Text = "Tên Người Đại Diện";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(116, 174);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(418, 26);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.ToolTip = "Số Điện thoại liên lạc";
            this.txtPhone.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // lbPhone
            // 
            this.lbPhone.Location = new System.Drawing.Point(8, 177);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(100, 19);
            this.lbPhone.TabIndex = 8;
            this.lbPhone.Text = "Số Điện Thoại";
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(8, 61);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(51, 19);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "Địa Chỉ";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Location = new System.Drawing.Point(8, 7);
            this.lbCompanyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(92, 19);
            this.lbCompanyName.TabIndex = 5;
            this.lbCompanyName.Text = "Tên Công Ty";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(116, 5);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(418, 26);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.ToolTip = "Tên công ty cần thêm mới";
            this.txtCompanyName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // mmedAddress
            // 
            this.mmedAddress.Location = new System.Drawing.Point(116, 57);
            this.mmedAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mmedAddress.Name = "mmedAddress";
            this.mmedAddress.Size = new System.Drawing.Size(418, 89);
            this.mmedAddress.TabIndex = 2;
            this.mmedAddress.ToolTip = "Địa chỉ công ty";
            this.mmedAddress.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // mmedNote
            // 
            this.mmedNote.Location = new System.Drawing.Point(1076, 37);
            this.mmedNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mmedNote.Name = "mmedNote";
            this.mmedNote.Size = new System.Drawing.Size(338, 159);
            this.mmedNote.TabIndex = 8;
            this.mmedNote.ToolTip = "Ghi Chú thêm về công ty này";
            this.mmedNote.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1158, 205);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "&Cập Nhật";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1293, 205);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Hủy Thao Tác";
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 256);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dedDateCreated);
            this.Controls.Add(this.txtPhoneRepresentative);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbDateCreated);
            this.Controls.Add(this.lbFax);
            this.Controls.Add(this.txtNameRepresentative);
            this.Controls.Add(this.lbPhoneRepresentative);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.lbNameRepresentative);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.mmedAddress);
            this.Controls.Add(this.mmedNote);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmUpdateCustomer.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateCustomer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Thông Tin Của Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dedDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneRepresentative.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameRepresentative.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmedNote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dedDateCreated;
        private DevExpress.XtraEditors.TextEdit txtPhoneRepresentative;
        private DevExpress.XtraEditors.LabelControl lbNote;
        private DevExpress.XtraEditors.LabelControl lbDateCreated;
        private DevExpress.XtraEditors.LabelControl lbFax;
        private DevExpress.XtraEditors.TextEdit txtNameRepresentative;
        private DevExpress.XtraEditors.LabelControl lbPhoneRepresentative;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.LabelControl lbNameRepresentative;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl lbPhone;
        private DevExpress.XtraEditors.LabelControl lbAddress;
        private DevExpress.XtraEditors.LabelControl lbCompanyName;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.MemoEdit mmedAddress;
        private DevExpress.XtraEditors.MemoEdit mmedNote;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}