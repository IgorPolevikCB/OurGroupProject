using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace GroupProject32D
{

   
  
    public partial class Clock : Form
    {
        int second;
        int minute;
        int hour;

        public Clock()
        {
            InitializeComponent();

            labelTimeNow.Text = "";
            timerTimeMsc.Enabled = true;
            timerTimeMsc.Interval = 1000;

            labelTimeBerlin.Text = "";
            timerTimeBerlin.Enabled = true;
            timerTimeBerlin.Interval = 1000;

            labelTimeNewYork.Text = "";
            timerTimeNewYork.Enabled = true;
            timerTimeNewYork.Interval = 1000;

            labelTimeWWarszawie.Text = "";
            timerTimeWWarszawie.Enabled = true;
            timerTimeWWarszawie.Interval = 1000;

            labelTimeLondon.Text = "";
            timerTimeLondon.Enabled = true;
            timerTimeLondon.Interval = 1000;

            labelTimeLosAngeles.Text = "";
            timerTimeLosAngeles.Enabled = true;
            timerTimeLosAngeles.Interval = 1000;

            labelTimeSydney.Text = "";
            timerTimeSydney.Enabled = true;
            timerTimeSydney.Interval = 1000;

            labelTimeKyiv.Text = "";
            timerTimeKyiv.Enabled = true;
            timerTimeKyiv.Interval = 1000;

        }


        
        public void timerTimeMsc_Tick(object sender, EventArgs e)
        { 
            labelTimeNow.Text = DateTime.Now.ToLongTimeString();
        }

        private void timerTimeBerlin_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            labelTimeBerlin.Text = (dateTime.ToString("HH:mm:ss"));
        }
        
        private void timerTimeNewYork_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time");
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            labelTimeNewYork.Text = (dateTime.ToString("HH:mm:ss"));
        }
        
        private void timerTimeWWarszawie_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            labelTimeWWarszawie.Text = (dateTime.ToString("HH:mm:ss"));
        }

        private void timerTimeLondon_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Greenwich Standard Time");
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            labelTimeLondon.Text = (dateTime.ToString("HH:mm:ss"));
        }

        private void timerTimeLosAngeles_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            labelTimeLosAngeles.Text = (dateTime.ToString("HH:mm:ss"));
        }

        private void timerTimeSydney_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("AUS Eastern Standard Time");
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            labelTimeSydney.Text = (dateTime.ToString("HH:mm:ss"));
        }

        private void timerTimeKyiv_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("GTB Standard Time");
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            labelTimeKyiv.Text = (dateTime.ToString("HH:mm:ss"));
        }

        private void Clock_Load(object sender, EventArgs e){ }

        //Секундомер

        private void timerTimer_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
            }
            if (minute == 60)
            {
                minute = 0;
                hour++;
            }

            string sec = Convert.ToString(second);
            string min = Convert.ToString(minute);
            string h = Convert.ToString(hour);

            textHours.Text = h;
            textMinutes.Text = min;
            textSeconds.Text = sec;

        }

        private void buttonSrart_Click(object sender, EventArgs e)
        {
            timerTimer.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerTimer.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            timerTimer.Enabled = false;
            second = 0;
            minute = 0;
            hour = 0;

            textHours.Text = "0";
            textMinutes.Text = "0";
            textSeconds.Text = "0";
        }

        
    }
}
