using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate.decorate
{
    abstract class Decorate : Component
    {
        private Component component = null;

        public void setComponent(Component component)
        {
            this.component = component;
        }
        //装饰模式关键代码段
        public override void operation()
        {
            if (component != null)
            {
                component.operation();
            }
        }
    }
}
