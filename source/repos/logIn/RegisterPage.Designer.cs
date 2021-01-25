﻿
using System;

namespace StudentGrade
{
    partial class RegisterPage
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(290, 96);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(60, 13);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "رقم الحساب";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(282, 153);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(68, 13);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "اسم المستخدم";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(268, 199);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(82, 13);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "البريد الإلكتروني";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(298, 250);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(52, 13);
            this.label_pass.TabIndex = 3;
            this.label_pass.Text = "رمز المرور";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(275, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "العودة للخلف";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.back_button);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(124, 298);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(109, 45);
            this.create_button.TabIndex = 5;
            this.create_button.Text = "إنشاء";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(42, 247);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 390);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_ID);
            this.Name = "RegisterPage";
            this.Text = "إنشاء حساب";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}