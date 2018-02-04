namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ mask [ type ] ]
    /// 
    /// The SERVLIST command is used to list services currently connected to the network and visible to
    /// the user issuing the command. The optional parameters may be used to restrict the result of the
    /// query (to matching services names, and services type).
    /// </summary>
    public partial class IrcCommand
    {
        public static string ServList()
        {
            return "SERVLIST";
        }

        public static string ServList(string mask)
        {
            return $"SERVLIST {mask}";
        }

        public static string ServList(string mask, string type)
        {
            return $"SERVLIST {mask} {type}";
        }
    }
}
