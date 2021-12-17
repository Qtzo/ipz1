namespace IPZ_LAB
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginlabel = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.passbox = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.labelpass = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.loginlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 91);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginlabel
            // 
            this.loginlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginlabel.Font = new System.Drawing.Font("Leelawadee UI Semilight", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.loginlabel.Location = new System.Drawing.Point(110, 9);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(301, 64);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Реєстрація";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginlabel.UseCompatibleTextRendering = true;
            // 
            // RegButton
            // 
            this.RegButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegButton.BackColor = System.Drawing.Color.White;
            this.RegButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.RegButton.FlatAppearance.BorderSize = 0;
            this.RegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RegButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(208)));
            this.RegButton.ForeColor = System.Drawing.Color.Black;
            this.RegButton.Location = new System.Drawing.Point(110, 301);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(301, 63);
            this.RegButton.TabIndex = 13;
            this.RegButton.Text = "Зареєструватися";
            this.RegButton.UseCompatibleTextRendering = true;
            this.RegButton.UseMnemonic = false;
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // passbox
            // 
            this.passbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passbox.Font = new System.Drawing.Font("Microsoft YaHei", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passbox.Location = new System.Drawing.Point(72, 236);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(441, 40);
            this.passbox.TabIndex = 12;
            this.passbox.TextChanged += new System.EventHandler(this.passbox_TextChanged);
            // 
            // loginbox
            // 
            this.loginbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginbox.Font = new System.Drawing.Font("Microsoft YaHei", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbox.Location = new System.Drawing.Point(72, 137);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(441, 40);
            this.loginbox.TabIndex = 11;
            this.loginbox.TextChanged += new System.EventHandler(this.loginbox_TextChanged);
            // 
            // labelpass
            // 
            this.labelpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("Leelawadee UI Semilight", 14F, System.Drawing.FontStyle.Bold);
            this.labelpass.ForeColor = System.Drawing.Color.Black;
            this.labelpass.Location = new System.Drawing.Point(67, 203);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(89, 25);
            this.labelpass.TabIndex = 10;
            this.labelpass.Text = "Пароль:";
            this.labelpass.Click += new System.EventHandler(this.labelpass_Click);
            // 
            // labellogin
            // 
            this.labellogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Leelawadee UI Semilight", 14F, System.Drawing.FontStyle.Bold);
            this.labellogin.ForeColor = System.Drawing.Color.Black;
            this.labellogin.Location = new System.Drawing.Point(67, 104);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(69, 25);
            this.labellogin.TabIndex = 9;
            this.labellogin.Text = "Логін:";
            this.labellogin.Click += new System.EventHandler(this.labellogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IPZ_LAB.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(30, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IPZ_LAB.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(30, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(526, 446);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labellogin);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}