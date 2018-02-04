using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class OperTests
    {
        [TestMethod()]
        public void OperTest()
        {
            const string name = "foo";
            const string password = "bar";
            const string expected = "OPER foo bar";
            Assert.AreEqual(expected, IrcCommand.Oper(name, password));
        }
    }
}