using System.IO;
using System.Net.Sockets;

namespace JabberIRC.IRC
{
    public partial class ApiWrapper
    {
        private readonly StreamWriter _writer;
        private readonly StreamReader _reader;

        public ApiWrapper(StreamWriter writer, StreamReader reader)
        {
            _writer = writer;
            _reader = reader;
        }

    }
}
