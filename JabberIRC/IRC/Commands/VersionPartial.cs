namespace JabberIRC.IRC
{
    /// <summary>
    /// The version command is used to query the version of the server program. An optional
    /// parameter "target" is used to query the version of the server program which a client
    /// is not directly connected to
    /// </summary>
    public partial class ApiWrapper
    {
        public string Version(string target=null)
        {
            string space = target == null ? "" : " ";
            return $"Version{space}{target ?? ""}";
        }
    }
}
