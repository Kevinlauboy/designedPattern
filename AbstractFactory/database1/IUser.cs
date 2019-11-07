using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.database1
{
    interface IUser
    {
        void Insert(User user);

        User GetUser(int id);
    }
}
