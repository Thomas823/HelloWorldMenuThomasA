/*
 * Created by: Thomas Aubin
 * Created on: 07-Feb-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Hello World with Menu
 * This program displays Hello World but with an exit menu
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldMenuThomasA
{
    public partial class frmHelloWorldMenu : Form
    {
        public frmHelloWorldMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}