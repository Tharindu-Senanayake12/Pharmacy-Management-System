namespace PharmacyManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.user_label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_usersBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.main_categoriesBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.main_customersBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.main_inventoryBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.logout_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.main_notificationBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.main_dashboardBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.adminDashboard1 = new PharmacyManagementSystem.adminDashboard();
            this.notifications1 = new PharmacyManagementSystem.notifications();
            this.adminAddProducts1 = new PharmacyManagementSystem.AdminAddProducts();
            this.adminAddCategories1 = new PharmacyManagementSystem.AdminAddCategories();
            this.adminAddUsers1 = new PharmacyManagementSystem.adminAddUsers();
            this.adminCustomers1 = new PharmacyManagementSystem.adminCustomers();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            this.user_label1.Location = new System.Drawing.Point(1119, 52);
            this.user_label1.Name = "user_label1";
            this.user_label1.Size = new System.Drawing.Size(62, 23);
            this.user_label1.TabIndex = 3;
            this.user_label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Satoshi", 12F);
            this.label2.Location = new System.Drawing.Point(498, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pharmacy Management System  |  Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Satoshi", 13F);
            this.label4.Location = new System.Drawing.Point(1067, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hello,";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PharmacyManagementSystem.Properties.Resources.Dummy_Circle_Small;
            this.pictureBox3.Location = new System.Drawing.Point(1046, 55);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.main_usersBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.main_categoriesBtn);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.main_customersBtn);
            this.panel2.Controls.Add(this.main_inventoryBtn);
            this.panel2.Controls.Add(this.logout_Btn);
            this.panel2.Controls.Add(this.main_notificationBtn);
            this.panel2.Controls.Add(this.main_dashboardBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 758);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // main_usersBtn
            // 
            this.main_usersBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.main_usersBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_usersBtn.Image = global::PharmacyManagementSystem.Properties.Resources.Users;
            this.main_usersBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.main_usersBtn.ImageRotate = 0F;
            this.main_usersBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.main_usersBtn.Location = new System.Drawing.Point(3, 320);
            this.main_usersBtn.Name = "main_usersBtn";
            this.main_usersBtn.PressedState.Image = global::PharmacyManagementSystem.Properties.Resources.Users_Selected;
            this.main_usersBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_usersBtn.Size = new System.Drawing.Size(219, 38);
            this.main_usersBtn.TabIndex = 7;
            this.main_usersBtn.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(44, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login | Admin";
            // 
            // main_categoriesBtn
            // 
            this.main_categoriesBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.main_categoriesBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_categoriesBtn.Image = global::PharmacyManagementSystem.Properties.Resources.Categories_notSelected;
            this.main_categoriesBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.main_categoriesBtn.ImageRotate = 0F;
            this.main_categoriesBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.main_categoriesBtn.Location = new System.Drawing.Point(3, 275);
            this.main_categoriesBtn.Name = "main_categoriesBtn";
            this.main_categoriesBtn.PressedState.Image = global::PharmacyManagementSystem.Properties.Resources.Categories_Selected;
            this.main_categoriesBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_categoriesBtn.Size = new System.Drawing.Size(221, 38);
            this.main_categoriesBtn.TabIndex = 0;
            this.main_categoriesBtn.Click += new System.EventHandler(this.main_categoriesBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PharmacyManagementSystem.Properties.Resources.AdminIcon;
            this.pictureBox4.Location = new System.Drawing.Point(28, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(161, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // main_customersBtn
            // 
            this.main_customersBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.main_customersBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_customersBtn.Image = global::PharmacyManagementSystem.Properties.Resources.Customers_Btn;
            this.main_customersBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.main_customersBtn.ImageRotate = 0F;
            this.main_customersBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.main_customersBtn.Location = new System.Drawing.Point(3, 365);
            this.main_customersBtn.Name = "main_customersBtn";
            this.main_customersBtn.PressedState.Image = global::PharmacyManagementSystem.Properties.Resources.Customers_Btn_hover;
            this.main_customersBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_customersBtn.Size = new System.Drawing.Size(221, 38);
            this.main_customersBtn.TabIndex = 0;
            this.main_customersBtn.Click += new System.EventHandler(this.main_usersBtn_Click);
            // 
            // main_inventoryBtn
            // 
            this.main_inventoryBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.main_inventoryBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_inventoryBtn.Image = global::PharmacyManagementSystem.Properties.Resources.Inventory_notSelected;
            this.main_inventoryBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.main_inventoryBtn.ImageRotate = 0F;
            this.main_inventoryBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.main_inventoryBtn.Location = new System.Drawing.Point(4, 230);
            this.main_inventoryBtn.Name = "main_inventoryBtn";
            this.main_inventoryBtn.PressedState.Image = global::PharmacyManagementSystem.Properties.Resources.Inventory_Selected;
            this.main_inventoryBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_inventoryBtn.Size = new System.Drawing.Size(221, 38);
            this.main_inventoryBtn.TabIndex = 0;
            this.main_inventoryBtn.Click += new System.EventHandler(this.main_inventoryBtn_Click);
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
            // main_notificationBtn
            // 
            this.main_notificationBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.main_notificationBtn.HoverState.Image = global::PharmacyManagementSystem.Properties.Resources.Notification;
            this.main_notificationBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_notificationBtn.Image = global::PharmacyManagementSystem.Properties.Resources.Notification_Alerts_2;
            this.main_notificationBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.main_notificationBtn.ImageRotate = 0F;
            this.main_notificationBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.main_notificationBtn.Location = new System.Drawing.Point(2, 409);
            this.main_notificationBtn.Name = "main_notificationBtn";
            this.main_notificationBtn.PressedState.Image = global::PharmacyManagementSystem.Properties.Resources.NotificationSelected;
            this.main_notificationBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_notificationBtn.Size = new System.Drawing.Size(221, 38);
            this.main_notificationBtn.TabIndex = 0;
            this.main_notificationBtn.Click += new System.EventHandler(this.main_notificationBtn_Click);
            // 
            // main_dashboardBtn
            // 
            this.main_dashboardBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.main_dashboardBtn.HoverState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_dashboardBtn.Image = global::PharmacyManagementSystem.Properties.Resources.dashboard_notSelected;
            this.main_dashboardBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.main_dashboardBtn.ImageRotate = 0F;
            this.main_dashboardBtn.ImageSize = new System.Drawing.Size(200, 40);
            this.main_dashboardBtn.Location = new System.Drawing.Point(4, 185);
            this.main_dashboardBtn.Name = "main_dashboardBtn";
            this.main_dashboardBtn.PressedState.Image = global::PharmacyManagementSystem.Properties.Resources.dashboard_Selected;
            this.main_dashboardBtn.PressedState.ImageSize = new System.Drawing.Size(200, 40);
            this.main_dashboardBtn.Size = new System.Drawing.Size(221, 38);
            this.main_dashboardBtn.TabIndex = 0;
            this.main_dashboardBtn.Click += new System.EventHandler(this.main_dashboardBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.notifications1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.adminAddCategories1);
            this.panel3.Controls.Add(this.adminAddUsers1);
            this.panel3.Controls.Add(this.adminCustomers1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(231, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 758);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.BackColor = System.Drawing.Color.White;
            this.adminDashboard1.Location = new System.Drawing.Point(1, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1030, 758);
            this.adminDashboard1.TabIndex = 5;
            this.adminDashboard1.Load += new System.EventHandler(this.adminDashboard1_Load);
            // 
            // notifications1
            // 
            this.notifications1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notifications1.Location = new System.Drawing.Point(0, 0);
            this.notifications1.Name = "notifications1";
            this.notifications1.Size = new System.Drawing.Size(1030, 758);
            this.notifications1.TabIndex = 4;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.BackColor = System.Drawing.Color.GhostWhite;
            this.adminAddProducts1.Location = new System.Drawing.Point(2, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1030, 758);
            this.adminAddProducts1.TabIndex = 3;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.BackColor = System.Drawing.Color.GhostWhite;
            this.adminAddCategories1.Location = new System.Drawing.Point(0, 2);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1030, 758);
            this.adminAddCategories1.TabIndex = 2;
            // 
            // adminAddUsers1
            // 
            this.adminAddUsers1.BackColor = System.Drawing.Color.GhostWhite;
            this.adminAddUsers1.Location = new System.Drawing.Point(0, 0);
            this.adminAddUsers1.Name = "adminAddUsers1";
            this.adminAddUsers1.Size = new System.Drawing.Size(1030, 758);
            this.adminAddUsers1.TabIndex = 1;
            // 
            // adminCustomers1
            // 
            this.adminCustomers1.Location = new System.Drawing.Point(0, 0);
            this.adminCustomers1.Name = "adminCustomers1";
            this.adminCustomers1.Size = new System.Drawing.Size(1030, 758);
            this.adminCustomers1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1261, 842);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label user_label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton main_dashboardBtn;
        private System.Windows.Forms.Label close;
        private Guna.UI2.WinForms.Guna2ImageButton main_notificationBtn;
        private Guna.UI2.WinForms.Guna2ImageButton main_inventoryBtn;
        private Guna.UI2.WinForms.Guna2ImageButton main_categoriesBtn;
        private Guna.UI2.WinForms.Guna2ImageButton logout_Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2ImageButton main_customersBtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private AdminAddProducts adminAddProducts1;
        private AdminAddCategories adminAddCategories1;
        private adminAddUsers adminAddUsers1;
        private adminCustomers adminCustomers1;
        private Guna.UI2.WinForms.Guna2ImageButton main_usersBtn;
        private adminDashboard adminDashboard1;
        private PharmacyManagementSystem.notifications notifications1;
    }
}