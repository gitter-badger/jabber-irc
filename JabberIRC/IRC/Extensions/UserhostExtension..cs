using System.Collections.Generic;
using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: nickname *( SPACE nickname )
    /// 
    /// The USERHOST command takes a list of up to 5 nicknames, each
    /// separated by a space character and returns a list of information
    /// about each nickname that it found. The returned list has each reply
    /// separated by a space.
    /// </summary>
    public static class UserhostExtension
    {
        public static void Userhost(this ApiWrapper apiWrapper, StreamWriter writer, string nickname)
        {
            writer.WriteLine($"USERHOST {nickname}");
        }

        public static void Userhost(this ApiWrapper apiWrapper, StreamWriter writer, List<string> nicknames)
        {
            writer.WriteLine($"USEHOST {string.Join(" ", nicknames)}");
        }
    }
}
