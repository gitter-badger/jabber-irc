namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ target ]
    /// 
    /// The USERS command returns a list of users logged into the server in a 
    /// format similar to the UNIX commands who(1), ruser(1) and finger(1).
    /// If diabled, the correct numeric MUST be returned to indicate this.
    /// 
    /// Because of the security implications of such a command, it SHOULD be
    /// disabled by default in server implementations. Enabling it SHOULD
    /// require recompiling the server or some equivalent change rather than
    /// simply toggling an option and restarting the server. The procedure 
    /// to enable this command SHOULD also include suitable large comments.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Users(string targetServer=null)
        {
            string space = targetServer == null ? "" : " ";
            return $"USERS{space}{targetServer}";
        }
    }
}
