using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC
{
    class ApiWrapper
    {
        public ApiWrapper()
        {
            
        }

        /// <summary>
        /// Connect to an IRC server
        /// </summary>
        /// <param name="server">Server address</param>
        /// <param name="port">Port number</param>
        public void Connect(string server, int port, StreamReader reader, StreamWriter writer)
        {

        }

        /// <summary>
        /// Join a channel with its corresponding channel name
        /// </summary>
        public void Join(string channel, string nick, string realName, StreamReader reader, StreamWriter writer)
        {
            writer.WriteLine("NICK {0}", nick);
            writer.WriteLine("USER {0} +mode * : {1}", nick, realName);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Me()
        {

        }

        /// <summary>
        /// Start a private chat
        /// </summary>
        public void Msg()
        {

        }

        public void Nick()
        {

        }


        /// <summary>
        /// Send a short message to another person without opening up a private window
        /// </summary>
        public void Notice()
        {

        }

        /// <summary>
        /// To leave a channel
        /// </summary>
        public void Part()
        {

        }

        /// <summary>
        /// To leave all channels
        /// </summary>
        public void PartAll()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void Ping()
        {

        }

        /// <summary>
        /// Similar to Msg, except it foreces a window to pop open
        /// </summary>
        public void Query()
        {

        }

        /// <summary>
        /// Leave IRC altogether
        /// </summary>
        public void Quit()
        {

        }

        /// <summary>
        /// Ingnore messages sending from a user
        /// </summary>
        public void Ignore()
        {

        }

        /// <summary>
        /// Check information about one user
        /// </summary>
        public void WhoIs()
        {

        }

        /// <summary>
        /// Opens up a DCC/CHAT window to another user
        /// </summary>
        public void Chat()
        {

        }

        /// <summary>
        /// Check help info
        /// </summary>
        public void Help()
        {

        }

    }
}
