namespace JabberIRC.IRC
{
    // Motd stands for Message of the Day
    public partial class ApiWrapper
    {
        // Get the message of the day of the given server. If there is no target given it will return the MOTD of the current server
        public void MessageOfTheDay(string target = null)
        {
            _writer.WriteLine($"MOTD{target ?? $" {target}"}");
        }
    }
}
