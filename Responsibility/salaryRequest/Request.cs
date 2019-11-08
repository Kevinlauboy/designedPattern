using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsibilityPattern.salaryRequest
{
    class Request
    {
        //申请类别
        private string requestType;
        public string RequestType
        {
            get { return requestType; }
            set { requestType = value; }
        }

        //申请内容
        private string requestContent;
        public string RequestContent
        {
            get { return requestContent; }
            set { requestContent = value; }
        }

        //数量
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
