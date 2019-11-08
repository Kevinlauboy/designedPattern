using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.company
{
    class ConcreteCompany :Company
    {
        public List<Company> children = new List<Company>();
        public ConcreteCompany(string name) :base(name)
        {
      
        }
        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }

        public override void Display(int dept)
        {
            Console.WriteLine(new String('-', dept) + name);

            foreach (Company component in children)
            {
                component.Display(dept + 2);
            }
        }

        //履行职责
        public override void LineOfDuty()
        {
            foreach (Company component in children)
            {
                component.LineOfDuty();
            }
        }
    }
}
