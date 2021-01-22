using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone_Simulator_WinForm
{
    public partial class Drone : Form
    {
        public Drone()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlSimulator.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtXCoordinate.Text = "0";
            txtYCoordinate.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlSimulator.Visible = false;
        }
    }
}
