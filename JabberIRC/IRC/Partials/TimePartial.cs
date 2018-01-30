namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: [ target ]
    /// 
    /// The time command is used to query local time from the specified server. If the "target" parameter is
    /// not given, the server receiving the command must reply to the query
    /// 
    /// Wildcards are allowed in the "target" parameter
    /// </summary>
    public partial class ApiWrapper
    {
        public void Time(string target = null)
        {
            string space = target == null ? "" : " ";
            _writer.WriteLine($"TIME{space}{target}");
        }
    }
}
