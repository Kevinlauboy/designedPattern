using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate.dress
{
    class Person
    {
        public Person()
        {
        }
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }
}
