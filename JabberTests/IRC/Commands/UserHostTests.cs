using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;
using System.Collections.Generic;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class UserHostTests
    {
        [TestMethod()]
        public void UserHostTest()
        {
            Assert.AreEqual("USERHOST Wiz", IrcCommand.UserHost("Wiz"));
            Assert.AreEqual("USERHOST Wiz Michael syrk",
                IrcCommand.UserHost(new List<string> { "Wiz", "Michael", "syrk" }));
        }
    }
}