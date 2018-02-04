using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class MessageOfTheDayTests
    {
        [TestMethod()]
        public void MessageOfTheDayTest()
        {
            Assert.AreEqual("MOTD", IrcCommand.MessageOfTheDay());
            Assert.AreEqual("MOTD *.edu", IrcCommand.MessageOfTheDay("*.edu"));
        }
    }
}