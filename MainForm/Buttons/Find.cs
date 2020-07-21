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
        
        private void FindButton_Click(object sender, EventArgs e)
        {
            string Category = "Category", Country = "Country", Address = "Address" ,Date = "Date", Affected = "Affected", Description = "Description";

            SelectTab("Select * from incidents " +
               "WHERE " + Category + "  LIKE '" + CategoryBox.Text + "%' " +
               "AND " + Country + " LIKE '" + CountryText.Text + "%'" +
               "AND " + Address + " LIKE '" + AdressText.Text + "%'" +
               "AND " + Date + " LIKE '" + dateTimePicker1.Value.Date + "%'" +
               "AND " + Affected + " LIKE '" + AffectedText.Text + "%'" +
               "AND " + Description + " LIKE '" + DescriptionText.Text + "%'");

            this.Close();
        }

 
    }
}
