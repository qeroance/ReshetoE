namespace ReshetoE
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.reg_button = new System.Windows.Forms.Button();
            this.auth_button = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_text = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.Color.White;
            this.reg_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reg_button.FlatAppearance.BorderSize = 0;
            this.reg_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reg_button.Font = new System.Drawing.Font("Bernard MT Condensed", 10.5F, System.Drawing.FontStyle.Bold);
            this.reg_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reg_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reg_button.Location = new System.Drawing.Point(651, 513);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(318, 82);
            this.reg_button.TabIndex = 0;
            this.reg_button.Text = "Регистрация";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // auth_button
            // 
            this.auth_button.BackColor = System.Drawing.Color.IndianRed;
            this.auth_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auth_button.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.auth_button.FlatAppearance.BorderSize = 0;
            this.auth_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.auth_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.auth_button.Font = new System.Drawing.Font("Bernard MT Condensed", 10.5F, System.Drawing.FontStyle.Bold);
            this.auth_button.ForeColor = System.Drawing.Color.Transparent;
            this.auth_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.auth_button.Location = new System.Drawing.Point(1002, 513);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(269, 82);
            this.auth_button.TabIndex = 1;
            this.auth_button.Text = "Войти";
            this.auth_button.UseVisualStyleBackColor = false;
            this.auth_button.Click += new System.EventHandler(this.auth_button_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("Bernard MT Condensed", 10.1F, System.Drawing.FontStyle.Bold);
            this.Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Login.Location = new System.Drawing.Point(644, 246);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(116, 40);
            this.Login.TabIndex = 4;
            this.Login.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 10.1F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(644, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // password_text
            // 
            this.password_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_text.Location = new System.Drawing.Point(651, 412);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(620, 38);
            this.password_text.TabIndex = 7;
            this.password_text.UseSystemPasswordChar = true;
            this.password_text.TextChanged += new System.EventHandler(this.password_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 15.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(640, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "Авторизация";
            // 
            // login_text
            // 
            this.login_text.BackColor = System.Drawing.Color.White;
            this.login_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.login_text.Location = new System.Drawing.Point(651, 288);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(318, 38);
            this.login_text.TabIndex = 6;
            this.login_text.TextChanged += new System.EventHandler(this.login_text_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1219, 694);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 35);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Справка";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.IndianRed;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ReshetoE.Properties.Resources.fxy0;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ReshetoE.Properties.Resources.fxy0;
            this.pictureBox1.InitialImage = global::ReshetoE.Properties.Resources.fxy0;
            this.pictureBox1.Location = new System.Drawing.Point(1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 756);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1377, 747);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.auth_button);
            this.Controls.Add(this.reg_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button auth_button;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

