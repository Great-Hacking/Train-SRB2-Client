﻿using GMA;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSRB2Client.STATUS
{
    class Rings
    {
        public void rings()
        {
            Mod m = new Mod();
            bool check = m.OpenProcess("srb2win");

            if (!check)
            {
                Console.WriteLine("Cannot find process");
            }
            else
            {
              string val = m.ReadInt("base+55EC8D8").ToString();
                Console.WriteLine(val);
            }
        }
    }
}