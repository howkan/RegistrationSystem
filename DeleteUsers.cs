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
    public partial class DeleteUsers : Form
    {
        public DeleteUsers()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB dB = new DB();

            MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE id=@Id", dB.getConnection());
            command.Parameters.AddWithValue("Id", Convert.ToInt32(IdTextBox.Text));
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            dataTable.Clear();
            dataAdapter.Fill(dataTable);
            dB.openConnection();

            MessageBox.Show("Запись удалена");
            this.Close();
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void IdTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeleteButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
