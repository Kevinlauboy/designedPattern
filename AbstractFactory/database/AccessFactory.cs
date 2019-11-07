using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.database
{
    class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }


        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }
    }
}
