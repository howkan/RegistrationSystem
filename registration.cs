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
            this.passwordText.AutoSize = false;
            this.passwordText.Size = new Size(393, 33);
            StartPosition = FormStartPosition.CenterScreen;
            
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `password`, `name`) VALUES ( @login, @pass, @name)", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginText.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordText.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameText.Text;
                db.openConnection();


                if (checkTextBoxes())
                {
                    if (checkUserName())
                    {
                        if (CheckPasswordLenght())
                        {
                            if (passwordText.Text.Equals(passwordText2.Text))
                            {
                                if (!checkLogin())
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
                        }else
                        {
                            MessageBox.Show("Пароли не должен превышать 10 символов");
                        };
                    }else
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



        public Boolean checkLogin()
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


        public Boolean checkUserName()
        {
            String name = nameText.Text;
            if (name.Length <= 3)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Boolean CheckPasswordLenght ()
        {
            String password = passwordText.Text;

            if ( password.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public Boolean checkTextBoxes()
        {
            String name = nameText.Text;
            String login = LoginText.Text;
            String password = passwordText.Text;


            if (name == String.Empty || login == String.Empty || password == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nameText_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;
        }
    }
}


