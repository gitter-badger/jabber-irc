namespace JabberIRC.IRC
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
    public partial class ApiWrapper
    {
        public string Service()
        {
            return "";
        }
    }
}
