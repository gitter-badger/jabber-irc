using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class InviteTests
    {
        [TestMethod()]
        public void InviteTest()
        {
            const string nickname = "Wiz";
            const string channel = "#Twilight_Zone";
            Assert.AreEqual("INVITE Wiz #Twilight_Zone", IrcCommand.Invite(nickname, channel));
        }
    }
}