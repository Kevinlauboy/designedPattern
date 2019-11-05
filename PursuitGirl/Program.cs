using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using PursuitGirl.PursuitGirl;
using PursuitGirl.Proxytemp;
namespace PursuitGirl
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SchoolGirl jiaojiao = new SchoolGirl("Lily");
            Pursuit pursuit = new Pursuit(jiaojiao);
            Proxy proxy = new Proxy("LiWei",jiaojiao);
            proxy.giveChocolate();
            proxy.giveDolls();
            proxy.giveFlowers();*/

            Proxy proxy = new Proxy();
            proxy.request();
            Console.Read();
        }
    }
}
