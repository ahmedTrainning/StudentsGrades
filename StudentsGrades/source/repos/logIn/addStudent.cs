﻿using GradesForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddStudent
{
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hum4 = new StudentGrade();
            hum4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hum4 = new StudentGrade();
            hum4.Show();
        }
    }
}
