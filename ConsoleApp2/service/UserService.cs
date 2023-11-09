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

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public bool approveApplication()
        {
            throw new NotImplementedException();
        }

        public bool declineApplication()
        {
            throw new NotImplementedException();
        }

        public bool loginUser(UserLogin userLogin)
        {
            throw new NotImplementedException();
        }

        public void registerUser(UserRegistration userRegistration)
        {
            throw new NotImplementedException();
        }
    }
}
