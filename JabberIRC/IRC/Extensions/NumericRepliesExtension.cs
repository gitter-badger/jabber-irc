using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC.Extensions
{
    public static class NumericRepliesExtension
    {
        public enum NumericReply
        {
            [Description("Welcome to the Internet Reply network" +
                         "<nick>!<user>@<host>")]
            RPL_WELCOME = 001, 
            [Description("Your host is <servername>, running version <ver>")]
            RPL_YOURHOST = 002,
            [Description("This server was created <date>")]
            RPL_CREATED = 003,
            [Description("<servername> <version> <available user mode>" +
                         "<available channel modes")]
            RPL_MYINFO = 004,
            [Description("Try server <server name>, port <port number>")]
            RPL_BOUNCE = 005,
            RPL_USERHOST = 302, // :*1<reply> *( " " <reply> )
            RPL_ISON = 303,
            [Description("<nick> :<away message>")]
            RPL_AWAY = 301,
            [Description(":You are no longer marked as being away")]
            RPL_UNAWAY = 305,
            [Description(":You have been marked as being away")]
            RPL_NOWAWAY = 306,
            [Description("<nick> <user> <host> * :<real name>")]
            RPL_WHOISUSER = 311,
            [Description("<nick> <server> :<server nfo>")]
            RPL_WHOISSERVER = 312,
            [Description("<nick> :is an IRC operator")]
            RPL_WHOISOPERATOR = 313,
            [Description("<nick> <integer> :seconds idle")]
            RPL_WHOISIDLE = 317,
            [Description("<nick> :End of WHOIS list")]
            RPL_ENDOFWHOIS = 318,
            RPL_WHOISCHANNELS = 319, // "<nick> :*( ( "@" / "+" ) <channel> " " )"
        }
    }
}
