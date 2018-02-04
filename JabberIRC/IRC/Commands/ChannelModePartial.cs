using System.Collections.Generic;

namespace JabberIRC.IRC.Commands
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


    public partial class IrcCommand
    {
        public static string ChannelMode(string channel, ChannelMode mode)
        {
            return $"MODE {channel} {(char)mode}";
        }

        public static string ChannelMode(string channel, ChannelMode mode, ChannelAction action)
        {
            string actionName = $"{(char)action}";
            string modeName = $"{(char)mode}";
            string command = $"MODE {channel} {actionName}{modeName}";
            return command;
        }

        public static string ChannelMode(string channel, ChannelMode mode, ChannelAction action, string modeParam)
        {
            string param = $" {modeParam}";
            string actionName = $"{(char)action}";
            string modeName = $"{(char)mode}";
            string command = $"MODE {channel} {actionName}{modeName}{param}";
            return command;
        }

        public static string ChannelMode(string channel, ChannelMode mode, ChannelAction action, List<string> modeParams)
        {
            string param = $" {string.Join(" ", modeParams)}";
            string actionName = $"{(char)action}";
            string modeName = $"{(char)mode}";
            string command = $"MODE {channel} {actionName}{modeName}{param}";
            return command;
        }

        public static string ChannelMode(string channel, string modeString, string modeParam)
        {
            string param = $" {modeParam}";
            string command = $"MODE {channel} {modeString}{param}";
            return command;
        }

        public static string ChannelMode(string channel, string modeString)
        {
            string command = $"MODE {channel} {modeString}";
            return command;
        }

        public static string ChannelMode(string channel, string modeString, List<string> modeParams)
        {
            string param = $" {string.Join(" ", modeParams)}";
            string command = $"MODE {channel} {modeString}{param}";
            return command;
        }
    }
}
