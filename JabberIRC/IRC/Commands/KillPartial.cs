namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: nickname comment
    /// 
    /// The KILL command is used to cause a client-server connection to be
    /// closed by the server which has the actual connection. Servers
    /// generate KILL messages on nickname collisions. It MAY also be
    /// available to users who have the operator status.
    /// 
    /// Clients which have automatic reconnect algorithms effectively make
    /// this command useless since the disconnection is only brief. It does
    /// however break the flow of data and can be used to stop large amounts
    /// of 'flooding' from absive users or accidents. Abusive users usally 
    /// don't care as they will reconnect promptly and resume their abusive
    /// behaviour. To prevent this command from being abused, any user may
    /// elect to receive KILL messages generated for others to keep an 'eye'
    /// on would be trouble spots.
    /// 
    /// In an arena where nicknames are REQUIRED to be globally unique at all
    /// times, KILL messages are sent whenever 'duplicates' are deteced
    /// (that is an attempt to register two users with the same nickname) in
    /// the hope that both of them will disappear and only 1 appear.
    /// 
    /// When a client is removed as the result of a KILL message, the server 
    /// SHOULD add the nickname to the list of unavailable nicknames in an
    /// attempt to avoid clients to reuse this name immediately which is 
    /// usually the parttern of abusive behaviour often leading to useless
    /// "KILL loops".
    /// 
    /// The command give MUST reflect the actual reason for the KILL. For
    /// server-generated KILLs it usually is made up of details concerning 
    /// the origins of the two conflicting nicknames. For users it is left
    /// up to them to provide an adequate reason t satisfy others who see
    /// it. To prevent/disourage fake KILLs from being generated to hide
    /// the identify of the KILLer, the comment also shows a 'kill-path'
    /// which is updated by each server it passes through, each prepending
    /// its name to the path.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Kill(string nickname, string comment)
        {
            return $"KILL {nickname} {comment}";
        }
    }
}
