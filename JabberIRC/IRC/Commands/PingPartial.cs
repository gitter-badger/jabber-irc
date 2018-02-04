namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: server1 [ server2 ]
    /// 
    /// The PING command is used to test the presence of an active client or
    /// server at the other end of the connection. Servers send a PING
    /// message at regular intervals if no other activity detected coming
    /// from a connection. If a connection fails to respond to a PING
    /// message within a set amount of time, that connection is closed. A
    /// PING message MAY be sent even if the connection is active.
    /// 
    /// When a PING message is received, the appropriate PONG message MUST be
    /// sent as reply to server1 erver which sent the PING message out)
    /// as soon as possible. If the server2 parameter is specified, it
    /// represnets the target of the ping, and the message gets forwarded
    /// there.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Ping(string server1, string server2=null)
        {
            string space = server2 == null ? "": " ";
            return $"PING {server1}{space}{server2}";
        }
    }
}
