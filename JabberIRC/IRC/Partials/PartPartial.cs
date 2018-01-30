using System.Collections.Generic;

namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public void Part(string channel, string leaveMessage = null)
        {
            string message = leaveMessage != null ? " :" + leaveMessage : "";
            string command = string.Format("PART {0}{1}", channel, message);
            _writer.WriteLine(command);
        }

        public void Part(List<string> channels, string leaveMessage = null)
        {
            string message = leaveMessage != null ? " :" + leaveMessage : "";
            string channelNames = string.Join(",", channels.ToArray());
            string command = string.Format("PART {0}{1}", channelNames, message);
            _writer.WriteLine(command);
        }
    }
}
