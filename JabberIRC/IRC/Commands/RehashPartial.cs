namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: None
    /// 
    /// The rehash command is an administrative command which can be used by
    /// an operator to force the server to re-read and process its
    /// configuration file.
    /// </summary>
    public partial class ApiWrapper
    {
        public string Rehash()
        {
            return "REHASH";
        }
    }
}
