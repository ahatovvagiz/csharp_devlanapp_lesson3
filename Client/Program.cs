﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Server;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            NetClient.SentMessage(args[0], args[1]);
        }
        
    }
}