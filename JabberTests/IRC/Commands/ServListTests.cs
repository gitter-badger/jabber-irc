using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class ServListTests
    {
        [TestMethod()]
        public void ServListTest()
        {
            Assert.AreEqual("SERVLIST", IrcCommand.ServList());
            Assert.AreEqual("SERVLIST *.au", IrcCommand.ServList("*.au"));
            Assert.AreEqual("SERVLIST *.au 0", IrcCommand.ServList("*.au", "0"));
        }
    }
}