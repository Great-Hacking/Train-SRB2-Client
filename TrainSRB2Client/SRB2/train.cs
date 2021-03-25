using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Memory;
using TrainSRB2Client.STATUS;
using System.Diagnostics;
namespace TrainSRB2Client.SRB2
{
    class Train
    {
        public void attach()
        {
            Inject inject = new Inject();
            inject.attach();
        }
        public void rings()
        {
            Rings rings1 = new Rings();
            rings1.rings();
        }
    }
}
