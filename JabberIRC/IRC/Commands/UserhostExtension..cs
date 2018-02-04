using System.Collections.Generic;

namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: nickname *( SPACE nickname )
    /// 
    /// The USERHOST command takes a list of up to 5 nicknames, each
    /// separated by a space character and returns a list of information
    /// about each nickname that it found. The returned list has each reply
    /// separated by a space.
    /// </summary>
    public partial class IrcCommand
    {
        public static string UserHost(string nickname)
        {
            return $"USERHOST {nickname}";
        }

        public static string UserHost(List<string> nicknames)
        {
            return $"USERHOST {string.Join(" ", nicknames)}";
        }
    }
}
