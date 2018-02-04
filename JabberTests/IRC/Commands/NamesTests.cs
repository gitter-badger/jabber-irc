using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;
using System.Collections.Generic;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class NamesTests
    {
        [TestMethod()]
        public void NamesTest()
        {
            Assert.AreEqual("NAMES", IrcCommand.Names());
            Assert.AreEqual("NAMES #42", IrcCommand.Names("#42"));
            List<string> channels = new List<string> { "#twilight_zone", "#42" };
            Assert.AreEqual("NAMES #twilight_zone,#42", IrcCommand.Names(channels));
        }
    }
}