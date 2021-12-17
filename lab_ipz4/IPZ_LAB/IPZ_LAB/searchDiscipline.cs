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
    public partial class searchDiscipline : Form
    {
        public searchDiscipline()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transitional tranzitional = new Transitional();
            tranzitional.ShowDialog();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox2.Items.Clear();
                    items.Clear();
                    items.Add("Комп'ютерна інженерія");
                    items.Add("Кібер безпека");
                    comboBox2.Items.AddRange(items.ToArray());
                    break;
                case 1:
                    comboBox2.Items.Clear();
                    items.Clear();
                    items.Add("Системний аналіз");
                    items.Add("Філологія");
                    comboBox2.Items.AddRange(items.ToArray());
                    break;
                case 2:
                    comboBox2.Items.Clear();
                    items.Clear();
                    items.Add("Біомедична інженерія");
                    items.Add("Електроніка");
                    comboBox2.Items.AddRange(items.ToArray());
                    break;
                case 3:
                    comboBox2.Items.Clear();
                    items.Clear();
                    items.Add("Гідротехніка");
                    items.Add("Будівництво та цивільна інженерія");
                    comboBox2.Items.AddRange(items.ToArray());
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> items1 = new List<string>();
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    comboBox4.Items.Clear();
                    items1.Clear();
                    items1.Add("1");
                    items1.Add("2");
                    items1.Add("3");
                    items1.Add("4");
                    comboBox4.Items.AddRange(items1.ToArray());
                    break;
                case 1:
                    comboBox4.Items.Clear();
                    items1.Clear();
                    items1.Add("5");
                    comboBox4.Items.AddRange(items1.ToArray());
                    break;

            }
        }
    }
}
