namespace PM_QuanLyKhoHang.FormDetails
{
    partial class frmLocation
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
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.cbDatabaseName = new System.Windows.Forms.ComboBox();
            this.lbDatabaseName = new System.Windows.Forms.Label();
            this.gbLogOn = new System.Windows.Forms.GroupBox();
            this.rdSqlServer = new System.Windows.Forms.RadioButton();
            this.rdwindows = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtDataSourse = new System.Windows.Forms.TextBox();
            this.txtSeverName = new System.Windows.Forms.TextBox();
            this.lbServerName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbDataSource = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.gbConnect.SuspendLayout();
            this.gbLogOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbConnect);
            this.pnlMain.Controls.Add(this.gbLogOn);
            this.pnlMain.Controls.Add(this.txtDataSourse);
            this.pnlMain.Controls.Add(this.txtSeverName);
            this.pnlMain.Controls.Add(this.lbServerName);
            this.pnlMain.Controls.Add(this.btnOK);
            this.pnlMain.Controls.Add(this.btnTestConnection);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.lbDataSource);
            this.pnlMain.Controls.Add(this.btnChange);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(658, 551);
            this.pnlMain.TabIndex = 0;
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.cbDatabaseName);
            this.gbConnect.Controls.Add(this.lbDatabaseName);
            this.gbConnect.Location = new System.Drawing.Point(32, 373);
            this.gbConnect.Margin = new System.Windows.Forms.Padding(4);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Padding = new System.Windows.Forms.Padding(4);
            this.gbConnect.Size = new System.Drawing.Size(609, 126);
            this.gbConnect.TabIndex = 16;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Connect to a database";
            // 
            // cbDatabaseName
            // 
            this.cbDatabaseName.FormattingEnabled = true;
            this.cbDatabaseName.Location = new System.Drawing.Point(18, 69);
            this.cbDatabaseName.Margin = new System.Windows.Forms.Padding(4);
            this.cbDatabaseName.Name = "cbDatabaseName";
            this.cbDatabaseName.Size = new System.Drawing.Size(500, 27);
            this.cbDatabaseName.TabIndex = 5;
            // 
            // lbDatabaseName
            // 
            this.lbDatabaseName.AutoSize = true;
            this.lbDatabaseName.Location = new System.Drawing.Point(14, 45);
            this.lbDatabaseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatabaseName.Name = "lbDatabaseName";
            this.lbDatabaseName.Size = new System.Drawing.Size(228, 19);
            this.lbDatabaseName.TabIndex = 0;
            this.lbDatabaseName.Text = "Select or enter database name:";
            // 
            // gbLogOn
            // 
            this.gbLogOn.Controls.Add(this.rdSqlServer);
            this.gbLogOn.Controls.Add(this.rdwindows);
            this.gbLogOn.Controls.Add(this.txtPassword);
            this.gbLogOn.Controls.Add(this.txtUserName);
            this.gbLogOn.Controls.Add(this.lbUserName);
            this.gbLogOn.Controls.Add(this.lbPassword);
            this.gbLogOn.Location = new System.Drawing.Point(32, 174);
            this.gbLogOn.Margin = new System.Windows.Forms.Padding(4);
            this.gbLogOn.Name = "gbLogOn";
            this.gbLogOn.Padding = new System.Windows.Forms.Padding(4);
            this.gbLogOn.Size = new System.Drawing.Size(609, 189);
            this.gbLogOn.TabIndex = 15;
            this.gbLogOn.TabStop = false;
            this.gbLogOn.Text = "Log on to the server:";
            // 
            // rdSqlServer
            // 
            this.rdSqlServer.AutoSize = true;
            this.rdSqlServer.Location = new System.Drawing.Point(18, 70);
            this.rdSqlServer.Margin = new System.Windows.Forms.Padding(4);
            this.rdSqlServer.Name = "rdSqlServer";
            this.rdSqlServer.Size = new System.Drawing.Size(251, 23);
            this.rdSqlServer.TabIndex = 2;
            this.rdSqlServer.TabStop = true;
            this.rdSqlServer.Text = "Use SQL Server Authentication";
            this.rdSqlServer.UseVisualStyleBackColor = true;
            this.rdSqlServer.CheckedChanged += new System.EventHandler(this.rdSqlServer_CheckedChanged);
            // 
            // rdwindows
            // 
            this.rdwindows.AutoSize = true;
            this.rdwindows.Location = new System.Drawing.Point(18, 37);
            this.rdwindows.Margin = new System.Windows.Forms.Padding(4);
            this.rdwindows.Name = "rdwindows";
            this.rdwindows.Size = new System.Drawing.Size(236, 23);
            this.rdwindows.TabIndex = 1;
            this.rdwindows.TabStop = true;
            this.rdwindows.Text = "Use Windows Authentication";
            this.rdwindows.UseVisualStyleBackColor = true;
            this.rdwindows.CheckedChanged += new System.EventHandler(this.rdwindows_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(129, 142);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(390, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(129, 104);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(390, 27);
            this.txtUserName.TabIndex = 3;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(14, 108);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(91, 19);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User name:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(14, 146);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(82, 19);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password:";
            // 
            // txtDataSourse
            // 
            this.txtDataSourse.Enabled = false;
            this.txtDataSourse.Location = new System.Drawing.Point(32, 35);
            this.txtDataSourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataSourse.Name = "txtDataSourse";
            this.txtDataSourse.Size = new System.Drawing.Size(390, 27);
            this.txtDataSourse.TabIndex = 0;
            this.txtDataSourse.Text = "Microsoft SQL Server (SqlClient)";
            // 
            // txtSeverName
            // 
            this.txtSeverName.Location = new System.Drawing.Point(32, 111);
            this.txtSeverName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeverName.Name = "txtSeverName";
            this.txtSeverName.Size = new System.Drawing.Size(390, 27);
            this.txtSeverName.TabIndex = 0;
            // 
            // lbServerName
            // 
            this.lbServerName.AutoSize = true;
            this.lbServerName.Location = new System.Drawing.Point(27, 89);
            this.lbServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServerName.Name = "lbServerName";
            this.lbServerName.Size = new System.Drawing.Size(106, 19);
            this.lbServerName.TabIndex = 6;
            this.lbServerName.Text = "Server Name:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(279, 507);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 34);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(74, 507);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(157, 34);
            this.btnTestConnection.TabIndex = 6;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(448, 507);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(448, 108);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 34);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbDataSource
            // 
            this.lbDataSource.AutoSize = true;
            this.lbDataSource.Location = new System.Drawing.Point(27, 12);
            this.lbDataSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataSource.Name = "lbDataSource";
            this.lbDataSource.Size = new System.Drawing.Size(94, 19);
            this.lbDataSource.TabIndex = 7;
            this.lbDataSource.Text = "Data Source";
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(448, 35);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(112, 34);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change...";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // frmLocation
            // 
            this.AcceptButton = this.btnRefresh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 551);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocation";
            this.ShowInTaskbar = false;
            this.Text = "Cấu hình đường dẫn đến Sql Server";
            this.Load += new System.EventHandler(this.frmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbConnect.ResumeLayout(false);
            this.gbConnect.PerformLayout();
            this.gbLogOn.ResumeLayout(false);
            this.gbLogOn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.ComboBox cbDatabaseName;
        private System.Windows.Forms.Label lbDatabaseName;
        private System.Windows.Forms.GroupBox gbLogOn;
        private System.Windows.Forms.RadioButton rdSqlServer;
        private System.Windows.Forms.RadioButton rdwindows;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtDataSourse;
        private System.Windows.Forms.TextBox txtSeverName;
        private System.Windows.Forms.Label lbServerName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbDataSource;
        private System.Windows.Forms.Button btnChange;
    }
}