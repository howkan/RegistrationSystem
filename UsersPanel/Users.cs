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
    public partial class Users : Form
    {
        private MySqlDataAdapter adapter = null;
        private DataTable table = null;

        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;

        
        
        AddUser addUser;
        Delete delete;
        FindUsers findUsers;

        public Users()
        {

            InitializeComponent();
            Configure();
            ToolStrips();
            Status();
            TimerOne();
            TimerTwo();

        }

        private void ToolStrips()
        {
            infoLabel = new ToolStripLabel();
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
        }

        private void Configure()
        {
            StartPosition = FormStartPosition.CenterScreen;
            infoLabel.Text = "Текущие дата и время:";

        }

        private void Status()
        {
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
        }

        private void TimerTwo()
        {
            timer2 = new Timer() { Interval = 10000 };
            timer2.Tick += new EventHandler(Timer2_Tick);
            timer2.Start();
        }

        private void TimerOne()
        {
            timer = new Timer() { Interval = 1000 };
            timer.Tick += Timer1_Tick;
            timer.Start();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            dataGridView1.AutoGenerateColumns = false;

            adapter = new MySqlDataAdapter("SELECT * FROM users", dB.getConnection());
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }


        private void Users_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();


        private void Timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            Users_Load(null, null);
        }


        private void OfferToolStrip_Click(object sender, EventArgs e)
        {
            if (addUser == null || addUser.IsDisposed) { addUser = new AddUser(); addUser.Show(); }
            else { addUser.Show(); addUser.Focus(); }
        }

        private void UpdateToolStrip_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void DeleteToolStrip_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (delete == null || delete.IsDisposed) { delete = new Delete(id); delete.Show(); }
            else { delete.Show(); delete.Focus(); }
        }

        private void FindToolStrip_Click(object sender, EventArgs e)
        {
            if (findUsers == null || findUsers.IsDisposed) { findUsers = new FindUsers(); findUsers.Show(); }
            else { findUsers.Show(); findUsers.Focus(); }
            FindUsers.dataGridView1 = this.dataGridView1;
        }

        private void BackToolStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
