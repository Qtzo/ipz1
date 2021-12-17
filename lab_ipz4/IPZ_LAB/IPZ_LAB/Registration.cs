using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPZ_LAB
{
    public partial class Registration : Form
    {
        
      
        public Registration()
        {
            InitializeComponent();
          
        }
        
        private void EnterButton_Click(object sender, EventArgs e)
        {
            string login1 = loginbox.Text;
            string pass1 = passbox.Text;
            string input = "2" + Char.MinValue;

            if (!string.IsNullOrEmpty(login1) && !string.IsNullOrEmpty(pass1))
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket socket1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 904);
            socket1.Connect("127.0.0.1", 905);
            socket2.Connect("127.0.0.1", 906);

            

                byte[] buffer = Encoding.ASCII.GetBytes(login1);
                socket.Send(buffer, buffer.Length, 0);

                byte[] buffer1 = Encoding.ASCII.GetBytes(pass1);
                socket1.Send(buffer1, buffer1.Length, 0);
                byte[] buffer2 = Encoding.ASCII.GetBytes(input);
                socket2.Send(buffer2, buffer2.Length, 0);


                buffer = new byte[256];
                socket.Receive(buffer);
                string tmp = "" + Char.MinValue;
                tmp = Encoding.ASCII.GetString(buffer);
                string newtmp = tmp.TrimEnd('\0');
                string tmp1 = Convert.ToString(1);

                if (newtmp == tmp1)
                {
                    MessageBox.Show("Такий користувач зареєстрований, ввійдіть!");
                    this.Hide();
                    Loginform LOG = new Loginform();
                    LOG.ShowDialog();
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
                else
                {
                    MessageBox.Show("Користувача додано, авторизуйтеся!");
                    this.Hide();
                    Loginform LOG = new Loginform();
                    LOG.ShowDialog();
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
            else { MessageBox.Show("Ви не ввели логін або пароль"); }

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void labelpass_Click(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labellogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

