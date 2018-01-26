using System;
using System.IO;
using System.Net.Sockets;

namespace JabberIRC.IRC
{
    class IrcClient
    {
        private string host;
        private int port;
        private TcpClient tcpClient;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private ApiWrapper api;


        public IrcClient(string host="chat.freenode.net", int port=6667)
        {
            this.host = host;
            this.port = port;

            tcpClient = new TcpClient(host, port);
            stream = tcpClient.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream) {NewLine = "\r\n", AutoFlush = true};

            ApiWrapper api = new ApiWrapper();
        } 

        public void ConnectToServer()
        {

        }

        public void JoinChannel(string channel)
        {
            api.Join(channel, "nick", "real name", reader, writer);
        }

        public void SendMessage()
        {

        }
    }
}
