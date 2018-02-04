namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ target ] mask *( "," mask )
    /// 
    /// This command is used to query information about particular user.
    /// The server will answer this command with several numeric messages
    /// indicating different statuses of each user which matches the mask (if
    /// you are entitled to see them). If no wildcard is present in the 
    /// mask, any information about that nick which you are allowed to see
    /// is presented.
    /// 
    /// If the target parameter is specified, it sends the query to a 
    /// specific server. It is useful if you want to know how long the user
    /// in question has been idle as only local server (i.e., the server the 
    /// user is directly connected to) knows that information, while 
    /// everything else is globally known.
    /// 
    /// Wildcards are allowed in the target server
    /// </summary>
    public partial class IrcCommand
    {
        public static string WhoIs(string userMask, string targetServer=null)
        {
            string targetSpace = targetServer == null ? "" : " ";
            return $"WHOIS{targetSpace}{targetServer} {userMask}";
        }
    }
}
