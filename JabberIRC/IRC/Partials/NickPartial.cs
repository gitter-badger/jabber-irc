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
        public void Nick(string nickname)
        {
            _writer.WriteLine($"NICK {nickname}");
        }
    }
}
