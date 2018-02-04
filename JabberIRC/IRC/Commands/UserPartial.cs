namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: user mode unused realname
    /// 
    /// The USER command is used at the beginning of connection to specify
    /// the username, hostname and realname of a new user.
    /// 
    /// The mode parameter should be numeric, and can be used to 
    /// automatically set user modes when registering with the server. This
    /// parameter is a bitmask, with only 2 bits having any signification: if
    /// the bit 2 is set, the user mode 'w' will be set and if the bit 3 is
    /// set, the user mode 'i' will be set.
    /// 
    /// The realname may contain space characters.
    /// </summary>
    public partial class IrcCommand
    {
        public static string User(string username, string modeString, string realname)
        {
            return $"USER {username} {modeString} * :{realname}";
        }
    }
}
