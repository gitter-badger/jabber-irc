using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class SqueryTests
    {
        [TestMethod()]
        public void SqueryTest()
        {
            Assert.AreEqual("SQUERY irchelp :HELP privmsg", IrcCommand.Squery("irchelp", "HELP privmsg"));
        }
    }
}