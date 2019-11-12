using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fyweightPattern.fyweightBase;
namespace fyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;
            FlyweightFactory f = new FlyweightFactory();
            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = f.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = f.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);
            UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();
            uf.Operation(--extrinsicstate);
            Console.Read();

        }
    }
}
