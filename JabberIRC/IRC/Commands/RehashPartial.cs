namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: None
    /// 
    /// The rehash command is an administrative command which can be used by
    /// an operator to force the server to re-read and process its
    /// configuration file.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Rehash()
        {
            return "REHASH";
        }
    }
}
