using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.adapterBase;
namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Target target = new Adpter();
            target.Request();
            Console.Read();
        }
    }
}
