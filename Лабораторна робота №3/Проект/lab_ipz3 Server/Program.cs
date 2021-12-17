using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;



namespace Server_IPZ
{
    class Program
    {
        
        static int p;
        static string input , k, mydirect, mydate, myplace, mylogin, myemail, mynumber, checkplace; 
        static void Main(string[] args)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = (@"Data Source=DESKTOP-TR0L3MA\SQLEXPRESS;Initial Catalog=ipz;Integrated Security=True;Pooling=False"); 
            cnn = new SqlConnection(connetionString);

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket socket1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            byte[] buffer = new byte[1024];
            byte[] buffer1 = new byte[1024];
            byte[] buffer2 = new byte[1024];
            string contents, contents1, _contents, _contents1, pass, log;
            SqlCommand command, command1, command2, command3, command6, command21, command5;
           
            SqlDataReader reader;
            
           
                socket.Bind(new IPEndPoint(IPAddress.Any, 49152));
                socket1.Bind(new IPEndPoint(IPAddress.Any, 49153));
                socket2.Bind(new IPEndPoint(IPAddress.Any, 49154));
            
        
            
            try
            {

                cnn.Open();
                while (true) { 
                Menu();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Cannot connect to Database");
                    Console.ReadKey();
               

            }

            void Menu()
            {
                socket2.Listen(1000);
                socket.Listen(1000);
                socket1.Listen(1000);
                

                Console.WriteLine("waiting");

               
                Socket clientTest2 = socket2.Accept();

                

                Console.WriteLine("Connection is succeed");
                buffer2 = new byte[1024];
               
                clientTest2.Receive(buffer2);
                input = Encoding.ASCII.GetString(buffer2);
                Console.WriteLine("input отримано");
                string newinput = input.TrimEnd('\0');

                switch (newinput)
                {
                    case "1":
                        SearchUser();
                      
                        break;
                    case "2":
                        SearchUserLogin();
                        break;

                    default:
                        Console.WriteLine("Wrong input, try again!");
                        break;
                }
                  
                

            }

            void SearchUser()
            {
                Socket clientTest = socket.Accept();
                Socket clientTest1 = socket1.Accept();
                buffer = new byte[1024];
                buffer1 = new byte[1024];
                clientTest.Receive(buffer);
                contents = Encoding.ASCII.GetString(buffer);
                Console.WriteLine("LOG отримано");
                log = contents;
                mylogin = log;


                clientTest1.Receive(buffer1);
                contents1 = Encoding.ASCII.GetString(buffer1);
                Console.WriteLine("Pass отримано");
                pass = contents1;

                string sqlExpression = "select count(Login) from Users where Name = '" + log + "'";
                string sqlExpression1 = "select count(Pass) from Users where Password = '" + pass + "'";
                command = new SqlCommand(sqlExpression, cnn);
                command1 = new SqlCommand(sqlExpression1, cnn);
                int num = (Int32)command.ExecuteScalar();
                int num1 = (Int32)command1.ExecuteScalar();
                k = " " + Char.MinValue;
                if (num == 1 && num1 >= 1)
                {
                    Console.WriteLine("Користувача знайдено!");
                    k = Convert.ToString(1);
                    buffer = Encoding.ASCII.GetBytes(k);

                }
                else
                {
                    Console.WriteLine("Користувача не знайдено!");
                    k = Convert.ToString(0);
                    buffer = Encoding.ASCII.GetBytes(k);

                }
                clientTest.Send(buffer);
            }

            void SearchUserLogin()
            {
                Socket clientTest = socket.Accept();
                Socket clientTest1 = socket1.Accept();
                buffer = new byte[1024];
                buffer1 = new byte[1024];
                clientTest.Receive(buffer);
                contents = Encoding.ASCII.GetString(buffer);
                Console.WriteLine("LOG отримано");
                log = contents.TrimEnd('\0');

                clientTest1.Receive(buffer1);
                contents1 = Encoding.ASCII.GetString(buffer1);
                Console.WriteLine("Pass отримано");
                pass = contents1.TrimEnd('\0'); 

                string sqlExpression = "select count(Name) from Users where Name = '" + log + "'";
                command2 = new SqlCommand(sqlExpression, cnn);

                int num = (Int32)command2.ExecuteScalar();

                k = " " + Char.MinValue;
                if (num == 1)
                {
                    Console.WriteLine("Користувача знайдено!");
                    k = Convert.ToString(1);
                    buffer = Encoding.ASCII.GetBytes(k);

                }
                else
                {
                    Console.WriteLine("Користувача не знайдено!");

                    string sqlExpression1 = "insert into Users values ('" + log +"','" + pass + "')" ;
                    command21 = new SqlCommand(sqlExpression1 , cnn);
                    int num1 = (Int32)command21.ExecuteNonQuery();
                   
                    Console.WriteLine("Користувача додано!");
                    k = Convert.ToString(0);
                    buffer = Encoding.ASCII.GetBytes(k);

                }
                clientTest.Send(buffer);
            }         
            



        }
    }
}
