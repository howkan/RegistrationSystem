namespace RegistrationSystem
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.label1 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBoxId = new System.Windows.Forms.ComboBox();
            this.ComboBoxValue = new System.Windows.Forms.ComboBox();
            this.TextBoxNewValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Изменить";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(342, 386);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(176, 42);
            this.EditButton.TabIndex = 21;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(284, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Введите новое значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Какое поле изменить?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(284, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Id";
            // 
            // ComboBoxId
            // 
            this.ComboBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxId.FormattingEnabled = true;
            this.ComboBoxId.Location = new System.Drawing.Point(287, 153);
            this.ComboBoxId.Name = "ComboBoxId";
            this.ComboBoxId.Size = new System.Drawing.Size(279, 28);
            this.ComboBoxId.TabIndex = 38;
            // 
            // ComboBoxValue
            // 
            this.ComboBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxValue.FormattingEnabled = true;
            this.ComboBoxValue.Location = new System.Drawing.Point(287, 236);
            this.ComboBoxValue.Name = "ComboBoxValue";
            this.ComboBoxValue.Size = new System.Drawing.Size(279, 28);
            this.ComboBoxValue.TabIndex = 39;
            // 
            // TextBoxNewValue
            // 
            this.TextBoxNewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNewValue.Location = new System.Drawing.Point(287, 315);
            this.TextBoxNewValue.Multiline = true;
            this.TextBoxNewValue.Name = "TextBoxNewValue";
            this.TextBoxNewValue.Size = new System.Drawing.Size(279, 27);
            this.TextBoxNewValue.TabIndex = 40;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 536);
            this.Controls.Add(this.TextBoxNewValue);
            this.Controls.Add(this.ComboBoxValue);
            this.Controls.Add(this.ComboBoxId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(857, 575);
            this.MinimumSize = new System.Drawing.Size(857, 575);
            this.Name = "Edit";
            this.Text = "Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBoxId;
        private System.Windows.Forms.ComboBox ComboBoxValue;
        private System.Windows.Forms.TextBox TextBoxNewValue;
    }
}