namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: servicename text
    /// 
    /// The SQUERY command is used similarly to PRIVMSG. The only difference is that the recipient MUST be
    /// a service. This is the only way for a text message to be delivered to a service.
    /// 
    /// See PRIVMSG for more details on replies and example.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Squery(string serviceName, string text)
        {
            return $"SQUERY {serviceName} :{text}";
        }
    }
}
