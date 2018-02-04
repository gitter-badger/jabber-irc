namespace JabberIRC.IRC
{
    public partial class IrcCommand
    {
        public static string PrivateMessage(string target, string message)
        {
            return $"PRIVMSG {target} :{message}";
        }
    }
}
