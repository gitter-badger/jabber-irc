namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ mask [ target ] ]
    /// 
    /// LUSERS command is used to get statistics about the size of the network.
    /// If no parameter is given, the reply will be about the whole net. If a mask
    /// is specified, then the replay will only concern the part of the network
    /// formed by the servers matching the mask. Finally, if the target parameter
    /// is specified, the request is forwarded to that server which will generate
    /// the reply.
    /// 
    /// Wildcards are allowed in the "target" parameter
    /// </summary>
    public partial class IrcCommand
    {
        public static string Lusers()
        {
            return "LUSERS";
        }

        public static string Lusers(string mask)
        {
            return $"LUSERS {mask}";
        }

        public static string Lusers(string mask, string target)
        {
            return $"LUSERS {mask} {target}";
        }
    }
}
