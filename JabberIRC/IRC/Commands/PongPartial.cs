namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: server [ server2 ] 
    /// 
    /// PONG mesage is a reply to ping message. If parameter "server2" is
    /// given, this message MUST be forwarded to given target. the "server"
    /// parameter is the name o fthe entity who has responded to PING message
    /// and generated this message.
    /// </summary>
    public partial class IrcCommand 
    {
        public static string Pong(string server1, string server2=null)
        {
            string space = server2 == null ? "" : " ";
            return $"PONG {server1}{space}{server2}";
        }
    }
}
