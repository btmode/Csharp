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


    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            TextName.Text = "Введите имя";
            TextEmail.Text = "Введите почту";
            TextPassword.Text = "Введите пароль";
            TextBirthDate.Text = "Введите дату рождения";

            TextPassword.UseSystemPasswordChar = true;

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var dataRules = new DataRules();
            dataRules.name = TextName.Text;
            dataRules.email = TextEmail.Text;
            dataRules.password = TextPassword.Text;
            dataRules.brithDate = TextBirthDate.Text;

            var Db = new DataBase();
            var adapterSql = new MySqlDataAdapter();
            using (var connection = Db.GetConnection())
            {
                try
                {
                    connection.Open();
                    
                    if (TextName.Text == "Введите имя")
                    {
                        MessageBox.Show("Вы не ввели имя", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (TextEmail.Text == "Введите почту")
                    {
                        MessageBox.Show("Вы не ввели почту", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (TextPassword.Text == "Введите пароль")
                    {
                        MessageBox.Show("Вы не ввели пароль", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (TextBirthDate.Text == "Введите дату рождения")
                    {
                        MessageBox.Show("Вы не ввели дату рождения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var checkNameCmd = new MySqlCommand("SELECT * FROM users WHERE" +
                        " user_name = @name", connection);
                    checkNameCmd.Parameters.AddWithValue("@name", dataRules.name);
                    var checkName = Convert.ToInt32(checkNameCmd.ExecuteScalar());

                    var checkEmailCmd = new MySqlCommand("SELECT * FROM users WHERE" +
                        " user_email = @email", connection);
                    checkEmailCmd.Parameters.AddWithValue("@email", dataRules.email);
                    var checkEmail = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

                    if (checkName > 0 && checkEmail > 0)
                    {
                        MessageBox.Show("Этот никнейм и email уже заняты!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (checkName > 0)
                    {
                        MessageBox.Show("Этот никнейм уже занят! Придумайте другой.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (checkEmail > 0)
                    {
                        MessageBox.Show("Этот email уже зарегистрирован! Используйте другой email.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    var command = new MySqlCommand("INSERT INTO users" +
                        "(user_name, user_email, user_password, user_birth_date) Values" +
                        " (@name, @email, @password, @birthDate)", connection);

                    command.Parameters.AddWithValue("@name", dataRules.name);
                    command.Parameters.AddWithValue("@email", dataRules.email);
                    command.Parameters.AddWithValue("@password", dataRules.password);
                    command.Parameters.AddWithValue("@birthDate", dataRules.brithDate);


                    int rowsAffected = command.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Вы успешно зарегистрировались!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        var SignUp = new SignUpForm();
                        SignUp.Show();
                    }
                    else
                    {
                        MessageBox.Show("Регистрация не прошла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
        }

        private void TextName_Enter(object sender, EventArgs e)
        {
            if (TextName.Text == "Введите имя")
            {
                TextName.Text = "";
                TextName.ForeColor = Color.Red;
            }

        }
        private void TextName_Leave(object sender, EventArgs e)
        {
            if (TextName.Text == "")
            {
                TextName.Text = "Введите имя";
            }
        }

        private void TextEmail_Enter(object sender, EventArgs e)
        {
            if (TextEmail.Text == "Введите почту")
            {
                TextEmail.Text = "";
            }
        }
        private void TextEmail_Leave(object sender, EventArgs e)
        {
            if (TextEmail.Text == "")
            {
                TextEmail.Text = "Введите почту";
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

        private void TextBirthDate_Enter(object sender, EventArgs e)
        {
            if (TextBirthDate.Text == "Введите дату рождения")
            {
                TextBirthDate.Text = "";
            }

        }

        private void TextBirthDate_Leave(object sender, EventArgs e)
        {
            if (TextBirthDate.Text == "")
            {
                TextBirthDate.Text = "Введите дату рождения";
            }

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                TextPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TextPassword.UseSystemPasswordChar = true;
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
