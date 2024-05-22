namespace PM_QuanLyKhoHang.UserControlDetails
{
    partial class UcProductPriceChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.lbEndDate = new DevExpress.XtraEditors.LabelControl();
            this.lbProduct = new DevExpress.XtraEditors.LabelControl();
            this.lbStartDate = new DevExpress.XtraEditors.LabelControl();
            this.cbEndDate = new System.Windows.Forms.ComboBox();
            this.cbStartDate = new System.Windows.Forms.ComboBox();
            this.rdPeriod = new System.Windows.Forms.RadioButton();
            this.rdByYear = new System.Windows.Forms.RadioButton();
            this.pnlChart = new DevExpress.XtraEditors.PanelControl();
            this.chartProductPrice = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlChart)).BeginInit();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.Controls.Add(this.cbProduct);
            this.pnlSearch.Controls.Add(this.btnShow);
            this.pnlSearch.Controls.Add(this.lbEndDate);
            this.pnlSearch.Controls.Add(this.lbProduct);
            this.pnlSearch.Controls.Add(this.lbStartDate);
            this.pnlSearch.Controls.Add(this.cbEndDate);
            this.pnlSearch.Controls.Add(this.cbStartDate);
            this.pnlSearch.Controls.Add(this.rdPeriod);
            this.pnlSearch.Controls.Add(this.rdByYear);
            this.pnlSearch.Location = new System.Drawing.Point(0, 6);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(960, 128);
            this.pnlSearch.TabIndex = 0;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(726, 9);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(228, 27);
            this.cbProduct.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(606, 54);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 35);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Hiển &Thị";
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(342, 62);
            this.lbEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(28, 19);
            this.lbEndDate.TabIndex = 4;
            this.lbEndDate.Text = "Đến";
            this.lbEndDate.Visible = false;
            // 
            // lbProduct
            // 
            this.lbProduct.Location = new System.Drawing.Point(605, 12);
            this.lbProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(113, 19);
            this.lbProduct.TabIndex = 3;
            this.lbProduct.Text = "Chọn Sản Phẩm";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(9, 62);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(104, 19);
            this.lbStartDate.TabIndex = 3;
            this.lbStartDate.Text = "Chọn thời gian";
            // 
            // cbEndDate
            // 
            this.cbEndDate.FormattingEnabled = true;
            this.cbEndDate.Location = new System.Drawing.Point(394, 57);
            this.cbEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEndDate.Name = "cbEndDate";
            this.cbEndDate.Size = new System.Drawing.Size(180, 27);
            this.cbEndDate.TabIndex = 4;
            this.cbEndDate.Visible = false;
            // 
            // cbStartDate
            // 
            this.cbStartDate.FormattingEnabled = true;
            this.cbStartDate.Location = new System.Drawing.Point(124, 57);
            this.cbStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStartDate.Name = "cbStartDate";
            this.cbStartDate.Size = new System.Drawing.Size(180, 27);
            this.cbStartDate.TabIndex = 3;
            // 
            // rdPeriod
            // 
            this.rdPeriod.AutoSize = true;
            this.rdPeriod.Location = new System.Drawing.Point(288, 9);
            this.rdPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdPeriod.Name = "rdPeriod";
            this.rdPeriod.Size = new System.Drawing.Size(289, 23);
            this.rdPeriod.TabIndex = 1;
            this.rdPeriod.Text = "Biến động giá trong khoản thời gian";
            this.rdPeriod.UseVisualStyleBackColor = true;
            this.rdPeriod.CheckedChanged += new System.EventHandler(this.RdPeriod_CheckedChanged);
            // 
            // rdByYear
            // 
            this.rdByYear.AutoSize = true;
            this.rdByYear.Checked = true;
            this.rdByYear.Location = new System.Drawing.Point(27, 9);
            this.rdByYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdByYear.Name = "rdByYear";
            this.rdByYear.Size = new System.Drawing.Size(226, 23);
            this.rdByYear.TabIndex = 0;
            this.rdByYear.TabStop = true;
            this.rdByYear.Text = "Biến động Giá trong 1 năm";
            this.rdByYear.UseVisualStyleBackColor = true;
            this.rdByYear.CheckedChanged += new System.EventHandler(this.RdByYear_CheckedChanged);
            // 
            // pnlChart
            // 
            this.pnlChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChart.Controls.Add(this.chartProductPrice);
            this.pnlChart.Location = new System.Drawing.Point(0, 129);
            this.pnlChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(960, 337);
            this.pnlChart.TabIndex = 1;
            // 
            // chartProductPrice
            // 
            chartArea4.Name = "ChartArea1";
            this.chartProductPrice.ChartAreas.Add(chartArea4);
            this.chartProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartProductPrice.Legends.Add(legend4);
            this.chartProductPrice.Location = new System.Drawing.Point(2, 2);
            this.chartProductPrice.Name = "chartProductPrice";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartProductPrice.Series.Add(series4);
            this.chartProductPrice.Size = new System.Drawing.Size(956, 333);
            this.chartProductPrice.TabIndex = 0;
            this.chartProductPrice.Text = "chart1";
            // 
            // ucProductPriceChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.pnlSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucProductPriceChart";
            this.Size = new System.Drawing.Size(960, 471);
            this.Load += new System.EventHandler(this.UcProductPriceChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlChart)).EndInit();
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProductPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlSearch;
        private System.Windows.Forms.RadioButton rdPeriod;
        private System.Windows.Forms.RadioButton rdByYear;
        private DevExpress.XtraEditors.PanelControl pnlChart;
        private DevExpress.XtraEditors.LabelControl lbEndDate;
        private DevExpress.XtraEditors.LabelControl lbStartDate;
        private System.Windows.Forms.ComboBox cbEndDate;
        private System.Windows.Forms.ComboBox cbStartDate;
        private DevExpress.XtraEditors.SimpleButton btnShow;
        private System.Windows.Forms.ComboBox cbProduct;
        private DevExpress.XtraEditors.LabelControl lbProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductPrice;
    }
}
