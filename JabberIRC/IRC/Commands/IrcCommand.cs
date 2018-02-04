using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC
{
    public partial class IrcCommand
    {
        private static IrcCommand _instance;
        private IrcCommand() {}
        public static IrcCommand Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new IrcCommand();
                }
                return _instance;
            }
        }
    }
}
