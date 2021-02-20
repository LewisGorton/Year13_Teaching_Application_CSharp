//Lewis
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Height = SystemInformation.VirtualScreen.Height;
            Width = SystemInformation.VirtualScreen.Width;
            int HeightDivisor = 5;
            Quit.Height = Height / 25;
            Quit.Width = Height / 25;
            Quit.Location = new Point(Width - Quit.Width -HeightDivisor, HeightDivisor);

            int buttonHeight = (Height-20) /HeightDivisor;
            int buttonWidth = (Width - 20) / 2;
            int Height10 = Height / 128;

            divideButton.Height = buttonHeight;
            divideButton.Width = buttonWidth;

            multiplyButton.Height = buttonHeight;
            multiplyButton.Width = buttonWidth;

            addButton.Height = buttonHeight;
            addButton.Width = buttonWidth;

            subtractButton.Height = buttonHeight;
            subtractButton.Width = buttonWidth;

            modulusArgumentButton.Height = buttonHeight;
            modulusArgumentButton.Width = buttonWidth;

            circleLoci.Height = buttonHeight;
            circleLoci.Width = buttonWidth;

            midpointLoci.Height = buttonHeight;
            midpointLoci.Width = buttonWidth;

            angleLoci.Height = buttonHeight;
            angleLoci.Width = buttonWidth;

            argandButton.Height = 3*buttonHeight/HeightDivisor;
            argandButton.Width = buttonWidth*2;

            divideButton.Location = new Point(Height10, Height10+Quit.Height);
            multiplyButton.Location = new Point(Height10,  Height10+Quit.Height + Height / HeightDivisor);
            addButton.Location = new Point(Height10, Height10+Quit.Height + 2* Height / HeightDivisor);
            subtractButton.Location = new Point(Height10, Height10 + Quit.Height + 3 * Height / HeightDivisor);

            modulusArgumentButton.Location = new Point(Height10+buttonWidth,Height10+Quit.Height);
            circleLoci.Location = new Point(Height10 + buttonWidth, Height10 + Quit.Height + Height / HeightDivisor);
            midpointLoci.Location = new Point(Height10 + buttonWidth, Height10 + Quit.Height + 2 * Height / HeightDivisor);
            angleLoci.Location = new Point(Height10 + buttonWidth, Height10+ Quit.Height + 3 * Height / HeightDivisor);

            argandButton.Location = new Point(Height10, 6 * Height / 7);

        }
        private void modulusArgumentButton_Click(object sender, EventArgs e)
        {
            ModulusArgument start = new ModulusArgument();
            start.Show();
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            Operations start = new Operations("DIVIDE");
            start.Show();
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            Operations start = new Operations("MULTIPLY");
            start.Show();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Operations start = new Operations("ADD");
            start.Show();
        }
        private void subtractButton_Click(object sender, EventArgs e)
        {
            Operations start = new Operations("SUBTRACT");
            start.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void circleLoci_Click(object sender, EventArgs e)
        {
            ParameterGraph start = new ParameterGraph("CIRCLE");
            start.Show();
        }

        private void midpointLoci_Click(object sender, EventArgs e)
        {
            Midpoint start = new Midpoint();
            start.Show();
        }
        private void angleLoci_Click(object sender, EventArgs e)
        {
            ParameterGraph start = new ParameterGraph("HALFLINE");
            start.Show();
        }

        private void argandButton_Click(object sender, EventArgs e)
        {
            DisplayComplex start = new DisplayComplex();
            start.Show();
        }
    }
}
