﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using TrainSRB2Client.FRF;
using TrainSRB2Client;
using System.Threading.Tasks;

namespace TrainSRB2Client
{
    class TrainMenu
    {
        public void showProp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClientMenu menu = new ClientMenu();
            Application.Run(menu);
        }
        public void show()
        {
            ClientMenu menu = new ClientMenu();
            Application.Run(menu);
        }
        public void close()
        {
            Application.Exit();
        }
    }
}
