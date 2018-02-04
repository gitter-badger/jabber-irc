using JabberIRC.IRC.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class ConnectTests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            string targetServer = "tolsun.oulu.fi";
            int port = 6667;
            string remoteServer = "csd.bu.edu";

            string expected = "CONNECT tolsun.oulu.fi 6667";
            Assert.AreEqual(expected, IrcCommand.Connect(targetServer, port));

            expected = "CONNECT tolsun.oulu.fi 6667 csd.bu.edu";
            Assert.AreEqual(expected, IrcCommand.Connect(targetServer, port, remoteServer));
        }
    }
}