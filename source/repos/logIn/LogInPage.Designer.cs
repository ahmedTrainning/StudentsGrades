
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.LogInLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.visible_pic = new System.Windows.Forms.PictureBox();
            this.unvisibl_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.visible_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisibl_pic)).BeginInit();
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
            this.LogInbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInbutton.Location = new System.Drawing.Point(68, 311);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(75, 31);
            this.LogInbutton.TabIndex = 2;
            this.LogInbutton.Text = "تسجيل الدخول";
            this.LogInbutton.UseVisualStyleBackColor = true;
            this.LogInbutton.Click += new System.EventHandler(this.login_button);
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
            this.CloseButton.Text = "إغلاق";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.close_button);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(186, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "إنشاء حساب جديد ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Click += new System.EventHandler(this.register_lable);
            // 
            // visible_pic
            // 
            this.visible_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("visible_pic.BackgroundImage")));
            this.visible_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visible_pic.Location = new System.Drawing.Point(68, 234);
            this.visible_pic.Name = "visible_pic";
            this.visible_pic.Size = new System.Drawing.Size(57, 24);
            this.visible_pic.TabIndex = 0;
            this.visible_pic.TabStop = false;
            this.visible_pic.Click += new System.EventHandler(this.visible_pass_pic);
            // 
            // unvisibl_pic
            // 
            this.unvisibl_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unvisibl_pic.BackgroundImage")));
            this.unvisibl_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.unvisibl_pic.Location = new System.Drawing.Point(68, 234);
            this.unvisibl_pic.Name = "unvisibl_pic";
            this.unvisibl_pic.Size = new System.Drawing.Size(57, 24);
            this.unvisibl_pic.TabIndex = 12;
            this.unvisibl_pic.TabStop = false;
            this.unvisibl_pic.Click += new System.EventHandler(this.unvisible_pass_pic);
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(342, 425);
            this.Controls.Add(this.unvisibl_pic);
            this.Controls.Add(this.visible_pic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogInLabel1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LogInbutton);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.field_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogInPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visible_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisibl_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox field_id;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Button LogInbutton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label LogInLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox visible_pic;
        private System.Windows.Forms.PictureBox unvisibl_pic;

    }
}

