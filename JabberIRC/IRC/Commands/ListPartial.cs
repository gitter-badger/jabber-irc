using System.Collections.Generic;

namespace JabberIRC.IRC.Commands
{
    public partial class IrcCommand
    {
        /// <summary>
        /// Parameters: [ channel *( "," channel ) [ target ] ] 
        /// 
        /// The list command is used to list channels and their topics. If the
        /// "channel" paramter is used, only the status of that channel is
        /// displayed.
        /// 
        /// If the "target" parameter is specified, the request is forwarded to
        /// that server which will generate the reply.
        /// 
        /// Wildcards are allowed in the "target" parameter.
        /// </summary>
        public static string List()
        {
            return "LIST";
        }

        public static string List(string channel, string target=null)
        {
            string space = target == null ? "" : " ";
            return $"LIST {channel}{space}{target}";
        }

        public static string List(List<string> channels, string target=null)
        {
            string space = target == null ? "" : " ";
            return $"LIST {string.Join(",", channels)}{space}{target}";
        }
    }
}
