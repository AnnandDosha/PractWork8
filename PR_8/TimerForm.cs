using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_8
{
    public partial class TimerForm : Form
    {
        public int seconds=0;
        public TimerForm()
        {
            InitializeComponent();

            startButton.Click += startButton_Click;
            stopButton.Click += stopButton_Click;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (gameTimer.Enabled == false)
            {
                gameTimer.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (gameTimer.Enabled == true)
            {
                gameTimer.Stop();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            this.seconds++;
            int clockseconds = seconds % 60;
            int clockminutes = seconds / 60;
            string stroka = "";
            stroka = clockminutes < 10 ? "0" + clockminutes.ToString() : clockminutes.ToString();
            stroka += ":" + (clockseconds < 10 ? "0" + clockseconds.ToString() : clockseconds.ToString());
            timeLabel.Text = stroka;
        }
    }
}
