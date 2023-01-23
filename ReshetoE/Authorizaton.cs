using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReshetoE
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            Registration app = new Registration();
            app.FormClosed += (s, args) => this.Close();
            this.Hide();
            app.Show();
        }

        private void auth_button_Click(object sender, EventArgs e)
        {
            Database db = new Database("Data Source=dataBase.db");
            try
            {
                if (login_text.Text == "" && password_text.Text == "")
                    MessageBox.Show("Заполните все поля");
                else
                {
                    if (login_text.Text.Length < 4)
                        MessageBox.Show("Логин должен содержать не менее 4 символов и не более 15!");
                    else
                    {
                        if (password_text.Text.Length < 4)
                            MessageBox.Show("Пароль должен содержать не менее 4 символов и не более 15!");
                        else
                        {
                            string Hpassword = db.Hash(password_text.Text);
                            if (db.ValidUser(login_text.Text, Hpassword))
                            {
                                this.Hide();
                                var algorithm = new Algorithm();
                                algorithm.Closed += (s, args) => this.Close();
                                algorithm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Неверно введенные логин или пароль!");
                            }
                        }
                    }
                }
            }
            catch(Exception err) 
            {
                MessageBox.Show(err.Message, "Ошибка Авторизации!");
                return;
            }
        }
        private void login_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = "Данная программа разработана для выполнения алгоритма \"Решето Эратосфена\" - " + "алгоритм нахождение всех простых чисел до некоторого целого числа n.\n" + "\nДля нахождения простых чисел необходимо ввести нужное количество простых чисел (от 1 до 99), после чего выводится сетка, где в белых ячейках показаны простые числа. Для просмотра всех чисел, требуется проматать вниз.";
            MessageBox.Show(text);
        }
    }
}

