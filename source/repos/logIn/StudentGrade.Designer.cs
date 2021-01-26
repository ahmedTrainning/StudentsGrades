
namespace GradesForm
{
    partial class StudentGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGrade));
            this.Show = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.LogInLabel1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Show, "Show");
            this.Show.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Show.Name = "Show";
            this.Show.UseVisualStyleBackColor = false;
            // 
            // AddStudent
            // 
            this.AddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.AddStudent, "AddStudent");
            this.AddStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.UseVisualStyleBackColor = false;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.BackColor = System.Drawing.Color.Red;
            this.DeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.DeleteStudent, "DeleteStudent");
            this.DeleteStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.save, "save");
            this.save.Name = "save";
            this.save.UseVisualStyleBackColor = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.reset, "reset");
            this.reset.Name = "reset";
            this.reset.UseVisualStyleBackColor = false;
            // 
            // LogInLabel1
            // 
            resources.ApplyResources(this.LogInLabel1, "LogInLabel1");
            this.LogInLabel1.Cursor = System.Windows.Forms.Cursors.No;
            this.LogInLabel1.Name = "LogInLabel1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // StudentGrade
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LogInLabel1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.save);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.Show);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentGrade";
            this.Load += new System.EventHandler(this.StudentGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label LogInLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

