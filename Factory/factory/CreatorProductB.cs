using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.factory
{
    class CreatorProductB:Creator
    {
        public Product createProduct()
        {
            return new ProductB();
        }
    }
}
