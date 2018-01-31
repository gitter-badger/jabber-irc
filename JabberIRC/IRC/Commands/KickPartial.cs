namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public string Kick(string channel, string user, string reason=null)
        {
            return string.Format("KICK {0} {1}{2}", channel, user, reason == null ? "" : $" :{reason}");
        }
    }
}
