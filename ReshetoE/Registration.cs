using System;
using System.Windows.Forms;

namespace ReshetoE
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void new_login_text_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void new_password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_reg_button_Click(object sender, EventArgs e)
        {
            Database db = new Database("dataSource=dataBase.db");
            try
            {
                if (new_login_text.Text == "" && new_password_text.Text == "")
                    MessageBox.Show("Заполните все поля");
                else
                {
                    if (new_login_text.Text.Length < 4 || new_login_text.Text.Length > 10)
                        MessageBox.Show("Логин должен содержать не менее 4 символов и не более 10!");
                    else
                    {
                        if (new_password_text.Text.Length < 4 || new_password_text.Text.Length > 15)
                            MessageBox.Show("Пароль должен содержать не менее 4 символов и не более 15!");
                        else
                        {
                            if (db.Checklogin(new_login_text.Text) == false)
                            {
                                string Hpassword = db.Hash(new_password_text.Text);
                                db.CreateUser(new_login_text.Text, Hpassword);
                                this.DialogResult = DialogResult.OK;
                                Algorithm alg = new Algorithm();
                                alg.FormClosed += (s, args) => this.Close();
                                this.Hide();
                                alg.Show();
                            }
                            else
                            {
                                MessageBox.Show("К сожалению,такое имя уже занято, напишите другое");
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка Авторизации!");
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
