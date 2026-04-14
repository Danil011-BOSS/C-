using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Human
    {
        internal string lastName;
        internal string firstName;
        internal string secondName;
        internal int age;

        public Human(string lastName, string firstName, string secondName, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
        }

        public void Info()
        {
            Console.WriteLine("Начальник: {0} {1} {2}, возраст: {3}",
                lastName, firstName, secondName, age);
        }
        public static Human operator !(Human a)
        {
            return new Human(a.lastName, a.firstName, a.secondName, a.age + 1);
        }

        public static Human operator /(Human a, string s)
        {
            return new Human(s, a.firstName, a.secondName, a.age);
        }
    }

    class Office
    {
        private Human boss;
        private string name;
        private int countworker;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CountWorker
        {
            get { return countworker; }
            set { countworker = value; }
        }

        public Human Boss
        {
            get { return boss; }
            set { boss = value; }
        }

        public void Info()
        {
            Console.WriteLine("Подразделение: {0}, работающих {1} человек",
                name, countworker);

            if (boss != null)
                boss.Info();
            else
                Console.WriteLine("Начальник не назначен");
        }

        public Office()
        {
        }

        public Office(string lastname, string name, string secondname,
            int age, string name1, int countworker)
        {
            this.name = name1;
            this.countworker = countworker;
            boss = new Human(lastname, name, secondname, age);
        }


    }
}