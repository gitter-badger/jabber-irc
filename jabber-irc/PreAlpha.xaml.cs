using System;
using System.Collections.Generic;
using System.Linq;
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

        public PreAlpha()
        {
            InitializeComponent();
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {
        }

        private void JoinChannel(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(channelText.Text);
            Console.WriteLine(usernameText.Text);
        }
    }
}
