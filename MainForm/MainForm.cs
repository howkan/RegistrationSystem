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
using MySqlX.XDevAPI.Relational;

namespace RegistrationSystem
{
    public partial class MainForm : Form
    {
        private MySqlDataAdapter adapter = null;
        private DataTable table = null;

        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
       
        Timer timer;
        Find find;
        Offer offer;

        public MainForm(string login)
        {

            InitializeComponent();

            toolStripLabel1.Text = "Логин: " + login;

            ToolStrips();

            Status();

            TimerOne();
            TimerTwo();

            Configure();
        }

        public MainForm()
        {
            InitializeComponent();


            ToolStrips();

            Status();

            TimerOne();
            TimerTwo();

            Configure();
        }

        private void ToolStrips()
        {
            infoLabel = new ToolStripLabel();
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();


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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            dataGridView1.AutoGenerateColumns = false;

            adapter = new MySqlDataAdapter("SELECT * FROM incidents", dB.getConnection());
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            
        }


        private void AddToolStrip_Click(object sender, EventArgs e)
        {
            if (offer == null || offer.IsDisposed) { offer = new Offer(); offer.Show(); }
            else { offer.Show(); offer.Focus(); }
        }

        private void UpdateToolStrip_Click(object sender, EventArgs e)
        {

            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void FindToolStrip_Click(object sender, EventArgs e)
        {
            if (find == null || find.IsDisposed) { find = new Find(); find.Show(); }
            else { find.Show(); find.Focus(); }
            Find.dataGridView1 = this.dataGridView1;
        }

        private void AuthorizationToolStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
        }
    }
}
