using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class AwayTests
    {
        [TestMethod()]
        public void AwayTest()
        {
            Assert.AreEqual("AWAY", IrcCommand.Away());
            string message = "Gone to lunch.";
            string expected = "AWAY :Gone to lunch.";
            Assert.AreEqual(expected, IrcCommand.Away(message));
        }
    }
}