namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: [ "Quit message" ]
    /// 
    /// A client session is terminated with a quit message. The server 
    /// acknowledges this by sending an ERROR message to the client.
    /// </summary>
    public partial class ApiWrapper
    {
        public string Quit(string message = null)
        {
            string space = message == null ? "" : " :";
            return $"QUIT{space}{message}";
        }
    }
}
