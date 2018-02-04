namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ [ remotew server ] server mask ]
    /// 
    /// With LINKS, a user can list all servernames, which are known by the server anwsering the query.
    /// The returned list of servers MUST match the mask, or if no mask is given, the full list is returned.
    /// 
    /// If "remote server" is given in addition to "server mask", the LINKS command is forwarded to the 
    /// first server found that matches that name (if any), and that server is then returned to anwser the
    /// query
    /// </summary>
    public partial class IrcCommand
    {
        public static string Links()
        {
            return "LINKS";
        }

        public static string Links(string remoteServer)
        {
            return $"LINKS {remoteServer}";
        }

        public static string Links(string remoteSerer, string serverMask)
        {
            return $"LINKS {remoteSerer} {serverMask}";
        }
    }
}
