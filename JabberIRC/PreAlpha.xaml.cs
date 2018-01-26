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
        }
    }
}
