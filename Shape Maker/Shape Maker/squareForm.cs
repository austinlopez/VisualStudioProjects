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
    public partial class squareForm : Form
    {
        PictureBox tempBox;
        Graphics device;
        Bitmap surface;
        Color rectangleColor;
        int rectLineWidth;
        int rectX;
        int rectY;
        int rectWidth;
        int rectHeight;
        public squareForm(ref PictureBox pb, ref Bitmap sface)
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
            rectangleColor = cd.Color;
            rectColorBox.BackColor = rectangleColor;
        }

        private void drawRect(int rX, int rY, int rW, int rH, int rLW)
        {
            device = Graphics.FromImage(surface);
            Pen pen = new Pen(rectangleColor, rectLineWidth);
            device.DrawRectangle(pen, rX, rY, rW, rH);
            tempBox.Image = surface;
        }

        private void drawRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectX = Convert.ToInt32(rectXBox.Text);
            rectY = Convert.ToInt32(rectYBox.Text);
            rectWidth = Convert.ToInt32(rectWBox.Text);
            rectHeight = Convert.ToInt32(rectHBox.Text);
            rectLineWidth = Convert.ToInt32(rectLWBox.Text);
            drawRect(rectX, rectY, rectWidth, rectHeight,rectLineWidth);
        }

        private void drawB_Click(object sender, EventArgs e)
        {
            rectX = Convert.ToInt32(rectXBox.Text);
            rectY = Convert.ToInt32(rectYBox.Text);
            rectWidth = Convert.ToInt32(rectWBox.Text);
            rectHeight = Convert.ToInt32(rectHBox.Text);
            rectLineWidth = Convert.ToInt32(rectLWBox.Text);
            drawRect(rectX, rectY, rectWidth, rectHeight, rectLineWidth);
        }
    }
}
