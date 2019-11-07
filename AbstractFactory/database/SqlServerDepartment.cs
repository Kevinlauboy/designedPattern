using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.database
{
    class SqlServerDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在Sqlserver中给Department表增加一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Sqlserver中根据ID得到Department表一条记录");
            return null;
        }
    }
}
