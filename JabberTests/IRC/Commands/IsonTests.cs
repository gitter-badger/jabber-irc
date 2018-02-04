using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class IsonTests
    {
        [TestMethod()]
        public void IsonTest()
        {
            Assert.AreEqual("ISON Wiz", IrcCommand.Ison("Wiz"));
            Assert.AreEqual("ISON Wiz Angel", IrcCommand.Ison(new List<string> { "Wiz", "Angel" }));
        }
    }
}