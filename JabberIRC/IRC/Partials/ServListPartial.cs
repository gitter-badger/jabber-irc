namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: [ mask [ type ] ]
    /// 
    /// The SERVLIST command is used to list services currently connected to the network and visible to
    /// the user issuing the command. The optional parameters may be used to restrict the result of the
    /// query (to matching services names, and services type).
    /// </summary>
    public partial class ApiWrapper
    {
        public void ServList(string mask=null, string type=null)
        {
            string space = mask == null ? "" : " ";
            _writer.WriteLine($"SERVLIST{space}{mask}{space}{type}");
        }
    }
}
