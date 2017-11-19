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

namespace Demo__WinForms_FinchControl
{
    public partial class Form1 : Form
    {
        Finch _myFinch;
        int _speed;
        int _LEDBrightness;
        int _LEDRedValue;
        int _LEDGreenValue;
        int _LEDBlueValue;


        public Form1()
        {
            _myFinch = new Finch();
            _myFinch.connect();

            InitializeFinch();
            InitializeTimer();

            InitializeComponent();
        }

        //
        // setup and initialize timer to update sensor values
        //
        private void InitializeTimer()
        {
            Timer timer = new Timer
            {
                Interval = (200)
            };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        //
        // update sensor values on form
        //
        private void Timer_Tick(object o, EventArgs e)
        {
            txtboxTemperature.Text = _myFinch.getTemperature().ToString();
            txtboxLightSensorValue.Text = AverageLightSensorValue();
            btnLeftObstacleIndicator.BackColor = LeftObstacleIndicatorColor();
            btnRightObstacleIndicator.BackColor = RightObstacleIndicatorColor();
        }

        private Color LeftObstacleIndicatorColor()
        {
            if (_myFinch.isObstacleLeftSide())
            {
                return Color.Red;
            }
            else
            {
                return Color.White;
            }
        }

        private Color RightObstacleIndicatorColor()
        {
            if (_myFinch.isObstacleRightSide())
            {
                return Color.Red;
            }
            else
            {
                return Color.White;
            }
        }

        private string AverageLightSensorValue()
        {
            int[] lightSensorValues = _myFinch.getLightSensors();
            return lightSensorValues.Average().ToString();
        }

        private void InitializeFinch()
        {
            _speed = 200;
            _LEDBrightness = 200;
            _LEDRedValue = 0;
            _LEDGreenValue = 0;
            _LEDBlueValue = 0;
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {
            _myFinch.setMotors(_speed, _speed);
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            _myFinch.setMotors(-_speed, -_speed);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _myFinch.setMotors(0, _speed);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _myFinch.setMotors(100, _speed);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _myFinch.setMotors(0, 0);
        }

        private void chkBoxLEDRed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxLEDRed.Checked)
            {
                _LEDRedValue = _LEDBrightness;
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
                _LEDGreenValue = _LEDBrightness;
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
                _LEDBlueValue = _LEDBrightness;
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
