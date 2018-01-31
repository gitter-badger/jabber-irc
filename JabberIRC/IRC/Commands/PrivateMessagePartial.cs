namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public string PrivateMessage(string target, string message)
        {
            return $"PRIVMSG {target} :{message}";
        }
    }
}
