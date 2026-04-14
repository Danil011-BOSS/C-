using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void F<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

        static void G<T>(T x) where T : Person1
        {
            Console.WriteLine("Фамилия {0}, информация {1}",
            x.Name, x.Info);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Обобщенный метод");
            int a = 5;
            int b = 7;
            F<int>(ref a, ref b);
            Console.WriteLine("Для чисел a = {0}, b = {1}", a, b);
            string u = "Tom";
            string v = "Bob";
            F<string>(ref u, ref v);
            Console.WriteLine("Для строк u = {0}, v = {1}", u, v);
            char s = 'x';
            char t = 'y';
            F<char>(ref s, ref t);
            Console.WriteLine("Для символов s = {0}, t = {1}", s, t);
            bool p = true;
            bool q = false;
            F<bool>(ref p, ref q);
            Console.WriteLine("Для логического типа p = {0}, q = {1}",
            p, q);



            Console.WriteLine("\n Использование первого класса");
            PersonId1<string> prid1 =
            new PersonId1<string>("Иванов", "123", 321);
            Console.WriteLine("До преобразования info = {0}",
            prid1.Info);
            prid1.Info = prid1.Info + 1;
            Console.WriteLine("После преобразования info = {0}",
            prid1.Info);


            Console.WriteLine("\n Использование второго класса");
            PersonId2<string> prid2 =
            new PersonId2<string>("Иванов", "123", "321");
            Console.WriteLine("До преобразования info = {0}, id ={1}", prid2.Info, prid2.Id);
            prid2.Info = prid2.Info + 1;
            prid2.Id = prid2.Id + 1;
            Console.WriteLine("После преобразования info = {0},id = {1}", prid2.Info, prid2.Id);


            Console.WriteLine("\n Использование третьего класса");
            PersonId3 prid3 = new PersonId3("Иванов", 'g', "321");
            Console.WriteLine("До преобразования info = {0}, id ={1}", prid3.Info, prid3.Id);
            prid3.Info = (char)(prid3.Info + 1);
            prid3.Id = prid3.Id + 1;
            Console.WriteLine("После преобразования info = {0},id = {1}", prid3.Info, prid3.Id);


            Console.WriteLine("\n Использование четвертого класса");
            PersonId4<int> prid4 =
            new PersonId4<int>("Иванов", 'g', 321);
            Console.WriteLine("До преобразования info = {0}, id ={1}", prid4.Info, prid4.Id);
            prid4.Info = (char)(prid4.Info + 1);
            prid4.Id = prid4.Id + 1;
            Console.WriteLine("После преобразования info = {0},id = {1}", prid4.Info, prid4.Id);


            Console.WriteLine("\n Использование пятого класса");
            PersonId5<int, string> prid5 =
            new PersonId5<int, string>("Иванов", 123, "321");
            Console.WriteLine("До преобразования info = {0},id = {1}", prid5.Info, prid5.Id); prid5.Info = prid5.Info + 1;
            prid5.Id = prid5.Id + 1;
            Console.WriteLine("После преобразования info = {0},id = {1}", prid5.Info, prid5.Id);


            Console.WriteLine("\n Использование ограничений наклассы");
            Game1 < Person1 > gm2 = new Game1<Person1>("КГАСУ",new Person1("Иванов", 123));
            gm2.PrName();

            Game1<PersonId> gm3 = new Game1<PersonId>("КГАСУ",new PersonId("Петров", "345", 567));
            gm3.PrName();

            Console.WriteLine("\n Использование ограничений наметоды");
            Person1 pr14 = new Person1("Николаев", 423);
            PersonId pr15 = new PersonId("Михайлов", "543", 678);
            G(pr14);
            G(pr15);

        }
    }
}
