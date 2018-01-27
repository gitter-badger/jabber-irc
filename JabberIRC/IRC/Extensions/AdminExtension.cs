using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: [ target ]
    /// 
    /// The admin command is used to find information about the adminisrator of the given server,
    /// or current server if "target" parameter is omitted. Each server MUST have the ability to 
    /// forward ADMIN messages to other servers
    /// 
    /// Wildcards are allowed in the "target" parameter
    /// </summary>
    public static class AdminExtension
    {
        public static void Admin(this ApiWrapper apiWrapper, StreamWriter writer, string target=null)
        {
            string space = target == null ? "" : " ";
            writer.WriteLine($"ADMIN{space}{target}");
        }
    }
}
