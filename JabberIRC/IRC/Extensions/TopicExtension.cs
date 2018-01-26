using System.IO;

namespace JabberIRC.IRC.Extensions
{
    public static class TopicExtension
    {
        public static void Topic(this ApiWrapper apiWrapper, string channel, StreamWriter writer, string topic=null)
        {
            writer.WriteLine($"TOPIC {channel} {topic}");
        }

        public static void ClearTopic(this ApiWrapper apiWrapper, string channel, StreamWriter writer)
        {
            writer.WriteLine($"TOPIC {channel} :");
        }

        public static void GetTopic(this ApiWrapper apiWrapper, string channel, StreamWriter writer)
        {
            writer.WriteLine($"TOPIC {channel}");
        }
    }
}
