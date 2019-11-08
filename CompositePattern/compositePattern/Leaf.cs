using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.compositePattern
{
    class Leaf : Component
    {

        public Leaf(string name)
            : base(name)
        {

        }
        public override void Add(Component c)
        {
            Console.WriteLine("cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("cannot remove from  a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
