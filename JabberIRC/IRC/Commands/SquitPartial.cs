namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: server comment
    /// 
    /// The SQUIT command is available only to operators. It is used to
    /// disconnect server links. Also servers can generate SQUIT messages on
    /// error conditions. A SQUIT message may also target a remote server
    /// connection. In this case, the SQUIT message will simply be sent to 
    /// operator and the remote server.
    /// 
    /// The comment SHOULD be supplied by all operators who execute a SQUIT
    /// for a remote server. The server ordered to disconnect its peer
    /// generates a WALLOPS message with 'comment' included, so that other
    /// users may be aware of the reason of this action.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Squit(string server, string comment)
        {
            return $"SQUIT {server} :{comment}";
        }
    }
}
