using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainSRB2Client;
using TrainSRB2Client.STATUS;
using System.Diagnostics;
using Xamarin.Forms;
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
            Console.WriteLine("Installed Console");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Made by Lapide");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Train -- " + console.version);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Title = "Train Console - "+console.version;

            Train train = new Train();
            Console.WriteLine("Installed Train");
            train.attach();

            TrainMenu trainMenu = new TrainMenu();
            Console.WriteLine("Installed TrainMenu");

            SRB2Game srb2 = new SRB2Game();
            Console.WriteLine("Installed SRB2");
            Console.WriteLine("Installed menu");

            Console.WriteLine("Done!");

            trainMenu.showProp();
        }
    }
}
