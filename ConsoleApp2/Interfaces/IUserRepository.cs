using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    internal interface IUserRepository
    {
        public bool registerUser(UserRegistration userRegistration);

        public bool deleteUser(string userId );
    }
}
