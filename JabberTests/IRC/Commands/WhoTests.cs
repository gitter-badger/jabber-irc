using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class WhoTests
    {
        [TestMethod()]
        public void WhoTest()
        {
            Assert.AreEqual("WHO", IrcCommand.Who());
            Assert.AreEqual("WHO *.fi", IrcCommand.Who("*.fi"));
            Assert.AreEqual("WHO jto* o", IrcCommand.Who("jto*", true));
        }
    }
}