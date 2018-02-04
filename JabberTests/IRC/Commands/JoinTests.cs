using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;
using System.Collections.Generic;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class JoinTests
    {
        [TestMethod()]
        public void JoinTest()
        {
            Assert.AreEqual("JOIN #foobar", IrcCommand.Join("#foobar"));
            Assert.AreEqual("JOIN &foo fubar", IrcCommand.Join("&foo", "fubar"));
            List<string> channels = new List<string> {"#foo", "#bar"};
            List<string> keys = new List<string> {"fubar", "foobar"};
            Assert.AreEqual("JOIN #foo,#bar", IrcCommand.Join(channels));
            Assert.AreEqual("JOIN #foo,#bar fubar", IrcCommand.Join(channels, "fubar"));
            Assert.AreEqual("JOIN #foo,#bar fubar,foobar", IrcCommand.Join(channels, keys));
            Assert.AreEqual("JOIN 0", IrcCommand.LeaveAllChannels());
        }
    }
}