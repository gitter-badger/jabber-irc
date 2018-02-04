namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: user [ target [ channel ] ]
    /// 
    /// The SUMMON command can be used to give users who are on a host
    /// running an IRC server a message asking them to please join IRC. This
    /// message isonly sent if the target server (a) has SUMMON enabled, (b)
    /// the user is logged in and (c) the server rocess can write to the 
    /// user's tty (or similar).
    /// 
    /// If no "server" parameter is given it tries to summon "user" from the
    /// server the client is connected to is assumed as the target.
    /// 
    /// if summon is not enabled in a server, it MUST return the 
    /// ERR_SUMMONDISABLED numeric.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Summon(string user)
        {
            return $"SUMMON {user}";
        }

        public static string Summon(string user, string targetServer)
        {
            return $"SUMMON {user} {targetServer}";
        }

        public static string Summon(string user, string targetServer, string channel)
        {
            return $"SUMMON {user} {targetServer} {channel}";
        }
    }
}
