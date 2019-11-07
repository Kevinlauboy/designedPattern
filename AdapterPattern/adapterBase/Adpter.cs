using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.adapterBase
{
    class Adpter : Target
    {
        private Adptee adptee =new Adptee();
        public override void Request()
        {
            adptee.SpecialRequest();
        }
    }
}
