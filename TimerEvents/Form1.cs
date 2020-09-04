using System;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Timer timer { get; set; }

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer = new Timer { Interval = 1000 };
            timer.Tick += Timer_tick;
            timer.Start();
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value>=100)
            {
                timer.Stop();
            }
        }
    }
}
