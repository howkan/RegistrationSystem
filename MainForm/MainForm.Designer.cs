namespace RegistrationSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoriy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Affected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AuthorizationToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FindToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Система регистрации происшествий";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Categoriy,
            this.Country,
            this.Address,
            this.Date,
            this.Affected,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(57, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(732, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 21;
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
            // Affected
            // 
            this.Affected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Affected.DataPropertyName = "Affected";
            this.Affected.HeaderText = "Пострадавшие";
            this.Affected.Name = "Affected";
            this.Affected.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Описание ";
            this.description.Name = "description";
            this.description.ReadOnly = true;
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
            this.panel1.Location = new System.Drawing.Point(84, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 586);
            this.panel1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.MintCream;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorizationToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AuthorizationToolStrip
            // 
            this.AuthorizationToolStrip.IsLink = true;
            this.AuthorizationToolStrip.LinkColor = System.Drawing.Color.Black;
            this.AuthorizationToolStrip.Name = "AuthorizationToolStrip";
            this.AuthorizationToolStrip.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.AuthorizationToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AuthorizationToolStrip.Size = new System.Drawing.Size(173, 17);
            this.AuthorizationToolStrip.Text = "Сменить пользователя";
            this.AuthorizationToolStrip.Click += new System.EventHandler(this.AuthorizationToolStrip_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MintCream;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStrip,
            this.toolStripSeparator2,
            this.UpdateToolStrip,
            this.toolStripSeparator1,
            this.FindToolStrip,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddToolStrip
            // 
            this.AddToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStrip.Image")));
            this.AddToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStrip.Name = "AddToolStrip";
            this.AddToolStrip.Size = new System.Drawing.Size(119, 22);
            this.AddToolStrip.Text = "Добавить запись";
            this.AddToolStrip.Click += new System.EventHandler(this.AddToolStrip_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "MainForm";
            this.Text = "Регистрация происшествий";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoriy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Affected;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddToolStrip;
        private System.Windows.Forms.ToolStripButton FindToolStrip;
        private System.Windows.Forms.ToolStripButton UpdateToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel AuthorizationToolStrip;
        private System.Windows.Forms.Timer timer2;
    }
}

