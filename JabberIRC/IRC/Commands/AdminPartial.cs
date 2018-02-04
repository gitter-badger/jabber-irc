namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ target ]
    /// 
    /// The admin command is used to find information about the adminisrator of the given server,
    /// or current server if "target" parameter is omitted. Each server MUST have the ability to 
    /// forward ADMIN messages to other servers
    /// 
    /// Wildcards are allowed in the "target" parameter
    /// </summary>
    public partial class IrcCommand
    {
        public static string Admin(string target=null)
        {
            string space = target == null ? "" : " ";
            return $"ADMIN{space}{target}";
        }
    }
}
