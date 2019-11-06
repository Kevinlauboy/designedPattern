using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    //具体创建类ConcreteBuilderB
    class ConcreteBuilderA : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("部件A1");
        }

        public override void BuildPartB()
        {
            product.Add("部件B1");
        }

        public  override Product getProduct()
        {
            return product;
        }
    }
}
