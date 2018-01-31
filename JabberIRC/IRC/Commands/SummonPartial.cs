namespace JabberIRC.IRC
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
    public partial class ApiWrapper
    {
        public string Summon(string user, string target=null, string channel=null)
        {
            string targetSpace = target == null ? "" : " ";
            string channelSpace = channel == null ? "" : " ";
            return $"SUMMON {user}{targetSpace}{target}{channelSpace}{channel}";
        }
    }
}
