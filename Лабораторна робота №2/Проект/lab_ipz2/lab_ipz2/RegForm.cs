using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_ipz2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            this.passfield.Size = new Size(this.passfield.Size.Width, 36);
            this.passfield.AutoSize = false;
            this.passfield2.Size = new Size(this.passfield.Size.Width, 36);
            this.passfield2.AutoSize = false;
        }

     
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void closebtn_MouseLeave(object sender, EventArgs e)
        {
            closebtn.ForeColor = Color.White;
        }

        private void closebtn_MouseEnter(object sender, EventArgs e)
        {
            closebtn.ForeColor = Color.Red;
        }
        Point lastPoint;

        private void regpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void regpanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
