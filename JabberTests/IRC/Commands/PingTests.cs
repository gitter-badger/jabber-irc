using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class PingTests
    {
        [TestMethod()]
        public void PingTest()
        {
            Assert.AreEqual("PING tolsun.oulu.fi", IrcCommand.Ping("tolsun.oulu.fi"));
            Assert.AreEqual("PING WiZ tolsun.oulu.fi", IrcCommand.Ping("WiZ", "tolsun.oulu.fi"));
        }
    }
}