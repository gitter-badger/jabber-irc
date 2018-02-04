namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: "error message"
    /// 
    /// The ERROR command is for use by servers when reporting a serious or
    /// fatal error to its peers. It may also be sent from one server to 
    /// another but MUST NOT be accepted from any normal unknown clients.
    /// 
    /// Only an Error message SHOULD be used for reporting errors which occur
    /// with a server-to-server link. An ERROR message it sent to the server
    /// at the other end (which reports it to apporpriate local users and 
    /// logs) and to appropriate local users and logs. It is not to be
    /// passed onto any other servers by a server if it is received from a
    /// server.
    /// 
    /// The Error message is also used before terminating a client
    /// connection.
    /// 
    /// When a server sends a received ERROR message to its operators, the
    /// message SHOULD be encapsulated inside a NOTICE message, indicating
    /// that the client was not responsible for the error.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Error(string message)
        {
            return $"ERROR :{message}";
        }
    }
}
