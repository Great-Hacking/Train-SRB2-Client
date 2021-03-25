using System;
using System.Collections.Generic;
using System.Linq;
using GMA;
using TrainSRB2Client.SRB2;
using offsets;
using System.Text;
using System.Threading.Tasks;

namespace SRB2.Game
{
    class Game
    {
        public void setRings(int value)
        {
            string val = value.ToString();
            Mod m = new Mod();
            m.OpenProcess("srb2win");
            m.WriteMemory(new Offsets().rings, "int", val);
        }
        public void setSpeed(int speed)
        {
            string val = speed.ToString();
            Mod m = new Mod();
            m.OpenProcess("srb2win");
            m.WriteMemory(new Offsets().speed, "int", val);
        }
        public void setScore(int score)
        {
            SRB2Game srb2 = new SRB2Game();
            srb2.setValue(new Offsets().score, "int", score, "nolog");
        }
    }
}
