using System;
using System.Reflection.Metadata.Ecma335;

namespace Algorithmic.Regular
{
    public class CalculationOutput
    {
        public void Calculation1()
        {
            int x = 4, b = 2;
            x -= b /= x * b;
            Console.WriteLine(x + " " + b);
            Console.ReadLine();
        }

        public void Calculation2()
        {
            int x = 8;
            int b = 16;
            int c = 64;
            x /= c /= b;
            Console.WriteLine(x + " " + b + " " + c);
            Console.ReadLine();
        }

        public void Calculation3(int ii, double kk)
        {
            double j = ii + kk;
            Console.WriteLine(j);
        }

        public void Calculation4(int ii, double kk)
        {
            double j = ii - kk;
            Console.WriteLine(j);
        }
    }
}
