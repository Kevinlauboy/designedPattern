using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.facade
{
    class FacadePlat
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        public FacadePlat()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n 方法组一");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }
        public void MethodB()
        {
            Console.WriteLine("\n 方法组二");
            one.MethodOne();
            three.MethodThree();
            four.MethodFour();
        }
    }
}
