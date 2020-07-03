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
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.passwordText.AutoSize = false;
            this.passwordText.Size = new Size(392, 33);


            
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registration Registration = new registration();
            Registration.Show();
        }



        private void login_Click(object sender, EventArgs e)
        {
            String loginUser = loginText.Text;
            String passwUser = passwordText.Text;

            try
            {
                DB db = new DB();
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();


                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL AND `password` = @uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwUser;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    if (CheckRole())
                    {
                        this.Hide();
                        AdminPanel adminPanel = new AdminPanel(loginUser);
                        adminPanel.Show();
                    }
                    else
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm(loginUser);
                        mainForm.Show();
                    }
                }

                else
                {
                    MessageBox.Show("Неправильный логин или пароль");

                }
            }

            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Отсутствует подключение с базой данных");
            }

        }


        public Boolean CheckRole()
        {
            DB db = new DB();

            String loginUser = loginText.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login and Role = 1", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;
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

        private void passwordText_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
