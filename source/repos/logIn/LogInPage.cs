using StudentGrade;
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

namespace GradesForm
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void register_lable(object sender, EventArgs e)
        {
            this.Hide();
            var register = new RegisterPage();
            register.Show();
        }

        private void close_button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visible_pass_pic(object sender, EventArgs e)
        {
            
            PasswordTXT.UseSystemPasswordChar = true;
            unvisibl_pic.Show();

        }

        private void unvisible_pass_pic(object sender, EventArgs e)
        {
            PasswordTXT.UseSystemPasswordChar = false;
            unvisibl_pic.Hide();

        }

        private void LogInPage_Load(object sender, EventArgs e)
        {
            
        }

        private void login_button(object sender, EventArgs e)
        {
            string text1 = field_id.Text;
            string text2 = PasswordTXT.Text;

            string sqlConnection = "Server=localhost;Database=studentsgrade;Uid=root;Pwd=";

            MySqlConnection dbConnection = new MySqlConnection(sqlConnection);

            MySqlCommand commandDb;


            try
            {
                dbConnection.Open();
                commandDb = dbConnection.CreateCommand();
                commandDb.CommandText = ("SELECT teacher_id FROM teacher;");
                MySqlDataReader reader = commandDb.ExecuteReader();

                bool isMatched = false;
                while (reader.Read())
                {
                    if (text1 == reader["teacher_id"].ToString())
                    {
                        isMatched = true;
                        break;
                    }  
                }
                reader.Close();

                if (isMatched)
                {
                    commandDb.CommandText = ("SELECT pass FROM teacher WHERE teacher_id = " + text1 + ";");
                    reader = commandDb.ExecuteReader();

                    while (reader.Read())
                    {
                        if (text2 == reader["pass"].ToString())
                        {
                            this.Hide();
                            var sgPage = new StudentGrade();
                            sgPage.Show();
                            break;
                        }
                        else
                        {
                            isMatched = false;
                            MessageBox.Show("رقم الحساب او كلمة المرور غير متطابقة");
                            break;
                        }
                    }
                    reader.Close();
                }
                commandDb.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Close();

                }
            }
        }

    }
}
