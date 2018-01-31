namespace JabberIRC.IRC
{
    /// <summary>
    /// The STATS command is used to query statistics of certain server. If "query" parameter is omitted,
    /// only the end of stats reply is sent back.
    ///
    /// A query may be given for any single letter which is only checked by the destination server and is
    /// otherwise passed on by intermediate servers, ignored and unaltered
    /// 
    /// Whildcards are allowed in the "target" parameter
    ///
    /// Except for the ones below, the list of valid queries is implementation dependent. The standard
    /// queries below SHOULD be supported by the server:
    ///     l - returns a list of the server's connections, showing how long each connection has been
    ///         established and the traffic over that connection in Kbytes and messages for each direction
    /// </summary>
    public partial class ApiWrapper
    {
        public string Stats(string query=null, string target=null)
        {
            string space = query == null ? "" : " ";
            return $"STATS{space}{query}{space}{target}";
        }
    }
}
