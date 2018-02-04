using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class KickTests
    {
        [TestMethod()]
        public void KickTest()
        {
            const string comment = "Speaking English";
            Assert.AreEqual("KICK &Melbourne Matthew", IrcCommand.Kick("&Melbourne", "Matthew"));
            string expected = "KICK #Finnish John :Speaking English";
            Assert.AreEqual(expected, IrcCommand.Kick("#Finnish", "John", comment));
            expected = "KICK #40,#30 user1,user2";
            List<string> channels = new List<string> { "#40", "#30" };
            List<string> users = new List<string> { "user1", "user2" };
            Assert.AreEqual(expected, IrcCommand.Kick(channels, users));
            expected += $" :{comment}";
            Assert.AreEqual(expected, IrcCommand.Kick(channels, users, comment));
        }
    }
}