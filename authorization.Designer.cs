namespace RegistrationSystem
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.ComeButton = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComeButton
            // 
            this.ComeButton.BackColor = System.Drawing.Color.White;
            this.ComeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComeButton.BackgroundImage")));
            this.ComeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ComeButton.FlatAppearance.BorderSize = 0;
            this.ComeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ComeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ComeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComeButton.Location = new System.Drawing.Point(40, 291);
            this.ComeButton.Name = "ComeButton";
            this.ComeButton.Size = new System.Drawing.Size(393, 43);
            this.ComeButton.TabIndex = 0;
            this.ComeButton.Text = "Войти";
            this.ComeButton.UseVisualStyleBackColor = false;
            this.ComeButton.Click += new System.EventHandler(this.ComeButton_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordText.Location = new System.Drawing.Point(40, 211);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(393, 31);
            this.PasswordText.TabIndex = 9;
            this.PasswordText.UseSystemPasswordChar = true;
            this.PasswordText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordText_KeyUp);
            // 
            // LoginText
            // 
            this.LoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(40, 111);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(393, 33);
            this.LoginText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Авторизация";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Registration);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoginText);
            this.panel1.Controls.Add(this.PasswordText);
            this.panel1.Controls.Add(this.ComeButton);
            this.panel1.Location = new System.Drawing.Point(203, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 443);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Нужна учетная запись?";
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.LinkColor = System.Drawing.Color.Black;
            this.Registration.Location = new System.Drawing.Point(195, 376);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(113, 13);
            this.Registration.TabIndex = 7;
            this.Registration.TabStop = true;
            this.Registration.Text = "Зарегистрироваться";
            this.Registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registration_LinkClicked);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 575);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComeButton;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel Registration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}