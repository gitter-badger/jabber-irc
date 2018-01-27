using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: [ target ]
    /// 
    /// The time command is used to query local time from the specified server. If the "target" parameter is
    /// not given, the server receiving the command must reply to the query
    /// 
    /// Wildcards are allowed in the "target" parameter
    /// </summary>
    public static class TimeExtension
    {
        public static void Time(this ApiWrapper apiWrapper, StreamWriter writer, string target=null)
        {
            string space = target == null ? "" : " ";
            writer.WriteLine($"TIME{space}{target}");

        }
    }
}
