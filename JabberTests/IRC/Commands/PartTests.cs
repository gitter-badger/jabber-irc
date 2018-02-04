using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;
using System.Collections.Generic;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class PartTests
    {
        [TestMethod()]
        public void PartTest()
        {
            Assert.AreEqual("PART #twilight_zone", IrcCommand.Part("#twilight_zone"));
            List<string> channels = new List<string>{"#oz-ops", "&group5"};
            Assert.AreEqual("PART #oz-ops,&group5", IrcCommand.Part(channels));
            Assert.AreEqual("PART #twilight_zone :Lunch Time.", IrcCommand.Part("#twilight_zone", "Lunch Time."));
            Assert.AreEqual("PART #oz-ops,&group5 :Lunch Time.", IrcCommand.Part(channels, "Lunch Time."));
        }
    }
}