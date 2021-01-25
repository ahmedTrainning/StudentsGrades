
namespace logIn
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
            this.UserIDTXT = new System.Windows.Forms.TextBox();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LogInLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserIDTXT
            // 
            this.UserIDTXT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.UserIDTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserIDTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserIDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDTXT.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UserIDTXT.Location = new System.Drawing.Point(68, 131);
            this.UserIDTXT.Name = "UserIDTXT";
            this.UserIDTXT.Size = new System.Drawing.Size(211, 24);
            this.UserIDTXT.TabIndex = 0;
            this.UserIDTXT.Text = "                   User ID";
            this.UserIDTXT.TextChanged += new System.EventHandler(this.UserIDTXT_TextChanged);
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
            this.PasswordTXT.Text = "                 Password";
            this.PasswordTXT.TextChanged += new System.EventHandler(this.PasswordTXT_TextChanged);
            // 
            // LogInbutton
            // 
            this.LogInbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInbutton.Location = new System.Drawing.Point(68, 311);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(75, 31);
            this.LogInbutton.TabIndex = 2;
            this.LogInbutton.Text = "تسجيل الدخول";
            this.LogInbutton.UseVisualStyleBackColor = true;
            this.LogInbutton.Click += new System.EventHandler(this.LogInbutton_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.Blue;
            this.register.Location = new System.Drawing.Point(221, 371);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(78, 23);
            this.register.TabIndex = 3;
            this.register.Text = "Click here !";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.button2_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(204, 311);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 31);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LogInLabel1
            // 
            this.LogInLabel1.AutoSize = true;
            this.LogInLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel1.Location = new System.Drawing.Point(140, 63);
            this.LogInLabel1.Name = "LogInLabel1";
            this.LogInLabel1.Size = new System.Drawing.Size(65, 22);
            this.LogInLabel1.TabIndex = 9;
            this.LogInLabel1.Text = "log In ";
            this.LogInLabel1.Click += new System.EventHandler(this.LogInLabel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Don\'t have an acount ? ";
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(342, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogInLabel1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.register);
            this.Controls.Add(this.LogInbutton);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.UserIDTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserIDTXT;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Button LogInbutton;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label LogInLabel1;
        private System.Windows.Forms.Label label2;
    }
}

