﻿using GradesForm;
using Student1Grade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logIn
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var register_page = new RegisterPage();
            register_page.Show();
        }

        private void UserIDTXT_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void UserIDTXT_Click(object sender, EventArgs e)
        {
            UserIDTXT.Clear();
        }

        private void LogInLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PasswordTXT_Click(object sender, EventArgs e)
        {
            PasswordTXT.Clear();
        }
        private void PasswordTXT_TextChanged(object sender, EventArgs e)
        {
            PasswordTXT.PasswordChar = '*';
        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hum2 = new StudentGrade();  
            hum2.Show();
        }
    }
}
