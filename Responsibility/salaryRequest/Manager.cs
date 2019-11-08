using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsibilityPattern.salaryRequest
{
    //审批者抽象类
    abstract class Manager
    {
        protected string name;
        //具有更高权限的管理者，充当传递元素
        protected Manager superior;
        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }
        //申请请求
        abstract public void RequestApplication(Request request);
    }
}
