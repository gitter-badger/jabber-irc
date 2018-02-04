using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class ChannelModeTests
    {
        [TestMethod()]
        public void ChannelModeTest()
        {
            Assert.AreEqual("MODE #Finnish +imI", IrcCommand.ChannelMode("#Finnish", "+imI"));
            Assert.AreEqual("MODE #Finnish +imI *!*@*.fi", IrcCommand.ChannelMode("#Finnish","+imI", "*!*@*.fi"));
            Assert.AreEqual("MODE #Finnish +o Kilroy", IrcCommand.ChannelMode("#Finnish", ChannelMode.Operator, ChannelAction.Add, "Kilroy"));
            Assert.AreEqual("MODE #Fins -s", IrcCommand.ChannelMode("#Fins", ChannelMode.Secret, ChannelAction.Remove));
            Assert.AreEqual("MODE #meditation e", IrcCommand.ChannelMode("#meditation", ChannelMode.ExceptionMask));

            List<string> modeParams = new List<string> { "*!*@*.edu", "*!*@*.bu.edu" };
            Assert.AreEqual("MODE #bu +be *!*@*.edu *!*@*.bu.edu", IrcCommand.ChannelMode("#bu", "+be", modeParams));
        }
    }
}