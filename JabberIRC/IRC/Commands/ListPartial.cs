using System.Collections.Generic;

namespace JabberIRC.IRC
{
    public partial class IrcCommand
    {
        /// <summary>
        /// List all channels
        /// </summary>
        public static string List()
        {
            return "LIST";
        }

        public static string List(List<string> channels)
        {
            return $"LIST {string.Join(",", channels)}";
        }
    }
}
