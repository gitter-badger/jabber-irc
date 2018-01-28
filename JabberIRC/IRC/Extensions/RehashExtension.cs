using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: None
    /// 
    /// The rehash command is an administrative command which can be used by
    /// an operator to force the server to re-read and process its
    /// configuration file.
    /// </summary>
    public static class RehashExtension
    {
        public static void Rehash(this ApiWrapper apiWrapper, StreamWriter writer)
        {
            writer.WriteLine("REHASH");
        }
    }
}
