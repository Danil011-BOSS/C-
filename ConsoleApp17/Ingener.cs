using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Ingener : Human
    {
        private int oklad;
        public override int ZarPlata()
        {
            return oklad;
        }
        public Ingener(string lastname, string name, string
        secondname, int age, int oklad)
        : base(lastname, name, secondname, age)
        {
            this.oklad = oklad;
        }
    }
}
