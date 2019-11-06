using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.factory
{
    class ProductA: Product
    {
        public override void appliation()
        {
            Console.WriteLine("展示产品A");
        }
    }
}
