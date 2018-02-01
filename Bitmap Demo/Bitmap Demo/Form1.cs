using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmap_Demo
{
    public partial class Form1 : Form
    {
        Bitmap drawing;
        Graphics device;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                drawing = new Bitmap("planet.bmp");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            pb.Image = drawing;
            device = Graphics.FromImage(drawing);
            device.DrawImage(drawing, 400, 10, 64, 64);
        }
    }
}
