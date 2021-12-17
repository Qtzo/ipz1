namespace IPZ_LAB
{
    partial class Transitional
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
            this.btnsearchteacher = new System.Windows.Forms.Button();
            this.btnsearchdiscipline = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearchteacher
            // 
            this.btnsearchteacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsearchteacher.BackColor = System.Drawing.Color.White;
            this.btnsearchteacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.btnsearchteacher.FlatAppearance.BorderSize = 0;
            this.btnsearchteacher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsearchteacher.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnsearchteacher.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnsearchteacher.Location = new System.Drawing.Point(17, 136);
            this.btnsearchteacher.Name = "btnsearchteacher";
            this.btnsearchteacher.Size = new System.Drawing.Size(250, 180);
            this.btnsearchteacher.TabIndex = 0;
            this.btnsearchteacher.Text = "Пошук викладача";
            this.btnsearchteacher.UseVisualStyleBackColor = false;
            this.btnsearchteacher.Click += new System.EventHandler(this.btnsearchteacher_Click);
            // 
            // btnsearchdiscipline
            // 
            this.btnsearchdiscipline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsearchdiscipline.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsearchdiscipline.BackColor = System.Drawing.Color.White;
            this.btnsearchdiscipline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.btnsearchdiscipline.FlatAppearance.BorderSize = 0;
            this.btnsearchdiscipline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsearchdiscipline.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnsearchdiscipline.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnsearchdiscipline.Location = new System.Drawing.Point(297, 136);
            this.btnsearchdiscipline.Name = "btnsearchdiscipline";
            this.btnsearchdiscipline.Size = new System.Drawing.Size(250, 180);
            this.btnsearchdiscipline.TabIndex = 1;
            this.btnsearchdiscipline.Text = "Пошук дисципліни";
            this.btnsearchdiscipline.UseVisualStyleBackColor = false;
            this.btnsearchdiscipline.Click += new System.EventHandler(this.btnsearchdiscipline_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExit.Location = new System.Drawing.Point(17, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(530, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.loginlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 91);
            this.panel1.TabIndex = 9;
            // 
            // loginlabel
            // 
            this.loginlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginlabel.Font = new System.Drawing.Font("Leelawadee UI Semilight", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.loginlabel.Location = new System.Drawing.Point(129, 9);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(301, 64);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Оберіть дію";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginlabel.UseCompatibleTextRendering = true;
            // 
            // Transitional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(564, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnsearchdiscipline);
            this.Controls.Add(this.btnsearchteacher);
            this.Name = "Transitional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transitional";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsearchteacher;
        private System.Windows.Forms.Button btnsearchdiscipline;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginlabel;
    }
}