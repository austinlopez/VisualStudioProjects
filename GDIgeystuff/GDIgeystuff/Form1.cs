using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIgeystuff
{
    public partial class Form1 : Form
    {
        //Declare a variable for our PictureBox
        //This will hold our bitmap
        PictureBox pb;
        //Declare a variable for our bitmap
        //This will be what we draw on
        Bitmap paper;
        //Declare a variable for our Graphics 
        //This will be what we draw with
        Graphics device;

        //a timer for our animations
        Timer timer;
        //a random number generator for random colors
        Random rand;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //First lets set up our window the way we want
            //Give it a title
            Text = "First GDI+ Program";
            //set the size
            //700 width and 600 height
            Size = new Size(1000, 800);
            //Try this and see what it does
            FormBorderStyle = FormBorderStyle.FixedSingle;
            //Type your guess here:
            //made the border thinner
            //Make it so the size can't be changed

            //Now try this one
            MaximizeBox = false;
            //Did you guess turn off the maximize button

            //Next we will set up our picturebox
            //we could drag and drop from the design
            //editor, but this is just as easy
            pb = new PictureBox(); //creates a new PictureBox
            pb.Parent = this; //attaches it to the form
            pb.Dock = DockStyle.Fill; //makes it take up the whole screen
            pb.BackColor = Color.Black; //Black background

            //Creates our bitmap to draw on
            //it should be the same size as 
            //the picturebox
            paper = new Bitmap(Size.Width, Size.Height);

            //We can go ahead and put it in the picturebox
            pb.Image = paper;

            //Next we can create out Graphics device
            //We're not going to do anything with it yet though

            device = Graphics.FromImage(paper);

            //Next we set up the timer
            timer = new Timer();
            timer.Interval = 1;
            timer.Enabled = true;
            //This next line adds the event handler
            //if you press tab it makes it easy
            timer.Tick += Timer_Tick;

            //Create our random number generator
            rand = new Random();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                drawRect();
                drawLine();
            }
            
        }

        public void drawLine()
        {
            //make a random color
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);

            //This is ARGB color which is like
            //what you are used to (RGB) color
            //except there is a value for A,
            //see if you can figure out what the 
            //A does
            Color color = Color.FromArgb(A, R, G, B);

            //we also want a random width for
            //our lines
            int width = rand.Next(2, 10);

            //the Graphics class has many toold to 
            //draw with, for this we will use
            //the pen tool
            Pen pen = new Pen(color, width);
            //random starting and ending points
            //on our paper for the lines
            int startX = rand.Next(1, Size.Width);
            int startY = rand.Next(1, Size.Height);
            int endX = rand.Next(1, Size.Width);
            int endY = rand.Next(1, Size.Height);

            device.DrawLine(pen, startX, startY, endX, endY);

            //now put the paper(Bitmap) in the Picturebox
            pb.Image = paper;

            //now go up to Timer_Tick erase the exception and 
            //make it draw
            //a line each time the event 
        }

        public void drawRect()
        {
            //make a random color
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);

            //This is ARGB color which is like
            //what you are used to (RGB) color
            //except there is a value for A,
            //see if you can figure out what the 
            //A does
            Color color = Color.FromArgb(A, R, G, B);

            //we also want a random width for
            //our lines
            int width = rand.Next(2, 30);

            //the Graphics class has many toold to 
            //draw with, for this we will use
            //the pen tool
            
            //random starting and ending points
            //on our paper for the lines
            int startX = rand.Next(1, Size.Width);
            int startY = rand.Next(1, Size.Height);
            int endX = rand.Next(1, Size.Width);
            int endY = rand.Next(1, Size.Height);

            Pen pen = new Pen(color, width);

            device.DrawRectangle(pen, startX, startY, width, width);
            

            //now put the paper(Bitmap) in the Picturebox
            pb.Image = paper;

            //now go up to Timer_Tick erase the exception and 
            //make it draw
            //a line each time the event 
        }
    }
}
