
using System;

namespace ConsoleApp16
{
    abstract class Human
    {
        protected string name;
        protected string secondname;
        protected string lastname;
        protected int age;

        public abstract int ZarPlata();
        public void Info()
        {
            Console.WriteLine("{0} {1} {2}, {3} {4},зарплата { 5}руб", lastname, name,secondname, age, Option(), ZarPlata());
        }
        public Human()
        {
        }

        public Human(string lastname, string name, string secondname, int age)
        {
            this.lastname = lastname;
            this.name = name;
            this.secondname = secondname;
            this.age = age;
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string SecondName
        {
            get { return secondname; }
            set { secondname = value; }
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
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();
                return lastname + " " + name + " " + secondname;
            }
        }

        private string Option()
        {
            string s;
            if (age > 10 && age <= 20)
                s = " лет";
            else
            {
                switch (age % 10)
                {
                    case 1:
                        s = " год";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        s = " года";
                        break;
                    default:
                        s = " лет";
                        break;
                }
            }
            return s;
        }


        public override bool Equals(object ob)
        {
            Human hmn = (Human)ob;
            return name == hmn.name && lastname == hmn.lastname
            &&
            secondname == hmn.secondname && age == hmn.age;
        }
        public override string ToString()
        {
            return name + " " + secondname + " " + lastname +
            ", " + age;
        }



    }


}