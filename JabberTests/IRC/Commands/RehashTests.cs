using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class RehashTests
    {
        [TestMethod()]
        public void RehashTest()
        {
            Assert.AreEqual("REHASH", IrcCommand.Rehash());
        }
    }
}