using System.IO;

namespace JabberIRC.IRC.Extensions
{
    public static class KickExtension
    {
        public static void Kick(this ApiWrapper apiWrapper, string channel, string user, StreamWriter writer,  string reason=null)
        {
            writer.WriteLine(string.Format("KICK {0} {1}{2}", channel, user, reason == null ? "" : $" :{reason}"));
        }
    }
}
