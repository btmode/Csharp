using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbCRUD
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();

            TextNameOrEmail.Text = "Введите имя или почту";
            TextPassword.Text = "Введите пароль";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var dataRules = new DataRules();
            dataRules.name = TextNameOrEmail.Text;
            dataRules.password = TextPassword.Text;

            if (TextNameOrEmail.Text == "Введите имя или почту" && TextPassword.Text == "Введите пароль")
            {
                MessageBox.Show("Вы не ввели данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TextNameOrEmail.Text == "Введите имя или почту")
            {
                MessageBox.Show("Нужно ввести либо имя либо почту!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TextPassword.Text == "Введите пароль")
            {
                MessageBox.Show("Нужно ввести пароль!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Db = new DataBase();
            var adapterSql = new MySqlDataAdapter();

            using (var connection = Db.GetConnection())
            {
                try
                {
                    connection.Open();



                    var command = new MySqlCommand("SELECT * FROM users WHERE" +
                        "(user_name = @input OR " +
                        "user_email = @input) " +
                        "AND user_password = @password", connection);

                    command.Parameters.AddWithValue("@input", dataRules.name);
                    command.Parameters.AddWithValue("@password", dataRules.password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var userName = reader["user_name"].ToString();
                            MessageBox.Show($"Добро пожаловать, {userName}!", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверное имя пользователя, email или пароль!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void TextNameOrEmail_Enter(object sender, EventArgs e)
        {
            if (TextNameOrEmail.Text == "Введите имя или почту")
            {
                TextNameOrEmail.Text = "";
            }
        }

        private void TextNameOrEmail_Leave(object sender, EventArgs e)
        {
            if (TextNameOrEmail.Text == "")
            {
                TextNameOrEmail.Text = "Введите имя или почту";
            }
        }

        private void TextPassword_Enter(object sender, EventArgs e)
        {
            if (TextPassword.Text == "Введите пароль")
            {
                TextPassword.Text = "";
            }
        }

        private void TextPassword_Leave(object sender, EventArgs e)
        {
            if (TextPassword.Text == "")
            {
                TextPassword.Text = "Введите пароль";
            }
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            var mainForm = new MainForm();
            mainForm.Show();

        }
    }
}
