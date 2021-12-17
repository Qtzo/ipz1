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
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transitional transit = new Transitional();
            transit.ShowDialog();
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

        private void Confirmlabel_Click(object sender, EventArgs e)
        {

        }

        private void loginlabel_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Load(object sender, EventArgs e)
        {

        }
    }
}
