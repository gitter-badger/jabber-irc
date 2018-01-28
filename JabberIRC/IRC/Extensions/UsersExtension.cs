using System.IO;

namespace JabberIRC.IRC.Extensions
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
    public static class UsersExtension
    {
        public static void Users(this ApiWrapper apiWrapper, StreamWriter writer, string target=null)
        {
            string space = target == null ? "" : " ";
            writer.WriteLine($"USERS{space}{target}");
        }
    }
}
