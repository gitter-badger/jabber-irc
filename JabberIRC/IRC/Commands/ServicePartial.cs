namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: nickname reserved distribution type reserved info
    /// 
    /// The SERVICE command to register a new service. Command parameters
    /// specify the service nickname, distribution, type and info of a new 
    /// service.
    /// 
    /// The distribution parameter is used to specify the visibility of a 
    /// service. The service may only be known to servers which have a name 
    /// matching the distribution. For a matching server to have knowledge
    /// of the service, the network path between that server and the server
    /// on which the service is connected MUST be composed of servers which 
    /// names all match the mask.
    /// 
    /// The type parameter is currently reserved for future usage.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Service(string serviceName, string distribution,  string info, int? type=0, string reservedParam1="*", int? reservedParam2=0)
        {
            return $"SERVICE {serviceName} {reservedParam1} {distribution} {type} {reservedParam2} :{info}";
        }
    }
}
