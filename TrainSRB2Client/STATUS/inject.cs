﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using TrainSRB2Client.FRF;
using System.Threading;
using GMA;

namespace TrainSRB2Client.STATUS
{
    class Inject
    {
        public void attach()
        {
            Console.WriteLine("Starting...");
            Mod m = new Mod();
            bool  b= m.OpenProcess("srb2win");
            if (!b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to start.");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Started!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
