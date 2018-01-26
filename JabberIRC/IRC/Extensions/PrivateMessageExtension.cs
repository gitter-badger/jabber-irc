using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC.Extensions
{
    public static class PrivateMessageExtension
    {
        public static void PrivateMessage(this ApiWrapper apiWrapper, string target, string message, StreamWriter writer)
        {
            writer.WriteLine($"PRIVMSG {target} :{message}");
        }
    }
}
