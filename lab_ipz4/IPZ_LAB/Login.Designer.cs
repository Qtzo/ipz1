namespace IPZ_LAB
{
    partial class Loginform
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
            this.labellogin = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.loginlabel);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 91);
            this.panel1.TabIndex = 0;
            // 
            // loginlabel
            // 
            this.loginlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginlabel.Font = new System.Drawing.Font("Leelawadee UI Semilight", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.loginlabel.Location = new System.Drawing.Point(136, 9);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(301, 64);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Авторизація";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginlabel.UseCompatibleTextRendering = true;
            // 
            // labellogin
            // 
            this.labellogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Leelawadee UI Semilight", 14F, System.Drawing.FontStyle.Bold);
            this.labellogin.ForeColor = System.Drawing.Color.Black;
            this.labellogin.Location = new System.Drawing.Point(56, 128);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(69, 25);
            this.labellogin.TabIndex = 1;
            this.labellogin.Text = "Логін:";
            // 
            // labelpass
            // 
            this.labelpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("Leelawadee UI Semilight", 14F, System.Drawing.FontStyle.Bold);
            this.labelpass.ForeColor = System.Drawing.Color.Black;
            this.labelpass.Location = new System.Drawing.Point(56, 227);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(89, 25);
            this.labelpass.TabIndex = 3;
            this.labelpass.Text = "Пароль:";
            // 
            // loginbox
            // 
            this.loginbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginbox.Font = new System.Drawing.Font("Microsoft YaHei", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbox.Location = new System.Drawing.Point(61, 161);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(441, 40);
            this.loginbox.TabIndex = 4;
            this.loginbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginbox_KeyPress);
            // 
            // passbox
            // 
            this.passbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passbox.Font = new System.Drawing.Font("Microsoft YaHei", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passbox.Location = new System.Drawing.Point(61, 260);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(441, 40);
            this.passbox.TabIndex = 5;
            this.passbox.UseSystemPasswordChar = true;
            this.passbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passbox_KeyPress);
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterButton.BackColor = System.Drawing.Color.White;
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(208)));
            this.EnterButton.ForeColor = System.Drawing.Color.Black;
            this.EnterButton.Location = new System.Drawing.Point(196, 325);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(169, 63);
            this.EnterButton.TabIndex = 6;
            this.EnterButton.Text = "Вхід";
            this.EnterButton.UseCompatibleTextRendering = true;
            this.EnterButton.UseMnemonic = false;
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // regbtn
            // 
            this.regbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regbtn.BackColor = System.Drawing.Color.Yellow;
            this.regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.regbtn.ForeColor = System.Drawing.Color.Black;
            this.regbtn.Location = new System.Drawing.Point(196, 408);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(169, 53);
            this.regbtn.TabIndex = 7;
            this.regbtn.Text = "Реєстрація";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::IPZ_LAB.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(19, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::IPZ_LAB.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(19, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(562, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.panel1);
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Loginform_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}