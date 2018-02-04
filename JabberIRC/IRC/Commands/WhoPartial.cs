namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ "mask" [ "o" ] ]
    /// 
    /// The WHO command is used by a client to generate a query which returns
    /// a list of information which 'matches' the "mask" parameter given by
    /// the client.In the absence of the "mask" parameter, all visible
    /// (users who aren't invisible (user mode +i) and who don't have a
    /// common channel with the requesting client) are listed.The same
    /// result can be achieved by using a "mask" of "0" or any wildcard which
    /// will end up matching every visible user.
    /// 
    /// The "mask" passed to WHO is matched against users' host, server, real
    /// name and nickname if the channel "mask" cannot be found.
    /// 
    /// If the "o" parameter is passed only operators are returned according
    /// to the "mask" supplied.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Who()
        {
            return "WHO";
        }

        public static string Who(string mask)
        {
            return $"WHO {mask}";
        }

        public static string Who(string mask, bool operators)
        {
            if (!operators) return Who(mask);
            return $"WHO {mask} o";
        }
    }
}
