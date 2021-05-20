
namespace GroupProject32D
{
    partial class Clock
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
            this.components = new System.ComponentModel.Container();
            this.timerTimeMsc = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimeNow = new System.Windows.Forms.Label();
            this.timerTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonSrart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textHours = new System.Windows.Forms.TextBox();
            this.textSeconds = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textMinutes = new System.Windows.Forms.TextBox();
            this.labelTimeBerlin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTimeNewYork = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timerTimeBerlin = new System.Windows.Forms.Timer(this.components);
            this.timerTimeNewYork = new System.Windows.Forms.Timer(this.components);
            this.labelTimeWWarszawie = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timerTimeWWarszawie = new System.Windows.Forms.Timer(this.components);
            this.labelTimeKyiv = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTimeSydney = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelTimeLosAngeles = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelTimeLondon = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timerTimeLondon = new System.Windows.Forms.Timer(this.components);
            this.timerTimeLosAngeles = new System.Windows.Forms.Timer(this.components);
            this.timerTimeSydney = new System.Windows.Forms.Timer(this.components);
            this.timerTimeKyiv = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerTimeMsc
            // 
            this.timerTimeMsc.Tick += new System.EventHandler(this.timerTimeMsc_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(121, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время в Москве";
            // 
            // labelTimeNow
            // 
            this.labelTimeNow.AutoSize = true;
            this.labelTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTimeNow.Location = new System.Drawing.Point(355, 49);
            this.labelTimeNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeNow.Name = "labelTimeNow";
            this.labelTimeNow.Size = new System.Drawing.Size(51, 20);
            this.labelTimeNow.TabIndex = 1;
            this.labelTimeNow.Text = "label2";
            // 
            // timerTimer
            // 
            this.timerTimer.Interval = 1000;
            this.timerTimer.Tick += new System.EventHandler(this.timerTimer_Tick);
            // 
            // buttonSrart
            // 
            this.buttonSrart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(219)))), ((int)(((byte)(142)))));
            this.buttonSrart.Location = new System.Drawing.Point(209, 458);
            this.buttonSrart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSrart.Name = "buttonSrart";
            this.buttonSrart.Size = new System.Drawing.Size(129, 44);
            this.buttonSrart.TabIndex = 2;
            this.buttonSrart.Text = "Старт";
            this.buttonSrart.UseVisualStyleBackColor = false;
            this.buttonSrart.Click += new System.EventHandler(this.buttonSrart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(86)))), ((int)(((byte)(59)))));
            this.buttonStop.Location = new System.Drawing.Point(393, 458);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(129, 44);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(203, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Часы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(371, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Минуты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(543, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Секунды";
            // 
            // textHours
            // 
            this.textHours.Location = new System.Drawing.Point(262, 335);
            this.textHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textHours.Name = "textHours";
            this.textHours.ReadOnly = true;
            this.textHours.Size = new System.Drawing.Size(76, 26);
            this.textHours.TabIndex = 7;
            // 
            // textSeconds
            // 
            this.textSeconds.Location = new System.Drawing.Point(626, 335);
            this.textSeconds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSeconds.Name = "textSeconds";
            this.textSeconds.ReadOnly = true;
            this.textSeconds.Size = new System.Drawing.Size(76, 26);
            this.textSeconds.TabIndex = 9;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(573, 458);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(129, 44);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textMinutes
            // 
            this.textMinutes.Location = new System.Drawing.Point(446, 335);
            this.textMinutes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMinutes.Name = "textMinutes";
            this.textMinutes.ReadOnly = true;
            this.textMinutes.Size = new System.Drawing.Size(76, 26);
            this.textMinutes.TabIndex = 8;
            // 
            // labelTimeBerlin
            // 
            this.labelTimeBerlin.AutoSize = true;
            this.labelTimeBerlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTimeBerlin.Location = new System.Drawing.Point(355, 93);
            this.labelTimeBerlin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeBerlin.Name = "labelTimeBerlin";
            this.labelTimeBerlin.Size = new System.Drawing.Size(51, 20);
            this.labelTimeBerlin.TabIndex = 12;
            this.labelTimeBerlin.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(121, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Время в Берлине";
            // 
            // labelTimeNewYork
            // 
            this.labelTimeNewYork.AutoSize = true;
            this.labelTimeNewYork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTimeNewYork.Location = new System.Drawing.Point(355, 138);
            this.labelTimeNewYork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeNewYork.Name = "labelTimeNewYork";
            this.labelTimeNewYork.Size = new System.Drawing.Size(51, 20);
            this.labelTimeNewYork.TabIndex = 14;
            this.labelTimeNewYork.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(121, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Время в Нью-Йорке";
            // 
            // timerTimeBerlin
            // 
            this.timerTimeBerlin.Tick += new System.EventHandler(this.timerTimeBerlin_Tick);
            // 
            // timerTimeNewYork
            // 
            this.timerTimeNewYork.Tick += new System.EventHandler(this.timerTimeNewYork_Tick);
            // 
            // labelTimeWWarszawie
            // 
            this.labelTimeWWarszawie.AutoSize = true;
            this.labelTimeWWarszawie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTimeWWarszawie.Location = new System.Drawing.Point(355, 188);
            this.labelTimeWWarszawie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeWWarszawie.Name = "labelTimeWWarszawie";
            this.labelTimeWWarszawie.Size = new System.Drawing.Size(51, 20);
            this.labelTimeWWarszawie.TabIndex = 16;
            this.labelTimeWWarszawie.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(121, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Время в Варшаве";
            // 
            // timerTimeWWarszawie
            // 
            this.timerTimeWWarszawie.Tick += new System.EventHandler(this.timerTimeWWarszawie_Tick);
            // 
            // labelTimeKyiv
            // 
            this.labelTimeKyiv.AutoSize = true;
            this.labelTimeKyiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTimeKyiv.Location = new System.Drawing.Point(721, 188);
            this.labelTimeKyiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeKyiv.Name = "labelTimeKyiv";
            this.labelTimeKyiv.Size = new System.Drawing.Size(51, 20);
            this.labelTimeKyiv.TabIndex = 24;
            this.labelTimeKyiv.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(487, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Время в Киеве";
            // 
            // labelTimeSydney
            // 
            this.labelTimeSydney.AutoSize = true;
            this.labelTimeSydney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTimeSydney.Location = new System.Drawing.Point(721, 138);
            this.labelTimeSydney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeSydney.Name = "labelTimeSydney";
            this.labelTimeSydney.Size = new System.Drawing.Size(51, 20);
            this.labelTimeSydney.TabIndex = 22;
            this.labelTimeSydney.Text = "label2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(487, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Время в Сиднее";
            // 
            // labelTimeLosAngeles
            // 
            this.labelTimeLosAngeles.AutoSize = true;
            this.labelTimeLosAngeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTimeLosAngeles.Location = new System.Drawing.Point(721, 93);
            this.labelTimeLosAngeles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeLosAngeles.Name = "labelTimeLosAngeles";
            this.labelTimeLosAngeles.Size = new System.Drawing.Size(51, 20);
            this.labelTimeLosAngeles.TabIndex = 20;
            this.labelTimeLosAngeles.Text = "label2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(487, 93);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Время в Лос Анджелесе";
            // 
            // labelTimeLondon
            // 
            this.labelTimeLondon.AutoSize = true;
            this.labelTimeLondon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTimeLondon.Location = new System.Drawing.Point(721, 49);
            this.labelTimeLondon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeLondon.Name = "labelTimeLondon";
            this.labelTimeLondon.Size = new System.Drawing.Size(51, 20);
            this.labelTimeLondon.TabIndex = 18;
            this.labelTimeLondon.Text = "label2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(487, 49);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Время в Лондоне";
            // 
            // timerTimeLondon
            // 
            this.timerTimeLondon.Tick += new System.EventHandler(this.timerTimeLondon_Tick);
            // 
            // timerTimeLosAngeles
            // 
            this.timerTimeLosAngeles.Tick += new System.EventHandler(this.timerTimeLosAngeles_Tick);
            // 
            // timerTimeSydney
            // 
            this.timerTimeSydney.Tick += new System.EventHandler(this.timerTimeSydney_Tick);
            // 
            // timerTimeKyiv
            // 
            this.timerTimeKyiv.Tick += new System.EventHandler(this.timerTimeKyiv_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 546);
            this.Controls.Add(this.labelTimeKyiv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTimeSydney);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelTimeLosAngeles);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelTimeLondon);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelTimeWWarszawie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTimeNewYork);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTimeBerlin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textSeconds);
            this.Controls.Add(this.textMinutes);
            this.Controls.Add(this.textHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonSrart);
            this.Controls.Add(this.labelTimeNow);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock";
            this.ShowIcon = false;
            this.Text = "Часы";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerTimeMsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimeNow;
        private System.Windows.Forms.Timer timerTimer;
        private System.Windows.Forms.Button buttonSrart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHours;
        private System.Windows.Forms.TextBox textSeconds;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textMinutes;
        private System.Windows.Forms.Label labelTimeBerlin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTimeNewYork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerTimeBerlin;
        private System.Windows.Forms.Timer timerTimeNewYork;
        private System.Windows.Forms.Label labelTimeWWarszawie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerTimeWWarszawie;
        private System.Windows.Forms.Label labelTimeKyiv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTimeSydney;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTimeLosAngeles;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelTimeLondon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timerTimeLondon;
        private System.Windows.Forms.Timer timerTimeLosAngeles;
        private System.Windows.Forms.Timer timerTimeSydney;
        private System.Windows.Forms.Timer timerTimeKyiv;
    }
}