using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class WhoIsTests
    {
        [TestMethod()]
        public void WhoisTest()
        {
            Assert.AreEqual("WHOIS wiz", IrcCommand.WhoIs("wiz"));
            Assert.AreEqual("WHOIS eff.org wiz", IrcCommand.WhoIs("wiz", "eff.org"));
        }
    }
}