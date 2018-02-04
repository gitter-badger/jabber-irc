using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class TraceTests
    {
        [TestMethod()]
        public void TraceTest()
        {
            Assert.AreEqual("TRACE", IrcCommand.Trace());
            Assert.AreEqual("TRACE *.oulu.fi", IrcCommand.Trace("*.oulu.fi"));
        }
    }
}