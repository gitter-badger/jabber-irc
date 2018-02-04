namespace JabberIRC.IRC
{
    public partial class IrcCommand
    {
        public static string Notice(string target, string message)
        {
            return $"NOTICE {target} :{message}";
        }
    }
}
