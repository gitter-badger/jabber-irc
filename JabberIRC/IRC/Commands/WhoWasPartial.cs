using System.Collections.Generic;

namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: nickname *( "," nickname ) [ count [ target ] ]
    /// 
    /// Whowas asks for information about a nickname which no longer exists.
    /// This may either be due to a nickname change or the user leaving IRC.
    /// In response to this query, the server searches through its nickname
    /// history, looking for any nicks which are lexically the same (no wild
    /// card matching here). This history is searched backward, returning the
    /// most recent entry first. If there are multiple entries, up to 
    /// "count" replies will be returned (or all of them if no "count"
    /// parameter is given). If a non-positive number is passed as being 
    /// "count", then a full search is done.
    /// 
    /// Wildcards are allowed in the "target" parameter
    /// </summary>
    public partial class IrcCommand
    {
        public static string WhoWas(string nickname)
        {
            return $"WHOWAS {nickname}";
        }

        public static string WhoWas(List<string> nicknames)
        {
            return $"WHOWAS {string.Join(",", nicknames)}";
        }

        public static string WhoWas(string nickname, int count)
        {
            return $"WHOWAS {nickname} {count}";
        }

        public static string WhoWas(List<string> nicknames, int count)
        {
            return $"WHOWAS {string.Join(",", nicknames)} {count}";
        }

        public static string WhoWas(string nickname, int count, string target)
        {
            return $"WHOWAS {nickname} {count} {target}";
        }

        public static string WhoWas(List<string> nicknames, int count, string target)
        {
            return $"WHOWAS {string.Join(",", nicknames)} {count} {target}";
        }
    }
}
