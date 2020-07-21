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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            Configure();
        }




        private void Configure()
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.PasswordText.AutoSize = false;
            this.PasswordText.Size = new Size(392, 33);
        }

        private void ComeButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginText.Text;
            String passwUser = PasswordText.Text;

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



        private Boolean CheckRole()
        {
            DB db = new DB();

            String loginUser = LoginText.Text;

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

        
       
        private void Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration Registration = new Registration();
            Registration.Show();
        }


        private void PasswordText_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ComeButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
