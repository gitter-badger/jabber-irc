namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ target ]
    /// 
    /// The MOTD command is used to get the "Message of the Day" of the given
    /// server, or current server if "target" is omitted.
    /// 
    /// Wildcards are allowed in the "target" parameter.
    /// </summary>
    public partial class IrcCommand
    {
        // Get the message of the day of the given server. If there is no target given it will return the MOTD of the current server
        public static string MessageOfTheDay()
        {
            return "MOTD";
        }

        public static string MessageOfTheDay(string target)
        {
            return $"MOTD {target}";
        }
    }
}
