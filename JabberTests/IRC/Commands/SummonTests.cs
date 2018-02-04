using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class SummonTests
    {
        [TestMethod()]
        public void SummonTest()
        {
            Assert.AreEqual("SUMMON jto", IrcCommand.Summon("jto"));
            Assert.AreEqual("SUMMON jto tolsun.oulu.fi", IrcCommand.Summon("jto", "tolsun.oulu.fi"));
            Assert.AreEqual("SUMMON jto tolsun.oulu.fi #40", IrcCommand.Summon("jto", "tolsun.oulu.fi", "#40"));
        }
    }
}