namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: password
    /// 
    /// The PASS command is used to set a 'connection password'. The
    /// optional password can and MUST be set before any attempt to register
    /// the conenction is made. Currently this requires that user send a
    /// PASS command before sending the NICK/USER combination.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Pass(string password)
        {
            return $"PASS {password}";
        }
    }
}
