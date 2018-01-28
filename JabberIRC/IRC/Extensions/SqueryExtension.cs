using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: servicename text
    /// 
    /// The SQUERY command is used similarly to PRIVMSG. The only difference is that the recipient MUST be
    /// a service. This is the only way for a text message to be delivered to a service.
    /// </summary>
    public static class SqueryExtension
    {
        public static void Squery(this ApiWrapper apiWrapper, StreamWriter writer, string serviceName, string text)
        {
            writer.WriteLine($"SQUERY {serviceName} :{text}");
        }
    }
}
