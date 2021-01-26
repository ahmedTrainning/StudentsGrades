using logIn;
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
    public partial class homePage : Form
    {
        private string registered;
        public homePage(string registered)
        {

            this.registered = registered;
            InitializeComponent();
        }

        private void StudentGrade_Load(object sender, EventArgs e)
        {

        }


        private void close_button(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void courseF_button(object sender, EventArgs e)
        {
            this.Hide();
            var course = new CoursesF(registered);
            course.Show();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var delC = new delCourse(registered);
            delC.Show();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            this.Hide();
            var quy = new Query(registered);
            quy.Show();

        }
    }
}
