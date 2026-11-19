using System;
using System.Drawing;
using System.Windows.Forms;


namespace sanke_tıssss
{

    public partial class Form1 : Form
    {
        private int speedX = 0;
        private int speedY = 0;


        private int step = 20;

        private int currentInterval = 200;

        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.DoubleBuffered = true;
            this.Text = "Snake and Apple";

           
            pictureBox1.Size = new Size(30, 30);   
            pictureBox2.Size = new Size(20, 20);   

            
            pictureBox1.Location = new Point(300, 300);
            pictureBox2.Location = new Point(200, 90);

            
            timer1.Interval = currentInterval;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && speedX == 0)
            {
                speedX = -step;
                speedY = 0;
            }
            else if (e.KeyCode == Keys.Right && speedX == 0)
            {
                speedX = step;
                speedY = 0;
            }
            else if (e.KeyCode == Keys.Up && speedY == 0)
            {
                speedX = 0;
                speedY = -step;
            }
            else if (e.KeyCode == Keys.Down && speedY == 0)
            {
                speedX = 0;
                speedY = step;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int newLeft = pictureBox1.Left + speedX;
            int newTop = pictureBox1.Top + speedY;

            
            if (newLeft < 0) newLeft = 0;
            if (newTop < 0) newTop = 0;
            if (newLeft + pictureBox1.Width > ClientSize.Width)
                newLeft = ClientSize.Width - pictureBox1.Width;
            if (newTop + pictureBox1.Height > ClientSize.Height)
                newTop = ClientSize.Height - pictureBox1.Height;

            pictureBox1.Left = newLeft;
            pictureBox1.Top = newTop;

            
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                EatApple();
            }
        }
        private void EatApple()
        {
            
            int maxX = ClientSize.Width - pictureBox2.Width;
            int maxY = ClientSize.Height - pictureBox2.Height;

            pictureBox2.Left = rnd.Next(0, maxX);
            pictureBox2.Top = rnd.Next(0, maxY);

           
            if (currentInterval > 50)   
            {
                currentInterval -= 15;
                timer1.Interval = currentInterval;
            }
        }
    }
}
