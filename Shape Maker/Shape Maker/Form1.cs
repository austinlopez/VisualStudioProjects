using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape_Maker
{
    public partial class mainForm : Form
    {
        Bitmap sface;
        public mainForm()
        {
            InitializeComponent();
            sface = new Bitmap(pb.Size.Width, pb.Size.Height);
        }

        private void setup_Click(object sender, EventArgs e)
        {
            if (rButton.Checked)
            {
                squareForm sForm = new squareForm(ref pb, ref sface);
                sForm.Show();
            }
            else if (cButton.Checked)
            {
                circleForm cForm = new circleForm(ref pb, ref sface);
                cForm.Show();
            }
        }
    }
}
