using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: "target server" "port" [ remote server ]
    /// 
    /// The CONNECT command can be used to request a server to try to establish a new connection
    /// to another server immediately. CONNECT is a privileged command and SHOULD be available only
    /// to IRC operators. If a "remote server" is given and its mask doesn't match name of the parsing
    /// server, the CONNECT attempt is sent to the first match of remote server. Otherwise the 
    /// CONNECT attempt is made by the server processing the request
    /// 
    /// The server receiving a remote CONNECT command SHOULD generate a WALLOPS message describing the
    /// source and target of the request.
    /// </summary>
    public partial class ApiWrapper
    {
        public string Connect(string server, string port, string remoteServer=null)
        {
            string space = remoteServer == null ? "" : " ";
            return $"CONNECT {server} {port}{space}{remoteServer}";
        }
    }
}