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
    public class UserTests
    {
        [TestMethod()]
        public void UserTest()
        {
            const string user = "guest";
            const string modeString = "-i+a";
            const string realname = "Ronnie Reagan";
            string expected = "USER guest 0 * :Ronnie Reagan";


            expected = "USER guest -i+a * :Ronnie Reagan";
            Assert.AreEqual(expected, IrcCommand.User(user, modeString, realname));
        }
    }
}