namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: msgtarget "text to be sent"
    /// 
    /// PRIVMSG is used to send private messages between users, as well as to
    /// send messages to channels. "msgtarget" is actually the nickname of 
    /// the recipient of the message, or a channel name.
    /// 
    /// The "msgtarget" parameter may also be a host mask (#mask) or server
    /// mask ($mask). In both cases the server will only send the PRIVMSG
    /// to those who have a server or host matching the mask. The mask MUST
    /// have at least 1 (one) "." in it and no wildcards following the last
    /// ".". This requirement exists to prevent people sending messages to
    /// "#*" or "$*", which would broadcast to all users. Wildcards are the
    /// '*' and '?' characters. This extension to the PRIVMSG command is 
    /// only available to operators.
    /// </summary>
    public partial class IrcCommand
    {
        public static string PrivateMessage(string target, string message)
        {
            return $"PRIVMSG {target} :{message}";
        }
    }
}
