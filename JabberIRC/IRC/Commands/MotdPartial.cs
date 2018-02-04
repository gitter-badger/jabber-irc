namespace JabberIRC.IRC
{
    // Motd stands for Message of the Day
    public partial class IrcCommand
    {
        // Get the message of the day of the given server. If there is no target given it will return the MOTD of the current server
        public static string MessageOfTheDay(string target=null)
        {
            return $"MOTD{target ?? $" {target}"}";
        }
    }
}
