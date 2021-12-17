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
            socket.Bind(new IPEndPoint(IPAddress.Any, 904));
            socket1.Bind(new IPEndPoint(IPAddress.Any, 905));
            socket2.Bind(new IPEndPoint(IPAddress.Any, 906));

            
            try
            {

                cnn.Open();
                while (true) { 
                Menu();
                }

            }
            catch (Exception ex)
            {
              
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
                    /*case "3":
                        Info();
                        break;
                    case "4":
                        Directinfo();
                        break;
                    case "5":
                        CheckPlace();
                        break;
                    case "6":
                        BuyTicket();
                        break;*/
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
            
            /*void Info()
            {
                
                Socket clientTest = socket.Accept();
                Socket clientTest1 = socket1.Accept();
                buffer = new byte[1024];
                buffer1 = new byte[1024];

                clientTest.Receive(buffer);
                _contents = Encoding.ASCII.GetString(buffer);
                contents = _contents.TrimEnd('\0');
                Console.WriteLine("direct отримано");
                string direct = contents;

                clientTest1.Receive(buffer1);
                _contents1 = Encoding.ASCII.GetString(buffer1);
                contents1 = _contents1.TrimEnd('\0');
                Console.WriteLine("date отримано");
                string dateT = contents1;
                mydate = dateT;
                
                string sqlExpression11 = "select Direction from Autobuses where Direction = '" + direct +"' and Date_Time = '"+ dateT +"'";
                command3 = new SqlCommand(sqlExpression11,cnn);
                reader = null;
                reader = command3.ExecuteReader();
                k = null; p = 0;
                while (reader.Read())
                {
                    p = 1;
                    k += Convert.ToString(reader[0]) + "\n";
                }
                if (p == 1)
                {
                    Console.WriteLine("YOUR ANSWER TO INFO:" + k);
                    buffer = Encoding.ASCII.GetBytes(k);
                }
                else {
                    k = "Does not have a current direction";
                    buffer = Encoding.ASCII.GetBytes(k);
                }
                reader.Close();
                clientTest.Send(buffer);

               
            

               

            }*/
             /*void Directinfo()
            {
                Socket clientTest = socket.Accept();
                buffer = new byte[1024]; string my_direct, my_direct1;
                clientTest.Receive(buffer);
                my_direct = Encoding.ASCII.GetString(buffer);
                my_direct1 = my_direct.TrimEnd('\0');
                mydirect = my_direct1.TrimEnd('\n');
                Console.WriteLine("direct отримано: " + mydirect);
            }*/


            /*void CheckPlace()
            {
                Socket clientTest = socket.Accept();
                buffer = new byte[1024];
                clientTest.Receive(buffer);
                string place = Encoding.ASCII.GetString(buffer);
                myplace = place.TrimEnd('\0'); 

                string my_direct = mydirect; string my_date = mydate;
                string sqlExpression5 = "select ["+ myplace +"] from Autobuses where Direction = '" + my_direct + "' and Date_Time = '" + my_date + "'";
                command5 = new SqlCommand(sqlExpression5, cnn);
                reader = null;
                reader = command5.ExecuteReader();
                k = null;
                while (reader.Read())
                {
                    k += Convert.ToString(reader[0]) + "\n";
                }
                checkplace = k;
                Console.WriteLine("Answer to check place:" + k);
                buffer = Encoding.ASCII.GetBytes(k);
                reader.Close();
                clientTest.Send(buffer);
            }*/
             
            /*void BuyTicket()
            {
                Socket clientTest = socket.Accept();
                buffer = new byte[1024];
                Socket clientTest1 = socket1.Accept();
                buffer1 = new byte[1024];

                clientTest.Receive(buffer);
                clientTest1.Receive(buffer);
                string email = Encoding.ASCII.GetString(buffer);
                myemail = email.TrimEnd('\0');
                string number = Encoding.ASCII.GetString(buffer1);
                mynumber = number.TrimEnd('\0');

                string sqlExpression6 = "update Autobuses set [" + myplace + "] = 'yes' where Direction = '" + mydirect + "' and Date_Time = '" + mydate + "' ";
                command6 = new SqlCommand(sqlExpression6, cnn);

                k = " " + Char.MinValue;
                int num = (Int32)command6.ExecuteNonQuery();
                if (num == 1)
                {
                    k = Convert.ToString(1);
                    buffer = Encoding.ASCII.GetBytes(k);
                    Console.WriteLine("Значення місця оновлено!");
/*
                    // отправитель - устанавливаем адрес и отображаемое в письме имя
                    MailAddress From = new MailAddress("ipzlabvlad@gmail.com", "BusBuys");

                    // кому отправляем
                    MailAddress To = new MailAddress("" + myemail + "");

                    // создаем объект сообщения

                    MailMessage msg = new MailMessage(From, To);
                    // тема письма
                    msg.Subject = "BusBuys Ticket. Ticket number: " + myplace + " " + mydate + " .";


                    // текст письма
                    msg.Body = "Hello. You buy a ticket!\nTicket number: " + myplace + " " + mydate + " .\nCard number:"+ mynumber +"\nDirection: " + mydirect + " .\nDate: " + mydate + " .\nPlace: " + myplace + " .\nDeparture at 12 a.m., from the railway station";



                    // письмо представляет код html
                    msg.IsBodyHtml = true;

                    // адрес smtp-сервера и порт, с которого будем отправлять письмо

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("ipzlabvlad@gmail.com", "qwerty123456");
                    smtp.EnableSsl = true;
                    smtp.Send(msg);
                    Console.WriteLine("Повідомлення надіслано");
                    // логин и пароль
*/
               /* }
                else
                {
                    k = Convert.ToString(0);
                    buffer = Encoding.ASCII.GetBytes(k);
                    Console.WriteLine("Значення місця не оновлено, помилка!");
                }

                
                clientTest.Send(buffer);
                string s = "Hello. You buy a ticket!\nTicket number: " + myplace + " " + mydate + " .\nCard number:" + mynumber + "\nDirection: " + mydirect + " .\nDate: " + mydate + " .\nPlace: " + myplace + " .\nDeparture at 12 a.m., from the railway station";
                buffer1 = Encoding.ASCII.GetBytes(s);
                clientTest1.Send(buffer1);


            }*/







        }
    }
}
