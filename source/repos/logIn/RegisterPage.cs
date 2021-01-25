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

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
