using System.Collections.Generic;

namespace JabberIRC.IRC
{
    public partial class IrcCommand
    {
        /// <summary>
        /// List visiable users of a channel
        /// </summary>
        /// <param name="apiWrapper"></param>
        /// <param name="channel"></param>
        /// <param name="writer"></param>
        public static string Names(string channel)
        {
            return $"NAMES {channel}";
        }

        public static string Names(List<string> channels)
        {
            return $"NAMES {string.Join(",", channels.ToArray())}";
        }
    }
}
