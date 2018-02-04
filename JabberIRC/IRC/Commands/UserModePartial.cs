namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: nickname
    ///             *( ( "+" / "-" ) *( "i" / "w" / "o" / "O" / "r" ) )
    /// The user MODE's are typically changes changes which affect either how the
    /// client is seen by others or what 'extra' messages the client is sent.
    /// 
    /// A user MODE command MUST only be accepted if both the sender of the
    /// message and the nickname given as a parameter are both the same. If
    /// no other parameter is given, then the server will return the current 
    /// settings for the nick
    /// </summary>
    public partial class IrcCommand
    {
        public static string UserMode(string nickname, string modeString)
        {
            return $"MODE {nickname} {modeString}";
        }
    }
}
