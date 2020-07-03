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

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer1_Tick;
            timer.Start();

            StartPosition = FormStartPosition.CenterScreen;

            timer2 = new Timer() { Interval = 10000 };
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();


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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (offer == null || offer.IsDisposed) { offer = new Offer(); offer.Show(); }
            else { offer.Show(); offer.Focus(); }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (find == null || find.IsDisposed) { find = new Find(); find.Show(); }
            else { find.Show(); find.Focus(); }
            Find.dataGridView1 = this.dataGridView1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

   

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorization authorization = new authorization();
            authorization.ShowDialog();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
        }
    }
}
