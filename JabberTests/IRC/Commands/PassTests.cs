using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class PassTests
    {
        [TestMethod()]
        public void PassTest()
        {
            const string password = "TestPassword";
            const string expected = "PASS TestPassword";
            Assert.AreEqual(expected, IrcCommand.Pass(password));
        }
    }
}