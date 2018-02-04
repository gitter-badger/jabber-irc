using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class TopicTests
    {
        [TestMethod()]
        public void TopicTest()
        {
            const string channel = "#test";
            Assert.AreEqual("TOPIC #test :another topic", IrcCommand.Topic(channel, "another topic"));
            Assert.AreEqual("TOPIC #test :", IrcCommand.ClearTopic(channel));
            Assert.AreEqual("TOPIC #test", IrcCommand.GetTopic(channel));
        }
    }
}