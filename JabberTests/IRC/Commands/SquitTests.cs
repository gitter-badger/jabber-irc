using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class SquitTests
    {
        [TestMethod()]
        public void SquitTest()
        {
            const string server = "tolsun.oulu.fi";
            const string message = "Bad Link";
            const string expected = "SQUIT tolsun.oulu.fi :Bad Link";
            Assert.AreEqual(expected, IrcCommand.Squit(server, message));
        }
    }
}