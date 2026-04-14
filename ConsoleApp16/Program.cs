using System;

namespace ConsoleApp16
{

    class Program
    {

        static void Main(string[] args)
        {
            Figure f1, f2;
            f1 = new Triangle(3, 4, 5);
            f2 = new Rectangle(2, 6);
            Console.WriteLine(f1.Perimeter() + ", " + f1.Square());
            Console.WriteLine(f2.Perimeter() + ", " + f2.Square());


        }
    }
}