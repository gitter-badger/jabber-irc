namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: None
    /// 
    /// An operator can use the DIE command to shutdown the server. This
    /// message is optional since it may be viewed as a risk to allow
    /// arbitrary people to connect to a server as an operator and execute
    /// this command.
    /// 
    /// The DIE command MUST always be fully processed by the server to which
    /// the sending client is connected and MUST NOT be passed onto other
    /// connected servers.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Die()
        {
            return "DIE";
        }
    }
}
