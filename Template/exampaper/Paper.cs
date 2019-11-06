using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.exampaper
{
    class Paper
    {
        public void Question1()
        {
            Console.WriteLine("1.下列说法正确的是({0}) \n " +
                "A．布朗运动就是液体分子的无规则热运动 \n " +
                "B．当分子间距离增大时，分子间引力增大，而分子间斥力减小 \n " +
                "C．热机效率不可能提高到100%，因为它违背了热力学第一定律 \n " +
                "D．对不同种类的物体，只要温度相同，分子热运动的平均动能就一定相同 \n ", Answer1());
        }

        public void Question2()
        {
            Console.WriteLine("2．下列溶液中，能大量共存的离子组是({0})  \n " +
             "A．能使氢氧化铝迅速溶解的溶液：Na+、Fe2+、NO3－、SO42－ \n " +
             "B．c(H+) = 1×10－2 mol•L－1的溶液：Na+、NH4+、CO32－、SO42－ \n " +
             "C．含有大量SO42－的溶液：K+、Cu2+、Cl－、NO3－ \n " +
             "D．含有大量ClO－的溶液：H+、Mg2+、I－、SO42－ \n ", Answer2());
        }

        public void Question3()
        {
            Console.WriteLine("3．下列说法不正确的是({0}) \n " +
               "A．含铅汽油、含磷洗涤剂的使用均可对环境造成危害  \n " +
               "B．棉花、木材及草类的纤维都是天然纤维  \n " +
               "C．氮化硅陶瓷、光导纤维均属于新型无机非金属材料  \n " +
               "D．煤、石油、天然气均属于可再生的化石燃料 \n ", Answer3());
        }
        protected virtual string Answer1()
        {
            return "";
        }
        protected virtual string Answer2()
        {
            return "";
        }
        protected virtual string Answer3()
        {
            return "";
        }
    }
}
