namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters [ target ]
    /// 
    /// TRACE command is used to find the route to specific server and information about its peers.
    /// Each server that processes this command MUST report to the sender about it. The replies from
    /// pass-through links form a chain, which shows route to destination. After sending this reply
    /// back, the query MUST be sent to the next server until given "target" server is reached.
    /// 
    /// TRACE command is used to find the route to specific server. Each server that processes this 
    /// message MUST tell the sender about it by sending a reply indicating it is a passAtrough-link,
    /// forming a chain of replies. After sending this reply back, it MUST then send the TRACE message
    /// to the next server until given server is reached. If the "target" parameter is ommited, it is
    /// RECOMMENDED that TRACE command sends a message to the sender telling which servers the local
    /// server has direct connection to.
    /// 
    /// If the destination given by "target" is an actual server, the destination server is REQUIRED to
    /// report all servers, services and operators which are connected to it; if the command was issued
    /// by an operator, the server MAY also report all users which are connected to it. If the destination
    /// given by "target" is a nickname, then only a reply for that nickname is given. If the "target"
    /// parameter is omitted, it is RECOMMAND that the TRACE command is parsed as targeted to the processing
    /// server.
    /// 
    /// Wildcards are allowed in the "target" parameter.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Trace(string target=null)
        {
            string space = target == null ? "" : " ";
            return $"TRACE{space}{target}";
        }
    }
}
