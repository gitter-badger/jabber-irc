namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public string Notice(string target, string message)
        {
            return $"NOTICE {target} :{message}";
        }
    }
}
