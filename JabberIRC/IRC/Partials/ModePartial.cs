using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JabberIRC.IRC
{
    /// <summary>
    /// Channel modes, source: https://tools.ietf.org/html/rfc2811
    /// </summary>
    public enum ChannelMode
    {
        Creator = 'O',
        Operator = 'o',
        Voice = 'v',
        Anonymous = 'a',
        InviteOnly = 'i',
        Moderated = 'm',
        NoMessages = 'n', // toggle the no messages to channel from clients on the outside
        Quiet = 'q',
        Private = 'p',
        Secret = 's',
        ServerReop = 'r',
        TopicSettable = 't',
        Key = 'k',
        UserLimit = 'l',
        BanMask = 'b',
        ExceptionMask = 'e', // overrides a ban mask
        InvitationMask = 'I' // overrides the invite-only flag
    }

    public enum ChannelAction
    {
        Add = '+',
        Remove = '-'
    }


    public partial class ApiWrapper
    {
        public void Mode(string channel, ChannelMode mode, ChannelAction? action = null)
        {
            string command = $"MODE {channel} {action.ToString()??""}{mode}";
            _writer.WriteLine(command);
        }

        public void Mode(string channel, List<ChannelMode> modes, ChannelAction? action = null, string modeParams=null)
        {
            string param = modeParams != null ? $" {modeParams}" : "";
            string modeNames = string.Join("", modes.Select(mode => mode.ToString() ?? ""));
            string command = $"MODE {channel} {action.ToString()??""}{modeNames}{param}";
            _writer.WriteLine(command);
        }
    }
}
