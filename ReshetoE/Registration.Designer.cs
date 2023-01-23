namespace ReshetoE
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.new_reg_button = new System.Windows.Forms.Button();
            this.new_login_text = new System.Windows.Forms.TextBox();
            this.new_password_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(644, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // new_reg_button
            // 
            this.new_reg_button.BackColor = System.Drawing.Color.IndianRed;
            this.new_reg_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_reg_button.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.new_reg_button.FlatAppearance.BorderSize = 0;
            this.new_reg_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.new_reg_button.Font = new System.Drawing.Font("Bernard MT Condensed", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_reg_button.ForeColor = System.Drawing.Color.White;
            this.new_reg_button.Location = new System.Drawing.Point(651, 513);
            this.new_reg_button.Name = "new_reg_button";
            this.new_reg_button.Size = new System.Drawing.Size(488, 82);
            this.new_reg_button.TabIndex = 5;
            this.new_reg_button.Text = "Зарегистрироваться";
            this.new_reg_button.UseVisualStyleBackColor = false;
            this.new_reg_button.Click += new System.EventHandler(this.new_reg_button_Click);
            // 
            // new_login_text
            // 
            this.new_login_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_login_text.Location = new System.Drawing.Point(651, 288);
            this.new_login_text.Name = "new_login_text";
            this.new_login_text.Size = new System.Drawing.Size(318, 38);
            this.new_login_text.TabIndex = 6;
            this.new_login_text.TextChanged += new System.EventHandler(this.new_login_text_TextChanged);
            // 
            // new_password_text
            // 
            this.new_password_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_password_text.Location = new System.Drawing.Point(651, 412);
            this.new_password_text.Name = "new_password_text";
            this.new_password_text.Size = new System.Drawing.Size(488, 38);
            this.new_password_text.TabIndex = 7;
            this.new_password_text.UseSystemPasswordChar = true;
            this.new_password_text.TextChanged += new System.EventHandler(this.new_password_text_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 15.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(640, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 64);
            this.label3.TabIndex = 9;
            this.label3.Text = "Регистрация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ReshetoE.Properties.Resources.fxy0;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ReshetoE.Properties.Resources.fxy0;
            this.pictureBox1.InitialImage = global::ReshetoE.Properties.Resources.fxy0;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 756);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1377, 747);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_password_text);
            this.Controls.Add(this.new_login_text);
            this.Controls.Add(this.new_reg_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button new_reg_button;
        private System.Windows.Forms.TextBox new_login_text;
        private System.Windows.Forms.TextBox new_password_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}