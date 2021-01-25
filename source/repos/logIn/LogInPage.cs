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

namespace logIn
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
    }
}
