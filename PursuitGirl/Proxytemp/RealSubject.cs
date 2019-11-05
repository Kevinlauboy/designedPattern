using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PursuitGirl.Proxytemp
{
    class RealSubject : Subject
    {
        public override void request()
        {
            Console.WriteLine("真实的请求");
        }
    }
}
