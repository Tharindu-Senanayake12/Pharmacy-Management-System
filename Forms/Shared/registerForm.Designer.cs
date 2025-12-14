namespace PharmacyManagementSystem
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            this.register_Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.register_ShowPass = new System.Windows.Forms.CheckBox();
            this.register_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.register_loginBtn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.register_confirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_Btn
            // 
            this.register_Btn.BorderRadius = 9;
            this.register_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.register_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.register_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.register_Btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.register_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.register_Btn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_Btn.ForeColor = System.Drawing.Color.White;
            this.register_Btn.Location = new System.Drawing.Point(451, 386);
            this.register_Btn.Name = "register_Btn";
            this.register_Btn.Size = new System.Drawing.Size(302, 45);
            this.register_Btn.TabIndex = 4;
            this.register_Btn.Text = "Sign Up";
            this.register_Btn.Click += new System.EventHandler(this.register_Btn_Click);
            // 
            // register_ShowPass
            // 
            this.register_ShowPass.AutoSize = true;
            this.register_ShowPass.Font = new System.Drawing.Font("Inter", 10F);
            this.register_ShowPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.register_ShowPass.Location = new System.Drawing.Point(451, 346);
            this.register_ShowPass.Name = "register_ShowPass";
            this.register_ShowPass.Size = new System.Drawing.Size(131, 21);
            this.register_ShowPass.TabIndex = 16;
            this.register_ShowPass.Text = "Show Password";
            this.register_ShowPass.UseVisualStyleBackColor = true;
            this.register_ShowPass.CheckedChanged += new System.EventHandler(this.register_ShowPass_CheckedChanged);
            // 
            // register_password
            // 
            this.register_password.BorderRadius = 9;
            this.register_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_password.DefaultText = "";
            this.register_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.register_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_password.Location = new System.Drawing.Point(451, 220);
            this.register_password.Margin = new System.Windows.Forms.Padding(4);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '•';
            this.register_password.PlaceholderText = "";
            this.register_password.SelectedText = "";
            this.register_password.Size = new System.Drawing.Size(302, 38);
            this.register_password.TabIndex = 2;
            this.register_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // register_username
            // 
            this.register_username.BorderRadius = 9;
            this.register_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_username.DefaultText = "";
            this.register_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.register_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_username.Location = new System.Drawing.Point(451, 138);
            this.register_username.Margin = new System.Windows.Forms.Padding(4);
            this.register_username.Name = "register_username";
            this.register_username.PasswordChar = '\0';
            this.register_username.PlaceholderText = "";
            this.register_username.SelectedText = "";
            this.register_username.Size = new System.Drawing.Size(302, 38);
            this.register_username.TabIndex = 1;
            this.register_username.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(485, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Already have an account?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 11F);
            this.label3.Location = new System.Drawing.Point(447, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Satoshi", 18.5F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(511, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Register Here!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 11F);
            this.label2.Location = new System.Drawing.Point(447, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(779, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 21);
            this.close.TabIndex = 8;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 500);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = global::PharmacyManagementSystem.Properties.Resources.pharmacyIcon;
            this.pictureBox1.Location = new System.Drawing.Point(178, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(129, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Let\'s get you set up!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(64, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "- Pharmacy Management System -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(136, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "MediTrust";
            // 
            // register_loginBtn
            // 
            this.register_loginBtn.AutoSize = true;
            this.register_loginBtn.Font = new System.Drawing.Font("Inter", 10F);
            this.register_loginBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.register_loginBtn.LinkColor = System.Drawing.SystemColors.MenuText;
            this.register_loginBtn.Location = new System.Drawing.Point(666, 444);
            this.register_loginBtn.Name = "register_loginBtn";
            this.register_loginBtn.Size = new System.Drawing.Size(44, 17);
            this.register_loginBtn.TabIndex = 7;
            this.register_loginBtn.TabStop = true;
            this.register_loginBtn.Text = "Login";
            this.register_loginBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_loginBtn_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 11F);
            this.label1.Location = new System.Drawing.Point(447, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirm Password";
            // 
            // register_confirmPassword
            // 
            this.register_confirmPassword.BorderRadius = 9;
            this.register_confirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_confirmPassword.DefaultText = "";
            this.register_confirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_confirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_confirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_confirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_confirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.register_confirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_confirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_confirmPassword.Location = new System.Drawing.Point(451, 297);
            this.register_confirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.register_confirmPassword.Name = "register_confirmPassword";
            this.register_confirmPassword.PasswordChar = '•';
            this.register_confirmPassword.PlaceholderText = "";
            this.register_confirmPassword.SelectedText = "";
            this.register_confirmPassword.Size = new System.Drawing.Size(302, 38);
            this.register_confirmPassword.TabIndex = 3;
            this.register_confirmPassword.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.register_Btn);
            this.Controls.Add(this.register_ShowPass);
            this.Controls.Add(this.register_confirmPassword);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton register_Btn;
        private System.Windows.Forms.CheckBox register_ShowPass;
        private Guna.UI2.WinForms.Guna2TextBox register_password;
        private Guna.UI2.WinForms.Guna2TextBox register_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel register_loginBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox register_confirmPassword;
        private System.Windows.Forms.Label label4;
    }
}