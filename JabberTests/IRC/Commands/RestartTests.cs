using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class RestartTests
    {
        [TestMethod()]
        public void RestartTest()
        {
            Assert.AreEqual("RESTART", IrcCommand.Restart());
        }
    }
}