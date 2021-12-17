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

        private void btnsearchteacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchTeacher searchteacher = new searchTeacher();
            searchteacher.ShowDialog();
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

        private void btnsearchdiscipline_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchDiscipline searchdiscipline = new searchDiscipline();
            searchdiscipline.ShowDialog();
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
    }
    }

