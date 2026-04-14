using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3435
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обобщенный класс как обобщенный тип");
            Game<Person2<int>> gm1 = new Game<Person2<int>>("КГАСУ",
            new Person2<int>("Иванов", 123));
            Console.WriteLine("Организация участника {0}, фамилия {1},
            информация { 2}
            ", gm1.Company, gm1.Member.Name,
gm1.Member.Info);
        }
    }
}
