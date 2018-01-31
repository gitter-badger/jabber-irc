namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        public string Topic(string channel, string topic=null)
        {
            return $"TOPIC {channel} {topic}";
        }

        public string ClearTopic(string channel)
        {
            return $"TOPIC {channel} :";
        }

        public string GetTopic(string channel)
        {
            return $"TOPIC {channel}";
        }
    }
}
