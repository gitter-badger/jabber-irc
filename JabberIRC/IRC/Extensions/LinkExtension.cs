using System.IO;

namespace JabberIRC.IRC.Extensions
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
    public static class LinkExtension
    {
        public static void Link(this ApiWrapper apiWrapper, string remoteServer, StreamWriter writer)
        {
            writer.WriteLine($"LINKS {remoteServer}");
        }

        public static void Link(this ApiWrapper apiWrapper, string remoteSerer, string serverMask, StreamWriter writer)
        {
            writer.WriteLine($"LINKS {remoteSerer} {serverMask}");
        }
    }
}
