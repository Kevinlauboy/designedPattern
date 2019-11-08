using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.company
{
    class FinanceDepartment :Company
    {
        public FinanceDepartment(string name):base(name)
        {

        }

        public override void Add(Company c)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Company c)
        {
            
        }

        public override void Display(int dept)
        {
            Console.WriteLine(new String('-', dept) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司财务收支管理", name);
        }
    }
}
