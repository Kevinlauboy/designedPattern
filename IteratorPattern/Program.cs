using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IteratorPattern.IteratorBase;
namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "大鸟";
            a[1] = "小菜";
            a[2] = "行李";
            a[3] = "老外";
            a[4] = "公交内部员工";
            a[5] = "小偷";

            Iterator i = new ConcreteIterator(a);
            //Iterator i = new ConcreteIteratorDesc(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0} 请买车票!", i.CurrentItem());
                i.Next();
            }
            */

            IList<string> a = new List<string>();
            a.Add("大鸟");
            a.Add("小菜");
            a.Add("行李");
            a.Add("老外");
            a.Add("公交内部员工");
            a.Add("小偷");

            foreach (string item in a)
            {
                Console.WriteLine("{0} 请买车票!", item);
            }

            IEnumerator<string> e = a.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine("{0} 请买车票!", e.Current);

            }
            Console.Read();
        }
    }
}
