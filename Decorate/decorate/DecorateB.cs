using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate.decorate
{
    class DecorateB : Decorate
    {
        //装饰模式关键代码段
        public override void operation()
        {
            base.operation();
            //添加本类自己的方法
            AddedBehavior(); 
            Console.WriteLine("DecorateB 操作");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("DecorateB增加的功能");
        }
    }
}
