using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinchAPI;

namespace Demo__Windows_FinchControl
{
    public partial class Form1 : Form
    {
        Finch _myFinch;
        int _speed;
        int _LEDRedValue;
        int _LEDGreenValue;
        int _LEDBlueValue;


        public Form1()
        {
            _myFinch = new Finch();
            _myFinch.connect();

            InitializeFinch();

            InitializeComponent();
        }

        private void InitializeFinch()
        {
            _speed = 200;
            _LEDRedValue = 0;
        }
        private void btnFoward_Click(object sender, EventArgs e)
        {
            _myFinch.setMotors(_speed, _speed);
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            _myFinch.setMotors(-_speed, -_speed);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _myFinch.setMotors(0, 0);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void chkBoxLEDRed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxLEDRed.Checked)
            {
                _LEDRedValue = 255;
            }
            else
            {
                _LEDRedValue = 0;
            }

            UpdateLED();
        }

        
        private void chkBoxLEDGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxLEDGreen.Checked)
            {
                _LEDGreenValue = 255;
            }
            else
            {
                _LEDGreenValue = 0;
            }

            UpdateLED();
        }

        private void chkBoxLEDBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxLEDBlue.Checked)
            {
                _LEDBlueValue = 255;
            }
            else
            {
                _LEDBlueValue = 0;
            }

            UpdateLED();
        }

        private void UpdateLED()
        {
            _myFinch.setLED(_LEDRedValue, _LEDGreenValue, _LEDBlueValue);
        }
    }
}
