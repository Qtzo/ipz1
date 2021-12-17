
namespace lab_ipz2
{
    partial class RegForm
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
            this.mainregpanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passfield2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.regbtn = new System.Windows.Forms.Button();
            this.passfield = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regpanel = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainregpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.regpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainregpanel
            // 
            this.mainregpanel.BackColor = System.Drawing.Color.Yellow;
            this.mainregpanel.Controls.Add(this.label7);
            this.mainregpanel.Controls.Add(this.label6);
            this.mainregpanel.Controls.Add(this.label5);
            this.mainregpanel.Controls.Add(this.passfield2);
            this.mainregpanel.Controls.Add(this.pictureBox3);
            this.mainregpanel.Controls.Add(this.regbtn);
            this.mainregpanel.Controls.Add(this.passfield);
            this.mainregpanel.Controls.Add(this.pictureBox2);
            this.mainregpanel.Controls.Add(this.loginfield);
            this.mainregpanel.Controls.Add(this.pictureBox1);
            this.mainregpanel.Controls.Add(this.regpanel);
            this.mainregpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainregpanel.Location = new System.Drawing.Point(0, 0);
            this.mainregpanel.Name = "mainregpanel";
            this.mainregpanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainregpanel.Size = new System.Drawing.Size(555, 421);
            this.mainregpanel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(187, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Повторіть пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(187, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(187, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Логін:";
            // 
            // passfield2
            // 
            this.passfield2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passfield2.Location = new System.Drawing.Point(191, 267);
            this.passfield2.Name = "passfield2";
            this.passfield2.Size = new System.Drawing.Size(174, 29);
            this.passfield2.TabIndex = 11;
            this.passfield2.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::lab_ipz2.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(149, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // regbtn
            // 
            this.regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regbtn.Location = new System.Drawing.Point(226, 330);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(113, 41);
            this.regbtn.TabIndex = 6;
            this.regbtn.Text = "Готово";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // passfield
            // 
            this.passfield.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passfield.Location = new System.Drawing.Point(191, 192);
            this.passfield.Name = "passfield";
            this.passfield.Size = new System.Drawing.Size(174, 29);
            this.passfield.TabIndex = 5;
            this.passfield.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::lab_ipz2.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(149, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // loginfield
            // 
            this.loginfield.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginfield.Location = new System.Drawing.Point(191, 116);
            this.loginfield.Multiline = true;
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(174, 36);
            this.loginfield.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab_ipz2.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(149, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // regpanel
            // 
            this.regpanel.BackColor = System.Drawing.Color.DarkBlue;
            this.regpanel.Controls.Add(this.closebtn);
            this.regpanel.Controls.Add(this.label1);
            this.regpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.regpanel.Location = new System.Drawing.Point(0, 0);
            this.regpanel.Name = "regpanel";
            this.regpanel.Size = new System.Drawing.Size(555, 74);
            this.regpanel.TabIndex = 0;
            this.regpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.regpanel_MouseDown);
            this.regpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.regpanel_MouseMove);
            // 
            // closebtn
            // 
            this.closebtn.AutoSize = true;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.closebtn.Location = new System.Drawing.Point(535, 0);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реєстрація";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 421);
            this.Controls.Add(this.mainregpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.mainregpanel.ResumeLayout(false);
            this.mainregpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.regpanel.ResumeLayout(false);
            this.regpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainregpanel;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.TextBox passfield;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel regpanel;
        private System.Windows.Forms.Label closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passfield2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}