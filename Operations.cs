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
    public partial class Operations : Form
    {
        string typeOfOperation;
        public Operations()
        {
            InitializeComponent();
        }
        public Operations(string operationType)
        {
            typeOfOperation = operationType.ToUpper();
            InitializeComponent();
        }
        private void Divide_Load(object sender, EventArgs e)
        {
            Height = SystemInformation.VirtualScreen.Height;
            Width = SystemInformation.VirtualScreen.Width;
            int Height5 = Height / 256;
            int Height10 = Height / 128;
            int HeightDivisor = Height/7;
            int CentreScreen = Width / 2;
            int HeightOver20 = Height / 20;
            Quit.Height = Height / 25;
            Quit.Width = Height / 25;
            Quit.Location = new Point(Width - Quit.Width -Height5, Height5);
            Back.Height = Height / 25;
            Back.Width = Height / 25;
            Back.Location = new Point(Height5, Height5);
            demandLabel.Height = Height / 10;
            demandLabel.Width = Width - Height5;
            demandLabel.Location = new Point(Height5, HeightDivisor);
            realLabel1.Height = HeightOver20;
            realLabel1.Width = (CentreScreen -Height5) / 2;
            realLabel1.Location = new Point(Height5, 2 * HeightDivisor);
            realLabel2.Height = HeightOver20;
            realLabel2.Width = (CentreScreen -Height5) / 2;
            realLabel2.Location = new Point((Width +Height10) / 2, 2 * HeightDivisor);
            realInput1.Width = (CentreScreen -Height5) / 2;
            realInput1.Location = new Point(Height5, 2 * HeightDivisor +Height10 + realLabel1.Height);
            realInput2.Width = (CentreScreen -Height5) / 2;
            realInput2.Location = new Point((Width +Height10) / 2, 2 * HeightDivisor +Height10 + realLabel1.Height);
            imaginaryLabel1.Height = HeightOver20;
            imaginaryLabel1.Width = (CentreScreen -Height5) / 2;
            imaginaryLabel1.Location = new Point((CentreScreen +Height10) / 2, 2 * HeightDivisor);
            imaginaryLabel2.Height = HeightOver20;
            imaginaryLabel2.Width = (CentreScreen -Height5) / 2;
            imaginaryLabel2.Location = new Point(3 * (CentreScreen) / 2 + Height5, 2 * HeightDivisor);
            imagInput1.Width = (CentreScreen -Height5) / 2;
            imagInput1.Location = new Point((CentreScreen +Height10) / 2, 2 * HeightDivisor +Height10 + realLabel1.Height);
            imagInput2.Width = (CentreScreen -Height5) / 2;
            imagInput2.Location = new Point(3 * (CentreScreen) / 2 + 5, 2 * HeightDivisor +Height10 + realLabel1.Height);
            realButton.Width = CentreScreen;
            realButton.Height = Height / 14 - Height / 256;
            realButton.Location = new Point(Width/25, 3 * HeightDivisor);
            modulusButton.Width = CentreScreen;
            modulusButton.Height = Height / 14 - Height5;
            modulusButton.Location = new Point(Width/25, Height / 2);
            output.Height = HeightDivisor;
            output.Width = Width / 7;
            outputLabel.Width = Width;
            output.Location = new Point(24 * (Width - output.Width) / 25, 3 * HeightDivisor);
            demandLabel.Text = "Input the complex numbers to " + typeOfOperation.ToLower()+":";
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
                Complex complex1 = new Complex(Convert.ToDouble(realInput1.Value), Convert.ToDouble(imagInput1.Value));
                Complex complex2 = new Complex(Convert.ToDouble(realInput2.Value), Convert.ToDouble(imagInput2.Value));
                Complex outputComplex;
                switch (typeOfOperation)
                {
                    case "DIVIDE":
                        outputComplex = complex1 / complex2;
                        break;
                    case "MULTIPLY":
                        outputComplex = complex1 * complex2;
                        break;
                    case "ADD":
                        outputComplex = complex1 + complex2;
                        break;
                    case "SUBTRACT":
                        outputComplex = complex1 - complex2;
                        break;
                    default:
                        outputComplex = new Complex(0, 0);
                        break;
                }
                if (modulusButton.Checked == true)
                {
                    outputLabel.Text = outputComplex.outputModulusArgument();
                }
                if (realButton.Checked == true)
                {
                    outputLabel.Text = outputComplex.outputRealImaginary();
                }
                outputLabel.Location = new Point((Width - outputLabel.Width) / 2, 5 * HeightDivisor);
            }
            catch
            {
                MessageBox.Show("Error: This is not a valid input, please try again.");
            }
        }
    }
}
