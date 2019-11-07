using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.database1
{
    class SqlServerUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Sqlserver中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Sqlserver中根据ID得到User表一条记录");
            return null;
        }
    }
}
