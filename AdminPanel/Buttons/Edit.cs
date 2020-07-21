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
    public partial class Edit : Form
    {
        private string query = "";

        public Edit()
        {
            InitializeComponent();
            SelectTab("SELECT id from incidents");
            Values();
            Configure();
        }

        private void Configure()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Values()
        {
            ComboBoxValue.Items.Add("Category");
            ComboBoxValue.Items.Add("Country");
            ComboBoxValue.Items.Add("Address");
            ComboBoxValue.Items.Add("Date");
            ComboBoxValue.Items.Add("Affected");
            ComboBoxValue.Items.Add("Description");
            ComboBoxValue.SelectedItem = "Category";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string primary = ComboBoxId.SelectedItem.ToString();
            string name = ComboBoxValue.SelectedItem.ToString();
            string update_row = TextBoxNewValue.Text;

            query = "UPDATE incidents SET " + name + " = '" + update_row + "' where id = '" + primary + "'" ;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query , db.getConnection());
            db.openConnection();
            command.ExecuteNonQuery();
            this.Close();
            
        }
        private void SelectTab(string query)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "incidents");
            for(int i = 0; i < ds.Tables["incidents"].Rows.Count; i++)
            {
                ComboBoxId.Items.Add(ds.Tables["incidents"].Rows[i][0].ToString());

            }
            ComboBoxId.SelectedItem = ds.Tables["incidents"].Rows[0][0].ToString();
            
        }

        private void ComboBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
