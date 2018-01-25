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
using System.Data.SqlClient;
using System.Diagnostics;

namespace jabber_irc
{
    /// <summary>
    /// Interaction logic for PreAlpha.xaml
    /// </summary>
    public partial class PreAlpha : Window
    {
        private string server = "chat.freenode.net";
        private int port = 6667;
        private StringBuilder output = new StringBuilder();

        public PreAlpha()
        {
            InitializeComponent();
        }

        private void appendDebugMsg(string msg)
        {
            output.AppendLine(msg);
            this.Dispatcher.Invoke(() => { debugText.Text = output.ToString(); });
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {
        }

        private void JoinChannel(object sender, RoutedEventArgs e)
        {
            var thread = new Thread(() =>
            {
                var client = new TcpClient(server, port);

                using (NetworkStream stream = client.GetStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        using (StreamWriter writer = new StreamWriter(stream) { NewLine = "\r\n", AutoFlush = true })
                        {
                            writer.WriteLine("NICK JabberTester");
                            writer.Flush();
                            writer.WriteLine("USER {0} +mode * : Jabber IRC", "JabberIRC");
                            writer.Flush();
                            writer.WriteLine("JOIN #JabberIRC");
                            writer.Flush();

                            string inputLine;
                            while ((inputLine = reader.ReadLine()) != null)
                            {
                                appendDebugMsg(inputLine);
                            }
                            appendDebugMsg("Exited while loop");
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
