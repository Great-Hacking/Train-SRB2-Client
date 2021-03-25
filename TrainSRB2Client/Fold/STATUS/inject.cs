using System;
using System.Collections.Generic;
using System.Text;
using Memory;
using System.Threading;
namespace TrainSRB2Client.STATUS
{
    class Inject
    {
        public void attach()
        {
            Console.WriteLine("Starting...");
            Mem m = new Mem();
            bool  b= m.OpenProcess("srb2win");
            if (!b)
            {
                Console.WriteLine("Failed to start.");
                Thread.Sleep(5000);
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Started!");
            }
        }
    }
}
