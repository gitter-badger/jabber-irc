using System.Collections.Generic;

namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: channel *( "," channel ) [ "Part Message" ]
    /// 
    /// The PART command causes the user sending the message to be removed
    /// from the list of active members for all given channels listed in the
    /// parameter string. If a "Part Message" is given, this will be sent 
    /// instead of the default message, the nickname. This request is always
    /// granted by the server
    /// 
    /// Servers MUST be able to parse arguments in the form of a list of
    /// target, but SHOULD NOT use lists when sending PART messages to 
    /// clients.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Part(string channel, string leaveMessage = null)
        {
            string message = leaveMessage != null ? " :" + leaveMessage : "";
            string command = $"PART {channel}{message}";
            return command;
        }

        public static string Part(List<string> channels, string leaveMessage = null)
        {
            string message = leaveMessage != null ? " :" + leaveMessage : "";
            string channelNames = string.Join(",", channels.ToArray());
            string command = $"PART {channelNames}{message}";
            return command;
        }
    }
}
