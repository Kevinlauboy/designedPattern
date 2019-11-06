using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class ConcreteBuilderB : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("部件A2");
        }

        public override void BuildPartB()
        {
            product.Add("部件B2");
        }

        public override Product getProduct()
        {
            return product;
        }
    }
}
