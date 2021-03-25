using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using GMA;
using System.Threading.Tasks;

namespace TrainSRB2Client.SRB2
{
    class SRB2Game
    {
        public Process game = Process.GetProcessesByName("srb2win")[0];
        public Mod memory = new Mod();
        public void killGame()
        {
            game.Kill();
            Console.WriteLine("Killed " + game.ProcessName);
        }
        public void setValue(string address, string type, int value, string ifLog) {
            if (ifLog == "log")
            {
                memory.OpenProcess("srb2win");
                string val = value.ToString();
                string ge = memory.ReadInt(address).ToString();
                memory.WriteMemory(address, type, val);
                Console.WriteLine("Changed address " + address + " with value " + ge + " to " + val);
            } else if(ifLog == "nolog")
            {
                memory.OpenProcess("srb2win");
                string val = value.ToString();
                string ge = memory.ReadInt(address).ToString();
                memory.WriteMemory(address, type, val);
            } else
            {
                memory.OpenProcess("srb2win");
                string val = value.ToString();
                string ge = memory.ReadInt(address).ToString();
                memory.WriteMemory(address, type, val);
            }
        }
    }
}
