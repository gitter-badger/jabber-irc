using System.IO;
using System.Net.Sockets;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: [ mask [ type ] ]
    /// 
    /// The SERVLIST command is used to list services currently connected to the network and visible to
    /// the user issuing the command. The optional parameters may be used to restrict the result of the
    /// query (to matching services names, and services type).
    /// </summary>
    public static class ServListExtension
    {
        public static void ServList(this ApiWrapper apiWrapper, StreamWriter writer, string mask=null, string type=null)
        {
            string space = mask == null ? "" : " ";
            writer.WriteLine($"SERVLIST{space}{mask}{space}{type}");
        }
    }
}
