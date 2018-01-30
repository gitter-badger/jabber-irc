namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: nickname *( "," nickname ) [ count [ target ] ]
    /// 
    /// Whowas asks for information about a nickname which no longer exists.
    /// This may either be due to a nickname change or the user leaving IRC.
    /// In response to this query, the server searches through its nickname
    /// history, looking for any nicks which are lexically the same (no wild
    /// card matching here). This history is searched backward, returning the
    /// most recent entry first. If there are multiple entries, up to 
    /// "count" replies will be returned (or all of them if no "count"
    /// parameter is given). If a non-positive number is passed as being 
    /// "count", then a full search is done.
    /// 
    /// Wildcards are allowed in the "target" parameter
    /// </summary>
    public partial class ApiWrapper
    {
        public void WhoWas(string nickname, int? count=null, string target=null)
        {
            string countSpace = count == null ? "" : " ";
            string targetSpace = target == null ? "" : " ";
            _writer.WriteLine($"WHOWAS {nickname}{countSpace}{count}{targetSpace}{target}");
        }
    }
}
