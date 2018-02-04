using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class OperwallTests
    {
        [TestMethod()]
        public void OperwallTest()
        {
            Assert.AreEqual("WALLOPS :text", IrcCommand.Operwall("text"));
        }
    }
}