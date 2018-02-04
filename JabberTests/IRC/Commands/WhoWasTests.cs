using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class WhoWasTests
    {
        [TestMethod()]
        public void WhoWasTest()
        {
            Assert.AreEqual("WHOWAS Wiz", IrcCommand.WhoWas("Wiz"));
            Assert.AreEqual("WHOWAS Wiz 9", IrcCommand.WhoWas("Wiz", 9));
            Assert.AreEqual("WHOWAS Wiz 1 *.edu", IrcCommand.WhoWas("Wiz", 1, "*.edu"));
        }
    }
}