using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class InfoTests
    {
        [TestMethod()]
        public void InfoTest()
        {
            string target = "csd.bu.edu";
            string expected = "INFO csd.bu.edu";
            Assert.AreEqual(expected, IrcCommand.Info(target));
            expected = "INFO";
            Assert.AreEqual(expected, IrcCommand.Info());
        }
    }
}