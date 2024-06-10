using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace CST_250_Activity_5
{
    public partial class Form1 : Form
    {

        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        public int score = 0; // score tracker
        public int highscore = 0;
        private int xMin = 20; // target minimum x boundary
        private int yMin = 50; // target minimum y boundary
        private int xMax = 250; // target max x boundary
        private int yMax = 350; // target max y boundary
        private TimeSpan additionalTime = TimeSpan.Zero;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            watch.Start();
            timer1.Enabled = true;
            label2.Text = "Score: 0";
            label4.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            watch.Stop();
            timer1.Enabled = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            watch.Reset();
            score = 0;
            timer1.Enabled = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = watch.Elapsed + additionalTime;

            // Format the elapsed time to a readable format
            string formattedTime = string.Format(
                "{2:00}",
                (int)elapsed.TotalHours,
                elapsed.Minutes,
                elapsed.Seconds,
                elapsed.Milliseconds / 10);

            label1.Text = formattedTime;

            // Main target
            if (random.Next(0, 10) < 8)
            {
                int maxWidth = xMax - xMin - button4.Width;
                int maxHeight = yMax - yMin - button4.Height;

                button4.Left = random.Next(xMin, xMax - button4.Width);
                button4.Top = random.Next(yMin, yMax - button4.Height);
                button4.Visible = true;
            }

            // Starting decoy
            if (random.Next(0, 10) < 11)
            {
                int maxWidth = xMax - xMin - button4.Width;
                int maxHeight = yMax - yMin - button4.Height;

                button5.Left = random.Next(xMin, xMax - button4.Width);
                button5.Top = random.Next(yMin, yMax - button4.Height);
                button5.Visible = true;
            }

            // Decoy after score is higher than 10
            if (random.Next(0, 10) < 11 && score > 10)
            {
                timer1.Interval = 900;
                int maxWidth = xMax - xMin - button4.Width;
                int maxHeight = yMax - yMin - button4.Height;

                button6.Left = random.Next(xMin, xMax - button4.Width);
                button6.Top = random.Next(yMin, yMax - button4.Height);
                button6.Visible = true;
            }

            // Decoy after score is higher than 20
            if (random.Next(0, 10) < 11 && score > 20)
            {
                timer1.Interval = 800;
                int maxWidth = xMax - xMin - button4.Width;
                int maxHeight = yMax - yMin - button4.Height;

                button8.Left = random.Next(xMin, xMax - button4.Width);
                button8.Top = random.Next(yMin, yMax - button4.Height);
                button8.Visible = true;
            }

            // Bonus target
            if (random.Next(0, 10) < 2)
            {
                int maxWidth = xMax - xMin - button4.Width;
                int maxHeight = yMax - yMin - button4.Height;

                button7.Left = random.Next(xMin, xMax - button4.Width);
                button7.Top = random.Next(yMin, yMax - button4.Height);
                button7.Visible = true;
            }

            if (score > 30)
            {
                timer1.Interval = 700;
                
            }

            if (score > 40)
            {
                timer1.Interval = 600;
            }

            if (score > 50)
            {
                timer1.Interval = 500;
            }

            if (score > 60)
            {
                timer1.Interval = 400;
            }

            // Reset the stopwatch and additionalTime if elapsed is greater than or equal to 30 seconds
            if (elapsed >= TimeSpan.FromSeconds(30))
            {
                timer1.Interval = 1000;
                watch.Reset();
                additionalTime = TimeSpan.FromSeconds(0);
                timer1.Enabled = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;

                if (score > highscore)
                {
                    highscore = score;
                }

                label3.Text = $"High Score: {highscore}";
                score = 0;
                label4.Visible = true;
                return; // exit the Tick method early
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            score++;
            label2.Text = $"Score: {score}";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            additionalTime += TimeSpan.FromSeconds(5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            additionalTime += TimeSpan.FromSeconds(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            additionalTime += TimeSpan.FromSeconds(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            additionalTime += TimeSpan.FromSeconds(-5);
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            additionalTime += TimeSpan.FromSeconds(5);
        }
    }
}
