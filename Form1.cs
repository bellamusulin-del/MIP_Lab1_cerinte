
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MIPLAB1
{
    public partial class Form1 : Form
    {
        private Timer timer1 = new Timer();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;

            startButton.Click += startButton_Click;
            stopButton.Click += stopButton_Click;

            downButton.Click += downButton_Click;
            leftButton.Click += leftButton_Click;
            rightButton.Click += rightButton_Click;

            intervalTextBox.TextChanged += intervalTextBox_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intervalTextBox.Text = "300";
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to move up?",
                "UP",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            resultTextBox.Text = result.ToString();

            Location = new Point(Location.X, Location.Y - 20);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to move down?",
                "DOWN",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            resultTextBox.Text = result.ToString();

            Location = new Point(Location.X, Location.Y + 20);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to move left?",
                "LEFT",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Question);

            resultTextBox.Text = result.ToString();

            Location = new Point(Location.X - 20, Location.Y);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to move right?",
                "RIGHT",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Error);

            resultTextBox.Text = result.ToString();

            Location = new Point(Location.X + 20, Location.Y);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(
                random.Next(256),
                random.Next(256),
                random.Next(256));
        }

        private void intervalTextBox_TextChanged(object sender, EventArgs e)
        {
            int interval;

            if (int.TryParse(intervalTextBox.Text, out interval))
            {
                if (interval > 0)
                {
                    timer1.Interval = interval;
                }
            }
        }
    }
}


