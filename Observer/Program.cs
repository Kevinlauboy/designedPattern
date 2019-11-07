using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using ObserverPattern.BossCome;
using ObserverPattern.ObserverBase;
namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Subject boss = new Boss();
            Observer colleague1 = new StockObserver("Zhangxing", boss);
            Observer colleague2 = new NBAObserver("Zhangyi", boss);
            boss.Attach(colleague1);
            boss.Attach(colleague2);
            boss.SubjectState = "boss回来了，大家开会";
            boss.Notify();*/


            Subject boss = new ConcreteSubject();
            Observer colleague = new ConcreteObserver(boss,"Zhangxing");
            boss.Attach(colleague);
            boss.SubjectState = "boss回来了，大家开会";
            boss.Notify();
            Console.Read();
        }
    }
}
