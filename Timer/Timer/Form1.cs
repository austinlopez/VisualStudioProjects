using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            count--;
            timerLabel.Text = count.ToString();
            if (count == 0)
            {
                timer.Stop();
                timerLabel.Visible = false;
                timeUp.Visible = true;
                startButton.Visible = true;
            }
        }

        private void start_click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(inputBox.Text);
            timerLabel.Text = count.ToString();
            timer.Start(); timerLabel.Visible = true;
            timeUp.Visible = false;
            startButton.Visible = false;
        }
    }
}
