using Microsoft.VisualStudio.TestTools.UnitTesting;
using JabberIRC.IRC.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberTests.IRC.Commands
{
    [TestClass()]
    public class UserModeTests
    {
        [TestMethod()]
        public void UserModeTest()
        {
            const string nickname = "WiZ";
            const string modeString = "-w";
            const string expected = "MODE WiZ -w";
            Assert.AreEqual(expected, IrcCommand.UserMode(nickname, modeString));
        }
    }
}