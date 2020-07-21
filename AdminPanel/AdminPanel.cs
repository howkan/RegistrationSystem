using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

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
            
            toolStripLabel1.Text = "Логин " + login;

            Configure();
            ToolStripts();
            Statuts();
            TimerOne();
            TimerTwo();


        }
        public AdminPanel()
        {
            InitializeComponent();
            Configure();
            ToolStripts();
            Statuts();
            TimerOne();
            TimerTwo();


        }

        private void ToolStripts()
        {
            infoLabel = new ToolStripLabel();
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
        }

        private void Statuts()
        {
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
        }

        private void Configure()
        {
            StartPosition = FormStartPosition.CenterScreen;
            infoLabel.Text = "Текущие дата и время:";
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

        private void AdmiPanel_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            dataGridView1.AutoGenerateColumns = false;

            adapter = new MySqlDataAdapter("SELECT * FROM incidents", dB.getConnection());
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;


        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();


        private void Timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }


        private void Timer2_Tick(object sender, EventArgs e) => AdmiPanel_Load(null, null);


        private void OfferToolStrip_Click(object sender, EventArgs e)
        {
            if (offer == null || offer.IsDisposed) { offer = new Offer(); offer.Show(); }
            else { offer.Show(); offer.Focus(); }
        }

        private void FindToolStrip_Click(object sender, EventArgs e)
        {
            if (find == null || find.IsDisposed) { find = new Find(); find.Show(); }
            else { find.Show(); find.Focus(); }
            Find.dataGridView1 = this.dataGridView1;
        }

        private void DeleteToolStrip_Click(object sender, EventArgs e)
        {
            int id = 1;
            if (delete == null || delete.IsDisposed) { delete = new Delete(id); delete.Show(); }
            else { delete.Show(); delete.Focus(); }
        }

        private void EditToolStrip_Click(object sender, EventArgs e)
        {
            if (edit == null || edit.IsDisposed) { edit = new Edit(); edit.Show(); }
            else { edit.Show(); edit.Focus(); }
        }

        private void UsersToolStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }

        private void UpdateToolStrip_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void AuthorizationToolStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
        }


    }
}
