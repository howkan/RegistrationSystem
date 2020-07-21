namespace RegistrationSystem
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoriy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Injured = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AuthorizationToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OfferToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.FindToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.EditToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.UsersToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Categoriy,
            this.Country,
            this.Address,
            this.Date,
            this.Injured,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(43, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 414);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 21;
            // 
            // Categoriy
            // 
            this.Categoriy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoriy.DataPropertyName = "category";
            this.Categoriy.HeaderText = "Категория";
            this.Categoriy.Name = "Categoriy";
            this.Categoriy.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Город";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Injured
            // 
            this.Injured.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Injured.DataPropertyName = "Affected";
            this.Injured.HeaderText = "Пострадавшие";
            this.Injured.Name = "Injured";
            this.Injured.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Описание ";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(170, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Система регистрации происшествий";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(76, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 603);
            this.panel1.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorizationToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AuthorizationToolStrip
            // 
            this.AuthorizationToolStrip.IsLink = true;
            this.AuthorizationToolStrip.LinkColor = System.Drawing.Color.Black;
            this.AuthorizationToolStrip.Name = "AuthorizationToolStrip";
            this.AuthorizationToolStrip.Size = new System.Drawing.Size(133, 17);
            this.AuthorizationToolStrip.Text = "Сменить пользователя";
            this.AuthorizationToolStrip.Click += new System.EventHandler(this.AuthorizationToolStrip_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MintCream;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OfferToolStrip,
            this.toolStripSeparator7,
            this.DeleteToolStrip,
            this.toolStripSeparator6,
            this.FindToolStrip,
            this.toolStripSeparator5,
            this.EditToolStrip,
            this.toolStripSeparator2,
            this.UpdateToolStrip,
            this.toolStripSeparator4,
            this.UsersToolStrip,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(857, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OfferToolStrip
            // 
            this.OfferToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("OfferToolStrip.Image")));
            this.OfferToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OfferToolStrip.Name = "OfferToolStrip";
            this.OfferToolStrip.Size = new System.Drawing.Size(79, 22);
            this.OfferToolStrip.Text = "Добавить";
            this.OfferToolStrip.Click += new System.EventHandler(this.OfferToolStrip_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // DeleteToolStrip
            // 
            this.DeleteToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStrip.Image")));
            this.DeleteToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStrip.Name = "DeleteToolStrip";
            this.DeleteToolStrip.Size = new System.Drawing.Size(71, 22);
            this.DeleteToolStrip.Text = "Удалить";
            this.DeleteToolStrip.Click += new System.EventHandler(this.DeleteToolStrip_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // FindToolStrip
            // 
            this.FindToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("FindToolStrip.Image")));
            this.FindToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindToolStrip.Name = "FindToolStrip";
            this.FindToolStrip.Size = new System.Drawing.Size(61, 22);
            this.FindToolStrip.Text = "Найти";
            this.FindToolStrip.Click += new System.EventHandler(this.FindToolStrip_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // EditToolStrip
            // 
            this.EditToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStrip.Image")));
            this.EditToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStrip.Name = "EditToolStrip";
            this.EditToolStrip.Size = new System.Drawing.Size(107, 22);
            this.EditToolStrip.Text = "Редактировать";
            this.EditToolStrip.Click += new System.EventHandler(this.EditToolStrip_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // UpdateToolStrip
            // 
            this.UpdateToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("UpdateToolStrip.Image")));
            this.UpdateToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateToolStrip.Name = "UpdateToolStrip";
            this.UpdateToolStrip.Size = new System.Drawing.Size(81, 22);
            this.UpdateToolStrip.Text = "Обновить";
            this.UpdateToolStrip.Click += new System.EventHandler(this.UpdateToolStrip_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // UsersToolStrip
            // 
            this.UsersToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("UsersToolStrip.Image")));
            this.UsersToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsersToolStrip.Name = "UsersToolStrip";
            this.UsersToolStrip.Size = new System.Drawing.Size(105, 22);
            this.UsersToolStrip.Text = "Пользователи";
            this.UsersToolStrip.Click += new System.EventHandler(this.UsersToolStrip_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel1.Text = "Логин admin";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 761);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 800);
            this.Name = "AdminPanel";
            this.Text = "Панель администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdmiPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoriy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Injured;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OfferToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton DeleteToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton FindToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton EditToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton UpdateToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton UsersToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel AuthorizationToolStrip;
        private System.Windows.Forms.Timer timer2;
    }
}