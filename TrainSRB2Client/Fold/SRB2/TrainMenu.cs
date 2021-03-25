using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using TrainSRB2Client;
using System.Threading.Tasks;

namespace TrainSRB2Client
{
    class TrainMenu
    {
        public void show()
        {
            TrainFormMenu menu = new TrainFormMenu();
            Application.Run(menu);
        }
        public void close()
        {
            Application.Exit();
        }
    }
}
