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
    public partial class Midpoint : Form
    {
        Graph graph = new Graph();
        public Midpoint()
        {
            InitializeComponent();
        }
        private void Midpoint_Load(object sender, EventArgs e)
        {
            int LabelInputHeight = Height /20;
            int QuitBackDimensions = Height / 25;
            int LabelInputWidth = 2 * Width / 5 - Height / 256;
            int HeightDivider = Height / 7;
            int Height5 = Height / 256;
            int Height10 = Height / 128;
            Height = SystemInformation.VirtualScreen.Height;
            Width = SystemInformation.VirtualScreen.Width;
            Quit.Height = QuitBackDimensions;
            Quit.Width = QuitBackDimensions;
            Quit.Location = new Point(Width - Quit.Width -Height5, Height5);
            Back.Height = QuitBackDimensions;
            Back.Width = QuitBackDimensions;
            Back.Location = new Point(Height5, Height5);
            demandLabel.Width = 2*Width/5;
            demandLabel.Height = HeightDivider;
            demandLabel.Location = new Point((Width - demandLabel.Width) / 2, Height / 10);
            realLabel1.Height = LabelInputHeight;
            realLabel1.Width = (LabelInputWidth);
            realLabel2.Height = LabelInputHeight;
            realLabel2.Width = (LabelInputWidth);
            realInput1.Width = (LabelInputWidth);
            realInput1.Height= LabelInputHeight;
            realInput2.Width = (LabelInputWidth);
            realInput1.Height = LabelInputHeight;
            imaginaryLabel1.Height = LabelInputHeight;
            imaginaryLabel1.Width = (LabelInputWidth);
            imaginaryLabel2.Height = LabelInputHeight;
            imaginaryLabel2.Width = (LabelInputWidth);
            imagInput1.Width = (LabelInputWidth);
            imagInput1.Height = LabelInputHeight;
            imagInput2.Width = (LabelInputWidth);
            imagInput2.Height= LabelInputHeight;
            graphButton.Width = Width / 4;
            graphButton.Height = LabelInputHeight;
            realInput1.Location = new Point(Height5, 2 * HeightDivider + realLabel1.Height + Height10);
            realLabel1.Location = new Point(Height5, 2 * HeightDivider);
            imagInput1.Location = new Point(Height5, 3 * HeightDivider + realLabel1.Height + Height10);
            imaginaryLabel1.Location = new Point(Height5, 3 * HeightDivider);
            realInput2.Location = new Point(Height5, 4 * HeightDivider + realLabel1.Height + Height10);
            realLabel2.Location = new Point(Height5, 4 * HeightDivider);
            imagInput2.Location = new Point(Height5, 5 * HeightDivider + realLabel1.Height + Height10);
            imaginaryLabel2.Location = new Point(Height5, 5 * HeightDivider);
            graphButton.Location = new Point(Height5, 6 * HeightDivider);
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

        private void graphButton_Click(object sender, EventArgs e)
        {
            graph.Close();
            graph = new Graph((double)realInput1.Value, (double)realInput2.Value, (double)imagInput1.Value, (double)imagInput2.Value);
            graph.Show();
        }
    }
}
