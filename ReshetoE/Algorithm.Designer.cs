namespace ReshetoE
{
    partial class Algorithm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Algorithm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.input_number = new System.Windows.Forms.NumericUpDown();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.Decision_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(9, 11);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersWidth = 102;
            this.dataGridView.RowTemplate.Height = 20;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(368, 350);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // input_number
            // 
            this.input_number.BackColor = System.Drawing.Color.White;
            this.input_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_number.Font = new System.Drawing.Font("Bahnschrift SemiLight", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_number.ForeColor = System.Drawing.Color.Black;
            this.input_number.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_number.Location = new System.Drawing.Point(286, 47);
            this.input_number.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.input_number.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.input_number.MaximumSize = new System.Drawing.Size(112, 0);
            this.input_number.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.input_number.Name = "input_number";
            this.input_number.Size = new System.Drawing.Size(44, 31);
            this.input_number.TabIndex = 1;
            this.input_number.Tag = "";
            this.input_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input_number.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.input_number.ValueChanged += new System.EventHandler(this.input_number_ValueChanged);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 10.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество простых чисел";
            // 
            // Decision_button
            // 
            this.Decision_button.BackColor = System.Drawing.Color.IndianRed;
            this.Decision_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decision_button.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.Decision_button.FlatAppearance.BorderSize = 0;
            this.Decision_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Decision_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Decision_button.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.Decision_button.ForeColor = System.Drawing.Color.Transparent;
            this.Decision_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Decision_button.Location = new System.Drawing.Point(354, 40);
            this.Decision_button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Decision_button.Name = "Decision_button";
            this.Decision_button.Size = new System.Drawing.Size(109, 43);
            this.Decision_button.TabIndex = 4;
            this.Decision_button.Text = "Решение";
            this.Decision_button.UseVisualStyleBackColor = false;
            this.Decision_button.Click += new System.EventHandler(this.Decision_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(241, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 39);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::ReshetoE.Properties.Resources.fxy0;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::ReshetoE.Properties.Resources.fxy0;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.InitialImage = global::ReshetoE.Properties.Resources.fxy0;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 466);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.Color.IndianRed;
            this.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Button.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.Save_Button.FlatAppearance.BorderSize = 0;
            this.Save_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Save_Button.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.Save_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Save_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save_Button.Location = new System.Drawing.Point(470, 40);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(109, 43);
            this.Save_Button.TabIndex = 10;
            this.Save_Button.Text = "Сохранить";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(218, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Size = new System.Drawing.Size(385, 368);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 445);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Decision_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_number);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Algorithm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.Load += new System.EventHandler(this.Algorithm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown input_number;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Decision_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}