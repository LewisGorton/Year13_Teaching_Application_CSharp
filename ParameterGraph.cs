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
    public partial class ParameterGraph : Form
    {
        private string typeOfGraph;
        Graph graph = new Graph();
        public ParameterGraph()
        {
            InitializeComponent();
        }
        public ParameterGraph(string graphType)
        {
            typeOfGraph = graphType.ToUpper();
            InitializeComponent();
        }
        private void Halfline_Load(object sender, EventArgs e)
        {
            Height = SystemInformation.VirtualScreen.Height;
            Width = SystemInformation.VirtualScreen.Width;
            int QuitBackDimensions = Height / 25;
            int QuitBackStart = 5;
            int Height10 = Height / 128;
            int HeightOver20 = Height / 20;
            int ScreenDivisor = Height / 7;
            int StartX = 3;
            Quit.Height = QuitBackDimensions;
            Quit.Width = QuitBackDimensions;
            Quit.Location = new Point(Width - Quit.Width - QuitBackStart, QuitBackStart);
            Back.Height = QuitBackDimensions;
            Back.Width = QuitBackDimensions;
            Back.Location = new Point(QuitBackStart, QuitBackStart);
            demandLabel.Height = Height / 10;
            demandLabel.Width = Width - 20;
            demandLabel.Location = new Point(5, ScreenDivisor);
            int LabelInputHeight = HeightOver20;
            aLabel.Height = LabelInputHeight;
            aInput.Height = LabelInputHeight;
            bLabel.Height = LabelInputHeight;
            bInput.Height = LabelInputHeight;
            parameterLabel.Height = LabelInputHeight;
            parameterInput.Height = LabelInputHeight;
            int LabelInputWidth = (Width / StartX) - 9;
            aLabel.Width = LabelInputWidth;
            aInput.Width = LabelInputWidth;
            bLabel.Width = LabelInputWidth;
            bInput.Width = LabelInputWidth;
            parameterLabel.Width = LabelInputWidth;
            parameterInput.Width = LabelInputWidth;
            graphButton.Width = Width / 4;
            graphButton.Height = LabelInputHeight;
            aLabel.Location = new Point(StartX, 2 * ScreenDivisor);
            aInput.Location = new Point(StartX, 2 * ScreenDivisor + HeightOver20 + Height10);
            bLabel.Location = new Point(StartX, Height / 2);
            bInput.Location = new Point(StartX, Height / 2 + HeightOver20 + Height10);
            parameterLabel.Location = new Point(StartX, 5 * ScreenDivisor);
            parameterInput.Location = new Point(StartX, 5 * ScreenDivisor + HeightOver20 + Height10);
            graphButton.Location = new Point(Height / 256, 6 * ScreenDivisor);
            switch(typeOfGraph)
            {
                case "HALFLINE":
                    demandLabel.Text = "Please input your values of a, b, and θ:";
                    parameterLabel.Text = "θ:";
                    break;
                case "CIRCLE":
                    demandLabel.Text = "Please input your values of a, b, and r:";
                    parameterLabel.Text = "r:";
                    break;
            }
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
            graph = new Graph(typeOfGraph, (double)aInput.Value, (double)bInput.Value, (double)parameterInput.Value);
            graph.Show();
        }

    }
}