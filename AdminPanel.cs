using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrationSystem
{
    public partial class AdminPanel : Form
    {

        private MySqlDataAdapter adapter = null;
        private DataTable table = null;
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;

        Offer offer;
        Edit edit;
        Delete delete;
        Find find;

        public AdminPanel(string login)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            toolStripLabel1.Text = "Логин " + login;


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
        public AdminPanel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            


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

        private void AdmiPanel_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            dataGridView1.AutoGenerateColumns = false;

            adapter = new MySqlDataAdapter("SELECT * FROM incidents", dB.getConnection());
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;


        }

      

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (offer == null || offer.IsDisposed) { offer = new Offer(); offer.Show(); }
            else { offer.Show(); offer.Focus(); }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            if (delete == null || delete.IsDisposed) { delete = new Delete(); delete.Show(); }
            else { delete.Show(); delete.Focus(); }
        }

        private void FindToolStripButton3_Click(object sender, EventArgs e)
        {
            if (find == null || find.IsDisposed) { find = new Find(); find.Show(); }
            else { find.Show(); find.Focus(); }
            Find.dataGridView1 = this.dataGridView1;
        }

        private void EditToolStripButton4_Click(object sender, EventArgs e)
        {
            if (edit == null || edit.IsDisposed) { edit = new Edit(); edit.Show(); }
            else { edit.Show(); edit.Focus(); }
        }

        private void UpdateToolStripButton5_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void UsersToolStripButton6_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Users users = new Users();
            users.Show();
            
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorization authorization = new authorization();
            authorization.ShowDialog();
        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {
            AdmiPanel_Load(null, null);
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
