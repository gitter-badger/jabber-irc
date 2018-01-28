using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: server [ server2 ] 
    /// 
    /// PONG mesage is a reply to ping message. If parameter "server2" is
    /// given, this message MUST be forwarded to given target. the "server"
    /// parameter is the name o fthe entity who has responded to PING message
    /// and generated this message.
    /// </summary>
    public static class PongExtension
    {
        public static void Pong(this ApiWrapper apiWrapper, StreamWriter writer, string server1, string server2=null)
        {
            string space = server2 == null ? "" : " ";
            writer.WriteLine($"PONG {server1}{space}{server2}");
        }
    }
}
