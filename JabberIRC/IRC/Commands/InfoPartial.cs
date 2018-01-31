using System.IO;

namespace JabberIRC.IRC
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
    public partial class ApiWrapper
    {
        public string Info(string target=null)
        {
            string space = target == null ? "" : " ";
            return $"INFO{space}{target}";
        }
    }
}
