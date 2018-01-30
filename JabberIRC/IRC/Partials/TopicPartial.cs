namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public void Topic(string channel, string topic=null)
        {
            _writer.WriteLine($"TOPIC {channel} {topic}");
        }

        public void ClearTopic(string channel)
        {
            _writer.WriteLine($"TOPIC {channel} :");
        }

        public void GetTopic(string channel)
        {
            _writer.WriteLine($"TOPIC {channel}");
        }
    }
}
