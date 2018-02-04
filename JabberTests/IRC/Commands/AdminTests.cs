using JabberIRC.IRC.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class AdminTests
    {
        [TestMethod()]
        public void AdminTest()
        {
            Assert.AreEqual("ADMIN", IrcCommand.Admin());
            string target = "tolsun.oulu.fi";
            Assert.AreEqual($"ADMIN {target}", IrcCommand.Admin(target));
        }
    }
}