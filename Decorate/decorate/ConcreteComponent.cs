using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate.decorate
{
    //被装饰的具体类
    class ConcreteComponent : Component
    {
        public override void operation()
        {
            Console.WriteLine("被装饰的类操作");
        }

    }
}
