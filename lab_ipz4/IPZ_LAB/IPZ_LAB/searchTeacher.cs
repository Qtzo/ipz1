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
    public partial class searchTeacher : Form
    {
        public searchTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transitional transitional = new Transitional();
            transitional.ShowDialog();
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           List<string> items = new List<string>();
           switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        comboBox4.Items.Clear();
                        items.Clear();
                        items.Add("ЕОМ");
                        items.Add("СКС");
                        comboBox4.Items.AddRange(items.ToArray());
                        break;
                    case 1:
                        comboBox4.Items.Clear();
                        items.Clear();
                        items.Add("ІСМ");
                        items.Add("АСУ");
                        comboBox4.Items.AddRange(items.ToArray());
                        break;
                    case 2:
                        comboBox4.Items.Clear();
                        items.Clear();
                        items.Add("ЕП");
                        items.Add("ТК");
                        comboBox4.Items.AddRange(items.ToArray());
                        break;
                    case 3:
                        comboBox4.Items.Clear();
                        items.Clear();
                        items.Add("АДМ");
                        items.Add("БКМ");
                        comboBox4.Items.AddRange(items.ToArray());
                        break;
                }
            
        }

      
    }
}

