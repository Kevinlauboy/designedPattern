using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorate.decorate;
using Decorate.dress;

namespace Decorate
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 装饰模式
            ConcreteComponent concreteComponent = new ConcreteComponent();
            DecorateA decorateA = new DecorateA();
            DecorateB decorateB = new DecorateB();
            decorateA.setComponent(concreteComponent);
            decorateB.setComponent(decorateA);
            decorateB.operation();
            */

            /*卡通人物服饰添加实例
             */
            Person person = new Person("superman");
            BigTrouser bigTrouser = new BigTrouser();
            Shoe shoe = new Shoe();
            Tshirt tshirt = new Tshirt();

            bigTrouser.decorate(person);
            shoe.decorate(bigTrouser);
            tshirt.decorate(shoe);
            tshirt.Show();
        }
    }
}
