using System;
using System.Collections.Generic;
using System.ComponentModel;
using SRB2.Game;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSRB2Client.FRF
{
    public partial class ClientMenu : Form
    {
        Game game = new Game();
        public ClientMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox3.Text);
            game.setSpeed(value);
            Console.WriteLine("Set speed to " + value);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox1.Text);
            game.setRings(value);
            Console.WriteLine("Set rings to " + value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox2.Text);
            game.setScore(value);
            Console.WriteLine("Set score to " + value);
        }
    }
}
