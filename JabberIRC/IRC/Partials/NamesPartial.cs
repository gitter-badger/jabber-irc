using System.Collections.Generic;

namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        /// <summary>
        /// List visiable users of a channel
        /// </summary>
        /// <param name="apiWrapper"></param>
        /// <param name="channel"></param>
        /// <param name="writer"></param>
        public void Names(string channel)
        {
            _writer.Write($"NAMES {channel}");
        }

        public void Names(List<string> channels)
        {
            _writer.Write($"NAMES {string.Join(",", channels.ToArray())}");
        }
    }
}
