using System.Collections.Generic;
using System.IO;

namespace JabberIRC.IRC.Extensions
{
    public static class NamesExtension
    {
        /// <summary>
        /// List visiable users of a channel
        /// </summary>
        /// <param name="apiWrapper"></param>
        /// <param name="channel"></param>
        /// <param name="writer"></param>
        public static void Names(this ApiWrapper apiWrapper, string channel, StreamWriter writer)
        {
            writer.Write($"NAMES {channel}");
        }

        public static void Names(this ApiWrapper apiWrapper, List<string> channels, StreamWriter writer)
        {
            writer.Write($"NAMES {string.Join(",", channels.ToArray())}");
        }
    }
}
