using System.IO;

namespace JabberIRC.IRC.Extensions
{
    public static class NoticeExtension
    {
        public static void Notice(this ApiWrapper apiWrapper, string target, string message, StreamWriter writer)
        {
            writer.WriteLine($"NOTICE {target} :{message}");
        }
    }
}
