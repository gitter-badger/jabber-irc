using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: password
    /// 
    /// The PASS command is used to set a 'connection password'. The
    /// optional password can and MUST be set before any attempt to register
    /// the conenction is made. Currently this requires that user send a
    /// PASS command before sending the NICK/USER combination.
    /// </summary>
    public static class PassExtension
    {
        public static void Pass(this ApiWrapper apiWrapper, StreamWriter writer, string password)
        {
            writer.WriteLine($"PASS {password}");
        }
    }
}
