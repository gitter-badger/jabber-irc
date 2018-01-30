namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public void Notice(string target, string message)
        {
            _writer.WriteLine($"NOTICE {target} :{message}");
        }
    }
}
