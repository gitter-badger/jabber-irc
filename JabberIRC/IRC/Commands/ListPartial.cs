using System.Collections.Generic;

namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        /// <summary>
        /// List all channels
        /// </summary>
        public string List()
        {
            return "LIST";
        }

        public string List(List<string> channels)
        {
            return $"LIST {string.Join(",", channels)}";
        }
    }
}
