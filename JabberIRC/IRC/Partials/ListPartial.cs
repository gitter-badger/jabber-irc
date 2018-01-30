using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        /// <summary>
        /// List all channels
        /// </summary>
        public void List()
        {
            _writer.Write("LIST");
        }

        public void List(List<string> channels)
        {
            _writer.Write($"LIST {string.Join(",", channels)}");
        }
    }
}
