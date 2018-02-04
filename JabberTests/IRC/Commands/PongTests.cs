using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class PongTests
    {
        [TestMethod()]
        public void PongTest()
        {
            Assert.AreEqual("PONG csd.bu.edu", IrcCommand.Pong("csd.bu.edu"));
            Assert.AreEqual("PONG csd.bu.edu tolsun.oulu.fi", IrcCommand.Pong("csd.bu.edu", "tolsun.oulu.fi"));
        }
    }
}