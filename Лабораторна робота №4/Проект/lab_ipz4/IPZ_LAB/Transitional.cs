using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IPZ_LAB
{
    public partial class Transitional : Form
    {
        public Transitional()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exit exit = new Exit();
            exit.ShowDialog();
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("Ви успішно забронювали місце", "Succes", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void findTbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration regForm = new Registration();
            regForm.Show();
        }

        private void findDbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform loginForm = new Loginform();
            loginForm.Show();
        }

    }
}

