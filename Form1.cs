using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace LightController
{
    public partial class Form1 : Form
    {
        private SerialPort port = new SerialPort("COM3",
        9600, Parity.None, 8, StopBits.One);
        public Form1()
        {
            InitializeComponent();
            port.Open();
        }

        

        private void green_1_CheckedChanged(object sender, EventArgs e)
        {
            if (green_1.Checked == true)
            {
                port.Write("On 0\n");
            }
            else
            {
                port.Write("Off 0\n");
            }
        }

        private void green_2_CheckedChanged(object sender, EventArgs e)
        {
            if (green_2.Checked == true)
            {
                port.Write("On 1\n");
            }
            else
            {
                port.Write("Off 1\n");
            }
        }

        private void red_1_CheckedChanged(object sender, EventArgs e)
        {
            if (red_1.Checked == true)
            {
                port.Write("On 2\n");
            }
            else
            {
                port.Write("Off 2\n");
            }
        }

        private void red_2_CheckedChanged(object sender, EventArgs e)
        {
            if (red_2.Checked == true)
            {
                port.Write("On 3\n");
            }
            else
            {
                port.Write("Off 3\n");
            }
        }

        private void yellow_1_CheckedChanged(object sender, EventArgs e)
        {
            if (yellow_1.Checked == true)
            {
                port.Write("On 4\n");
            }
            else
            {
                port.Write("Off 4\n");
            }
        }
        private void yellow_2_CheckedChanged(object sender, EventArgs e)
        {
            if (yellow_2.Checked == true)
            {
                port.Write("On 5\n");
            }
            else
            {
                port.Write("Off 5\n");
            }
        }
        private void blue_1_CheckedChanged(object sender, EventArgs e)
        {
            if (blue_1.Checked == true)
            {
                port.Write("On 6\n");
            }
            else
            {
                port.Write("Off 6\n");
            }
        }

        private void blue_2_CheckedChanged(object sender, EventArgs e)
        {
            if (blue_2.Checked == true)
            {
                port.Write("On 7\n");
            }
            else
            {
                port.Write("Off 7\n");
            }
        }

        private void On_All_Click(object sender, EventArgs e)
        {
            port.Write("On all\n");
        }

        private void Off_All_Click(object sender, EventArgs e)
        {
            port.Write("Off all\n");
        }
    }
}
