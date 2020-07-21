using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrationSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            Configure();

        }


        private void Configure()
        {
            this.PasswordText.AutoSize = false;
            this.PasswordText.Size = new Size(393, 33);
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void NameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }


        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `password`, `name`) VALUES ( @login, @pass, @name)", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginText.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordText.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameText.Text;
                db.openConnection();


                if (CheckTextBoxes())
                {
                    if (CheckUserName())
                    {
                        if (CheckPasswordLenght())
                        {
                            if (PasswordText.Text.Equals(PasswordText2.Text))
                            {
                                if (!CheckLogin())
                                {
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        this.Hide();
                                        Authorization authorization = new Authorization();
                                        authorization.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Такой логин уже существует");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Пароль не совпадают");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пароли не должен превышать 10 символов");
                        };
                    }
                    else
                    {
                        MessageBox.Show("Имя должно содержать больше 2 букв");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните пустые поля");
                }
            }

            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Отсутствует подключение с базой данных");
            }

        }


        public Boolean CheckLogin()
        {
            DB db = new DB();
            String login = LoginText.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public Boolean CheckUserName()
        {
            String name = NameText.Text;
            if (name.Length <= 3)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Boolean CheckPasswordLenght()
        {
            String password = PasswordText.Text;

            if (password.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public Boolean CheckTextBoxes()
        {
            String name = NameText.Text;
            String login = LoginText.Text;
            String password = PasswordText.Text;


            if (name == String.Empty || login == String.Empty || password == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Authorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }
    }
}


