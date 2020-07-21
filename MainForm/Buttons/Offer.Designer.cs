namespace RegistrationSystem
{
    partial class Offer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Offer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.AdressText = new System.Windows.Forms.TextBox();
            this.DescriptionsText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonOffer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AffectdsText = new System.Windows.Forms.TextBox();
            this.CountryText = new System.Windows.Forms.TextBox();
            this.CategoryText = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.AdressText);
            this.panel1.Controls.Add(this.DescriptionsText);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ButtonOffer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AffectdsText);
            this.panel1.Controls.Add(this.CountryText);
            this.panel1.Controls.Add(this.CategoryText);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 502);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 23, 10, 45, 11, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Адрес";
            // 
            // AdressText
            // 
            this.AdressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressText.Location = new System.Drawing.Point(32, 240);
            this.AdressText.Multiline = true;
            this.AdressText.Name = "AdressText";
            this.AdressText.Size = new System.Drawing.Size(329, 27);
            this.AdressText.TabIndex = 13;
            // 
            // DescriptionsText
            // 
            this.DescriptionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionsText.Location = new System.Drawing.Point(393, 197);
            this.DescriptionsText.Multiline = true;
            this.DescriptionsText.Name = "DescriptionsText";
            this.DescriptionsText.Size = new System.Drawing.Size(286, 141);
            this.DescriptionsText.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(210, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "Добавить запись";
            // 
            // ButtonOffer
            // 
            this.ButtonOffer.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOffer.Location = new System.Drawing.Point(247, 400);
            this.ButtonOffer.Name = "ButtonOffer";
            this.ButtonOffer.Size = new System.Drawing.Size(217, 40);
            this.ButtonOffer.TabIndex = 10;
            this.ButtonOffer.Text = "Добавить";
            this.ButtonOffer.UseVisualStyleBackColor = false;
            this.ButtonOffer.Click += new System.EventHandler(this.ButtonOffer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(390, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пострадавшие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(390, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = " Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Категория";
            // 
            // AffectdsText
            // 
            this.AffectdsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AffectdsText.Location = new System.Drawing.Point(32, 301);
            this.AffectdsText.Multiline = true;
            this.AffectdsText.Name = "AffectdsText";
            this.AffectdsText.Size = new System.Drawing.Size(330, 27);
            this.AffectdsText.TabIndex = 3;
            // 
            // CountryText
            // 
            this.CountryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryText.Location = new System.Drawing.Point(32, 178);
            this.CountryText.Multiline = true;
            this.CountryText.Name = "CountryText";
            this.CountryText.Size = new System.Drawing.Size(330, 27);
            this.CountryText.TabIndex = 1;
            // 
            // CategoryText
            // 
            this.CategoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryText.FormattingEnabled = true;
            this.CategoryText.Items.AddRange(new object[] {
            "Дорожно-транспортное происшествие",
            "Пожар ",
            "Повреждения при стихийных бедствиях.",
            "Потоп",
            "Убийство",
            "Падение, обрушение, обвалы предметов, материалов, земли и т.д.",
            "Другое"});
            this.CategoryText.Location = new System.Drawing.Point(33, 122);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(329, 28);
            this.CategoryText.TabIndex = 0;
            this.CategoryText.SelectedIndexChanged += new System.EventHandler(this.CategoryText_SelectedIndexChanged);
            // 
            // Offer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 501);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(728, 540);
            this.MinimumSize = new System.Drawing.Size(728, 540);
            this.Name = "Offer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryText;
        private System.Windows.Forms.TextBox CountryText;
        private System.Windows.Forms.TextBox AffectdsText;
        private System.Windows.Forms.TextBox DescriptionsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonOffer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AdressText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}