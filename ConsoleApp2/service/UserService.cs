using ConsoleApp2.Entitities;
using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.service
{
    internal class UserService : IUserService
    {

        private IUserRepository userRepository;
        private INotificationService notificationService;

        public UserService(IUserRepository userRepository,INotificationService notificationService)
        {
            this.userRepository = userRepository;
            this.notificationService = notificationService;
        }
        public bool ApproveApplication(int applicationID)
        {
            throw new NotImplementedException();
        }

        public bool DeclineApplication(int applicationID)
        {
            throw new NotImplementedException();
        }

        public bool LoginUser(UserLogin userLogin)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(UserRegistration userRegistration)
        {
            throw new NotImplementedException();
        }
    }
}
