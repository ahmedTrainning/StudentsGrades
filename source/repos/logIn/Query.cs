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
    public partial class Query : Form
    {
        private string registered;

        public Query(string registered)
        {
            this.registered = registered;
            InitializeComponent();
        }

        private void close_button(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void back_button(object sender, EventArgs e)
        {
            this.Hide();
            var homePage = new homePage(registered);
            homePage.Show();
        }

        private void Query_Load (object sender, EventArgs e)
        {
            string sqlConnection = "Server=localhost;Database=studentsgrade;Uid=root;Pwd=";

            MySqlConnection dbConnection = new MySqlConnection(sqlConnection);
            MySqlCommand commandDb;


            try
            {
                dbConnection.Open();
                commandDb = dbConnection.CreateCommand();
                commandDb.CommandText = ("SELECT * FROM teacher WHERE teacher_id = "+registered+";");
                commandDb.ExecuteNonQuery();


                MySqlDataReader reader = commandDb.ExecuteReader();
                reader.Read();
                label1.Text += reader["teacher_id"].ToString();
                reader.Read();
                label2.Text += reader["teacher_name"].ToString();
                reader.Read();
                label3.Text += reader["email"].ToString();
                reader.Close();


                commandDb.CommandText = ("SELECT COUNT(course_id) FROM teachers_courses WHERE teacher_id =" + registered+";");
                reader = commandDb.ExecuteReader();
                reader.Read();
                label4.Text += (reader["COUNT(course_id)"].ToString());
                reader.Close();
                commandDb.ExecuteNonQuery();

                commandDb.CommandText = ("SELECT course.course_id, course.course_name From course JOIN teachers_courses ON course.course_id = teachers_courses.course_id WHERE teacher_id = "+ registered);

                reader = commandDb.ExecuteReader();
                while (reader.Read())
                {
                    label5.Text += ("\n\t"+reader["course_id"].ToString()+"\t").Replace("\t","                  ");
                    label5.Text += ("\t" + reader["course_name"].ToString() + "\n").Replace("\t", "                                 ");

                }
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

    }
}
