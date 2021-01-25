
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
            this.Add1Student = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Show.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.Show, "Show");
            this.Show.Name = "Show";
            this.Show.UseVisualStyleBackColor = false;
            // 
            // Add1Student
            // 
            this.Add1Student.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Add1Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add1Student.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add1Student.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.Add1Student, "Add1Student");
            this.Add1Student.Name = "Add1Student";
            this.Add1Student.UseVisualStyleBackColor = false;
            this.Add1Student.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.DeleteStudent, "DeleteStudent");
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            resources.ApplyResources(this.save, "save");
            this.save.Name = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // reset
            // 
            resources.ApplyResources(this.reset, "reset");
            this.reset.Name = "reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::logIn.Properties.Resources.LoginBackground;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // StudentGrade
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.save);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.Add1Student);
            this.Controls.Add(this.Show);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StudentGrade";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Add1Student;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

