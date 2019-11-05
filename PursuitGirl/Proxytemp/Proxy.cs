using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PursuitGirl.Proxytemp
{
    class Proxy : Subject
    {
        private Subject subject;
        public override void request()
        {
            if (null == subject) {
                this.subject = new RealSubject();
            }
            subject.request();
        }
    }
}
