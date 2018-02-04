using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class NickTests
    {
        [TestMethod()]
        public void NickTest()
        {
            const string nickname = "Tom";
            const string expected = "NICK Tom";
            Assert.AreEqual(expected, IrcCommand.Nick(nickname));
        }
    }
}