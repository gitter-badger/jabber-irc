using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class QuitTests
    {
        [TestMethod()]
        public void QuitTest()
        {
            const string message = "Gone to have lunch";
            const string expected = "QUIT :Gone to have lunch";

            Assert.AreEqual("QUIT", IrcCommand.Quit());
            Assert.AreEqual(expected, IrcCommand.Quit(message));
        }
    }
}