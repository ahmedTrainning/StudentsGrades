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

namespace GradesForm
{
    public partial class CoursesF : Form
    {
        private string registered;
        public CoursesF(string registered)
        {

            this.registered = registered;
            InitializeComponent();
        }
        private void CoursesF_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void back_button(object sender, EventArgs e)
        {
            this.Hide();
            var sgPage = new homePage(registered);
            sgPage.Show();
        }

        private void add_course_button(object sender, EventArgs e)
        {
            string c_id = textBox2.Text;
            string sqlConnection = "Server=localhost;Database=studentsgrade;Uid=root;Pwd=";

            MySqlConnection dbConnection = new MySqlConnection(sqlConnection);
            MySqlCommand commandDb;


            try
            {
                dbConnection.Open();
                commandDb = dbConnection.CreateCommand();
                commandDb.CommandText = ("INSERT INTO teachers_courses VALUES ("+registered+","+c_id+");");
                commandDb.ExecuteNonQuery();

                commandDb.CommandText = ("SELECT course_name FROM course WHERE course_id = "+c_id+" ;");

                MySqlDataReader reader = commandDb.ExecuteReader();
                reader.Read();
                MessageBox.Show(" .لقائمتك "+reader["course_name"].ToString()+" تمت اضافة المادة ");
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

        private void show_courses(object sender, EventArgs e)
        {
            string sqlConnection = "Server=localhost;Database=studentsgrade;Uid=root;Pwd=";

            MySqlConnection dbConnection = new MySqlConnection(sqlConnection);
            MySqlCommand commandDb;


            try
            {
                dbConnection.Open();
                commandDb = dbConnection.CreateCommand();
                commandDb.CommandText = ("SELECT * FROM course;");

                MySqlDataReader reader = commandDb.ExecuteReader();
                string[,] reader_res = new string[10, 2];
                int i = 0;
                while (reader.Read() &&  i < 10)
                {
                    reader_res[i,0]=reader["course_id"].ToString();
                    reader_res[i, 1] = reader["course_name"].ToString();
                    i++;
                }
                reader.Close();

                MessageBox.Show("المادة\t - رقم المادة\n"+reader_res[0,1]+"\t -\t "+reader_res[0,0]+"\n"
                    + reader_res[1, 1] + "\t -\t " + reader_res[1, 0] + "\n"
                    + reader_res[2, 1] + "\t -\t " + reader_res[2, 0] + "\n"
                    + reader_res[3, 1] + "\t -\t " + reader_res[3, 0] + "\n"
                    + reader_res[4, 1] + "\t -\t " + reader_res[4, 0] + "\n"
                    + reader_res[5, 1] + "\t -\t " + reader_res[5, 0] + "\n"
                    + reader_res[6, 1] + "\t -\t " + reader_res[6, 0] + "\n"
                    + reader_res[7, 1] + "\t -\t " + reader_res[7, 0] + "\n"
                    + reader_res[8, 1] + " -\t " + reader_res[8, 0] + "\n"
                    + reader_res[9, 1] + "\t -\t " + reader_res[9, 0] + "\n");
                
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
