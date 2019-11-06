using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Product
    {
        IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void show()
        {
            Console.WriteLine("\n 创建产品 创建 -----");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
