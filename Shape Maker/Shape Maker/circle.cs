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
    public partial class circleForm : Form
    {
        PictureBox tempBox;
        Graphics device;
        Bitmap surface;
        Color circleColor;
        int circleWidth;
        int circleRadius;
        int circleX;
        int circleY;
        public circleForm(ref PictureBox pb, ref Bitmap sface)
        {
            InitializeComponent();
            tempBox = pb;
            surface = sface;
            //surface = new Bitmap(tempBox.Size.Width, tempBox.Size.Height);
        }

        private void changeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Color backColo = cd.Color;
            tempBox.BackColor = cd.Color;
        }

        private void setColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            circleColor = cd.Color;
            circleColorBox.BackColor = circleColor;
        }

        private void drawCircle(int cX, int cY, int cRad, int cWidth)
        {
            device = Graphics.FromImage(surface);
            Pen pen = new Pen(circleColor, cWidth);
            cX = cX - cRad / 2;
            cY = cY - cRad / 2;
            device.DrawArc(pen, cX, cY, cRad * 2, cRad * 2, 0, 360);
            tempBox.Image = surface;
        }

        private void drawCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleWidth = Convert.ToInt32(lineBox.Text);
            circleRadius = Convert.ToInt32(rBox.Text);
            circleX = Convert.ToInt32(centerXBox.Text);
            circleY = Convert.ToInt32(centerYBox.Text);
            drawCircle(circleX, circleY, circleRadius, circleWidth);
        }

        private void drawB_Click(object sender, EventArgs e)
        {
            circleWidth = Convert.ToInt32(lineBox.Text);
            circleRadius = Convert.ToInt32(rBox.Text);
            circleX = Convert.ToInt32(centerXBox.Text);
            circleY = Convert.ToInt32(centerYBox.Text);
            drawCircle(circleX, circleY, circleRadius, circleWidth);
        }
    }
}
