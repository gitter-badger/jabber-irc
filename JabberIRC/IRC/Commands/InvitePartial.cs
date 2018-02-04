namespace JabberIRC.IRC
{
    public partial class IrcCommand
    {
        public static string Invite(string nickname, string channel)
        {
            return $"INVITE {nickname} {channel}";
        }
    }
}
