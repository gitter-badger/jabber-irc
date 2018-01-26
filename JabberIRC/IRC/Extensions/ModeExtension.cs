using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JabberIRC.IRC.Extensions
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


    public static class ModeExtension
    {
        public static void Mode(this ApiWrapper apiWrapper, string channel, ChannelMode mode, StreamWriter writer, ChannelAction? action = null)
        {
            string command = $"MODE {action.ToString()??""}{channel} {mode}";
            writer.WriteLine(command);
        }

        public static void Mode(this ApiWrapper apiWrapper, string channel, List<ChannelMode> modes, StreamWriter writer, ChannelAction? action = null, string modeParams=null)
        {
            string param = modeParams != null ? $" {modeParams}" : "";
            string modeNames = string.Join("", modes.Select(mode => mode.ToString() ?? ""));
            string command = $"MODE {action.ToString()??""}{channel} {modeNames}{param}";
            writer.WriteLine(command);
        }
    }
}
