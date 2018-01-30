namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: password
    /// 
    /// The PASS command is used to set a 'connection password'. The
    /// optional password can and MUST be set before any attempt to register
    /// the conenction is made. Currently this requires that user send a
    /// PASS command before sending the NICK/USER combination.
    /// </summary>
    public partial class ApiWrapper
    {
        public void Pass(string password)
        {
            _writer.WriteLine($"PASS {password}");
        }
    }
}
