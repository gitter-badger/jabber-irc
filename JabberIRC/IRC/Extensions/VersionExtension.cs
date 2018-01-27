using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// The version command is used to query the version of the server program. An optional
    /// parameter "target" is used to query the version of the server program which a client
    /// is not directly connected to
    /// </summary>
    public static class VersionExtension
    {
        public static void Version(this ApiWrapper apiWrapper, StreamWriter writer, string target=null)
        {
            string space = target == null ? "" : " ";
            writer.WriteLine($"Version{space}{target ?? ""}");
        }
    }
}
