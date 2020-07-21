namespace RegistrationSystem
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordText2 = new System.Windows.Forms.TextBox();
            this.Authorization = new System.Windows.Forms.LinkLabel();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NameText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PasswordText2);
            this.panel1.Controls.Add(this.Authorization);
            this.panel1.Controls.Add(this.RegistrationButton);
            this.panel1.Controls.Add(this.LoginText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PasswordText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(185, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 552);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Имя";
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(63, 121);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(393, 33);
            this.NameText.TabIndex = 11;
            this.NameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameText_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Повторите пароль";
            // 
            // PasswordText2
            // 
            this.PasswordText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordText2.Location = new System.Drawing.Point(64, 365);
            this.PasswordText2.Name = "PasswordText2";
            this.PasswordText2.Size = new System.Drawing.Size(392, 31);
            this.PasswordText2.TabIndex = 9;
            this.PasswordText2.UseSystemPasswordChar = true;
            // 
            // Authorization
            // 
            this.Authorization.AutoSize = true;
            this.Authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization.LinkColor = System.Drawing.Color.Black;
            this.Authorization.Location = new System.Drawing.Point(362, 469);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(134, 13);
            this.Authorization.TabIndex = 8;
            this.Authorization.TabStop = true;
            this.Authorization.Text = "Уже зарегистрированы?";
            this.Authorization.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Authorization_LinkClicked);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegistrationButton.BackgroundImage")));
            this.RegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RegistrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RegistrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrationButton.Location = new System.Drawing.Point(64, 444);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(190, 38);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // LoginText
            // 
            this.LoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(63, 201);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(393, 33);
            this.LoginText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordText.Location = new System.Drawing.Point(64, 284);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(392, 31);
            this.PasswordText.TabIndex = 7;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 711);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.LinkLabel Authorization;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordText2;
    }
}