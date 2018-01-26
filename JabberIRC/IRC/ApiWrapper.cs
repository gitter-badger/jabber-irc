using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC
{
    public class ApiWrapper
    {
        public ApiWrapper()
        {

        }

        /// <summary>
        /// Leave a given channel
        /// </summary>
        public void Part(string channel, StreamWriter writer)
        {
            writer.WriteLine("PART {0}", channel);
        }

        /// <summary>
        /// Leave multiple channels
        /// </summary>
        /// <param name="channels"></param>
        /// <param name="writer"></param>
        public void Part(List<string> channels, StreamWriter writer)
        {
            writer.WriteLine("PART {0}", string.Join(",", channels.ToArray()));
        }

        /// <summary>
        /// Leave all joined channels
        /// </summary>
        public void PartAll(StreamWriter writer)
        {
            writer.WriteLine("PART 0");
        }

        /// <summary>
        /// Set channel mode
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="mode"></param>
        /// <param name="modeParams"></param>
        public void ChannelMode(string channel, string mode, string modeParams, StreamWriter writer)
        {
            writer.WriteLine("MODE {0} {1} {2}", channel, mode, modeParams);
        }

        public void SetTopicMessage(string channel, string topic, StreamWriter writer)
        {
            writer.WriteLine("TOPIC {0} :{1}", channel, topic);
        }

        public void ClearTopicMessage(string channel, StreamWriter writer)
        {
            writer.WriteLine("TOPIC {0} :", channel);
        }

        public void CheckTopicMessage(string channel, StreamWriter writer)
        {
            writer.WriteLine("TOPIC {0}", channel);
        }

    }
}
