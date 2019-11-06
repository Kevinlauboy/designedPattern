using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Director
    {
        private Builder builder = null;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public Product createProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            return builder.getProduct();
        }
    }
}
