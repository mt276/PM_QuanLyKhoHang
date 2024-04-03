using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyKhoHang
{
    public partial class MainWinform : BaseForm
    {
        public MainWinform()
        {
            InitializeComponent();
            
            this.Width = 760;
            this.Height = 600;
            SetUpMenu();
            SetUpFilterFirst();
            SetUpFilterSecond();
            
        }

        void SetUpMenu()
        {
            #region flpMenu
            // Tạo flpMenu
            FlowLayoutPanel flpMenu = new FlowLayoutPanel();
            flpMenu.FlowDirection = FlowDirection.LeftToRight;
            flpMenu.AutoSize = true;
            flpMenu.Size = new Size(this.ClientSize.Width, 50);
            flpMenu.BackColor = Color.White;
            //flpMenu.FontChanged += (sender, e) =>
            //{
            //    flpMenu.Font = new Font("Roboto", 9, FontStyle.Bold);
            //    // Lặp qua tất cả các control trong panel và thay đổi font của chúng
            //    foreach (Control control in flpMenu.Controls)
            //    {
            //        control.Font = flpMenu.Font;
            //    }
            //};
            this.Controls.Add(flpMenu);
            #endregion

            #region btnInput
            //Tạo và thiết lập button Nhập kho
            Button btnInput = new Button();
            btnInput.Text = "Nhập kho";
            btnInput.Size = new Size(100, 30);
            Image imgInput = Image.FromFile(Application.StartupPath + "\\image\\input.png");
            Image rzImgInput = new Bitmap(imgInput, new Size(22, 22));
            btnInput.Image = rzImgInput;
            btnInput.ImageAlign = ContentAlignment.MiddleCenter;
            btnInput.AutoSize = true;
            btnInput.TextImageRelation = TextImageRelation.TextAboveImage;
            btnInput.BackColor = Color.LightCyan;
            btnInput.FlatStyle = FlatStyle.Flat;
            btnInput.FlatAppearance.BorderSize = 1;
            flpMenu.Controls.Add(btnInput);
            btnInput.Click += (sender, e) =>
            {
                InputWinform inputWinform = new InputWinform();
                inputWinform.Show();
            };
            #endregion

            #region btnOutput
            //Tạo và thiết lập button Nhập kho
            Button btnOutput = new Button();
            btnOutput.Text = "Xuất kho";
            btnOutput.Size = new Size(100, 30);
            Image imgOutput = Image.FromFile(Application.StartupPath + "\\image\\output.png");
            Image rzImgOutput = new Bitmap(imgOutput, new Size(22, 22));
            btnOutput.Image = rzImgOutput;
            btnOutput.ImageAlign = ContentAlignment.MiddleCenter;
            btnOutput.AutoSize = true;
            btnOutput.TextImageRelation = TextImageRelation.TextAboveImage;
            btnOutput.BackColor = Color.LightCyan;
            btnOutput.FlatStyle = FlatStyle.Flat;
            btnOutput.FlatAppearance.BorderSize = 1;
            flpMenu.Controls.Add(btnOutput);
            btnOutput.Click += (sender, e) =>
            {
                OutputWinform outputWinform = new OutputWinform();
                outputWinform.Show();
            };
            #endregion

            #region btnSupplies
            // Tạo và thiết lập button Vật tư
            Button btnSupplies = new Button();
            btnSupplies.Text = "Vật tư";
            btnSupplies.Size = new Size(100, 30);
            Image imgSupplies = Image.FromFile(Application.StartupPath + "\\image\\supplies.png");
            Image rzImgSupplies = new Bitmap(imgSupplies, new Size(22, 22));
            btnSupplies.Image = rzImgSupplies;
            btnSupplies.ImageAlign = ContentAlignment.MiddleCenter;
            btnSupplies.AutoSize = true;
            btnSupplies.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSupplies.BackColor = Color.LightCyan;
            btnSupplies.FlatStyle = FlatStyle.Flat;
            btnSupplies.FlatAppearance.BorderSize = 1;
            flpMenu.Controls.Add(btnSupplies);
            btnSupplies.Click += (sender, e) =>
            {
                SuppliesWinform suppliesWinform = new SuppliesWinform();
                suppliesWinform.Show();
            };
            #endregion

            #region btnUnit
            // Tạo và thiết lập button Đơn vị
            Button btnUnit = new Button();
            btnUnit.Text = "Đơn vị đo";
            btnUnit.Size = new Size(100, 30);
            Image imgUnit = Image.FromFile(Application.StartupPath + "\\image\\unit.png");
            Image rzImgUnit = new Bitmap(imgUnit, new Size(22, 22));
            btnUnit.Image = rzImgUnit;
            btnUnit.ImageAlign = ContentAlignment.MiddleCenter;
            btnUnit.AutoSize = true;
            btnUnit.TextImageRelation = TextImageRelation.TextAboveImage;
            btnUnit.BackColor = Color.LightCyan;
            btnUnit.FlatStyle = FlatStyle.Flat;
            btnUnit.FlatAppearance.BorderSize = 1;
            flpMenu.Controls.Add(btnUnit);
            btnUnit.Click += (sender, e) =>
            {
                UnitWinform unitWinform = new UnitWinform();
                unitWinform.Show();
            };
            #endregion

            #region btnSupplier
            // Tạo và thiết lập button Nhà cung cấp
            Button btnSupplier = new Button();
            btnSupplier.Text = "Nhà cung cấp";
            btnSupplier.Size = new Size(100, 30);
            Image imgSupplier = Image.FromFile(Application.StartupPath + "\\image\\supplier.png");
            Image rzImgSupplier = new Bitmap(imgSupplier, new Size(22, 22));
            btnSupplier.Image = rzImgSupplier;
            btnSupplier.ImageAlign = ContentAlignment.MiddleCenter;
            btnSupplier.AutoSize = true;
            btnSupplier.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSupplier.BackColor = Color.LightCyan;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.FlatAppearance.BorderSize = 1;
            flpMenu.Controls.Add(btnSupplier);
            btnSupplier.Click += (sender, e) =>
            {
                SupplierWinform supplierWinform = new SupplierWinform();
                supplierWinform.Show();
            };
            #endregion

            #region btnCustomer
            // Tạo và thiết lập button Khách hàng
            Button btnCustomer = new Button();
            btnCustomer.Text = "Khách hàng";
            btnCustomer.Size = new Size(100, 30);
            Image imgCustomer = Image.FromFile(Application.StartupPath + "\\image\\customer.png");
            Image rzImgCustomer = new Bitmap(imgCustomer, new Size(22, 22));
            btnCustomer.Image = rzImgCustomer;
            btnCustomer.ImageAlign = ContentAlignment.MiddleCenter;
            btnCustomer.AutoSize = true;
            btnCustomer.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCustomer.BackColor = Color.LightCyan;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.FlatAppearance.BorderSize = 1;
            flpMenu.Controls.Add(btnCustomer);
            btnCustomer.Click += (sender, e) =>
            {
                CustomerWinform customerWinform = new CustomerWinform();
                customerWinform.Show();
            };
            #endregion

            #region btnUser
            // Tạo và thiết lập button Người dùng
            Button btnUser = new Button();
            btnUser.Text = "Người dùng";
            btnUser.Size = new Size(100, 30);
            Image imgUser = Image.FromFile(Application.StartupPath + "\\image\\user.png");
            Image rzImgUser = new Bitmap(imgUser, new Size(22, 22));
            btnUser.Image = rzImgUser;
            btnUser.ImageAlign = ContentAlignment.MiddleCenter;
            btnUser.AutoSize = true;
            btnUser.TextImageRelation = TextImageRelation.TextAboveImage;
            btnUser.BackColor = Color.LightCyan;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.FlatAppearance.BorderSize = 1;
            flpMenu.Controls.Add(btnUser);

            btnUser.Click += (sender, e) =>
            {
                UserWinform userWinform = new UserWinform();
                userWinform.Show();
            };
            #endregion

        }

        void SetUpFilterFirst()
        {
            #region pnlDateFilter
            // Tạo pnlDateFilter
            Panel pnlDateFilter = new Panel();
            pnlDateFilter.Size = new Size(this.ClientSize.Width, 200);
            pnlDateFilter.Location = new Point(0, 70);
            pnlDateFilter.AutoSize = true;
            pnlDateFilter.BackColor = Color.White;
            this.Controls.Add(pnlDateFilter);
            #endregion

            #region flpStartDate
            // Tạo flpStartDate
            FlowLayoutPanel flpStartDate = new FlowLayoutPanel();
            flpStartDate.Size = new Size(30, 20);
            flpStartDate.FlowDirection = FlowDirection.LeftToRight;
            flpStartDate.Location = new Point(0, 0);
            flpStartDate.AutoSize = true;
            flpStartDate.BackColor = Color.White;
            pnlDateFilter.Controls.Add(flpStartDate);
            
                #region lbStart
                Label lbStart = new Label();
                lbStart.Text = "Ngày bắt đầu:";
                lbStart.AutoSize = true;
                lbStart.Margin = new Padding(5, 5, 11, 0);
                flpStartDate.Controls.Add(lbStart);
                #endregion

                #region dtpkStart
                // Cấu hình DateTimePickerStart
                DateTimePicker dtpkStart = new DateTimePicker();
                dtpkStart.Location = new Point(10, 30);
                dtpkStart.Size = new Size(120, 20);
                dtpkStart.Format = DateTimePickerFormat.Custom;
                dtpkStart.CustomFormat = " ";
                dtpkStart.ValueChanged += (sender, e) =>
                {
                    // Đặt lại CustomFormat để hiển thị ngày tháng đã chọn
                    dtpkStart.CustomFormat = "dd/MM/yyyy";
                };
                flpStartDate.Controls.Add(dtpkStart);
            #endregion

            #endregion

            #region flpEndDate
            // Tạo flpStartDate
            FlowLayoutPanel flpEndDate = new FlowLayoutPanel();
            flpEndDate.Size = new Size(30, 20);
            flpEndDate.FlowDirection = FlowDirection.LeftToRight;
            flpEndDate.Location = new Point(0, 30);
            flpEndDate.AutoSize = true;
            flpEndDate.BackColor = Color.White;
            pnlDateFilter.Controls.Add(flpEndDate);
            
                #region lbEnd
                Label lbEnd = new Label();
                lbEnd.Text = "Ngày kết thúc:";
                lbEnd.AutoSize = true;
                lbEnd.Margin = new Padding(5, 5, 10, 0);
                flpEndDate.Controls.Add(lbEnd);
                #endregion

                #region dtpkEnd
                // Cấu hình DateTimePickerStart
                DateTimePicker dtpkEnd = new DateTimePicker();
                dtpkEnd.Location = new Point(10, 30);
                dtpkEnd.Size = new Size(120, 20);
                dtpkEnd.Format = DateTimePickerFormat.Custom;
                dtpkEnd.CustomFormat = " ";
                dtpkEnd.ValueChanged += (sender, e) =>
                {
                    // Đặt lại CustomFormat để hiển thị ngày tháng đã chọn
                    dtpkEnd.CustomFormat = "dd/MM/yyyy";
                };
                flpEndDate.Controls.Add(dtpkEnd);
            #endregion
            #endregion

            #region btnDateFilter
            // Tạo và cấu hình button "Lọc"
            Button btnDateFilter = new Button();
            btnDateFilter.Text = "Lọc";
            btnDateFilter.Location = new Point(250, 12);
            btnDateFilter.Size = new Size(100, 35);
            btnDateFilter.BackColor = Color.Teal;
            btnDateFilter.ForeColor = Color.White;
            btnDateFilter.FlatStyle = FlatStyle.Flat;
            btnDateFilter.FlatAppearance.BorderSize = 0; //loại bỏ đường viền
            btnDateFilter.Font = new Font("Roboto", 8, FontStyle.Bold);
            btnDateFilter.Click += (sender, e) =>
            {
                // Lấy ngày bắt đầu và ngày kết thúc từ DateTimePicker
                DateTime startDate = dtpkStart.Value;
                DateTime endDate = dtpkEnd.Value;

                // Hiển thị thông báo với ngày bắt đầu và ngày kết thúc đã chọn
                MessageBox.Show($"Ngày bắt đầu: {dtpkStart.Text}\nNgày kết thúc: {dtpkEnd.Text}", "Kết quả");
            };
            pnlDateFilter.Controls.Add(btnDateFilter);
            #endregion

            #region separatorFirst
            // Tạo một panel ngăn cách
            Panel separatorFirst = new Panel();
            separatorFirst.BackColor = Color.LightGray; // Màu của đường ngăn cách
            separatorFirst.Size = new Size(pnlDateFilter.ClientSize.Width-20, 2); // Độ dài và độ dày của đường ngăn cách
            separatorFirst.Margin = new Padding(0, 5, 0, 5); // Khoảng cách giữa đường ngăn cách và các điều khiển khác
                                                             // Thêm panel ngăn cách vào FlowLayoutPanel
            separatorFirst.Location = new Point(10, 70);
            pnlDateFilter.Controls.Add(separatorFirst);
            #endregion

            #region pnlWMS 
            // Tạo Warehouse Management System (WMS)
            Panel pnlWMS = new Panel();
            pnlWMS.Size = new Size(this.ClientSize.Width, 100);
            pnlWMS.Location = new Point(0, 75);
            pnlWMS.AutoSize = true;
            pnlDateFilter.Controls.Add(pnlWMS);
            
                #region pnlInputQuantity
                // Tạo pnlInputQuantity
                Panel pnlInputQuantity = new Panel();
                pnlInputQuantity.Size = new Size(180, 100);
                pnlInputQuantity.Location = new Point(40, 10);
                pnlInputQuantity.AutoSize = true;
                pnlInputQuantity.BackColor = Color.DodgerBlue;
                pnlWMS.Controls.Add(pnlInputQuantity);
                      #region
                      Label lbTextInputQuantity = new Label();
                      lbTextInputQuantity.Text = "Lượng nhập";
                      lbTextInputQuantity.ForeColor = Color.White;
                      lbTextInputQuantity.Location = new Point((pnlInputQuantity.ClientSize.Width - lbTextInputQuantity.Width) / 2, 10);
                      lbTextInputQuantity.Font = new Font("Microsoft Sans Serif",12);
                      lbTextInputQuantity.AutoSize = true;
                      pnlInputQuantity.Controls.Add(lbTextInputQuantity);
                      #endregion
                      #region
                      Label lbInputQuantity = new Label();
                      lbInputQuantity.Text = "980000";
                      lbInputQuantity.ForeColor = Color.White;
                      lbInputQuantity.Location = new Point((pnlInputQuantity.ClientSize.Width - lbInputQuantity.Width) / 2, 50);
                      lbInputQuantity.Font = new Font("Microsoft Sans Serif",20);
                      lbInputQuantity.AutoSize = true;
                      pnlInputQuantity.Controls.Add(lbInputQuantity);
                      #endregion

                 #endregion

                 #region pnlOutputQuantity
                 // Tạo pnlInputQuantity
                 Panel pnlOutputQuantity = new Panel();
                 pnlOutputQuantity.Size = new Size(180, 100);
                 pnlOutputQuantity.Location = new Point(280, 10);
                 pnlOutputQuantity.AutoSize = true;
                 pnlOutputQuantity.BackColor = Color.DodgerBlue;
                 pnlWMS.Controls.Add(pnlOutputQuantity);

                      #region
                      Label lbTextOutputQuantity = new Label();
                      lbTextOutputQuantity.Text = "Lượng xuất";
                      lbTextOutputQuantity.ForeColor = Color.White;
                      lbTextOutputQuantity.Location = new Point((pnlOutputQuantity.ClientSize.Width- lbTextOutputQuantity.Width) /2, 10);
                      lbTextOutputQuantity.Font = new Font("Microsoft Sans Serif",12);
                      lbTextOutputQuantity.AutoSize = true;
                      pnlOutputQuantity.Controls.Add(lbTextOutputQuantity);
                      #endregion
                      #region
                      Label lbOutputQuantity = new Label();
                      lbOutputQuantity.Text = "980000";
                      lbOutputQuantity.ForeColor = Color.White;
                      lbOutputQuantity.Location = new Point((pnlOutputQuantity.ClientSize.Width - lbOutputQuantity.Width) / 2, 50);
                      lbOutputQuantity.Font = new Font("Microsoft Sans Serif",20);
                      lbOutputQuantity.AutoSize = true;
                      pnlOutputQuantity.Controls.Add(lbOutputQuantity);
                      #endregion
                 #endregion

                  #region pnlInventory
                  // Tạo pnlInputQuantity
                  Panel pnlInventory = new Panel();
                  pnlInventory.Size = new Size(180, 100);
                  pnlInventory.Location = new Point(520, 10);
                  pnlInventory.AutoSize = true;
                  pnlInventory.BackColor = Color.DodgerBlue;
                  pnlWMS.Controls.Add(pnlInventory);

                      #region
                      Label lbTextInventory = new Label();
                      lbTextInventory.Text = "Tồn kho";
                      lbTextInventory.ForeColor = Color.White;
                      lbTextInventory.Location = new Point((pnlInventory.ClientSize.Width - lbTextInventory.Width) / 2, 10);
                      lbTextInventory.Font = new Font("Microsoft Sans Serif",12);
                      lbTextInventory.AutoSize = true;
                      pnlInventory.Controls.Add(lbTextInventory);
                      #endregion
                      #region
                      Label lbInventory = new Label();
                      lbInventory.Text = "980000";
                      lbInventory.ForeColor = Color.White;
                      lbInventory.Location = new Point((pnlInventory.ClientSize.Width - lbInventory.Width) / 2, 50);
                      lbInventory.Font = new Font("Microsoft Sans Serif",20);
                      lbInventory.AutoSize = true;
                      pnlInventory.Controls.Add(lbInventory);
                      #endregion
                  #endregion
                #endregion
        }

        void SetUpFilterSecond()
        {
            #region pnlDateFilter
            // Tạo pnlDateFilter
            Panel pnlDateFilter = new Panel();
            pnlDateFilter.Size = new Size(this.ClientSize.Width, 200);
            pnlDateFilter.Location = new Point(0, 280);
            pnlDateFilter.AutoSize = true;
            pnlDateFilter.BackColor = Color.White;
            this.Controls.Add(pnlDateFilter);
            #endregion

            #region flpStartDate
            // Tạo flpStartDate
            FlowLayoutPanel flpStartDate = new FlowLayoutPanel();
            flpStartDate.Size = new Size(30, 20);
            flpStartDate.FlowDirection = FlowDirection.LeftToRight;
            flpStartDate.Location = new Point(0, 0);
            flpStartDate.AutoSize = true;
            flpStartDate.BackColor = Color.White;
            pnlDateFilter.Controls.Add(flpStartDate);

            #region lbStart
            Label lbStart = new Label();
            lbStart.Text = "Ngày bắt đầu:";
            lbStart.AutoSize = true;
            lbStart.Margin = new Padding(5, 5, 11, 0);
            flpStartDate.Controls.Add(lbStart);
            #endregion

            #region dtpkStart
            // Cấu hình DateTimePickerStart
            DateTimePicker dtpkStart = new DateTimePicker();
            dtpkStart.Location = new Point(10, 30);
            dtpkStart.Size = new Size(120, 20);
            dtpkStart.Format = DateTimePickerFormat.Custom;
            dtpkStart.CustomFormat = " ";
            dtpkStart.ValueChanged += (sender, e) =>
            {
                // Đặt lại CustomFormat để hiển thị ngày tháng đã chọn
                dtpkStart.CustomFormat = "dd/MM/yyyy";
            };
            flpStartDate.Controls.Add(dtpkStart);
            #endregion

            #endregion

            #region flpEndDate
            // Tạo flpStartDate
            FlowLayoutPanel flpEndDate = new FlowLayoutPanel();
            flpEndDate.Size = new Size(30, 20);
            flpEndDate.FlowDirection = FlowDirection.LeftToRight;
            flpEndDate.Location = new Point(0, 30);
            flpEndDate.AutoSize = true;
            flpEndDate.BackColor = Color.White;
            pnlDateFilter.Controls.Add(flpEndDate);

            #region lbEnd
            Label lbEnd = new Label();
            lbEnd.Text = "Ngày kết thúc:";
            lbEnd.AutoSize = true;
            lbEnd.Margin = new Padding(5, 5, 10, 0);
            flpEndDate.Controls.Add(lbEnd);
            #endregion

            #region dtpkEnd
            // Cấu hình DateTimePickerStart
            DateTimePicker dtpkEnd = new DateTimePicker();
            dtpkEnd.Location = new Point(10, 30);
            dtpkEnd.Size = new Size(120, 20);
            dtpkEnd.Format = DateTimePickerFormat.Custom;
            dtpkEnd.CustomFormat = " ";
            dtpkEnd.ValueChanged += (sender, e) =>
            {
                // Đặt lại CustomFormat để hiển thị ngày tháng đã chọn
                dtpkEnd.CustomFormat = "dd/MM/yyyy";
            };
            flpEndDate.Controls.Add(dtpkEnd);
            #endregion
            #endregion

            #region btnDateFilter
            // Tạo và cấu hình button "Lọc"
            Button btnDateFilter = new Button();
            btnDateFilter.Text = "Lọc";
            btnDateFilter.Location = new Point(250, 12);
            btnDateFilter.Size = new Size(100, 35);
            btnDateFilter.BackColor = Color.Teal;
            btnDateFilter.ForeColor = Color.White;
            btnDateFilter.FlatStyle = FlatStyle.Flat;
            btnDateFilter.FlatAppearance.BorderSize = 0; //loại bỏ đường viền
            btnDateFilter.Font = new Font("Roboto", 8, FontStyle.Bold);
            btnDateFilter.Click += (sender, e) =>
            {
                // Lấy ngày bắt đầu và ngày kết thúc từ DateTimePicker
                DateTime startDate = dtpkStart.Value;
                DateTime endDate = dtpkEnd.Value;

                // Hiển thị thông báo với ngày bắt đầu và ngày kết thúc đã chọn
                MessageBox.Show($"Ngày bắt đầu: {dtpkStart.Text}\nNgày kết thúc: {dtpkEnd.Text}", "Kết quả");
            };
            pnlDateFilter.Controls.Add(btnDateFilter);
            #endregion

            #region separatorFirst
            // Tạo một panel ngăn cách
            Panel separatorFirst = new Panel();
            separatorFirst.BackColor = Color.LightGray; // Màu của đường ngăn cách
            separatorFirst.Size = new Size(pnlDateFilter.ClientSize.Width - 20, 2); // Độ dài và độ dày của đường ngăn cách
            separatorFirst.Margin = new Padding(0, 5, 0, 5); // Khoảng cách giữa đường ngăn cách và các điều khiển khác
                                                             // Thêm panel ngăn cách vào FlowLayoutPanel
            separatorFirst.Location = new Point(10, 70);
            pnlDateFilter.Controls.Add(separatorFirst);
            #endregion

            #region
            ListView lvDateFilter = new ListView();
            lvDateFilter.View = View.Details;
            lvDateFilter.Location = new Point(10, 80);
            lvDateFilter.Size = new Size(pnlDateFilter.ClientSize.Width, 200);
            lvDateFilter.BorderStyle = BorderStyle.None;
            pnlDateFilter.Controls.Add(lvDateFilter);

            // Thêm các cột
            lvDateFilter.Columns.Add("STT", 50);
            lvDateFilter.Columns.Add("Tên vật tư", 200);
            lvDateFilter.Columns.Add("Số lượng tồn", 100);

            // Thêm items
            ListViewItem item1 = new ListViewItem("1");
            item1.SubItems.Add("Vật tư A");
            item1.SubItems.Add("100");

            ListViewItem item2 = new ListViewItem("2");
            item2.SubItems.Add("Vật tư B");
            item2.SubItems.Add("150");

            ListViewItem item3 = new ListViewItem("3");
            item3.SubItems.Add("Vật tư C");
            item3.SubItems.Add("75");

            // Thêm items vào listview
            lvDateFilter.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            #endregion
        }
    }
}
