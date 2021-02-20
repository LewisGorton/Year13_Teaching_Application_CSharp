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
    public partial class ModulusArgument : Form
    {
        public ModulusArgument()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Height = SystemInformation.VirtualScreen.Height;
            Width = SystemInformation.VirtualScreen.Width;
            int HeightDivisor = Height / 7;
            int Height5=Height/256;
            int Height10 = Height / 128;
            int HeightOver20 = Height/20;
            int CentreScreen = Width/2;
            Quit.Height = Height / 25;
            Quit.Width = Height / 25;
            Quit.Location = new Point(Width - Quit.Width - Height5, Height5);
            Back.Height = Height / 25;
            Back.Width = Height / 25;
            Back.Location = new Point(Height5, Height5);
            demandLabel.Height = Height / 10;
            demandLabel.Width = Width -Height/64;
            demandLabel.Location = new Point(Height5, HeightDivisor);
            realLabel.Height = HeightOver20;
            realLabel.Width = CentreScreen-Height5;
            realLabel.Location = new Point(Height5, 2*HeightDivisor);
            realInput.Width = CentreScreen-Height5;
            realInput.Location = new Point(10, 2 * HeightDivisor + Height10 + realLabel.Height);
            imaginaryLabel.Height = HeightOver20;
            imaginaryLabel.Width = CentreScreen -Height5;
            imaginaryLabel.Location = new Point(Width/2+Height5, 2 * HeightDivisor);
            imagInput.Width = CentreScreen -Height5;
            imagInput.Location = new Point(Width/2+Height5, 2 * HeightDivisor + Height10 + realLabel.Height);
            output.Height = HeightDivisor;
            output.Width = Width / 7;
            output.Location = new Point((Width - output.Width) / 2, 3 * HeightDivisor);

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void output_Click(object sender, EventArgs e)
        {
            int HeightDivisor = Height / 7;
                try
                {
                    Complex outputComplex = new Complex(Convert.ToDouble(realInput.Value), Convert.ToDouble(imagInput.Value));
                    outputLabel.Text = outputComplex.outputModulusArgument();
                outputLabel.Location = new Point((Width - outputLabel.Width) / 2, 5 * HeightDivisor);
                }
                catch
                {
                    MessageBox.Show("Error: This is not a valid input, please try again");
                }
        }
    }
}
