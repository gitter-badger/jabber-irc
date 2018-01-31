namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public string Invite(string nickname, string channel)
        {
            return $"INVITE {nickname} {channel}";
        }
    }
}
