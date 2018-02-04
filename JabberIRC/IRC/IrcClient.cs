using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using JabberIRC.IRC.Commands;

namespace JabberIRC.IRC
{
    class IrcClient
    {
        private readonly TcpClient _tcpClient;
        private readonly NetworkStream _stream;
        private readonly StreamWriter _writer;
        private readonly StreamReader _reader;
        private Thread _writeThread;
        private Thread _readThread;

        public IrcClient(string host="chat.freenode.net", int port=6667)
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

        private void Send(string command)
        {
            _writer.WriteLine(command);
        }

        public void ConnectToServer()
        {

        }

        public void JoinChannel(string channel, string nick, string realName, Action<string> callback)
        {
            _writeThread = new Thread(() =>
            {
                Send(IrcCommand.Nick(nick));
                Send(IrcCommand.User(nick, "0", realName));
                Send(IrcCommand.Join(channel));

                string response;
                while ((response = _reader.ReadLine()) != null)
                {
                    callback(response);
                }

            });
            _writeThread.Start();
        }

        public void SendMessage()
        {

        }
    }
}
