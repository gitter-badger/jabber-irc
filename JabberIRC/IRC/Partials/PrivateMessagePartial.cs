namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public void PrivateMessage(string target, string message)
        {
            _writer.WriteLine($"PRIVMSG {target} :{message}");
        }
    }
}
