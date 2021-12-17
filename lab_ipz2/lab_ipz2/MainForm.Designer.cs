
namespace lab_ipz2
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findDbtn = new System.Windows.Forms.Button();
            this.findTbtn = new System.Windows.Forms.Button();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainloginpanel.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainloginpanel
            // 
            this.mainloginpanel.BackColor = System.Drawing.Color.Yellow;
            this.mainloginpanel.Controls.Add(this.button1);
            this.mainloginpanel.Controls.Add(this.label6);
            this.mainloginpanel.Controls.Add(this.textBox1);
            this.mainloginpanel.Controls.Add(this.label5);
            this.mainloginpanel.Controls.Add(this.comboBox2);
            this.mainloginpanel.Controls.Add(this.label4);
            this.mainloginpanel.Controls.Add(this.comboBox1);
            this.mainloginpanel.Controls.Add(this.label3);
            this.mainloginpanel.Controls.Add(this.label2);
            this.mainloginpanel.Controls.Add(this.findDbtn);
            this.mainloginpanel.Controls.Add(this.findTbtn);
            this.mainloginpanel.Controls.Add(this.loginpanel);
            this.mainloginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainloginpanel.Location = new System.Drawing.Point(0, 0);
            this.mainloginpanel.Name = "mainloginpanel";
            this.mainloginpanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainloginpanel.Size = new System.Drawing.Size(800, 650);
            this.mainloginpanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Зайняти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reserve_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Номера";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Місце";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(117, 272);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Зона";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(284, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вільних місць";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(537, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 100);
            this.label2.TabIndex = 0;
            this.label2.Text = "0";
            // 
            // findDbtn
            // 
            this.findDbtn.BackColor = System.Drawing.Color.Yellow;
            this.findDbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findDbtn.Location = new System.Drawing.Point(169, 602);
            this.findDbtn.Name = "findDbtn";
            this.findDbtn.Size = new System.Drawing.Size(151, 36);
            this.findDbtn.TabIndex = 2;
            this.findDbtn.Text = "Логін";
            this.findDbtn.UseVisualStyleBackColor = false;
            this.findDbtn.Click += new System.EventHandler(this.findDbtn_Click);
            // 
            // findTbtn
            // 
            this.findTbtn.BackColor = System.Drawing.Color.Yellow;
            this.findTbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findTbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findTbtn.Location = new System.Drawing.Point(12, 602);
            this.findTbtn.Name = "findTbtn";
            this.findTbtn.Size = new System.Drawing.Size(151, 36);
            this.findTbtn.TabIndex = 1;
            this.findTbtn.Text = "Реєстрація";
            this.findTbtn.UseVisualStyleBackColor = false;
            this.findTbtn.Click += new System.EventHandler(this.findTbtn_Click);
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.DarkBlue;
            this.loginpanel.Controls.Add(this.closebtn);
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(800, 74);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginpanel_MouseDown);
           
            // 
            // closebtn
            // 
            this.closebtn.AutoSize = true;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.closebtn.Location = new System.Drawing.Point(780, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(20, 19);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "X";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть дію";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.mainloginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainloginpanel.ResumeLayout(false);
            this.mainloginpanel.PerformLayout();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainloginpanel;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Label closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findTbtn;
        private System.Windows.Forms.Button findDbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}