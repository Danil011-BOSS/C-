using System;

namespace ConsoleApp17
{
    class Triangle3 : ISquare2, IPerimeter3
    {
        private double a, b, c;

        public Triangle3(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Square()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Perimeter()
        {
            return a + b + c;
        }
    }
}