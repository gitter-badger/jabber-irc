using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class ErrorTests
    {
        [TestMethod()]
        public void ErrorTest()
        {
            string errorMessage = "Server *.fi already exists.";
            string expected = "ERROR :Server *.fi already exists.";
            Assert.AreEqual(expected, IrcCommand.Error(errorMessage));
        }
    }
}