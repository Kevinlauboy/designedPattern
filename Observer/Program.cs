using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using ObserverPattern.BossCome;
//using ObserverPattern.ObserverBase;
using ObserverPattern.BossEvent;
namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*使用观察者模式实现:boss回来了,告知大家
            Subject boss = new Boss();
            Observer colleague1 = new StockObserver("Zhangxing", boss);
            Observer colleague2 = new NBAObserver("Zhangyi", boss);
            boss.Attach(colleague1);
            boss.Attach(colleague2);
            boss.SubjectState = "boss回来了，大家开会";
            boss.Notify();
             * */

            /* 观察者模式模板
            Subject sub = new ConcreteSubject();
            Observer observer = new ConcreteObserver(sub,"Zhangxing");
            sub.Attach(observer);
            sub.SubjectState = "状态改变了";
            sub.Notify();
             * */

            /*观察者模式&事件托管实现:boss回来了,告知大家*/
            Subject boss = new Boss();
            Observer colleague1 = new StockObserver("Zhangxing", boss);
            Observer colleague2 = new NBAObserver("Zhangyi", boss);
            boss.Update += new EventHandle(colleague1.Update);
            boss.Update += new EventHandle(colleague2.Update);
            boss.SubjectState = "boss回来了，大家开会";
            boss.Notify();
            Console.Read();
        }
    }
}
