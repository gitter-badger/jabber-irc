using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class DieTests
    {
        [TestMethod()]
        public void DieTest()
        {
            Assert.AreEqual("DIE", IrcCommand.Die());
        }
    }
}