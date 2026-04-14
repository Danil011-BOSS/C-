using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakDanClasses
{
    public class Human
    {
        private string name;
        private string secondName;
        private string lastName;
        private int age;
        static private int countHuman;



        static public int CountHuman
        {
            set { countHuman = value; }
        }
        public string SecondName
        {
            set { secondName = value; }
        }
        public string Name
        {
            set {  name = value; }
        }
        public string LastName
        {
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string FullName
        {
            get
            {
                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine();
                if (password == "123")
                {
                    return $"{secondName} {name} {lastName}  ";
                }
                else
                {
                    throw new Exception("Incorrect password!");
                }
            }
        }

        public void Info()
        {
            Console.WriteLine($"\nName: {name}\nSecond name: {secondName}\nLast name: {lastName}\nAge: {age} {Option()}");
        }
        public string Option()
        {
            string s;
            if(age >=10 && age <= 20){
                s = "лет";

            }
            else
            {
                switch (age / 10)
                {
                    case 1:
                        s = "год";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        s = "года";
                        break;
                    default:
                        s = "лет";
                        break;
                }
            }
            return s;
        }

        public Human(string SecondName, string Name, string LastName, int Age)
        {
            this.lastName = LastName;
            this.name = Name;
            this.age = Age;
            this.secondName = SecondName;
            countHuman++;
        }
        public Human() { countHuman++; }

        static public void GetCountHuman()
        {
            Console.WriteLine($"Количество: {countHuman}");
        }
        static Human()
        {
            Console.WriteLine("Вы используете класс Human");
        }
    }
}
