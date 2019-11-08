using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsibilityPattern.salaryRequest
{
    //部门经理
    class CommonManager : Manager
    {
        public CommonManager(string name)
            : base(name)
        { }
        public override void RequestApplication(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 2)
            {
                Console.WriteLine("{0}:{1} 数量{2} 被批准", name, request.RequestContent, request.Number);
            }
            else
            {
                if (superior != null)
                    superior.RequestApplication(request);
            }
        }
    }
}
