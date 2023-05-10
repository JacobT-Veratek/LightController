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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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

        void OnOff(System.Windows.Forms.CheckBox checkBox,int num)
        {
                if (checkBox.Checked == true) {
                    string onCommand = string.Format("On {0}\n", num);
                    port.Write(onCommand);
                }
                else
                {
                    string offCommand = string.Format("Off {0}\n", num);
                    port.Write(offCommand);
                }
        }

        void BlinkLed(int num, System.Windows.Forms.TextBox ledInterval)
        {
            string intervalText = ledInterval.Text;
            int interval = int.Parse(intervalText);

            string blinkCommand = string.Format("Blink {0} {1}\n", num, interval);
            
            port.Write(blinkCommand);
        }

        private void green_1_CheckedChanged(object sender, EventArgs e)
        {
            OnOff(green_1, 0);
        }
        private void green_2_CheckedChanged(object sender, EventArgs e)
        {
            OnOff(green_2, 1);
        }
        private void red_1_CheckedChanged(object sender, EventArgs e)
        {
            OnOff(red_1, 2);
        }
        private void red_2_CheckedChanged(object sender, EventArgs e)
        {
            OnOff(red_2, 3);
        }
        private void yellow_1_CheckedChanged(object sender, EventArgs e)
        {
            OnOff(yellow_1, 4);
        }
        private void yellow_2_CheckedChanged(object sender, EventArgs e)
        {
            OnOff(yellow_2, 5);
        }
        private void blue_1_CheckedChanged(object sender, EventArgs e)
        {
            OnOff(blue_1, 6);
        }
        private void blue_2_CheckedChanged(object sender, EventArgs e)
        {
            OnOff(blue_2, 7);
        }

        private void On_All_Click(object sender, EventArgs e)
        {
            port.Write("On all\n");
        }
        private void Off_All_Click(object sender, EventArgs e)
        {
            port.Write("Off all\n");
        }

        private void blink_g_1_Click(object sender, EventArgs e)
        {
            BlinkLed(0, g_1_interval);
        }
        private void blink_g_2_Click(object sender, EventArgs e)
        {
            BlinkLed(1, g_2_interval);
        }
        private void blink_r_1_Click(object sender, EventArgs e)
        {
            BlinkLed(2, r_1_interval);
        }
        private void blink_r_2_Click(object sender, EventArgs e)
        {
            BlinkLed(3, r_2_interval);
        }
        private void blink_y_1_Click(object sender, EventArgs e)
        {
            BlinkLed(4, y_1_interval); ;
        }
        private void blink_y_2_Click(object sender, EventArgs e)
        {
            BlinkLed(5, y_2_interval);
        }
        private void blink_b_1_Click(object sender, EventArgs e)
        {
            BlinkLed(6, y_1_interval);
        }
        private void blink_b_2_Click(object sender, EventArgs e)
        {
            BlinkLed(7, y_2_interval);
        }

        private void blink_all_Click(object sender, EventArgs e)
        {
            string intervalText = blink_all_interval.Text;
            int interval = int.Parse(intervalText);

            string blinkAllCommand = string.Format("Blink all {0}\n", interval);

            port.Write(blinkAllCommand);
        }

        private void simultaneous_start_Click(object sender, EventArgs e)
        {
            port.Write("simul start\n");
        }
    }
}
