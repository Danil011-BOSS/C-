using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class PersonId3 : Person2<char>
    {
        private string id;
        public string Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public PersonId3(string name, char info, string id) :
        base(name, info)
        {
            this.id = id;
        }
    }
}
