using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakDanClasses
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product2 = new Product();
            //product2.Name = "Milk";
            //product2.Description = "This is Milk";
            //product2.Price = 99;
            //product2.Quantity = 12;

            //product2.Info();

            //product2.SellProduct(3);
            //product2.SetNewPrice(89);
            //product2.AddQuantity(1);
            //product2.Info();


            Human.CountHuman = 0;
            Human.GetCountHuman();
            Human hmn3 = new Human("Закиров","Данил","Радикович",18);
            hmn3.Info();
            Console.WriteLine("\n");
            

            Human hmn1 = new Human();
            hmn1.LastName = "Василиевич";
            hmn1.Name = "Василий";
            hmn1.SecondName = "Иванов";
            hmn1.Age = 15;
            

            hmn1.Info();
            
            Human hmn2 = new Human();
            hmn2.LastName = "Михайлович";
            hmn2.Name = "Сидоров";
            hmn2.SecondName = "Александр";
            hmn2.Age = 23;
            
            Console.WriteLine("\n");
            Console.WriteLine($"Сотрудник {hmn2.FullName} \nВозраст: {hmn2.Age}");
            Human.GetCountHuman();

        }
    }
}
