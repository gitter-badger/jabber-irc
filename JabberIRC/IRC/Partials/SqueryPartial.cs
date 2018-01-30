namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: servicename text
    /// 
    /// The SQUERY command is used similarly to PRIVMSG. The only difference is that the recipient MUST be
    /// a service. This is the only way for a text message to be delivered to a service.
    /// </summary>
    public partial class ApiWrapper
    {
        public void Squery(string serviceName, string text)
        {
            _writer.WriteLine($"SQUERY {serviceName} :{text}");
        }
    }
}
