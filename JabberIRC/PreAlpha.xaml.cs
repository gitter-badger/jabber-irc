using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows;
using JabberIRC.IRC;


namespace JabberIRC
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
            
            IrcClient ircClient = new IrcClient();
            ircClient.ConnectToServer();
            ircClient.JoinChannel("#JabberIRC", "JabberTest", "Jabber IRC", appendDebugMsg);
            /*
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
            */
        }
    }
}
