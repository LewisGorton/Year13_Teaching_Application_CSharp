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
    public partial class DisplayComplex : Form
    {
        
        Graph graph = new Graph();
        public DisplayComplex()
        {
            InitializeComponent();
        }
        private void DisplayComplex_Load(object sender, EventArgs e)
        {
            Height = SystemInformation.VirtualScreen.Height;
            //Cannot be constant as width and height changes.
            int BackQuitDimensions = Height / 25;
            int ComponentsHeight = Height / 20;
            int ComponentsWidth = (Width / 3) - 9;
            int BackQuitLocationStart = Height / 240;
            Width = SystemInformation.VirtualScreen.Width;
            Quit.Height = BackQuitDimensions;
            Quit.Width = BackQuitDimensions;
            Quit.Location = new Point(Width - Quit.Width - BackQuitLocationStart, BackQuitLocationStart);
            Back.Height = BackQuitDimensions;
            Back.Width = BackQuitDimensions;
            Back.Location = new Point(BackQuitLocationStart, BackQuitLocationStart);
            demandLabel.Height = Height / 18;
            demandLabel.Width = Width - 2 * Height / 128;
            demandLabel.Location = new Point(BackQuitLocationStart, Height / 7);
            realLabel.Height = ComponentsHeight;
            realInput.Height = ComponentsHeight;
            imagLabel.Height = ComponentsHeight;
            imagInput.Height = ComponentsHeight;

            realLabel.Width = ComponentsWidth;
            realInput.Width = ComponentsWidth;
            imagLabel.Width = ComponentsWidth;
            imagInput.Width = ComponentsWidth;

            displayButton.Width = Width / 4;
            displayButton.Height = ComponentsHeight;
            int LabelInputX = 3;
            realLabel.Location = new Point(LabelInputX, 2 * Height / 7);
            realInput.Location = new Point(LabelInputX, 2 * Height / 7 + ComponentsHeight + Height / 128);
            imagLabel.Location = new Point(LabelInputX, Height / 2);
            imagInput.Location = new Point(LabelInputX, Height / 2 + ComponentsHeight + Height / 128);

            displayButton.Location = new Point(Height/256, 5 * Height / 7);
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            graph.Close();
        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            graph.Close();
            graph = new Graph((double)realInput.Value, (double)imagInput.Value);
            graph.Show();
        }

    }
}
