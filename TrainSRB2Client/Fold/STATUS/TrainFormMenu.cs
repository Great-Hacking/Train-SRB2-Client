using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using TrainSRB2Client.SRB2.Game;
using System.Diagnostics;
using TrainSRB2Client.SRB2;
using TrainSRB2Client.SRB2.offsets;
using TrainSRB2Client.STATUS;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSRB2Client
{
    public partial class TrainFormMenu : Form
    {

        TrainMenu menu = new TrainMenu();
        TrainConsole console = new TrainConsole();
        Train train = new Train();
        SRB2Game srb2 = new SRB2Game();
        Inject inject = new Inject();
        Offsets offsets = new Offsets();
        Game game = new Game();
        
        Rings rings = new Rings();

        public TrainFormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val = Int32.Parse(textBox1.Text);
            game.setRings(val);
        }

        private void TrainFormMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Async.RunWorkerAsync();
        }

        private void Async_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Async.RunWorkerAsync();
        }
    }
}
