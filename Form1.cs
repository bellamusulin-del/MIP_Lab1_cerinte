using System;
using System.Drawing;
using System.Windows.Forms;

namespace MIP_Lab1_cerinte
{
    public partial class Form1 : Form
    {
        private int windowMoveStep = 30;
        private Random randomGenerator = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            string message = "Esti sigur ca vrei sa muti fereastra in sus?";
            string title = "UP";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            textBoxChoice.Text = result.ToString();

            this.Top = this.Top - windowMoveStep;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            string message = "Fereastra se muta in jos.";
            string title = "DOWN";
            MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            textBoxChoice.Text = result.ToString();

            this.Top = this.Top + windowMoveStep;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            string message = "Muti fereastra la stanga?";
            string title = "LEFT";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            textBoxChoice.Text = result.ToString();

            this.Left = this.Left - windowMoveStep;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            string message = "Muti fereastra la dreapta?";
            string title = "RIGHT";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Error;

            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            textBoxChoice.Text = result.ToString();

            this.Left = this.Left + windowMoveStep;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerColor.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerColor.Stop();
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
            int redValue = randomGenerator.Next(256);
            int greenValue = randomGenerator.Next(256);
            int blueValue = randomGenerator.Next(256);

            Color randomColor = Color.FromArgb(redValue, greenValue, blueValue);

            this.BackColor = randomColor;
        }

        private void textBoxInterval_TextChanged(object sender, EventArgs e)
        {
            string typedText = textBoxInterval.Text;

            int newInterval;
            bool isNumber = int.TryParse(typedText, out newInterval);

            // Csak pozitív szám esetén változtatjuk meg a Timer intervallumát.
            if (isNumber == true && newInterval > 0)
            {
                timerColor.Interval = newInterval;
            }
        }

        private void textBoxChoice_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

