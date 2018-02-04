using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class StatsTests
    {
        [TestMethod()]
        public void StatsTest()
        {
            Assert.AreEqual("STATS", IrcCommand.Stats());
            Assert.AreEqual("STATS m", IrcCommand.Stats(StatsQuery.UsageCount));
            Assert.AreEqual("STATS m tolsun.oulu.fi", IrcCommand.Stats(StatsQuery.UsageCount, "tolsun.oulu.fi"));
        }
    }
}