
namespace GradesForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Show = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
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
            // AddStudent
            // 
            this.AddStudent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.AddStudent, "AddStudent");
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.UseVisualStyleBackColor = false;
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
            // 
            // reset
            // 
            resources.ApplyResources(this.reset, "reset");
            this.reset.Name = "reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reset);
            this.Controls.Add(this.save);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.Show);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
    }
}

