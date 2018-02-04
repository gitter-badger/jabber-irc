using System.Collections.Generic;

namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: channel *( "," channel ) user *( "," user ) [comment]
    /// 
    /// The KICK command can be used to request the forced removal of a user
    /// from a channel. It causes the "user" to PART from the "channel" by
    /// force. For the message to be syntactically correct, there MUST be
    /// either one channel parameter and multiple user parameter, or as many
    /// channel parameters are there are user parameters. If a "comment" is
    /// given, this will be sent instead of the default message, the nickname
    /// of the user issuing the KICK.
    /// 
    /// The server MUST NOT send KICK messages with multiple channels or
    /// users to clients. This is necessarily to maintain backward
    /// compatibility with old client software.
    /// </summary>
    public partial class IrcCommand
    {
        
        public static string Kick(string channel, string user, string comment=null)
        {
            return $"KICK {channel} {user}{(comment== null ? "" : $" :{comment}")}";
        }

        public static string Kick(List<string> channels, List<string> users, string comment=null)
        {
            string channelNames = string.Join(",", channels);
            string usernames = string.Join(",", users);
            string separator = comment == null ? "" : " :";
            return $"KICK {channelNames} {usernames}{separator}{comment}";
        }
    }
}
