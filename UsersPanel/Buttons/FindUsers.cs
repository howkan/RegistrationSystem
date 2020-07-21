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
    public partial class FindUsers : Form
    {
        public static DataGridView dataGridView1;

        public FindUsers()
        {
            InitializeComponent();
            Configure();
        }

        private void Configure()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SelectTab(string query)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


        }

        

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string login = "login", password = "password", name = "name", id = "id", Role = "Role";
            SelectTab("Select * from users " +
               "WHERE " + login + "  LIKE '" + Loginbox.Text + "%' " +
               "AND " + id + " LIKE '" + IdBox.Text + "%'" +
                "AND " + Role + " LIKE '" + RoleBox.Text + "%'" +
               "AND " + password + " LIKE '" + PasswordBox.Text + "%'" +
               "AND " + name + " LIKE '" + NameBox.Text + "%'");
        }
    }
}
