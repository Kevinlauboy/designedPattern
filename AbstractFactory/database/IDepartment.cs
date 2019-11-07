using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.database
{
    interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}
