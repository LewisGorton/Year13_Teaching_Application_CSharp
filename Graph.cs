//Lewis
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace testForm
{
    public partial class Graph : Form
    {
        private const int CentreOfGraphScale = 2;
        private const double DrawCrossCoordinates = 0.2;
        private const double outOfRangeValue = 99999999999;
        private const int ScaleBase = 10;//Used to give the base that the graph is in.
        private int significantFigures;
        private int ScreenHeight = SystemInformation.VirtualScreen.Height;
        private int ScreenWidth = SystemInformation.VirtualScreen.Width;
        private int startingX = SystemInformation.VirtualScreen.Width / CentreOfGraphScale + 5 * SystemInformation.VirtualScreen.Height / 64;
        private int startingY = 2 * SystemInformation.VirtualScreen.Height / 7;
        private string typeOfGraph;
        List<double> Values = new List<double>();
        double ScalingFactor;
        public Graph()
        {
            InitializeComponent();
        }
        public Graph(double real1, double real2, double imag1, double imag2)
        {
            Values.Add(real1);
            Values.Add(real2);
            Values.Add(imag1);
            Values.Add(imag2);
            typeOfGraph = "MIDPOINT";
            InitializeComponent();
        }
        public Graph(double real,double imag)
        {
            Values.Add(real);
            Values.Add(imag);
            typeOfGraph = "DISPLAY";
            InitializeComponent();
        }
        public Graph(string graphType, double a, double b, double parameter)
        {
            Values.Add(a);
            Values.Add(b);
            Values.Add(parameter);
            typeOfGraph = graphType.ToUpper();
            InitializeComponent();
        }
        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            double Unit = Width / 22;
            Pen blackPen = new Pen(Brushes.Black,2);
            Pen redPen = new Pen(Brushes.Red,3);
            Font font = new Font("Microsoft Sans Serif",(int)(5*Unit/9-(MAL.Modulus(significantFigures-1))));
            SolidBrush brush = new SolidBrush(Color.Black);
            e.Graphics.DrawLine(blackPen, Width / CentreOfGraphScale, 0, Width / CentreOfGraphScale,  Height);
            e.Graphics.DrawLine(blackPen, 0, Height / CentreOfGraphScale, Width, Height / CentreOfGraphScale); 
            for(int i = 1; i<=21;i++)
            {
                if (i != 11)
                {
                    e.Graphics.DrawLine(blackPen, (float)(i * Unit +Unit/10), Height / CentreOfGraphScale - Height / 80, (float)(i * Unit+Unit/10), Height / CentreOfGraphScale + Height / 80);
                    e.Graphics.DrawLine(blackPen, Width / CentreOfGraphScale - Width / 80, (float)(i * Unit+Unit/10), Width / CentreOfGraphScale + Width / 80, (float)(i * Unit+Unit/10));
                }
            }
            int n = 1;
            for (int i = -10; i <= 10; i++)
            {
                PointF ImagAxis;
                PointF RealAxis;
                if (i % 2 == 0)
                {
                    ImagAxis = new PointF(Width / CentreOfGraphScale + Width / 55, (float)(Height - (n * Unit) - Unit / CentreOfGraphScale));
                    RealAxis = new PointF((float)(n * Unit - Unit / 3), Width / CentreOfGraphScale + Width / 125);
                }
                else
                {
                    RealAxis = new PointF((float)outOfRangeValue, (float)outOfRangeValue);
                    ImagAxis = new PointF((float)outOfRangeValue, (float)outOfRangeValue);
                }
                if(i==0)
                    ImagAxis = new PointF((float)outOfRangeValue, (float)outOfRangeValue);
                string number = Convert.ToString(i * ScalingFactor);
                e.Graphics.DrawString(number,font, brush, RealAxis);
                e.Graphics.DrawString(number, font, brush, ImagAxis);
                n++;
            }
            switch(typeOfGraph)
            {
                case "MIDPOINT":
                    Complex Coordinates1 = new Complex(Values[0], Values[2]);
                    Complex Coordinates2 = new Complex(Values[1], Values[3]);
                    Complex Midpoint = Complex.calculateMidpoint(Coordinates1, Coordinates2);
                    double Gradient = Complex.calculatePerpendicularGradient(Coordinates1, Coordinates2);
                    //Scale the graph to accept large and small values; also makes the coordinates relative to the centre of the graph.
                    //Scaling and drawing coordinates centrally is used later.
                    //Below is how the bisector is drawn.
                    e.Graphics.DrawLine(redPen, Width/2+(float)(Unit*(Midpoint.real/ScalingFactor - 22)), Width / CentreOfGraphScale - (float)(Unit*(Midpoint.imaginary / ScalingFactor - Gradient *22)), Width / CentreOfGraphScale + (float)(Unit*(Midpoint.real / ScalingFactor + 22)), Width / CentreOfGraphScale - (float)(Unit*(Midpoint.imaginary / ScalingFactor + Gradient *22)));
                    //Draws coordinates of complex numbers as crosses.
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Coordinates1.real / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Coordinates1.imaginary / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Coordinates1.real / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Coordinates1.imaginary / ScalingFactor + DrawCrossCoordinates)));
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Coordinates1.real / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Coordinates1.imaginary / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Coordinates1.real / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Coordinates1.imaginary / ScalingFactor - DrawCrossCoordinates)));
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Coordinates2.real / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Coordinates2.imaginary / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Coordinates2.real / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Coordinates2.imaginary / ScalingFactor + DrawCrossCoordinates)));
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Coordinates2.real / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Coordinates2.imaginary / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Coordinates2.real / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Coordinates2.imaginary / ScalingFactor - DrawCrossCoordinates)));
                    break;
                case "HALFLINE":
                    Complex endCoordinates = new Complex(32, Values[2], true);//Creates a new complex number with the same argument and a modulus outside the graph.
                    //Draws the halfline.
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * Values[0]/ScalingFactor), Width / CentreOfGraphScale - (float)(Unit * Values[1]/ScalingFactor), Width / CentreOfGraphScale + (float)(Unit*(endCoordinates.real+Values[0]/ScalingFactor)), Width / CentreOfGraphScale - (float)(Unit*(endCoordinates.imaginary+Values[1]/ScalingFactor)));
                    //Draws starting coordinates of complex number as a cross.
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor + DrawCrossCoordinates)));
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor - DrawCrossCoordinates)));
                    break;
                case "CIRCLE":
                    try
                    {
                        //The radius must be subtracted from a for x and added to b for y as DrawPie uses (x,y) as coordinates of top left corner of the square surrounding the circle. 
                        e.Graphics.DrawPie(redPen, Width / CentreOfGraphScale + (float)(Unit * (Values[0] - Values[2]) / ScalingFactor), Width / CentreOfGraphScale - (float)(Unit * (Values[1] + Values[2]) / ScalingFactor), (float)(Unit * Values[2] * 2 / ScalingFactor), (float)(Unit * 2 * Values[2] / ScalingFactor), 360, 360);//diameter = 2*radius.
                        //Draws centre as a cross
                        e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor + DrawCrossCoordinates)));
                        e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor - DrawCrossCoordinates)));
                    }
                    catch
                    {
                        MessageBox.Show("Error: The circle must have a positive radius");
                    }
                    break;
                case "DISPLAY":
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale, Width / CentreOfGraphScale, Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor)));
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor + DrawCrossCoordinates)));
                    e.Graphics.DrawLine(redPen, Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor - DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale + (float)(Unit * (Values[0] / ScalingFactor + DrawCrossCoordinates)), Width / CentreOfGraphScale - (float)(Unit * (Values[1] / ScalingFactor - DrawCrossCoordinates)));
                    break;
            }
        }
        private void Graph_Load(object sender, EventArgs e)
        {
            Width = ScreenWidth / CentreOfGraphScale -ScreenHeight/4;
            Height = Width;
            Location = new Point(startingX, startingY);
            double[] scalingTest = new double[2];
            double scalingTrial;
            switch(typeOfGraph)
            { 
                case "MIDPOINT":
                   scalingTest[0] = Values.Max();
                   scalingTest[1] = MAL.Modulus(Values.Min());
                   scalingTrial = scalingTest.Max();
                   significantFigures = MAL.Exponent(scalingTrial, ScaleBase);
                   ScalingFactor = MAL.Power(ScaleBase, significantFigures);
                break;
                case "HALFLINE":
                    scalingTest[0] = MAL.Modulus(Values[0]);
                    scalingTest[1] = MAL.Modulus(Values[1]);
                    scalingTrial = scalingTest.Max();
                    significantFigures = MAL.Exponent(scalingTrial, ScaleBase);
                    ScalingFactor = MAL.Power(ScaleBase, significantFigures);
                break;
                case "CIRCLE":
                    scalingTest[0] = MAL.Modulus(Values[0]);
                    scalingTest[1] = MAL.Modulus(Values[1]);
                    scalingTrial = scalingTest.Max()+Values[2];
                    significantFigures = MAL.Exponent(scalingTrial, ScaleBase);
                    ScalingFactor = MAL.Power(ScaleBase, significantFigures);
                break;
                case "DISPLAY":
                    scalingTest[0] = MAL.Modulus(Values[0]);
                    scalingTest[1] = MAL.Modulus(Values[1]);
                    scalingTrial = scalingTest.Max();
                    significantFigures = MAL.Exponent(scalingTrial, ScaleBase);
                    ScalingFactor = MAL.Power(ScaleBase, significantFigures);
                break;
            }
        }
    }
}