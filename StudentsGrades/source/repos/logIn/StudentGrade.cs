using AddStudent;
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
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hum = new addStudent(); 
            hum.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hum5 = new logInPage();
            hum5.Show();
        }
    }
}
