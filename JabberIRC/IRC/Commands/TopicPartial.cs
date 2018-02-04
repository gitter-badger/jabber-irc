namespace JabberIRC.IRC.Commands
{
    /// <summary>
    /// Parameters: channel [ topic ]
    /// 
    /// The TOPIC command is used to change or view the topic of a channel.
    /// The topic for channel "channel" is returned if there is no "topic"
    /// given. If the "topic" parameter is present, the topic for that 
    /// channel will be changed, if this action is allowed for the user
    /// requesting it. If the "topic" parameter is an empty string, the
    /// topic for that channel will be removed.
    /// </summary>
    public partial class IrcCommand
    {
        public static string Topic(string channel, string topic=null)
        {
            return $"TOPIC {channel} :{topic}";
        }

        public static string ClearTopic(string channel)
        {
            return $"TOPIC {channel} :";
        }

        public static string GetTopic(string channel)
        {
            return $"TOPIC {channel}";
        }
    }
}
