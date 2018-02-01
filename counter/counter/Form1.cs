using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counter
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void click_addOne(object sender, EventArgs e)
        {
            count++;
            countLabel.Text = count.ToString();
        }

        private void click_reset(object sender, EventArgs e)
        {
            count = 0;
            countLabel.Text = count.ToString();
        }
    }
}
