using System.Collections.Generic;
using System.IO;

namespace JabberIRC.IRC.Extensions
{
    public static class PartExtension
    {
        public static void Part(this ApiWrapper apiWrapper, string channel, StreamWriter writer, string leaveMessage = null)
        {
            string message = leaveMessage != null ? " :" + leaveMessage : "";
            string command = string.Format("PART {0}{1}", channel, message);
            writer.WriteLine(command);
        }

        public static void Part(this ApiWrapper apiWrapper, List<string> channels, StreamWriter writer, string leaveMessage = null)
        {
            string message = leaveMessage != null ? " :" + leaveMessage : "";
            string channelNames = string.Join(",", channels.ToArray());
            string command = string.Format("PART {0}{1}", channelNames, message);
            writer.WriteLine(command);
        }
    }
}
