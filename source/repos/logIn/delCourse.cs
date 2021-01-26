using GradesForm;
using MySql.Data.MySqlClient;
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
    public partial class delCourse : Form
    {
        private string registered;

        public delCourse(string registered)
        {
            this.registered = registered;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sgPage = new homePage(registered);
            sgPage.Show();
        }

        private void close_button(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void del_course(object sender, EventArgs e)
        {
            string c_id = textBox1.Text;
            string sqlConnection = "Server=localhost;Database=studentsgrade;Uid=root;Pwd=";

            MySqlConnection dbConnection = new MySqlConnection(sqlConnection);
            MySqlCommand commandDb;


            try
            {
                dbConnection.Open();
                commandDb = dbConnection.CreateCommand();
                commandDb.CommandText = ("DELETE FROM teachers_courses WHERE teacher_id = "+registered+" AND course_id ="+c_id+";");
                commandDb.ExecuteNonQuery();

                commandDb.CommandText = ("SELECT course_name FROM course WHERE course_id = " + c_id + " ;");

                MySqlDataReader reader = commandDb.ExecuteReader();
                reader.Read();
                MessageBox.Show(".من قائمتك " + reader["course_name"].ToString() + " تم حذف المادة ");
                reader.Close();

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

        private void delCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
