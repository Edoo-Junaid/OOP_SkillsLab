using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    internal interface IUserService
    {
        public void registerUser(UserRegistration userRegistration);

        public bool approveApplication();   

        public bool declineApplication();
    }
}
