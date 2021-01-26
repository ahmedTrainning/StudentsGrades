﻿using logIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GradesForm;

namespace StudentGrade
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void back_button(object sender, EventArgs e)
        {
            this.Hide();
            var log_page = new LogInPage();
            log_page.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string text3 = textBox3.Text;
            string text4 = textBox4.Text;
            string query = ("INSERT INTO teacher VALUES ("+text1+",NULL,NULL,'"+text2+"','"+text3+"','"+text4+"');");

            string sqlConnection = "Server=localhost;Database=studentsgrade;Uid=root;Pwd=";

            MySqlConnection dbConnection = new MySqlConnection(sqlConnection);

            MySqlCommand commandDb;

            try
            {
                dbConnection.Open();
                commandDb = dbConnection.CreateCommand();
                commandDb.CommandText=query;
                commandDb.ExecuteNonQuery();

                this.Hide();
                var loginPage = new LogInPage();
                loginPage.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Close();
                    
                }
            }
            /* TextBox tb_empty1 = (TextBox)sender;
             tb_empty1.Text = string.Empty;
             tb_empty1.GotFocus -= button2_Click;
            if(button2_Click.Text.Trim() != "" || button2_Click.Text != null)
            {
                button2_Click.Text = "";
            }*/
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
