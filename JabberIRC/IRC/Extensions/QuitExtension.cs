using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: [ "Quit message" ]
    /// 
    /// A client session is terminated with a quit message. The server 
    /// acknowledges this by sending an ERROR message to the client.
    /// </summary>
    public static class QuitExtension
    {
        public static void Quit(this ApiWrapper apiWrapper, StreamWriter writer, string message = null)
        {
            string space = message == null ? "" : " :";
            writer.WriteLine($"QUIT{space}{message}");
        }
    }
}
