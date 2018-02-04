using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class ListTests
    {
        [TestMethod()]
        public void ListTest()
        {
            Assert.AreEqual("LIST", IrcCommand.List());
            Assert.AreEqual("LIST #twilight_zone", IrcCommand.List("#twilight_zone"));
            List<string> channels = new List<string> { "#twilight_zone", "#42" };
            Assert.AreEqual("LIST #twilight_zone,#42", IrcCommand.List(channels));
            const string target = "#30";
            Assert.AreEqual("LIST #twilight_zone #30", IrcCommand.List("#twilight_zone", target));
            Assert.AreEqual("LIST #twilight_zone,#42 #30", IrcCommand.List(channels, target));
        }
    }
}