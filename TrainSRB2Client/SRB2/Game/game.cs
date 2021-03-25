using System;
using System.Collections.Generic;
using System.Linq;
using Memory;
using TrainSRB2Client.SRB2.offsets;
using System.Text;
using System.Threading.Tasks;

namespace TrainSRB2Client.SRB2.Game
{
    class Game
    {
        public void setRings(int value)
        {
            string val = value.ToString();
            Mem m = new Mem();
            m.OpenProcess("srb2win");
            m.WriteMemory(new Offsets().rings, "int", val);
        }
    }
}
