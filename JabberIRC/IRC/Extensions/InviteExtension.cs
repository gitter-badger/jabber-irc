using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC.Extensions
{
    public static class InviteExtension
    {
        public static void Invite(this ApiWrapper apiWrapper, string nickname, string channel, StreamWriter writer)
        {
            writer.WriteLine($"INVITE {nickname} {channel}");
        }
    }
}
