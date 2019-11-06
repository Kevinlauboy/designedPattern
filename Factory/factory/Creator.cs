using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.factory
{
    interface Creator
    {
        //抽象产生产品类接口
        Product createProduct();
    }
}
