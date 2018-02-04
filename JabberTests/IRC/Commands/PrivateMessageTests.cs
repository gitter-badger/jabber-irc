using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class PrivateMessageTests
    {
        [TestMethod()]
        public void PrivateMessageTest()
        {
            const string target = "Angel";
            const string message = "yes I'm receiving it!";
            Assert.AreEqual("PRIVMSG Angel :yes I'm receiving it!", IrcCommand.PrivateMessage(target, message));
        }
    }
}