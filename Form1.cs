using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TimeSpan Remaining;
        TimeSpan Loop;
        private void Timenow(object sender, EventArgs e)
        {
            Time_now.Text = DateTime.Now.ToString("hh:mm:ss tt");
            Date_now.Text = DateTime.Now.ToString("dd/MM/yyyy");

            DateTime currentDateTime = DateTime.Now;

            Picker_Time_now.Value = currentDateTime;
        }

        private void Update_timer()
        {
            timer1.Interval = 1000;
            timer1.Tick += Timenow;
            timer1.Start();
        }


        private void Time_Remaining(object sender, EventArgs e)
        {
            Remaining = Remaining.Subtract(TimeSpan.FromSeconds(1));

            if (Remaining.TotalSeconds <= 0)
            {
                timer2.Stop();
                timer2.Tick -= Time_Remaining;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.ShowBalloonTip(3000, "Alarm", "This is alarm time", ToolTipIcon.Info);
                return;
            }
           
            Alarm_time.Text = string.Format("{0:D2}:{1:D2}:{2:D2} ", Remaining.Hours, Remaining.Minutes, Remaining.Seconds);
        }

        private void Alarm_()
        {

            DateTime now = Picker_Time_now.Value;
            
            DateTime alarmTime = Picker_Time_Alarm.Value;


            TimeSpan result =alarmTime - now;


            if (result.TotalSeconds < 0)
            {
                MessageBox.Show("The alarm time must be after the current time." ,"warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Alarm_time.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", result.Hours, result.Minutes, result.Seconds);
            Remaining = result;

            timer2.Interval = 1000;
            timer2.Tick += Time_Remaining;
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Update_timer();
            tabControl1.ItemSize = new Size(100, 30);
            Picker_Time_Alarm.Value = DateTime.Now;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Alarm_();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            Alarm_time.Text = "00:00:00";
            timer2.Tick -= Time_Remaining;
        }


        private void The_Timer(object sender , EventArgs e)
        {
            Progress_Par.Value -= 1;
            Progress_Par.Refresh();

            Loop = Loop.Subtract(TimeSpan.FromSeconds(1));
            Timer.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", Loop.Hours, Loop.Minutes, Loop.Seconds);

            if(Loop.TotalSeconds<=0)
            {
                timer3.Stop();
                timer3.Tick -= The_Timer;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.ShowBalloonTip(3000, "Timer", "Period ended", ToolTipIcon.Info);
            }
        }

        private  void StartTimer_Click(object sender, EventArgs e)
        {

            int hours = (int)Hours.Value;
            int minutes = (int)Minutes.Value;
            int seconds = (int)Seconds.Value;
            TimeSpan timer = new TimeSpan(hours, minutes, seconds);

            Timer.Text = timer.ToString();

             Loop = timer;

            Progress_Par.Maximum = (int)timer.TotalSeconds;
            Progress_Par.Value = Progress_Par.Maximum;
            Progress_Par.Minimum = 0;

            timer3.Interval = 1000;
            timer3.Tick += The_Timer;
            timer3.Start();

          
        }

        private void Stop_Timer_Click(object sender, EventArgs e)
        {
            if(Stop_Timer.Tag.ToString()=="1")
            {
                Stop_Timer.Text = "Resume";
                timer3.Stop();
                timer3.Tick -= The_Timer;
                Stop_Timer.Tag = "2";
            }

            else if(Stop_Timer.Tag.ToString()=="2")
            {
                Stop_Timer.Text = "Stop";
                timer3.Interval=1000;
                timer3.Tick += The_Timer;
                timer3.Start();
                Stop_Timer.Tag = "1";
            }
        }

        private void Reset_Timer_Click(object sender, EventArgs e)
        {
            Progress_Par.Value = 0;
            timer3.Stop();
            Timer.Text = "00:00:00";
            timer3.Tick -= The_Timer;
        }
    }
}