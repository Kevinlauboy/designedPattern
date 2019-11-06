using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder createrA = new ConcreteBuilderA();
            Director director = new Director(createrA);
            Product proA = director.createProduct();
            proA.show();
            Console.Read();
        }
    }
}
