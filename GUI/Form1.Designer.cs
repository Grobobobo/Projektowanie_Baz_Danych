﻿namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.PatientB = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Location = new System.Drawing.Point(99, 217);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(49, 20);
            this.loginL.TabIndex = 0;
            this.loginL.Text = "Login:";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(99, 277);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(50, 20);
            this.passwordL.TabIndex = 1;
            this.passwordL.Text = "Hasło:";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(169, 207);
            this.loginTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(166, 27);
            this.loginTB.TabIndex = 2;
            this.loginTB.Text = "Login";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(169, 277);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(166, 27);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.Text = "password";
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // PatientB
            // 
            this.PatientB.Location = new System.Drawing.Point(249, 389);
            this.PatientB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatientB.Name = "PatientB";
            this.PatientB.Size = new System.Drawing.Size(86, 31);
            this.PatientB.TabIndex = 4;
            this.PatientB.Text = "Szczepienia";
            this.PatientB.UseVisualStyleBackColor = true;
            this.PatientB.Click += new System.EventHandler(this.PatientB_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(477, 24);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(467, 624);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zaloguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.userB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 669);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PatientB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.loginL);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Szpital Baza Danych";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button PatientB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

