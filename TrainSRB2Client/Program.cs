using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainSRB2Client;
using TrainSRB2Client.STATUS;
using System.Diagnostics;
using TrainSRB2Client.SRB2;
using System.Windows.Forms;

namespace TrainSRB2Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TrainConsole console = new TrainConsole();
            Console.Title = "Train Console - "+console.version;
            Train train = new Train();
            train.attach();
            TrainMenu trainMenu = new TrainMenu();
            trainMenu.show();
            SRB2Game srb2 = new SRB2Game();
        }
    }
}
