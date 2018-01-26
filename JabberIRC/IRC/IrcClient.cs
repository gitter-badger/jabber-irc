using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace JabberIRC.IRC
{
    class IrcClient
    {
        private readonly TcpClient _tcpClient;
        private readonly NetworkStream _stream;
        private readonly StreamReader _reader;
        private readonly StreamWriter _writer;
        private readonly ApiWrapper _api;
        private Thread _thread;

        /// <summary>
        /// Init 
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        public IrcClient(string host = "chat.freenode.net", int port = 6667)
        {
            _tcpClient = new TcpClient(host, port);
            _stream = _tcpClient.GetStream();
            _reader = new StreamReader(_stream);
            _writer = new StreamWriter(_stream) { NewLine = "\r\n", AutoFlush = true };
            _api = new ApiWrapper();
        }

        /// <summary>
        /// Release connections
        /// </summary>
        ~IrcClient()
        {
            _reader.Close();
            _writer.Close();
            _stream.Close();
            _tcpClient.Close();
            _thread.Abort();
        }

        public void ConnectToServer()
        {

        }

        public void JoinChannel(string channel, string nick, string realName, Action<string> callback)
        {
            _thread = new Thread(() =>
            {
                _api.Join(channel, nick, realName, _reader, _writer);
                string response;
                while ((response = _reader.ReadLine()) != null)
                {
                    callback(response);
                }

            });
            _thread.Start();

        }

        public void SendMessage()
        {

        }
    }
}
