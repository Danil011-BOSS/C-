using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Game1<P> where P : Person1
    {
        private string company;
        private P member;
        public string Company
        {
            set
            {
                company = value;
            }
            get
            {
                return company;
            }
        }
        public P Member
        {
            set
            {
                member = value;
            }
            get
            {
                return member;
            }
        }
        public Game1(string company, P member)
        {
            this.company = company;
            this.member = member;
        }
        public void PrName()
        {
            Console.WriteLine("Фамилия участника {0}",
            member.Name);
        }
    }
}
