namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ "Quit message" ]
    /// 
    /// A client session is terminated with a quit message. The server 
    /// acknowledges this by sending an ERROR message to the client.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Quit(string message = null)
        {
            string space = message == null ? "" : " :";
            return $"QUIT{space}{message}";
        }
    }
}
