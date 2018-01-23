using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace jabber_irc
{
    /// <summary>
    /// Interaction logic for PreAlpha.xaml
    /// </summary>
    public partial class PreAlpha : Window
    {
        private string server = "chat.freenode.net";
        private int port = 6667;
        private Socket senderSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private Socket receiverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public PreAlpha()
        {
            InitializeComponent();
            InitSockets();
        }

        private void InitSockets()
        {

        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {
        }

        private void JoinChannel(object sender, RoutedEventArgs e)
        {

            var thread = new Thread(() =>
            {
                var client = new TcpClient(server, port);
                var output = new StringBuilder();

                using (NetworkStream stream = client.GetStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            this.Dispatcher.Invoke(() =>
                            {
                                writer.WriteLine(string.Format("NICK {0}", nicknameText.Text));
                                writer.Flush();
                                writer.WriteLine(nicknameText.Text);
                                writer.Flush();
                            });


                            string inputLine;
                            while ((inputLine = reader.ReadLine()) != null)
                            {
                                this.Dispatcher.Invoke(() =>
                                {
                                    output.AppendLine(inputLine);
                                    debugText.Text = output.ToString();
                                    Console.WriteLine(inputLine);
                                });

                                string[] inputWords = inputLine.Split(new Char[] { ' ' });
                                if (inputWords[0] == "PING")
                                {
                                    string pongResponse = inputWords[1];
                                    writer.WriteLine("PONG " + pongResponse);
                                    writer.Flush();
                                }

                                switch (inputWords[1])
                                {
                                    case "001":
                                        writer.WriteLine(string.Format("JOIN {0}", channelText.Text));
                                        writer.Flush();
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }

                this.Dispatcher.Invoke(() =>
                {
                    debugText.Text = output.ToString();
                });

            });

            thread.Start();
        }
    }
}
