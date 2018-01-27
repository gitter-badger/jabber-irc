using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// LUSERS command is used to get statistics about the size of the network.
    /// If no parameter is given, the reply will be about the whole net. If a mask
    /// is specified, then the replay will only concern the part of the network
    /// formed by the servers matching the mask. Finally, if the target parameter
    /// is specified, the request is forwarded to that server which will generate
    /// the reply.
    /// </summary>
    public static class LusersExtension
    {
        public static void Lusers(this ApiWrapper apiWrapper, string mask, string target, StreamWriter writer)
        {
            writer.WriteLine($"LUSERS {mask} {target}");
        }

        public static void Lusers(this ApiWrapper apiWrapper, StreamWriter writer)
        {
            writer.WriteLine("LUSERS");
        }
    }
}
