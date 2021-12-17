
namespace lab_ipz2
{
    partial class LoginForm
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
            this.mainloginpanel = new System.Windows.Forms.Panel();
            this.regbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.passfield = new System.Windows.Forms.TextBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainloginpanel.SuspendLayout();
            this.loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainloginpanel
            // 
            this.mainloginpanel.BackColor = System.Drawing.Color.Yellow;
            this.mainloginpanel.Controls.Add(this.regbtn);
            this.mainloginpanel.Controls.Add(this.loginbtn);
            this.mainloginpanel.Controls.Add(this.passfield);
            this.mainloginpanel.Controls.Add(this.pictureBox2);
            this.mainloginpanel.Controls.Add(this.loginfield);
            this.mainloginpanel.Controls.Add(this.pictureBox1);
            this.mainloginpanel.Controls.Add(this.loginpanel);
            this.mainloginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainloginpanel.Location = new System.Drawing.Point(0, 0);
            this.mainloginpanel.Name = "mainloginpanel";
            this.mainloginpanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainloginpanel.Size = new System.Drawing.Size(279, 301);
            this.mainloginpanel.TabIndex = 1;
            // 
            // regbtn
            // 
            this.regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regbtn.Location = new System.Drawing.Point(92, 242);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(107, 23);
            this.regbtn.TabIndex = 7;
            this.regbtn.Text = "Зареєструватися";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginbtn.Location = new System.Drawing.Point(114, 213);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(67, 23);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "Готово";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passfield
            // 
            this.passfield.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passfield.Location = new System.Drawing.Point(67, 171);
            this.passfield.Name = "passfield";
            this.passfield.Size = new System.Drawing.Size(174, 29);
            this.passfield.TabIndex = 5;
            this.passfield.UseSystemPasswordChar = true;
            // 
            // loginfield
            // 
            this.loginfield.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginfield.Location = new System.Drawing.Point(67, 113);
            this.loginfield.Multiline = true;
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(174, 36);
            this.loginfield.TabIndex = 3;
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.DarkBlue;
            this.loginpanel.Controls.Add(this.closebtn);
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(279, 74);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginpanel_MouseDown);
            this.loginpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginpanel_MouseMove);
            // 
            // closebtn
            // 
            this.closebtn.AutoSize = true;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.closebtn.Location = new System.Drawing.Point(259, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(20, 19);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "X";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            this.closebtn.MouseEnter += new System.EventHandler(this.closebtn_MouseEnter);
            this.closebtn.MouseLeave += new System.EventHandler(this.closebtn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизація";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::lab_ipz2.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(25, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab_ipz2.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(25, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 301);
            this.Controls.Add(this.mainloginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.mainloginpanel.ResumeLayout(false);
            this.mainloginpanel.PerformLayout();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainloginpanel;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.TextBox passfield;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Label closebtn;
    }
}