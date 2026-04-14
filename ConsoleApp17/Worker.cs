using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Worker : Human
    {
        private int tarif;
        private int countday;
        public override int ZarPlata()
        {
            return tarif * countday;
        }
        public Worker(string lastname, string name, string
        secondname, int age, int tarif, int countday)
        : base(lastname, name, secondname, age)
        {
            this.tarif = tarif;
            this.countday = countday;
        }
    }
}
