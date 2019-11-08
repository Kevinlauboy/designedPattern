using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.barbecue
{
    //烤肉串者,命令实际执行者
    class Barbecuer
    {
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串!");
        }

        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅!");
        }
    }
}
