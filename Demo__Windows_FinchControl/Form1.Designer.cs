namespace Demo__WinForms_FinchControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFoward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.chkBoxLEDRed = new System.Windows.Forms.CheckBox();
            this.chkBoxLEDGreen = new System.Windows.Forms.CheckBox();
            this.chkBoxLEDBlue = new System.Windows.Forms.CheckBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblLightSensorAverage = new System.Windows.Forms.Label();
            this.txtboxTemperature = new System.Windows.Forms.TextBox();
            this.txtboxLightSensorValue = new System.Windows.Forms.TextBox();
            this.lblLeftObstacle = new System.Windows.Forms.Label();
            this.btnLeftObstacleIndicator = new System.Windows.Forms.Button();
            this.btnRightObstacleIndicator = new System.Windows.Forms.Button();
            this.lblRightObstacle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFoward
            // 
            this.btnFoward.Location = new System.Drawing.Point(242, 13);
            this.btnFoward.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(100, 58);
            this.btnFoward.TabIndex = 0;
            this.btnFoward.Text = "Forward";
            this.btnFoward.UseVisualStyleBackColor = true;
            this.btnFoward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(242, 173);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(100, 58);
            this.btnBackward.TabIndex = 1;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(391, 93);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 58);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(88, 93);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 58);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(242, 93);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 58);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(439, 412);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(149, 50);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // chkBoxLEDRed
            // 
            this.chkBoxLEDRed.AutoSize = true;
            this.chkBoxLEDRed.Location = new System.Drawing.Point(37, 361);
            this.chkBoxLEDRed.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxLEDRed.Name = "chkBoxLEDRed";
            this.chkBoxLEDRed.Size = new System.Drawing.Size(56, 21);
            this.chkBoxLEDRed.TabIndex = 6;
            this.chkBoxLEDRed.Text = "Red";
            this.chkBoxLEDRed.UseVisualStyleBackColor = true;
            this.chkBoxLEDRed.CheckedChanged += new System.EventHandler(this.chkBoxLEDRed_CheckedChanged);
            // 
            // chkBoxLEDGreen
            // 
            this.chkBoxLEDGreen.AutoSize = true;
            this.chkBoxLEDGreen.Location = new System.Drawing.Point(37, 389);
            this.chkBoxLEDGreen.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxLEDGreen.Name = "chkBoxLEDGreen";
            this.chkBoxLEDGreen.Size = new System.Drawing.Size(70, 21);
            this.chkBoxLEDGreen.TabIndex = 7;
            this.chkBoxLEDGreen.Text = "Green";
            this.chkBoxLEDGreen.UseVisualStyleBackColor = true;
            this.chkBoxLEDGreen.CheckedChanged += new System.EventHandler(this.chkBoxLEDGreen_CheckedChanged);
            // 
            // chkBoxLEDBlue
            // 
            this.chkBoxLEDBlue.AutoSize = true;
            this.chkBoxLEDBlue.Location = new System.Drawing.Point(37, 417);
            this.chkBoxLEDBlue.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxLEDBlue.Name = "chkBoxLEDBlue";
            this.chkBoxLEDBlue.Size = new System.Drawing.Size(58, 21);
            this.chkBoxLEDBlue.TabIndex = 8;
            this.chkBoxLEDBlue.Text = "Blue";
            this.chkBoxLEDBlue.UseVisualStyleBackColor = true;
            this.chkBoxLEDBlue.CheckedChanged += new System.EventHandler(this.chkBoxLEDBlue_CheckedChanged);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(34, 269);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(90, 17);
            this.lblTemperature.TabIndex = 10;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblLightSensorAverage
            // 
            this.lblLightSensorAverage.AutoSize = true;
            this.lblLightSensorAverage.Location = new System.Drawing.Point(34, 301);
            this.lblLightSensorAverage.Name = "lblLightSensorAverage";
            this.lblLightSensorAverage.Size = new System.Drawing.Size(145, 17);
            this.lblLightSensorAverage.TabIndex = 11;
            this.lblLightSensorAverage.Text = "Light Sensor Average";
            // 
            // txtboxTemperature
            // 
            this.txtboxTemperature.Location = new System.Drawing.Point(192, 269);
            this.txtboxTemperature.Name = "txtboxTemperature";
            this.txtboxTemperature.Size = new System.Drawing.Size(88, 22);
            this.txtboxTemperature.TabIndex = 12;
            // 
            // txtboxLightSensorValue
            // 
            this.txtboxLightSensorValue.Location = new System.Drawing.Point(192, 301);
            this.txtboxLightSensorValue.Name = "txtboxLightSensorValue";
            this.txtboxLightSensorValue.Size = new System.Drawing.Size(88, 22);
            this.txtboxLightSensorValue.TabIndex = 13;
            // 
            // lblLeftObstacle
            // 
            this.lblLeftObstacle.AutoSize = true;
            this.lblLeftObstacle.Location = new System.Drawing.Point(362, 274);
            this.lblLeftObstacle.Name = "lblLeftObstacle";
            this.lblLeftObstacle.Size = new System.Drawing.Size(92, 17);
            this.lblLeftObstacle.TabIndex = 14;
            this.lblLeftObstacle.Text = "Left Obstacle";
            // 
            // btnLeftObstacleIndicator
            // 
            this.btnLeftObstacleIndicator.BackColor = System.Drawing.SystemColors.Info;
            this.btnLeftObstacleIndicator.Location = new System.Drawing.Point(478, 269);
            this.btnLeftObstacleIndicator.Name = "btnLeftObstacleIndicator";
            this.btnLeftObstacleIndicator.Size = new System.Drawing.Size(50, 22);
            this.btnLeftObstacleIndicator.TabIndex = 15;
            this.btnLeftObstacleIndicator.UseVisualStyleBackColor = false;
            // 
            // btnRightObstacleIndicator
            // 
            this.btnRightObstacleIndicator.BackColor = System.Drawing.SystemColors.Info;
            this.btnRightObstacleIndicator.Location = new System.Drawing.Point(478, 301);
            this.btnRightObstacleIndicator.Name = "btnRightObstacleIndicator";
            this.btnRightObstacleIndicator.Size = new System.Drawing.Size(50, 22);
            this.btnRightObstacleIndicator.TabIndex = 17;
            this.btnRightObstacleIndicator.UseVisualStyleBackColor = false;
            // 
            // lblRightObstacle
            // 
            this.lblRightObstacle.AutoSize = true;
            this.lblRightObstacle.Location = new System.Drawing.Point(362, 306);
            this.lblRightObstacle.Name = "lblRightObstacle";
            this.lblRightObstacle.Size = new System.Drawing.Size(101, 17);
            this.lblRightObstacle.TabIndex = 16;
            this.lblRightObstacle.Text = "Right Obstacle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 478);
            this.Controls.Add(this.btnRightObstacleIndicator);
            this.Controls.Add(this.lblRightObstacle);
            this.Controls.Add(this.btnLeftObstacleIndicator);
            this.Controls.Add(this.lblLeftObstacle);
            this.Controls.Add(this.txtboxLightSensorValue);
            this.Controls.Add(this.txtboxTemperature);
            this.Controls.Add(this.lblLightSensorAverage);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.chkBoxLEDBlue);
            this.Controls.Add(this.chkBoxLEDGreen);
            this.Controls.Add(this.chkBoxLEDRed);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnFoward);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFoward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox chkBoxLEDRed;
        private System.Windows.Forms.CheckBox chkBoxLEDGreen;
        private System.Windows.Forms.CheckBox chkBoxLEDBlue;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblLightSensorAverage;
        private System.Windows.Forms.TextBox txtboxTemperature;
        private System.Windows.Forms.TextBox txtboxLightSensorValue;
        private System.Windows.Forms.Label lblLeftObstacle;
        private System.Windows.Forms.Button btnLeftObstacleIndicator;
        private System.Windows.Forms.Button btnRightObstacleIndicator;
        private System.Windows.Forms.Label lblRightObstacle;
    }
}

