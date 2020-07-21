using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrationSystem
{
    public partial class Offer : Form
    {
        public Offer()
        {
            InitializeComponent();
            Configure();

        }

        private void Configure()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }



        private void ButtonOffer_Click(object sender, EventArgs e)
        {

            try
            {
                DB db = new DB();


                MySqlCommand command = new MySqlCommand("INSERT INTO `incidents` ( `Category`, `Country`, `Address`, `Date`, `Affected`, `Description`) VALUES ( @category, @country, @address, @date, @affect, @description)", db.getConnection());
                command.Parameters.Add("@category", MySqlDbType.VarChar).Value = CategoryText.Text;
                command.Parameters.Add("@country", MySqlDbType.VarChar).Value = CountryText.Text;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = AdressText.Text;
                command.Parameters.Add("@Date", MySqlDbType.Date);
                command.Parameters["@Date"].Value = dateTimePicker1.Value.Date;
                command.Parameters.Add("@affect", MySqlDbType.VarChar).Value = AffectdsText.Text;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = DescriptionsText.Text;
                db.openConnection();


                if (CheckTextBoxes())
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись добавлена");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Запись не добавлена");
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

        private void CategoryText_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CategoryText.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Boolean CheckTextBoxes()
        {
            String category = CategoryText.Text;
            String country = CountryText.Text;
            String address = AdressText.Text;

            String affected = AffectdsText.Text;
            String description = DescriptionsText.Text;
            if (category == String.Empty || country == String.Empty || address == String.Empty ||
                affected == String.Empty || description == String.Empty)

            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
