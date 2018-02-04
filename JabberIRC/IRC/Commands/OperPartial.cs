namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: name password
    /// 
    /// A normal user uses the OPER command to obtain operator privileges.
    /// The combination of "name" and "password" are REQUIRED to gain
    /// Operator privileges. Upon success, the user will receive a MODE
    /// message indicating the new user modes.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Oper(string name, string password)
        {
            return $"OPER {name} {password}";
        }
    }
}
