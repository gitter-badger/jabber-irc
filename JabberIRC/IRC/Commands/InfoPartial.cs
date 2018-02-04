namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters [ target ]
    /// 
    /// The INFO command is REQUIRED to return information describing the server: its version, when it was
    /// compiled, the patchlevel, when it was started, and any other miscellaneous information which may be 
    /// considred to be relevant.
    /// 
    /// Wildcards are allowed in the "target" parameter
    /// </summary>
    public partial class IrcCommand
    {
        public static string Info(string target=null)
        {
            string space = target == null ? "" : " ";
            return $"INFO{space}{target}";
        }
    }
}
