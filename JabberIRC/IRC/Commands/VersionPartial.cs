namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: [ target ]
    /// 
    /// The version command is used to query the version of the server program. An optional
    /// parameter "target" is used to query the version of the server program which a client
    /// is not directly connected to
    /// </summary>
    public partial class IrcCommand
    {
        public static string Version(string target=null)
        {
            string space = target == null ? "" : " ";
            return $"VERSION{space}{target ?? ""}";
        }
    }
}
