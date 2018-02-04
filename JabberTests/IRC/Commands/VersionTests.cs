using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class VersionTests
    {
        [TestMethod()]
        public void VersionTest()
        {
            Assert.AreEqual("VERSION", IrcCommand.Version());
            Assert.AreEqual("VERSION tolsun.oulu.fi", IrcCommand.Version("tolsun.oulu.fi"));
        }
    }
}