using System.Collections.Generic;

namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: nickname *( SPACE nickname )
    /// 
    /// The ISON command was implemented to provide a quick and efficient
    /// means to get a response about whether a given nickname was currently
    /// on IRC. ISON only takes one (1) type of parameter: a space-separated
    /// list of nicks. For each nickname in the list that is present, the
    /// server adds that to its reply string. Thus the reply string may
    /// return empty (none of the given nicks are present), an exact copy of
    /// the parameter string (all of them present) or any other subset of the 
    /// nikcs that may be checked is that the combined length MUST NOT be too
    /// large as to cause the server to chop it off so it fits in 512 caracters.
    /// 
    /// ISON is only processed by the server local to the client sending the
    /// command and thus not passed onto other servers for further processing.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Ison(string nickname)
        {
            return $"ISON {nickname}";
        }

        public static string Ison(List<string> nicknames)
        {
            return $"ISON {string.Join(" ", nicknames)}";
        }
    }
}
