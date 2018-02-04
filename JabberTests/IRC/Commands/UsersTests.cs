using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class UsersTests
    {
        [TestMethod()]
        public void UsersTest()
        {
            Assert.AreEqual("USERS", IrcCommand.Users());
            Assert.AreEqual("USERS eff.org", IrcCommand.Users("eff.org"));
        }
    }
}