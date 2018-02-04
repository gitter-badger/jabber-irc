using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void ServiceTest()
        {
            const string serviceName = "dict";
            const string distribution = "*.fr";
            const string info = "French Dictionary";
            const string expected = "SERVICE dict * *.fr 0 0 :French Dictionary";
            Assert.AreEqual(expected, IrcCommand.Service(serviceName, distribution, info));
        }
    }
}