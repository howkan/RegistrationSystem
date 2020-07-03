using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrationSystem
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `password`, `name`) VALUES ( @login, @pass, @name)", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginTextBox.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordTextBox.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameTextBox.Text;
                db.openConnection();


                if (checkTextBoxes())
                {
                    if (checkUserName())
                    {
                        if (PasswordTextBox.Text.Equals(PasswordTextBox2.Text))
                        {
                            if (!checkLogin())
                            {
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    this.Close();
                                  
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
                            MessageBox.Show("Пароли не совпадают");
                        }
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

        public Boolean checkLogin()
        {
            DB db = new DB();
            String login = LoginTextBox.Text;
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
            String name = NameTextBox.Text;
            if (name.Length <= 3)
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
            String name = NameTextBox.Text;
            String login = LoginTextBox.Text;
            String password = PasswordTextBox.Text;


            if (name == String.Empty || login == String.Empty || password == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;
            
        }
    }
}
