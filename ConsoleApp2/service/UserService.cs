using ConsoleApp2.DALInterface;
using ConsoleApp2.Entitities;

using ConsoleApp2.ServicesInterface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.service
{
    internal class UserService : IUserService
    {

        private IUserDAL userRepository;
        private INotificationService notificationService;

        public bool ApproveApplication(int applicationID)
        {
            throw new NotImplementedException();
        }

        public bool DeclineApplication(int applicationID)
        {
            throw new NotImplementedException();
        }

        public User Login(UserLogin userLogin)
        {
            throw new NotImplementedException();
        }

        public void Register(UserRegistration userRegistration)
        {
            throw new NotImplementedException();
        }
    }
}
