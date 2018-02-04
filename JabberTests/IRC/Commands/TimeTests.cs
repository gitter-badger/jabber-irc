using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class TimeTests
    {
        [TestMethod()]
        public void TimeTest()
        {
            Assert.AreEqual("TIME", IrcCommand.Time());
            Assert.AreEqual("TIME TIME tolsun.oulu.fi", IrcCommand.Time("TIME tolsun.oulu.fi"));
        }
    }
}