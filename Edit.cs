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
        public string query = "";
        public Edit()
        {
            InitializeComponent();
            Select_tab("SELECT id from incidents");

            comboBox2.Items.Add("Category");
            comboBox2.Items.Add("Country");
            comboBox2.Items.Add("Address");
            comboBox2.Items.Add("Date");
            comboBox2.Items.Add("Affected");
            comboBox2.Items.Add("Description");
            comboBox2.SelectedItem = "Category";

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string primary = comboBox1.SelectedItem.ToString();

            string name = comboBox2.SelectedItem.ToString();
            string update_row = textBox1.Text;

            query = "UPDATE incidents SET " + name + " = '" + update_row + "' where id = '" + primary + "'" ;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query , db.getConnection());
            db.openConnection();
            command.ExecuteNonQuery();
            this.Close();
            
        }
        public void Select_tab(string query)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "incidents");
            for(int i = 0; i < ds.Tables["incidents"].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables["incidents"].Rows[i][0].ToString());

            }
            comboBox1.SelectedItem = ds.Tables["incidents"].Rows[0][0].ToString();
            
        }
        
       
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
