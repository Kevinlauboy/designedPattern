using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prototype.prototype;
using Prototype.resume;
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 clone1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", clone1.Id);
            */

            /* 浅复制
            Resume a = new Resume("凯文");
            a.SetPersonal("男", "32");
            a.SetWorkExperience("2015-2019", "广州xx科技");
            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("2015-2020", "xx科技");
            a.display();
            b.display();
            Console.Read();
             * */

            /* 深度复制*/
            Resumedeep a = new Resumedeep("凯文");
            a.SetPersonal("男", "32");
            a.SetWorkExperience("2013-2019", "广州xx科技");

            Resumedeep b = (Resumedeep)a.Clone();
            b.SetPersonal("男", "35");
            b.SetWorkExperience("2015-2019", "广州xx科技");

            a.display();
            b.display();

            Console.Read();

        }
    }
}
