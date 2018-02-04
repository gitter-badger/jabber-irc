namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: nickname channel
    /// 
    /// The INVITE command is used to invite a user to a channel. The
    /// parameter "nickname" is the nickname of the person to be invited to
    /// the target channel "channel". There is no requirements that the
    /// channel the target user is being invited to must exist or be a valid
    /// channel. However, if the channel exists, only members of the channel
    /// are allowed to invite other users. When the channel has invite-only
    /// flag set, only channel operators may issue INVITE command.
    /// 
    /// Only the user inviting and the user being invited will receive
    /// notification of the invitation. Other channel members are not
    /// notified. (This is unlike the MODE changes, and is occasionally the
    /// source of trouble for users.)
    /// </summary>
    public partial class IrcCommand
    {
        public static string Invite(string nickname, string channel)
        {
            return $"INVITE {nickname} {channel}";
        }
    }
}
