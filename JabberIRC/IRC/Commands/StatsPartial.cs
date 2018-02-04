namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ query [ target ] ]
    /// 
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
    ///     m - returns the usage count for each of commands supported
    ///         by the server; commands for which the usage count is 
    ///         zero MAY be omitted
    ///     o - returns a list of configured privileged users,
    ///         operators
    ///     u - returns a string showing how long the server has been up
    /// It is also RECOMMANDED that client and server access configuration be published this way.
    /// </summary>

    public enum StatsQuery
    {
        ListOfConnections = 'l',
        UsageCount = 'm',
        Operators = 'o',
        UpTime = 'u'
    }

    public partial class IrcCommand
    {
        public static string Stats()
        {
            return "STATS";
        }

        public static string Stats(StatsQuery query)
        {
            return $"STATS {(char) query}";
        }

        public static string Stats(StatsQuery query, string target)
        {
            return $"STATS {(char) query} {target}";
        }
    }
}
