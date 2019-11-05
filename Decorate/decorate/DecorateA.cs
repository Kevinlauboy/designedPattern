using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate.decorate
{
    class DecorateA: Decorate
    {
        private string addApplication;
        //装饰模式关键代码段
        public override void operation()
        {
            base.operation();
            //添加本类自己的方法
            addApplication = "New State";
            Console.WriteLine("DecorateA 操作");
        }
    }
}
