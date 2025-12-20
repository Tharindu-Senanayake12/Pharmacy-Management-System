namespace PharmacyManagementSystem
{
    partial class CashierMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cashier_PointOfSalesBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cashier_CustomersBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cashier_notificationBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cashier_dashboardBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.user_label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrders11 = new PharmacyManagementSystem.cashierOrders1();
            this.adminCustomers1 = new PharmacyManagementSystem.adminCustomers();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.notifications1 = new PharmacyManagementSystem.notifications();
            this.adminDashboard1 = new PharmacyManagementSystem.adminDashboard();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.logout_Btn);
            this.panel2.Controls.Add(this.cashier_PointOfSalesBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cashier_CustomersBtn);
            this.panel2.Controls.Add(this.cashier_notificationBtn);
            this.panel2.Controls.Add(this.cashier_dashboardBtn);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 758);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logout_Btn
            // 
            this.logout_Btn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.logout_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_Btn.HoverState.ImageSize = new System.Drawing.Size(70, 22);
            this.logout_Btn.Image = global::PharmacyManagementSystem.Properties.Resources.Exit_Button;
            this.logout_Btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.logout_Btn.ImageRotate = 0F;
            this.logout_Btn.ImageSize = new System.Drawing.Size(70, 22);
            this.logout_Btn.Location = new System.Drawing.Point(28, 689);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.PressedState.ImageSize = new System.Drawing.Size(70, 22);
            this.logout_Btn.Size = new System.Drawing.Size(101, 38);
            this.logout_Btn.TabIndex = 0;
            this.logout_Btn.Click += new System.EventHandler(this.logout_Btn_Click);
            // 
            // cashier_PointOfSalesBtn
            // 
            this.cashier_PointOfSalesBtn.BackColor = System.Drawing.Color.White;
            this.cashier_PointOfSalesBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.cashier_PointOfSalesBtn.HoverState.Image = global::PharmacyManagementSystem.Properties.Resources.POS_Hover;
            this.cashier_PointOfSalesBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_PointOfSalesBtn.Image = global::PharmacyManagementSystem.Properties.Resources.POS_NotSelected;
            this.cashier_PointOfSalesBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cashier_PointOfSalesBtn.ImageRotate = 0F;
            this.cashier_PointOfSalesBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_PointOfSalesBtn.IndicateFocus = true;
            this.cashier_PointOfSalesBtn.Location = new System.Drawing.Point(2, 240);
            this.cashier_PointOfSalesBtn.Name = "cashier_PointOfSalesBtn";
            this.cashier_PointOfSalesBtn.PressedState.Image = global::PharmacyManagementSystem.Properties.Resources.POS_SelectedBtn;
            this.cashier_PointOfSalesBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_PointOfSalesBtn.Size = new System.Drawing.Size(221, 38);
            this.cashier_PointOfSalesBtn.TabIndex = 0;
            this.cashier_PointOfSalesBtn.Click += new System.EventHandler(this.cashier_PointOfSalesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(43, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login | Cashier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cashier_CustomersBtn
            // 
            this.cashier_CustomersBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.cashier_CustomersBtn.HoverState.Image = global::PharmacyManagementSystem.Properties.Resources.Customers_Btn_hover;
            this.cashier_CustomersBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_CustomersBtn.Image = global::PharmacyManagementSystem.Properties.Resources.Customers_Btn;
            this.cashier_CustomersBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cashier_CustomersBtn.ImageRotate = 0F;
            this.cashier_CustomersBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_CustomersBtn.Location = new System.Drawing.Point(3, 285);
            this.cashier_CustomersBtn.Name = "cashier_CustomersBtn";
            this.cashier_CustomersBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_CustomersBtn.Size = new System.Drawing.Size(221, 38);
            this.cashier_CustomersBtn.TabIndex = 0;
            this.cashier_CustomersBtn.Click += new System.EventHandler(this.cashier_CustomersBtn_Click);
            // 
            // cashier_notificationBtn
            // 
            this.cashier_notificationBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.cashier_notificationBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_notificationBtn.Image = global::PharmacyManagementSystem.Properties.Resources.Notification;
            this.cashier_notificationBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cashier_notificationBtn.ImageRotate = 0F;
            this.cashier_notificationBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_notificationBtn.Location = new System.Drawing.Point(3, 329);
            this.cashier_notificationBtn.Name = "cashier_notificationBtn";
            this.cashier_notificationBtn.PressedState.Image = global::PharmacyManagementSystem.Properties.Resources.NotificationSelected;
            this.cashier_notificationBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_notificationBtn.Size = new System.Drawing.Size(221, 38);
            this.cashier_notificationBtn.TabIndex = 0;
            this.cashier_notificationBtn.Click += new System.EventHandler(this.cashier_notificationBtn_Click);
            // 
            // cashier_dashboardBtn
            // 
            this.cashier_dashboardBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.cashier_dashboardBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_dashboardBtn.Image = global::PharmacyManagementSystem.Properties.Resources.dashboard_notSelected;
            this.cashier_dashboardBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cashier_dashboardBtn.ImageRotate = 0F;
            this.cashier_dashboardBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_dashboardBtn.Location = new System.Drawing.Point(4, 195);
            this.cashier_dashboardBtn.Name = "cashier_dashboardBtn";
            this.cashier_dashboardBtn.PressedState.Image = global::PharmacyManagementSystem.Properties.Resources.dashboard_Selected;
            this.cashier_dashboardBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.cashier_dashboardBtn.Size = new System.Drawing.Size(221, 38);
            this.cashier_dashboardBtn.TabIndex = 0;
            this.cashier_dashboardBtn.Click += new System.EventHandler(this.cashier_dashboardBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PharmacyManagementSystem.Properties.Resources.CashierIcon;
            this.pictureBox4.Location = new System.Drawing.Point(28, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(161, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1234, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 21);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // user_label1
            // 
            this.user_label1.AutoSize = true;
            this.user_label1.Font = new System.Drawing.Font("Satoshi", 13F);
            this.user_label1.Location = new System.Drawing.Point(1093, 52);
            this.user_label1.Name = "user_label1";
            this.user_label1.Size = new System.Drawing.Size(70, 23);
            this.user_label1.TabIndex = 3;
            this.user_label1.Text = "Cashier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Satoshi", 12F);
            this.label2.Location = new System.Drawing.Point(485, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pharmacy Management System  |  Cashier";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.user_label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 84);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Satoshi", 13F);
            this.label4.Location = new System.Drawing.Point(1041, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hello,";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PharmacyManagementSystem.Properties.Resources.Dummy_Circle_Small;
            this.pictureBox3.Location = new System.Drawing.Point(1020, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PharmacyManagementSystem.Properties.Resources.Profile_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(1191, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmacyManagementSystem.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(28, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.notifications1);
            this.panel3.Controls.Add(this.cashierOrders11);
            this.panel3.Controls.Add(this.adminCustomers1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1261, 842);
            this.panel3.TabIndex = 5;
            // 
            // cashierOrders11
            // 
            this.cashierOrders11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cashierOrders11.Location = new System.Drawing.Point(231, 84);
            this.cashierOrders11.Name = "cashierOrders11";
            this.cashierOrders11.Size = new System.Drawing.Size(1030, 758);
            this.cashierOrders11.TabIndex = 1;
            // 
            // adminCustomers1
            // 
            this.adminCustomers1.Location = new System.Drawing.Point(231, 84);
            this.adminCustomers1.Name = "adminCustomers1";
            this.adminCustomers1.Size = new System.Drawing.Size(1030, 758);
            this.adminCustomers1.TabIndex = 0;
            // 
            // notifications1
            // 
            this.notifications1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notifications1.Location = new System.Drawing.Point(231, 84);
            this.notifications1.Name = "notifications1";
            this.notifications1.Size = new System.Drawing.Size(1030, 758);
            this.notifications1.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.BackColor = System.Drawing.Color.White;
            this.adminDashboard1.Location = new System.Drawing.Point(231, 84);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1030, 758);
            this.adminDashboard1.TabIndex = 4;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 842);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierMainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton logout_Btn;
        private Guna.UI2.WinForms.Guna2ImageButton cashier_PointOfSalesBtn;
        private Guna.UI2.WinForms.Guna2ImageButton cashier_notificationBtn;
        private Guna.UI2.WinForms.Guna2ImageButton cashier_dashboardBtn;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label user_label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ImageButton cashier_CustomersBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private cashierOrders1 cashierOrders11;
        private adminCustomers adminCustomers1;
        private adminDashboard adminDashboard1;
        private notifications notifications1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}