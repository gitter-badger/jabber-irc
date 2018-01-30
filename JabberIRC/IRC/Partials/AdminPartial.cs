using System.IO;
using System.Runtime.CompilerServices;
using System.Linq;

namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: [ target ]
    /// 
    /// The admin command is used to find information about the adminisrator of the given server,
    /// or current server if "target" parameter is omitted. Each server MUST have the ability to 
    /// forward ADMIN messages to other servers
    /// 
    /// Wildcards are allowed in the "target" parameter
    /// </summary>
    public partial class ApiWrapper
    {
        public void Admin(string target=null)
        {
            string space = target == null ? "" : " ";
            _writer.WriteLine($"ADMIN{space}{target}");
        }
    }
}
