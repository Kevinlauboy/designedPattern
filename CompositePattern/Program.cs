using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompositePattern.compositePattern;
using CompositePattern.company;
namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*组合模式
            Component root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Component comp = new Composite("root");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);

            Component comp1 = new Composite("root");
            comp1.Add(new Leaf("Leaf XYA"));
            comp1.Add(new Leaf("Leaf XYB"));
            comp.Add(comp1);

            root.Add(new Leaf("Leaf C"));
            Leaf leaf = new Leaf("Leaf D");
            root.Add(new Leaf("Leaf XB"));
            root.Remove(leaf);

            root.Display(1);
             * */

            ConcreteCompany root = new ConcreteCompany("北京总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new FinanceDepartment("总公司财务部"));

            ConcreteCompany comp = new ConcreteCompany("上海华东分公司");
            comp.Add(new HRDepartment("华东分公司人力资源部"));
            comp.Add(new FinanceDepartment("华东分公司财务部"));
            root.Add(comp);

            ConcreteCompany comp1 = new ConcreteCompany("南京办事处");
            comp1.Add(new HRDepartment("南京办事处人力资源部"));
            comp1.Add(new FinanceDepartment("南京办事处财务部"));
            comp.Add(comp1);

            ConcreteCompany comp2 = new ConcreteCompany("杭州办事处");
            comp2.Add(new HRDepartment("杭州办事处人力资源部"));
            comp2.Add(new FinanceDepartment("杭州办事处财务部"));
            comp.Add(comp2);
            

            Console.WriteLine("\n结构图：");

            root.Display(1);

            Console.WriteLine("\n职责：");

            root.LineOfDuty();

            Console.Read();
        }
    }
}
