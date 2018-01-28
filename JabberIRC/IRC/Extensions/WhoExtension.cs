﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: [ "mask" [ "o" ] ]
    /// 
    /// The WHO command is used by a client to generate a query which returns
    /// a list of information which 'matches' the "mask" parameter given by
    /// the client.In the absence of the "mask" parameter, all visible
    /// (users who aren't invisible (user mode +i) and who don't have a
    /// common channel with the requesting client) are listed.The same
    /// result can be achieved by using a "mask" of "0" or any wildcard which
    /// will end up matching every visible user.
    /// 
    /// The "mask" passed to WHO is matched against users' host, server, real
    /// name and nickname if the channel "mask" cannot be found.
    /// 
    /// If the "o" parameter is passed only operators are returned according
    /// to the "mask" supplied.
    /// </summary>
    public static class WhoExtension
    {
        public static void Who(this ApiWrapper apiWrapper, StreamWriter writer, string mask=null, string oParam=null)
        {
            string oParamSpace = oParam == null ? "" : " ";
            string maskSpace = mask == null ? "" : " ";
            writer.WriteLine($"WHO{maskSpace}{mask}{oParamSpace}{oParam}");
        }
    }
}
