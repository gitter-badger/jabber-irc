using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC.Extensions
{
    // Motd stands for Message of the Day
    public static class MotdExtension
    {
        // Get the message of the day of the given server. If there is no target given it will return the MOTD of the current server
        public static void MessageOfTheDay(this ApiWrapper apiWrapper, string target=null, StreamWriter writer)
        {
            writer.WriteLine($"MOTD{target ?? $" {target}"}");
        } 
    }
}
