namespace JabberIRC.IRC
{
    /// <summary>
    /// Parameters: nickname
    /// 
    /// NICK command is used to give user a nickname or change the existing
    /// one.
    /// </summary>
    public partial class ApiWrapper
    {
        public string Nick(string nickname)
        {
            return $"NICK {nickname}";
        }
    }
}
