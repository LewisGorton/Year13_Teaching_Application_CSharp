namespace testForm
{
    static class MAL
    {
        //Round is used a lot in this class compared to in my pseudocode as I did not anticipate overflow occurring for datatype double.
        //I also occasionally use datatype long where it was datatype Int in my pseudocode to again avoid overflow.
        //This is also true for my Complex class.
        private const double errorMargin = 0.00000000000001;//The value to which values are considered to be approximately the same. Used throughout this code.
        private const int TrigonometricDecimals = 13;
        public static double Pi()//Calculates Pi everytime it is called to 14 significant figures.
        {
            const int PiDecimals = 14;//Used to return the value of Pi to 14 decimal places.
            const int chudnovsky1 = 426880;//Both are used for the numerator of the Chudnovsky algorithm./
            const int chudnovsky2 = 10005;
            double numerator = chudnovsky1 * SquareRoot(chudnovsky2, PiDecimals);//Numerator in Chudnovsky series is constant so only needs to be calculated once.
            double Denominator = calcPi(0);//Denominator is produced from a convergence series.
            return (Round(numerator / Denominator, PiDecimals));//Rounds to 14 significant figures.
        }
        private static double calcPi(int k)//Uses Chudnovsky series for approximating pi to a large number of decimal places.
        {
            //Constants below are used for the Chudnovsky algorithm and correspond to the long numbers that are required in the sum on the denominator.
            const int chudnovsky1 = 545140134;
            const int chudnovsky2 = 13591409;
            const long chudnovsky3 = -262537412640768000;
            double estValue = Factorial(6 * k) * (chudnovsky1 * k + chudnovsky2) / (Factorial(3 * k) * Power(Factorial(k), 3) * Power(chudnovsky3, k));
            double compValue = Factorial(6 * (k + 1)) * (chudnovsky1 * (k + 1) + chudnovsky2) / (Factorial(3 * (k + 1)) * Power(Factorial(k + 1), 3) * Power(chudnovsky3, k + 1));//compValue is the next value that would be calculated by this subroutine.
            if (estValue - compValue < errorMargin && estValue - compValue > -errorMargin)//If the values are within the errorMargin return the estValue because this is close enough to the next value to be considered approximated well enough.
                return (estValue + compValue);
            else
                return (estValue + calcPi(k + 1));//Continues algorithm until estValue and compValue are within the errorMargin.
        }
        public static double Round(double n, int dp)//Rounds by taking a value of n and the number of decimal places that it needs to be rounded to as parameters.
        {
            int Base = 10;
            //First two lines gets rid of all the unnecessary decimal places after dp+1 and converts n to an integer with all the necessary decimal places now before the decimal point.
            n = n * Power(Base, dp + 1);
            //The line of code below avoid any problems with rounding a negative number e.g. -1.6 would have rounded to -1 with this line of code
            //as -16 % 10 = -6 < 5.
            double absoluteN = Modulus(n);
            double test = absoluteN % Base;
            if (test < 5)
                absoluteN -= test;//Rounds down so the last digit is zero.
            else
                absoluteN += (Base - test);//Rounds up so the 2nd to last digit is incremented and the last digit is zero.
            double newNumber;
            newNumber = absoluteN * Power(Base, -(dp + 1));//The number is now divided by 10 to the power of dp+1 so the number has the number of decimal places equal to dp and it is rounded.
            if (n < 0)
                return (-newNumber);
            return (newNumber);//Returns rounded number.
        }
        public static double Power(double n, int power)//Calculates the value of a number to a certain integer power.
        {
            if (n == 0)
                return (0);//0 to any exponent apart from 0 is itself; 0^0 is undefined so this will return a default value of 0.
            double returnValue;
            double newNumber = 1;
            if (power < 0)//Calculates the number to a negative exponent.
            {
                for (int i = 0; i > power; i--)//Recognise that power<0 so i must be decremented for the for loop to work.
                {
                    newNumber = newNumber * n;//Calculates n to the magnitude of the power.
                }
                returnValue = 1 / newNumber;//This is because the number to a negative power is equal to the reciprocal of the number to the magnitude of the power.
            }
            else if (power > 0)
            {
                for (int i = 0; i < power; i++)
                {
                    newNumber = newNumber * n;//Continues to multiply n by itself the power number of times.
                }
                returnValue = newNumber;
            }
            else
                returnValue = 1;//If power = 0 then (apart from n = 0) n^0 = 1.
            return (returnValue);
        }
        public static double Arctan(double x)//Calculates a value of arctan for any given double value.        
        {
            double pi;
            double angle;
            if (x > 0.5 || x < -0.5)
            { if (x < 0)
                    return (-Arctan(-x));
              else
                    return (Arctan(0.5) + Arctan((x - 0.5) / (1 + 0.5 * x)));
            }
            pi = Pi();
            if (x == 1 || x == -1)
                angle = x * (pi / 4);//Arctan(1) = Pi/4, Arctan(-1)=-Pi/4.         
            else if (x > 1 || x < -1)
                angle = (pi / 2) - Arctan(1 / x);//To do with geometry of a right-angled triangle - the angle is the other non-right-angle subtracted from Pi/2.
            else if (x > 0.5 || x < -0.5)
            {
                if (x < 0)
                    return (-Arctan(-x));
                else return (Arctan(0.5) + Arctan((x - 0.5) / (1 + 0.5 * x)));
            }
            else angle = calcArctan(x, 0);
            //For values in the acceptance region i.e. greater than -1 and less than 1, the value of arctan is the Macluarin series for that value of x.       
            return (Round(angle, TrigonometricDecimals));
        }
        private static double calcArctan(double x, int n)//Performs the Macluarin's series for arctan.
        {
            double estValue = Power(-1, n) * Power(x, 2 * n + 1);//Calculates the denominator for the current iteration.
            int estDenominator = 2 * n + 1;//Calculates the denominator for the current iteration.
            double compValue = -1 * estValue * Power(x, 2);//Calculates what would the next value for the numerator.
            int compDenominator = estDenominator + 2;//Caclculates what would be the next value for the denominator.
            estValue = estValue / estDenominator;//Calculates current term in the series.
            compValue = compValue / compDenominator;//Calculates next term in the series.
            if (estValue + compValue < errorMargin && estValue + compValue > -errorMargin)//If the current value and next value are approximately the same, return the current value.
                return (estValue + compValue);
            else
                return (estValue + calcArctan(x, n + 1));//Repeats algorithm until the values are approximately the same.
        }
        public static double Cos(double x)//Calculates a value for cos for a double input.
        {
            //Maclaurin series is not required as we have the trigonometric identity where cos(x) = the square root of 1-the square of sin(x)
            double returnValue = Sin(x + Pi() / 2);//Cosine is just a translation of Pi/2 to the left i.e. vector of (-Pi/2,0). This means that we can add Pi/2 to the value of x and pass this as a parameter to the Sin function.
            return (returnValue);
        }
        public static double Sin(double x)//Calculates a value of sin for a double input.
        {
            //The first part of this method is based on the graph of y = sin(x) and its periodic behaviour can be manipulated.
            //Maclurin's series only converges in tractable time for -Pi/2<x<Pi/2 so this is to get the value of x in that range that still gives the same value of sine(original x). This is due to the cyclic nature of the sine graph.
            double pi = Pi();
            while (x > 1.5 * pi)//This is to get the value of x in the range -2Pi<x<2Pi as the values of sin(x) is the same as whatever sin(new value of x is) due to the cyclic nature of sine.
            {
                x -= 2 * pi;
            }
            while (x < -1.5 * pi)//This is the same as above but for negative values of x.
            {
                x += 2 * pi;
            }
            if (x > pi / 2)
                x = pi - x;//This is due to the symmetry of the sine graph along the line x=Pi/2 for -Pi/2<x<3Pi/2, hence we can get x in the tractable range if we do this.
            else if (x < -pi / 2)
                x = -x - pi;//This is due to the symmetry of the sine graph along the line x = -Pi/2 for -3Pi/2<x<Pi/2, hence we can get x in the tractable range.
            return (Round((calcSin(x, 0)), TrigonometricDecimals));//Starts the Maclaurin's series for Sine with n=0 i.e. starting case and the value of x. Rounds this value to 8 decimal places.
        }
        private static double calcSin(double x, int n)//Recursive algorithm that uses Maclaurin's series for sine.
        {
            double estValue = Power(-1, n) * Power(x, 2 * n + 1);
            long estDenominator = Factorial(2 * n + 1);
            double compValue = -1 * estValue * Power(x, 2);
            long compDenominator = estDenominator * (2 * (n + 1) + 1);//compDenominator is what the estDenomninator would be in the next iteration for this recursive algorithm which is (2(n+1)+1)! = (2(n+1)+1)*(2n+1)! and estDenominator = (2n+1)! so compDenominator = 2*(n+1)+1*estDenominator.
            estValue = estValue / estDenominator;
            compValue = compValue / compDenominator;
            if (estValue - compValue < errorMargin && estValue - compValue > -errorMargin)
                return (estValue + compValue);
            else
                return (estValue + calcSin(x, n + 1));//Recalls the calcSin algorithm if the answer is not within the error margin.
        }
        public static double SquareRoot(double x, int dp)//Calculate the square root of an input to a specified number of decimal places.
        {
            return (Round(getSquareRoot(x, 1), dp));//Starts the recursive algorithm that converges to the square root of the input. This begins with an original guess of 1. bThis then returns the rounded value to the specified number of decimal places.
        }
        private static double getSquareRoot(double x, double guess)//Recursive algorithm that converges to the square root of the inputted number.
        {
            double newGuess = (guess + (x / guess)) / 2;//Closer to the value of the square root of the numbers than the first guess.
            if ((newGuess - guess < errorMargin) && (newGuess - guess > -errorMargin))//If these guesses are close enough then the value of the newGuess is assumed to be close enough to the value of the square root.
                return (newGuess);
            else
                return (getSquareRoot(x, newGuess));//If the values are not close enough then this function is repeated until we have a value that is close enough to the square root of the value.
        }
        public static long Factorial(long n)//Function used to calculate the factorial value of a number.
        {
            if (n <= 1)
                return (1);//Default error value: 0! = 1! = 1 and (-n)! is undefined for n>0 so if the number is negative a default error value of 1 is returned.
            return (n * Factorial(n - 1));
        }
        public static int Exponent(double Dividend, double Divisor)//Used to calculate the exponent of a number with respect to another number e.g. the exponent of 5000 with respect to 10 is 3 as 5000 = 5x10^3.
        {
            int exponent = 0;
            if (Dividend <= 0)
                return (0);
            if (Dividend > 1)
            {
                for (double d = Dividend; d >= Divisor; d /= Divisor)
                {
                    exponent++;
                }
            }
            else
            {
                for (double d = Dividend; d < 1; d *= Divisor)
                {
                    exponent--;
                }
            }
            return (exponent);
        }
        public static double Modulus(double n)//Calculates magnitude of the number being passed to it e.g. the result of n=-5 would be 5.
        {
            if (n < 0)
                return (-n);
            else
                return (n);
        }
    }
}