namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public void Kick(string channel, string user, string reason=null)
        {
            _writer.WriteLine(string.Format("KICK {0} {1}{2}", channel, user, reason == null ? "" : $" :{reason}"));
        }
    }
}
