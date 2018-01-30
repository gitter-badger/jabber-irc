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
        public void Invite(string nickname, string channel)
        {
            _writer.WriteLine($"INVITE {nickname} {channel}");
        }
    }
}
