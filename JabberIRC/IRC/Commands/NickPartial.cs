namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: nickname
    /// 
    /// NICK command is used to give user a nickname or change the existing
    /// one.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Nick(string nickname)
        {
            return $"NICK {nickname}";
        }
    }
}
