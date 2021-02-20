//Lewis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace testForm
{
    class Complex
    {
        private const int InstantiationDecimals = 13;
        private const int OutputDecimals = 4;
        private const double errorMargin = 0.00000000001;
        public double real, imaginary, modulus, argument;
        public Complex()
        {
            real = 0;
            imaginary = 0;
            modulus = 0;
            argument = 0;
        }
        public Complex(double r, double i)
        {
            real = MAL.Round(r,InstantiationDecimals);
            imaginary = MAL.Round(i,InstantiationDecimals);
            modulus = MAL.Round(getModulus(),InstantiationDecimals);
            argument = MAL.Round(getArgument(),InstantiationDecimals);
        }
        public Complex(double m, double a, bool w)//Constructive method for modulus argument.
        {
            argument = MAL.Round(a,InstantiationDecimals);
            modulus = MAL.Round(m,InstantiationDecimals);
            real = MAL.Round((m * MAL.Cos(a)),InstantiationDecimals);
            imaginary = MAL.Round((m * MAL.Sin(a)),InstantiationDecimals);
        }
        public string outputModulusArgument()
        {
            string modulusArgument = Convert.ToString(MAL.Round(modulus,OutputDecimals)) + "(cos" + Convert.ToString(MAL.Round(argument,OutputDecimals)) + " + isin" + Convert.ToString(MAL.Round(argument, OutputDecimals)) + ")";
            return (modulusArgument);
        }
        public string outputRealImaginary()
        {
            string realImag;
            if(imaginary<0)
                realImag = Convert.ToString(MAL.Round(real, OutputDecimals)) + Convert.ToString(MAL.Round(imaginary,OutputDecimals)) + "i";
            else
                realImag = Convert.ToString(MAL.Round(real, OutputDecimals)) + " + " + Convert.ToString(MAL.Round(imaginary, OutputDecimals)) + "i";
            return (realImag);
        }
        public double getModulus()
        {
            double square = MAL.Power(real,2) + MAL.Power(imaginary,2);
            double complement = MAL.SquareRoot(square, InstantiationDecimals);
            return (complement);
        }
        public double getArgument()
        {
            double Pi = MAL.Pi();
            if(real==0)
            {
                if (imaginary < 0)
                    return (-Pi/ 2);
                else if (imaginary > 0)
                    return (Pi / 2);
                else
                    return (0);
            }
            double x = MAL.Modulus(imaginary / real);
            double angle = MAL.Arctan(x);
            if (real < 0 && imaginary < 0)
                angle = angle - Pi;
            else if (real < 0)
                angle = Pi - angle;//This is the part that has changed - the geometry is now correct.
            else if (imaginary < 0)
                angle = -angle; 
            return (angle);
        }
        private static Complex multiplyAndDivide(Complex x, Complex y, bool division)
        {
            double pi = MAL.Pi();
            double resultantModulus;
            double resultantArgument;
            if (division)
            {
                resultantModulus = x.modulus / y.modulus;
                resultantArgument = x.argument - y.argument;
            }
            else//This occurs when division is false
            {
                resultantModulus = x.modulus * y.modulus;
                resultantArgument = x.argument + y.argument;
            }
            if (resultantArgument > pi)
                resultantArgument -= 2 * pi;
            if (resultantArgument < -pi)
                resultantArgument += 2 * pi;
            Complex resultantNumber = new Complex(resultantModulus, resultantArgument, true);
            return (resultantNumber);
        }
        public static Complex operator *(Complex x, Complex y)
        {
            return (multiplyAndDivide(x, y, false));
        }
        public static Complex operator /(Complex x, Complex y)
        {
            return (multiplyAndDivide(x, y, true));
        }
        public static Complex operator +(Complex x, Complex y)
        {
            double resultantReal = x.real + y.real;
            double resultantImaginary = x.imaginary + y.imaginary;
            return (new Complex(resultantReal, resultantImaginary));
        }
        public static Complex operator -(Complex x, Complex y)
        {
            double resultantReal = x.real - y.real;
            double resultantImaginary = x.imaginary - y.imaginary;
            return (new Complex(resultantReal, resultantImaginary));
        }
        public static double calculatePerpendicularGradient(Complex x, Complex y)
        {
            if (x.real - y.real == 0)
                return (0);
            if (x.imaginary - y.imaginary < errorMargin&&x.imaginary-y.imaginary>-errorMargin)
                return (9999);
            double m = (x.imaginary - y.imaginary) / (x.real - y.real);//Calculates gradient of the line connecting the first complex number to the next.
            return (-1/m);//Applies the formula to calculate the gradient of the line that is perpendicular to another line with a known gradient.
        }
        public static Complex calculateMidpoint(Complex x, Complex y)
        {
            double resultantReal = (x.real + y.real) / 2;
            double resultantImaginary = (x.imaginary + y.imaginary) / 2;
            return (new Complex(resultantReal, resultantImaginary));
        }
    }
}