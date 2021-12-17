using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IPZ_LAB
{
    
    public partial class Loginform : Form
    {
       
      
        public Loginform()
        {
            InitializeComponent();

         
            this.passbox.UseSystemPasswordChar = true;
        }

            
      

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            string login1 = loginbox.Text ;
            string pass1 = passbox.Text ;
            string input = "1" + Char.MinValue;
             try
                {
            if (!string.IsNullOrEmpty(login1) && !string.IsNullOrEmpty(pass1)) { 
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
                else
                {
                    MessageBox.Show("Неправильний пароль або логін!");
                }
            }else
            {
                MessageBox.Show("Поля пусті");
            }

            }
            catch
            {
                MessageBox.Show("Відсутнє з'єднання з сервером");
            }


        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration newRegform = new Registration();
            newRegform.ShowDialog();
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

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void loginbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || (e.KeyChar == '@') || (e.KeyChar == '.') || (e.KeyChar == '-') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Лише [A-z], [0-9], [@ - _ .]");
            }
        }

        private void passbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || (e.KeyChar == '@') || (e.KeyChar == '.') || (e.KeyChar == '-') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Лише [A-z], [0-9], [@ - _ .]");

            }
        }
    }
}
