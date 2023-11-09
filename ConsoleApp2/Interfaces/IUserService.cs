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
        public void RegisterUser(UserRegistration userRegistration);

        public bool ApproveApplication(int applicationID);   

        public bool DeclineApplication(int applicationID);

        public bool LoginUser(UserLogin userLogin);
    }
}
