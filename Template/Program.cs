using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.exampaper;
using Template.template;
namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 考卷例子
            Console.WriteLine("考生1");
            Paper paper1 = new PaperA();
            paper1.Question1();
            paper1.Question2();
            paper1.Question3();

            Console.WriteLine("考生2");
            Paper paper2 = new PaperB();
            paper2.Question1();
            paper2.Question2();
            paper2.Question3();
            */

            AbstractClass impA = new ConcreteClassA();
            AbstractClass impB = new ConcreteClassB();
            impA.TemplateMethod();
            impB.TemplateMethod();

            Console.Read();
        }
    }
}
