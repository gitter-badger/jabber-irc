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
        private readonly StreamWriter _writer;
        private readonly StreamReader _reader;
        private readonly ApiWrapper _api;
        private Thread _thread;
        IrcCommand command; 
        

        public IrcClient(string host = "chat.freenode.net", int port = 6667)
        {
            _tcpClient = new TcpClient(host, port);
            _stream = _tcpClient.GetStream();
            _writer = new StreamWriter(_stream) { NewLine = "\r\n", AutoFlush = true };
            _reader = new StreamReader(_stream);
        }

        ~IrcClient()
        {
            _reader.Close();
            _writer.Close();
            _stream.Close();
            _tcpClient.Close();
        }

        public void ConnectToServer()
        {

        }

        public void JoinChannel(string channel, string nick, string realName, Action<string> callback)
        {
            _thread = new Thread(() =>
            {
                /*
                _api.Nick(nick);
                _api.User(nick, UserMode.Default, realName);
                _api.Join(channel);
                string response;
                while ((response = _reader.ReadLine()) != null)
                {
                    callback(response);
                }
                */
            });
            _thread.Start();

        }

        public void SendMessage()
        {

        }
    }
}
