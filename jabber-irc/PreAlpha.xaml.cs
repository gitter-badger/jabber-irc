using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
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
        private string server = "irc.freenode.net";
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
            // Connect to server
            IPAddress[] remoteIPs = Dns.GetHostAddresses(server);
            senderSock.Connect(remoteIPs, port);
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("Socket connected to {0}", senderSock.RemoteEndPoint.ToString()));
            debugText.Text = output.ToString();
            // Join to Channel
        }
    }
}
