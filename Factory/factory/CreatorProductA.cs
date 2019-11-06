using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.factory
{
    class CreatorProductA:Creator
    {
        public Product createProduct()
        {
            return new ProductA();
        }
    }
}
