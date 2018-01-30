using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: nickname
    /// 
    /// NICK command is used to give user a nickname or change the existing
    /// one.
    /// </summary>
    public static class NickExtension
    {
        public static void Nick(this ApiWrapper apiWrapper, StreamWriter writer, string nickname)
        {
            writer.WriteLine($"NICK {nickname}");
        }
    }
}
