using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class NoticeTests
    {
        [TestMethod()]
        public void NoticeTest()
        {
            const string target = "Angel";
            const string message = "yes I'm receiving it!";
            Assert.AreEqual("NOTICE Angel :yes I'm receiving it!", IrcCommand.Notice(target, message));
        }
    }
}