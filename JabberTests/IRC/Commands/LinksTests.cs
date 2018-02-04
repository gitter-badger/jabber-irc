using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class LinksTests
    {
        [TestMethod()]
        public void LinksTest()
        {
            Assert.AreEqual("LINKS", IrcCommand.Links());
            Assert.AreEqual("LINKS *.au", IrcCommand.Links("*.au"));
            Assert.AreEqual("LINKS *.edu *.bu.edu", IrcCommand.Links("*.edu", "*.bu.edu"));
        }
    }
}