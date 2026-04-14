using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class PersonId2<T> : Person2<T>
    {
        private T id;
        public T Id
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
        public PersonId2(string name, T info, T id) :
        base(name, info)
        {
            this.id = id;
        }
    }
}
