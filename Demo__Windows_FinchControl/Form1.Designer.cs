namespace Demo__Windows_FinchControl
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
            this.grpBoxLED = new System.Windows.Forms.GroupBox();
            this.radBtnBlue = new System.Windows.Forms.RadioButton();
            this.radBtnGreen = new System.Windows.Forms.RadioButton();
            this.radBtnLEDRed = new System.Windows.Forms.RadioButton();
            this.grpBoxLED.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFoward
            // 
            this.btnFoward.Location = new System.Drawing.Point(185, 77);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(75, 47);
            this.btnFoward.TabIndex = 0;
            this.btnFoward.Text = "Forward";
            this.btnFoward.UseVisualStyleBackColor = true;
            this.btnFoward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(185, 207);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(75, 47);
            this.btnBackward.TabIndex = 1;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(297, 142);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 47);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(70, 142);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 47);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(185, 142);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 47);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(329, 335);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(112, 41);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // chkBoxLEDRed
            // 
            this.chkBoxLEDRed.AutoSize = true;
            this.chkBoxLEDRed.Location = new System.Drawing.Point(28, 293);
            this.chkBoxLEDRed.Name = "chkBoxLEDRed";
            this.chkBoxLEDRed.Size = new System.Drawing.Size(46, 17);
            this.chkBoxLEDRed.TabIndex = 6;
            this.chkBoxLEDRed.Text = "Red";
            this.chkBoxLEDRed.UseVisualStyleBackColor = true;
            this.chkBoxLEDRed.CheckedChanged += new System.EventHandler(this.chkBoxLEDRed_CheckedChanged);
            // 
            // chkBoxLEDGreen
            // 
            this.chkBoxLEDGreen.AutoSize = true;
            this.chkBoxLEDGreen.Location = new System.Drawing.Point(28, 316);
            this.chkBoxLEDGreen.Name = "chkBoxLEDGreen";
            this.chkBoxLEDGreen.Size = new System.Drawing.Size(55, 17);
            this.chkBoxLEDGreen.TabIndex = 7;
            this.chkBoxLEDGreen.Text = "Green";
            this.chkBoxLEDGreen.UseVisualStyleBackColor = true;
            this.chkBoxLEDGreen.CheckedChanged += new System.EventHandler(this.chkBoxLEDGreen_CheckedChanged);
            // 
            // chkBoxLEDBlue
            // 
            this.chkBoxLEDBlue.AutoSize = true;
            this.chkBoxLEDBlue.Location = new System.Drawing.Point(28, 339);
            this.chkBoxLEDBlue.Name = "chkBoxLEDBlue";
            this.chkBoxLEDBlue.Size = new System.Drawing.Size(47, 17);
            this.chkBoxLEDBlue.TabIndex = 8;
            this.chkBoxLEDBlue.Text = "Blue";
            this.chkBoxLEDBlue.UseVisualStyleBackColor = true;
            this.chkBoxLEDBlue.CheckedChanged += new System.EventHandler(this.chkBoxLEDBlue_CheckedChanged);
            // 
            // grpBoxLED
            // 
            this.grpBoxLED.Controls.Add(this.radBtnBlue);
            this.grpBoxLED.Controls.Add(this.radBtnGreen);
            this.grpBoxLED.Controls.Add(this.radBtnLEDRed);
            this.grpBoxLED.Location = new System.Drawing.Point(113, 277);
            this.grpBoxLED.Name = "grpBoxLED";
            this.grpBoxLED.Size = new System.Drawing.Size(66, 85);
            this.grpBoxLED.TabIndex = 9;
            this.grpBoxLED.TabStop = false;
            // 
            // radBtnBlue
            // 
            this.radBtnBlue.AutoSize = true;
            this.radBtnBlue.Location = new System.Drawing.Point(6, 60);
            this.radBtnBlue.Name = "radBtnBlue";
            this.radBtnBlue.Size = new System.Drawing.Size(46, 17);
            this.radBtnBlue.TabIndex = 2;
            this.radBtnBlue.TabStop = true;
            this.radBtnBlue.Text = "Blue";
            this.radBtnBlue.UseVisualStyleBackColor = true;
            this.radBtnBlue.CheckedChanged += new System.EventHandler(this.radBtnBlue_CheckedChanged);
            // 
            // radBtnGreen
            // 
            this.radBtnGreen.AutoSize = true;
            this.radBtnGreen.Location = new System.Drawing.Point(6, 37);
            this.radBtnGreen.Name = "radBtnGreen";
            this.radBtnGreen.Size = new System.Drawing.Size(54, 17);
            this.radBtnGreen.TabIndex = 1;
            this.radBtnGreen.TabStop = true;
            this.radBtnGreen.Text = "Green";
            this.radBtnGreen.UseVisualStyleBackColor = true;
            this.radBtnGreen.CheckedChanged += new System.EventHandler(this.radBtnGreen_CheckedChanged);
            // 
            // radBtnLEDRed
            // 
            this.radBtnLEDRed.AutoSize = true;
            this.radBtnLEDRed.Location = new System.Drawing.Point(6, 14);
            this.radBtnLEDRed.Name = "radBtnLEDRed";
            this.radBtnLEDRed.Size = new System.Drawing.Size(45, 17);
            this.radBtnLEDRed.TabIndex = 0;
            this.radBtnLEDRed.TabStop = true;
            this.radBtnLEDRed.Text = "Red";
            this.radBtnLEDRed.UseVisualStyleBackColor = true;
            this.radBtnLEDRed.CheckedChanged += new System.EventHandler(this.radBtnLEDRed_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 388);
            this.Controls.Add(this.grpBoxLED);
            this.Controls.Add(this.chkBoxLEDBlue);
            this.Controls.Add(this.chkBoxLEDGreen);
            this.Controls.Add(this.chkBoxLEDRed);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnFoward);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxLED.ResumeLayout(false);
            this.grpBoxLED.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpBoxLED;
        private System.Windows.Forms.RadioButton radBtnBlue;
        private System.Windows.Forms.RadioButton radBtnGreen;
        private System.Windows.Forms.RadioButton radBtnLEDRed;
    }
}

