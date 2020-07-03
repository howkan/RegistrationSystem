using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace RegistrationSystem
{
    public partial class Find : Form
    {

        public static DataGridView dataGridView1;

        public Find()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        
        

        
        public void Select_tab(string query)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        
        private void FindButtton_Click(object sender, EventArgs e)
        {
            string Category = "Category", Country = "Country", Address = "Address" ,Date = "Date", Affected = "Affected", Description = "Description";

            Select_tab("Select * from incidents " +
               "WHERE " + Category + "  LIKE '" + CategoryBox.Text + "%' " +
               "AND " + Country + " LIKE '" + CountryText.Text + "%'" +
               "AND " + Address + " LIKE '" + AdressText.Text + "%'" +
               "AND " + Date + " LIKE '" + dateTimePicker1.Value.Date + "%'" +
               "AND " + Affected + " LIKE '" + AffectedText.Text + "%'" +
               "AND " + Description + " LIKE '" + DescriptionText.Text + "%'");

            this.Close();
        }

        private void AdressText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void AffectedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
