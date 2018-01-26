using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC.Extensions
{
    public static class ListExtension
    {
        /// <summary>
        /// List all channels
        /// </summary>
        public static void List(this ApiWrapper apiWrapper, StreamWriter writer)
        {
            writer.Write("LIST");
        }

        public static void List(this ApiWrapper apiWrapper, List<string> channels, StreamWriter writer)
        {
            writer.Write($"LIST {string.Join(",", channels)}");
        }
    }
}
