namespace JabberIRC.IRC
{
    /// a - user is flagged as away;
    /// i - marks a users as invisible;
    /// w - user receives wallops;
    /// r - restricted user connection;
    /// o - operator flag;
    /// O - local operator flag;
    /// s - marks a user for receipt of server notices
    public enum UserMode
    {
        Default = 0, // No meaning
        Away = 'a',
        Invisible = 'i',
        Wallops = 'w',
        Restricited = 'r',
        Operator = 'o',
        LocalOperator = 'O',
        ServerReceipt = 's'
    }

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
    public partial class ApiWrapper
    {
        public string User(string username, UserMode mode, string realname)
        {
            return $"USER {username} {mode} * :{realname}";
        }
    }
}
