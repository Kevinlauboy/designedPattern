using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.company
{
    //抽象封装公司类
    abstract class Company
    {
        protected string name;
        public Company(string name)
        {
            this.name = name;
        }
        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int dept);
        public abstract void LineOfDuty();
    }
}
