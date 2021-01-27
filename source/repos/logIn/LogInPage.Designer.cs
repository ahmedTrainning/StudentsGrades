
using System;

namespace GradesForm
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            this.field_id = new System.Windows.Forms.TextBox();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.LogInLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.unvisibl_pic = new System.Windows.Forms.PictureBox();
            this.visible_pic = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unvisibl_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visible_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // field_id
            // 
            this.field_id.BackColor = System.Drawing.SystemColors.HighlightText;
            this.field_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.field_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_id.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.field_id.Location = new System.Drawing.Point(68, 131);
            this.field_id.Name = "field_id";
            this.field_id.Size = new System.Drawing.Size(211, 24);
            this.field_id.TabIndex = 0;
            this.field_id.Text = "رقم الحساب";
            this.field_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTXT.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PasswordTXT.Location = new System.Drawing.Point(68, 195);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.Size = new System.Drawing.Size(211, 24);
            this.PasswordTXT.TabIndex = 1;
            this.PasswordTXT.Text = "الرقم السري";
            this.PasswordTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTXT.UseSystemPasswordChar = true;
            // 
            // LogInbutton
            // 
            this.LogInbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LogInbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInbutton.ForeColor = System.Drawing.Color.White;
            this.LogInbutton.Location = new System.Drawing.Point(68, 300);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(211, 26);
            this.LogInbutton.TabIndex = 2;
            this.LogInbutton.Text = "تسجيل الدخول";
            this.LogInbutton.UseVisualStyleBackColor = false;
            this.LogInbutton.Click += new System.EventHandler(this.login_button);
            // 
            // LogInLabel1
            // 
            this.LogInLabel1.AutoSize = true;
            this.LogInLabel1.Cursor = System.Windows.Forms.Cursors.No;
            this.LogInLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel1.Location = new System.Drawing.Point(125, 60);
            this.LogInLabel1.Name = "LogInLabel1";
            this.LogInLabel1.Size = new System.Drawing.Size(96, 22);
            this.LogInLabel1.TabIndex = 9;
            this.LogInLabel1.Text = "تسجيل دخول";
            this.LogInLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(144, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "اضغط هنا";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Click += new System.EventHandler(this.register_lable);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(301, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.close_button);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "ليس لديك حساب ؟";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = global::logIn.Properties.Resources.LoginBackground;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // unvisibl_pic
            // 
            this.unvisibl_pic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.unvisibl_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unvisibl_pic.BackgroundImage")));
            this.unvisibl_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.unvisibl_pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unvisibl_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unvisibl_pic.Location = new System.Drawing.Point(237, 236);
            this.unvisibl_pic.Name = "unvisibl_pic";
            this.unvisibl_pic.Size = new System.Drawing.Size(42, 24);
            this.unvisibl_pic.TabIndex = 12;
            this.unvisibl_pic.TabStop = false;
            this.unvisibl_pic.Click += new System.EventHandler(this.unvisible_pass_pic);
            // 
            // visible_pic
            // 
            this.visible_pic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.visible_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("visible_pic.BackgroundImage")));
            this.visible_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visible_pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.visible_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visible_pic.Location = new System.Drawing.Point(237, 236);
            this.visible_pic.Name = "visible_pic";
            this.visible_pic.Size = new System.Drawing.Size(42, 24);
            this.visible_pic.TabIndex = 0;
            this.visible_pic.TabStop = false;
            this.visible_pic.Click += new System.EventHandler(this.visible_pass_pic);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(285, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 24);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(285, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 24);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(342, 425);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogInLabel1);
            this.Controls.Add(this.LogInbutton);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.field_id);
            this.Controls.Add(this.unvisibl_pic);
            this.Controls.Add(this.visible_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogInPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unvisibl_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visible_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Button LogInbutton;
        private System.Windows.Forms.Label LogInLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox visible_pic;
        private System.Windows.Forms.PictureBox unvisibl_pic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox field_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

