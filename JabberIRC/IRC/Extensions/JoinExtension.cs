namespace JabberIRC.IRC
{
    using System.Collections.Generic;
    using System.IO;

    public static class JoinExtension
    {
        /// <summary>
        /// Join a channel with its corresponding channel name
        /// </summary>
        public static void Join(this ApiWrapper apiWrapper, string channel, string nick, string realName, StreamReader reader, StreamWriter writer)
        {
            writer.WriteLine("NICK {0}", nick);
            writer.WriteLine("USER {0} +mode * : {0}, {1}", nick, realName);
            writer.WriteLine("JOIN {0}", channel);
        }

        public static void Join(this ApiWrapper apiWrapper, string channel, string key, StreamWriter writer)
        {
            writer.WriteLine("JOIN {0} {1}", channel, key);
        }

        public static void Join(this ApiWrapper apiWrapper, List<string> channels, StreamWriter writer)
        {
            writer.WriteLine("JOIN {0}", string.Join(",", channels.ToArray()));
        }

        public static void LeaveAllChannels(this ApiWrapper apiWrapper, StreamWriter writer)
        {
            writer.WriteLine("JOIN 0");
        }
    }
}
