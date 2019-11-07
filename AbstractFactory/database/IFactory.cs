using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.database
{
    interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
}
