using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class KillTests
    {
        [TestMethod()]
        public void KillTest()
        {
            Assert.AreEqual("KILL tom comment",  IrcCommand.Kill("tom", "comment"));
        }
    }
}