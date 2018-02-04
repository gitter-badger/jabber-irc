namespace JabberIRC.IRC
{
    public partial class IrcCommand
    {
        public static string Kick(string channel, string user, string reason=null)
        {
            return $"KICK {channel} {user}{(reason == null ? "" : $" :{reason}")}";
        }
    }
}
