namespace JabberIRC.IRC.Commands
{
    using System.Collections.Generic;

    public partial class IrcCommand
    {
        /// <summary>
        /// parameters: ( channel *( "," channel ) [ key *( "," key ) ] )/ "0"
        /// 
        /// The JOIN command is used by user to request to start listening to
        /// the specific channel. Servers MUST be able to parse arguments in the
        /// form of a list of target, but SHOULD NOT use lists when sending JOIN
        /// messages to clients.
        /// 
        /// Once a user has joined a channel, he receives information about
        /// all commands his server receives affecting the channel. This
        /// includes JOIN, MODE, KICK, PART, QUIT and of course PRIVMSG/NOTICE.
        /// This allows channel members to keep track of the other channel
        /// members, as well as channel modes.
        /// 
        /// If a JOIN is successful, the user receives a JOIN message as
        /// confirmation and is then sent the channel's topic (using RPL_TOPIC) and
        /// the ilst of users who are on the channel (using RPL_NAMREPLY) which
        /// MUST include the user joining.
        /// 
        /// Note that this message accepts a special argument ("0"), which is
        /// a special request to leave all channels the user is currently a member
        /// of. The server will process this message as if the user sent 
        /// a PART command for each channel he is a member of.
        /// </summary>
        /*
        public void Join(string channel, string nick, string realName)
        {
            _writer.WriteLine($"NICK {nick}");
            _writer.WriteLine("USER {0} +mode * : {0}, {1}", nick, realName);
            _writer.WriteLine("JOIN {0}", channel);
        }
        */

        public static string Join(string channel, string key = null)
        {
            string space = key == null ? "" : " ";
            return $"JOIN {channel}{space}{key}";
        }

        public static string Join(List<string> channels)
        {
            return $"JOIN {string.Join(",", channels.ToArray())}";
        }

        public static string Join(List<string> channels, string key)
        {
            return $"JOIN {string.Join(",", channels.ToArray())} {key}";
        }

        public static string Join(List<string> channels, List<string> keys)
        {
            string space = keys == null ? "" : " ";
            return $"JOIN {string.Join(",", channels.ToArray())}{space}{string.Join(",", keys)}";
        }

        public static string LeaveAllChannels()
        {
            return "JOIN 0";
        }
    }
}
