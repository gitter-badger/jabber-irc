using System.Collections.Generic;

namespace JabberIRC.IRC.Commands
{
    public partial class IrcCommand
    {
        /// <summary>
        /// Parameters: [ channel *( "," channel ) [ target ] ]
        ///  
        /// By using the NAMES command, a user can list all nicknames that are
        /// visible to him. For more  details on what is visible and what is not,
        /// The "channel" parameter specifies which channel(s) to return information
        /// about. There is no error reply for bad channel names.
        /// 
        /// If no "channel" parameter is given, a list of all channels and their
        /// occupants is returned. At the end of this list, a list of users who
        /// are visible but either not on any channel or not on a visible channel
        /// are listed as being on channel "*".
        /// 
        /// If the "target" parameter is specified, the request is forwarded to 
        /// that server which will generate the reply.
        /// 
        /// Wildcards are allowed in the "target" parameter.
        /// </summary>
        public static string Names()
        {
            return "NAMES";
        }

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
